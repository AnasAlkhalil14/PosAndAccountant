using PosAndAccountant_DataTransfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_DataAccess
{
    public class clsProductCategoryData
    {

        public static DataTable GetAllProductsCategory()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("[Products].[SP_GetAllProductsCategory]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) dt.Load(reader);
                        }
                    }
                    catch { return null; }
                }
            }
            return dt;
        }
        public static bool DeleteProductCategoryByID(int CategoryID)
        {

            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("[Products].[SP_DeleteProductCategoryByID]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CategoryID", CategoryID);
                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch { return false; }
                }
            }
            return rowsAffected > 0;
        }
        public static int AddNewProductCategory(clsProductCategoryDTO ProductCategoryDTO)
        {
            int NewID = -1;


            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("[Products].[SP_AddNewCategory]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CategoryName", ProductCategoryDTO.CategoryName);
                    command.Parameters.AddWithValue("@Description", ProductCategoryDTO.Description);
                    

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                            NewID = insertedID;
                    }
                    catch { NewID = -1; }
                }
            }
            return NewID;
        }
        public static bool UpdateProducCategorytByID(clsProductCategoryDTO ProductCategoryDTO)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("[Products].[SP_UpdateCategoryByID]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CategoryID", ProductCategoryDTO.CategoryID);
                    command.Parameters.AddWithValue("@CategoryName", ProductCategoryDTO.CategoryName);
                    command.Parameters.AddWithValue("@Description", ProductCategoryDTO.Description);
                    

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch { return false; }
                }
            }
            return rowsAffected > 0;
        }
        public static clsProductCategoryDTO GetProductCategoryByID(int CategoryID)
        {
            clsProductCategoryDTO CategoryDTO = null;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("[Products].[SP_GetProductCategoryByID]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CategoryID", CategoryID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                CategoryDTO = new clsProductCategoryDTO();
                                CategoryDTO.CategoryID = CategoryID;
                                CategoryDTO.CategoryName = reader["CategoryName"].ToString();
                                CategoryDTO.Description= reader["Description"]!=DBNull.Value?reader["Description"].ToString():"";
                                CategoryDTO.CreateDate = Convert.ToDateTime(reader["CreatedDate"]);
                            }
                        }
                    }
                    catch { return null; }
                }
            }
            return CategoryDTO;
        }
        public static bool IsCategoryExistByName(string CategoryName)
        {

            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("[Products].[SP_IsProductCategoryExistByName]", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@CategoryName", CategoryName);


                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            IsFound = Convert.ToBoolean(result);
                        }
                        else
                        {
                            IsFound = false;
                        }


                    }



                }


            }

            catch (Exception ex)
            {
                //LogInEventLog;
                IsFound = false;
            }


            return IsFound;




        }

    }
}
