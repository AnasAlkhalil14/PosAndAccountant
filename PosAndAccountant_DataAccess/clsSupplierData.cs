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
    public class clsSupplierData
    {



        public static clsSupplierDTO FindSupplierByID(int SupplierID)
        {

            clsSupplierDTO SupplierDTO = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("[Suppliers].[SP_GetSupplierByID]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@SupplierID", SupplierID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                SupplierDTO = new clsSupplierDTO();

                                SupplierDTO.SupplierID = SupplierID;
                                SupplierDTO.PersonID = Convert.ToInt32(reader["PersonID"]);
                                SupplierDTO.IsActive = Convert.ToBoolean(reader["IsActive"]);
                                SupplierDTO.Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : "";
                                SupplierDTO.TotalRemainingDebt = Convert.ToDouble(reader["TotalRemainingDebt"]);
                                SupplierDTO.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                                SupplierDTO.ModifiedDate = Convert.ToDateTime(reader["ModifiedDate"]);

                            }

                        }



                    }
                    catch (Exception ex)
                    {
                        //Loging in event lopg
                        return null;

                    }



                }




            }




            return SupplierDTO;
        }
        public static clsSupplierDTO FindSupplierByPhone(string Phone)
        {

            clsSupplierDTO SupplierDTO = null;
            string query = @"SELECT   Suppliers.*
FROM         Suppliers INNER JOIN
                         People ON Suppliers.PersonID = People.PersonID
						 where Phone=@Phone";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Phone", Phone);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                SupplierDTO = new clsSupplierDTO();

                                SupplierDTO.SupplierID = Convert.ToInt32(reader["SupplierID"]); ;
                                SupplierDTO.PersonID = Convert.ToInt32(reader["PersonID"]);
                                SupplierDTO.IsActive = Convert.ToBoolean(reader["IsActive"]);
                                SupplierDTO.Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : "";
                                SupplierDTO.TotalRemainingDebt = Convert.ToDouble(reader["TotalRemainingDebt"]);
                                SupplierDTO.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                                SupplierDTO.ModifiedDate = Convert.ToDateTime(reader["ModifiedDate"]);

                            }

                        }



                    }
                    catch (Exception ex)
                    {
                        //Loging in event lopg
                        return null;

                    }



                }




            }




            return SupplierDTO;
        }

        public static clsSupplierDTO FindSupplierByPersonID(int PersonID)
        {
            clsSupplierDTO SupplierDTO = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("[Suppliers].[SP_GetSupplierByPersonID]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                               SupplierDTO = new clsSupplierDTO();
                                SupplierDTO.SupplierID = Convert.ToInt32(reader["SupplierID"]);
                               SupplierDTO.PersonID = PersonID;
                               SupplierDTO.IsActive = Convert.ToBoolean(reader["IsActive"]);
                               SupplierDTO.Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : "";
                                SupplierDTO.TotalRemainingDebt = Convert.ToDouble(reader["TotalRemainingDebt"]);
                               SupplierDTO.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                                SupplierDTO.ModifiedDate = Convert.ToDateTime(reader["ModifiedDate"]);

                            }

                        }



                    }
                    catch (Exception ex)
                    {
                        //Loging in event lopg
                        return null;

                    }



                }




            }




            return SupplierDTO;
        }


        public static DataTable GetAllSuppliers()
        {

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("[Suppliers].[SP_GetAllSuppliers]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;


                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dataTable.Load(reader);
                                return dataTable;

                            }
                            else
                            {
                                return null;
                            }

                        }



                    }
                    catch (Exception ex)
                    {
                        //Loging in event lopg
                        return null;

                    }



                }




            }





        }

        public static bool DeleteSupplierByID(int SupplierID)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using (SqlCommand command = new SqlCommand("[Suppliers].[SP_DeleteSupplierByID]", connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SupplierID", SupplierID);
                        connection.Open();
                        IsDeleted = command.ExecuteNonQuery() != 0;

                    }




                }


            }
            catch (Exception ex)
            {
                //log error
                IsDeleted = false;
            }



            return IsDeleted;
        }


        public static bool UpdateSupplierByID(clsSupplierDTO SupplierDTO)
        {
            int RowAffected = 0;

            try
            {



                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using (SqlCommand command = new SqlCommand("[Suppliers].[SP_UpdateSupplierByID]", connection))
                    {
                        command.Parameters.AddWithValue("@SupplierID", SupplierDTO.SupplierID);

                        command.Parameters.AddWithValue("@PersonID", SupplierDTO.PersonID);
                        command.Parameters.AddWithValue("@IsActive", SupplierDTO.IsActive);
                        command.Parameters.AddWithValue("@TotalRemainingDebt", SupplierDTO.TotalRemainingDebt);

                        if (!string.IsNullOrEmpty(SupplierDTO.Notes))
                        {
                            command.Parameters.AddWithValue("@Notes", SupplierDTO.Notes);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Notes", DBNull.Value);

                        }



                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();

                        RowAffected = command.ExecuteNonQuery();

                    }



                }

            }
            catch (Exception ex)
            {
                //log;
            }

            return RowAffected > 0;
        }

        public static int AddNewSupplier(clsSupplierDTO SupplierDTO)
        {
            int SupplierID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("[Suppliers].[SP_AddNewSupplier]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", SupplierDTO.PersonID);
                    command.Parameters.AddWithValue("@IsActive", SupplierDTO.IsActive);

                    if (!string.IsNullOrEmpty(SupplierDTO.Notes))
                    {
                        command.Parameters.AddWithValue("@Notes", SupplierDTO.IsActive);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Notes", DBNull.Value);

                    }
                    command.Parameters.AddWithValue("@TotalRemainingDebt", SupplierDTO.TotalRemainingDebt);
                  


                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out SupplierID))
                    {

                    }
                    else
                    {
                        SupplierID = -1;
                    }


                }



            }

            return SupplierID;

        }

        public static bool IsPersonSupplier(int PersonID)
        {

            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("[Suppliers].[SP_IsPersonSupplier]", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", PersonID);


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
