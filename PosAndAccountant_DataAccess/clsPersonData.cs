using PosAndAccountant_DataTransfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_DataAccess
{
    public class clsPersonData
    {


        public static clsPersonDTO FindPersonByID(int  PersonID )
        {

            clsPersonDTO personDTO =null;

            using (SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command=new SqlCommand("[People].[SP_GetPersonByID]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();
                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                  personDTO = new clsPersonDTO();

                                personDTO.ID = PersonID;

                                personDTO.FirstName = reader["FirstName"].ToString();
                                personDTO.LastName = reader["LastName"].ToString();
                                personDTO.CreateDate = Convert.ToDateTime(reader["CreateDate"]);

                                personDTO.SecondName = (reader["SecondName"] != DBNull.Value)?  reader["SecondName"].ToString()    :  "";
 
                                personDTO.Phone = (reader["Phone"] != DBNull.Value)?   reader["Phone"].ToString():      "";

                                personDTO.ImagePath= (reader["ImagePath"] != DBNull.Value) ? reader["ImagePath"].ToString() : "";


                                personDTO.Address =    (reader["Address"] != DBNull.Value)?  reader["Address"].ToString():    "";
                                  
                                personDTO. ModifyDate = reader["ModifyDate"] != DBNull.Value   ? (DateTime)reader["ModifyDate"] : personDTO.CreateDate;

                                
                               
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




            return personDTO;
         }


        public static clsPersonDTO FindPersonByPhone(string Phone)
        {

            clsPersonDTO personDTO = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("[People].[SP_GetPersonByPhone]", connection))
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
                                personDTO = new clsPersonDTO();

                                personDTO.Phone = Phone;

                                personDTO.FirstName = reader["FirstName"].ToString();
                                personDTO.LastName = reader["LastName"].ToString();
                                personDTO.CreateDate = Convert.ToDateTime(reader["CreateDate"]);

                                personDTO.SecondName = (reader["SecondName"] != DBNull.Value) ? reader["SecondName"].ToString() : "";

                                personDTO.ID = Convert.ToInt32(reader["PersonID"]);

                                personDTO.ImagePath = (reader["ImagePath"] != DBNull.Value) ? reader["ImagePath"].ToString() : "";


                                personDTO.Address = (reader["Address"] != DBNull.Value) ? reader["Address"].ToString() : "";

                                personDTO.ModifyDate = reader["ModifyDate"] != DBNull.Value ? (DateTime)reader["ModifyDate"] : personDTO.CreateDate;



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




            return personDTO;
        }


        public static DataTable GetAllPeople()
        {

         DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("[People].[SP_GetAllPeople]", connection))
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

        public static bool DeletePersonByID(int PersonID)
        {
            bool IsDeleted=false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using (SqlCommand command = new SqlCommand("[People].[SP_DeleteByIDPerson]", connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        connection.Open();
                        IsDeleted = command.ExecuteNonQuery() != 0;

                    }




                }


            }
            catch(Exception ex)
            {
                //log error
                IsDeleted = false;
            }



                return IsDeleted;
        }


        public static bool UpdatePersonByID(clsPersonDTO PersonDTO)
        {
            int RowAffected = 0;

            try
            { 
            
            

            using(SqlConnection connection = new SqlConnection( clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("[People].[SP_UpdatePersonByID]", connection))
                {
                    command.Parameters.AddWithValue("@PersonID",PersonDTO.ID);
                    command.Parameters.AddWithValue("@FirstName", PersonDTO.FirstName);
                    command.Parameters.AddWithValue("@LastName", PersonDTO.LastName);

                    if (!string.IsNullOrEmpty(PersonDTO.SecondName))
                    {
                        command.Parameters.AddWithValue("@SecondName", PersonDTO.SecondName);
                     }
                    else
                    {
                        command.Parameters.AddWithValue("@SecondName", DBNull.Value);

                    }


                    if (!string.IsNullOrEmpty(PersonDTO.Phone))
                    {
                        command.Parameters.AddWithValue("@Phone", PersonDTO.Phone);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Phone", DBNull.Value);

                    }

                    if (!string.IsNullOrEmpty(PersonDTO.Address))
                    {
                        command.Parameters.AddWithValue("@Address", PersonDTO.Address);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Address", DBNull.Value);

                    }
                                                            
                    if (!string.IsNullOrEmpty(PersonDTO.ImagePath))
                    {
                        command.Parameters.AddWithValue("@ImagePath", PersonDTO.ImagePath);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

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

        public static int AddNewPerson(clsPersonDTO PersonDTO)
        {
            int PersonID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using(SqlCommand command=new SqlCommand("[People].[SP_AddNewPerson]",connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", PersonDTO.FirstName);
                    command.Parameters.AddWithValue("@LastName", PersonDTO.LastName);

                    if (!string.IsNullOrEmpty(PersonDTO.SecondName))
                    {
                        command.Parameters.AddWithValue("@SecondName", PersonDTO.SecondName);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@SecondName", DBNull.Value);

                    }


                    if (!string.IsNullOrEmpty(PersonDTO.Phone))
                    {
                        command.Parameters.AddWithValue("@Phone", PersonDTO.Phone);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Phone", DBNull.Value);

                    }

                    if (!string.IsNullOrEmpty(PersonDTO.Address))
                    {
                        command.Parameters.AddWithValue("@Address", PersonDTO.Address);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Address", DBNull.Value);

                    }

                    if (!string.IsNullOrEmpty(PersonDTO.ImagePath))
                    {
                        command.Parameters.AddWithValue("@ImagePath", PersonDTO.ImagePath);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

                    }

                    connection.Open();

                    object result=command.ExecuteScalar();
                    if(result != null &&int.TryParse(result.ToString() ,out PersonID))
                    {

                    }
                    else
                    {
                        PersonID = -1;
                    }


                }



            }

            return PersonID;

        }

        public static string GetImagePathByPersonID(int PersonID)
        {
            string ImagePath ="";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("[People].[SP_GetImagePathByPersonID]", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            ImagePath = result.ToString();
                        }

                    }


                }

            }
            catch(Exception ex)
            {

            }
            

return ImagePath;

        }





    }
}
