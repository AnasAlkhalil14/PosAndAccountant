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
    public class clsPartnerData
    {

        public static clsPartnerDTO FindPartnerByID(int PartnerID)
        {

            clsPartnerDTO PartnerDTO = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("[Partners].[SP_GetPartnerByID]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PartnerID", PartnerID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PartnerDTO = new clsPartnerDTO();

                                PartnerDTO.PartnerID = PartnerID;
                                PartnerDTO.PersonID = Convert.ToInt32(reader["PersonID"]);
                                PartnerDTO.IsActive = Convert.ToBoolean(reader["IsActive"]);
                                PartnerDTO.CurrentBalance = Convert.ToDouble(reader["CurrentBalance"]);
                                PartnerDTO.ProfitPercentage = Convert.ToDouble(reader["ProfitPercentage"]);
                                PartnerDTO.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                                PartnerDTO.ModifiedDate = reader["CreatedDate"]!=DBNull.Value?Convert.ToDateTime(reader["CreatedDate"]):PartnerDTO.CreatedDate;

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




            return PartnerDTO;
        }
        



        public static DataTable GetAllPartners()
        {

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("[Partners].[SP_GetAllPartners]", connection))
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

        public static bool DeletePartnerByID(int PartnerID)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using (SqlCommand command = new SqlCommand("[Partners].[SP_DeletePartnerByID]", connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PartnerID", PartnerID);
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


        public static bool UpdatePartnerByID(clsPartnerDTO PartnerDTO)
        {
            int RowAffected = 0;

            try
            {



                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using (SqlCommand command = new SqlCommand("[Partners].[SP_UpdatePartnerByID]", connection))
                    {
                        command.Parameters.AddWithValue("@PartnerID", PartnerDTO.PartnerID);

                        command.Parameters.AddWithValue("@PersonID", PartnerDTO.PersonID);
                        command.Parameters.AddWithValue("@IsActive", PartnerDTO.IsActive);
                        command.Parameters.AddWithValue("@CurrentBalance", PartnerDTO.CurrentBalance);
                        command.Parameters.AddWithValue("@ProfitPercentage", PartnerDTO.ProfitPercentage);

                  


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

        public static int AddNewPartner(clsPartnerDTO PartnerDTO)
        {
            int PartnerID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("[Partners].[SP_AddNewPartner]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", PartnerDTO.PersonID);
                    command.Parameters.AddWithValue("@IsActive", PartnerDTO.IsActive);
                    command.Parameters.AddWithValue("@CurrentBalance", PartnerDTO.CurrentBalance);
                    command.Parameters.AddWithValue("@ProfitPercentage", PartnerDTO.ProfitPercentage);



                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out PartnerID))
                    {

                    }
                    else
                    {
                        PartnerID = -1;
                    }


                }



            }

            return PartnerID;

        }

        public static bool IsPersonPartner(int PersonID)
        {

            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("[Partners].[SP_IsPartnerPerson]", connection))
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
