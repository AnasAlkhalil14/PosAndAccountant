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
    public class clsProductData
    {
        // Internal helper to map data reader to DTO
        private static void MapReaderToDTO(SqlDataReader reader, clsProductDTO productDTO)
        {
            productDTO.ProductID = Convert.ToInt32(reader["ProductID"]);
            productDTO.ProductCategoryID = Convert.ToInt32(reader["ProductCategoryID"]);
            productDTO.CostPrice = Convert.ToDecimal(reader["CostPrice"]);
            productDTO.SellingPrice = Convert.ToDecimal(reader["SellingPrice"]);
            productDTO.UnitOfSale = reader["UnitOfSale"].ToString();
            productDTO.ProductName = reader["ProductName"].ToString();
            productDTO.Description = reader["Description"] != DBNull.Value ? reader["Description"].ToString() : "";
            productDTO.ImagePath = reader["ImagePath"] != DBNull.Value ? reader["ImagePath"].ToString() : "";
            productDTO.BarCode = reader["BarCode"] != DBNull.Value ? reader["BarCode"].ToString() : "";
            productDTO.QuantityInStock = Convert.ToInt32(reader["QuantityInStock"]);
            productDTO.MinimumQuantityForWarning = Convert.ToInt32(reader["MinimumQuantityForWarning"]);
            productDTO.CreateDate = Convert.ToDateTime(reader["CreateDate"]);
            productDTO.ModifyDate = Convert.ToDateTime(reader["ModifyDate"]);
            productDTO.IsActive = Convert.ToBoolean(reader["IsActive"]);
        }

        public static clsProductDTO GetProductByID(int ProductID)
        {
            clsProductDTO ProductDTO = null;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("Products.SP_GetProductByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProductID", ProductID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ProductDTO = new clsProductDTO();
                                MapReaderToDTO(reader, ProductDTO);
                            }
                        }
                    }
                    catch { return null; }
                }
            }
            return ProductDTO;
        }

        public static clsProductDTO GetProductByBarCode(string BarCode)
        {
            clsProductDTO ProductDTO = null;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("Products.SP_GetProductByBarCode", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BarCode", BarCode);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ProductDTO = new clsProductDTO();
                                MapReaderToDTO(reader, ProductDTO);
                            }
                        }
                    }
                    catch { return null; }
                }
            }
            return ProductDTO;
        }

        public static DataTable GetAllProducts()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("Products.SP_GetAllProducts", connection))
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

        public static int AddNewProduct(clsProductDTO ProductDTO)
        {
            int NewID = -1;

            
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("Products.SP_AddNewProduct", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProductCategoryID", ProductDTO.ProductCategoryID);
                    command.Parameters.AddWithValue("@CostPrice", ProductDTO.CostPrice);
                    command.Parameters.AddWithValue("@SellingPrice", ProductDTO.SellingPrice);
                    command.Parameters.AddWithValue("@UnitOfSale", ProductDTO.UnitOfSale);
                    command.Parameters.AddWithValue("@Name", ProductDTO.ProductName);
                    command.Parameters.AddWithValue("@Description", (object)ProductDTO.Description ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ImagePath", (object)ProductDTO.ImagePath ?? DBNull.Value);
                    command.Parameters.AddWithValue("@BarCode", (object)ProductDTO.BarCode ?? DBNull.Value);
                    command.Parameters.AddWithValue("@QuantityInStock", ProductDTO.QuantityInStock);
                    command.Parameters.AddWithValue("@MinimumQuantityForWarning", ProductDTO.MinimumQuantityForWarning);

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

        public static bool UpdateProductByID(clsProductDTO ProductDTO)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("Products.SP_UpdateProductByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProductID", ProductDTO.ProductID);
                    command.Parameters.AddWithValue("@ProductCategoryID", ProductDTO.ProductCategoryID);
                    command.Parameters.AddWithValue("@CostPrice", ProductDTO.CostPrice);
                    command.Parameters.AddWithValue("@SellingPrice", ProductDTO.SellingPrice);
                    command.Parameters.AddWithValue("@UnitOfSale", ProductDTO.UnitOfSale);
                    command.Parameters.AddWithValue("@ProductName", ProductDTO.ProductName);
                    command.Parameters.AddWithValue("@Description", (object)ProductDTO.Description ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ImagePath", (object)ProductDTO.ImagePath ?? DBNull.Value);
                    command.Parameters.AddWithValue("@BarCode", (object)ProductDTO.BarCode ?? DBNull.Value);
                    command.Parameters.AddWithValue("@QuantityInStock", ProductDTO.QuantityInStock);
                    command.Parameters.AddWithValue("@MinimumQuantityForWarning", ProductDTO.MinimumQuantityForWarning);
                    command.Parameters.AddWithValue("@IsActive", ProductDTO.IsActive);

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

        public static bool DeleteProductByID(int ProductID)
        {

            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("Products.SP_DeleteProductByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProductID", ProductID);
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

        public static bool DoesProductExistByID(int ProductID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("Products.SP_IsProductExistByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProductID", ProductID);
                    try
                    {
                        connection.Open();
                        isFound = Convert.ToBoolean(command.ExecuteScalar());
                    }
                    catch { isFound = false; }
                }
            }
            return isFound;
        }

        public static DataTable GetLowStockProducts()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("Products.SP_GetLowStockProducts", connection))
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

        public static DataTable GetProductsByName(string ProductName)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("Products.SP_GetProductByName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProductName", ProductName);
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

        public static bool DoesProductExistByName(string ProductName)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("Products.SP_IsProductExistByName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProductName", ProductName);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                            isFound = Convert.ToBoolean(result);
                    }
                    catch { isFound = false; }
                }
            }
            return isFound;
        }


    }
}
