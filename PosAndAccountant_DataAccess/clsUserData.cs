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
    public class clsUserData
    {

        public static clsUserDTO GetUserByID(int UserID)
        {

            clsUserDTO UserDTO;



            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using (SqlCommand command = new SqlCommand("[Users].[SP_GetUserByID]", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", UserID);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UserDTO = new clsUserDTO();
                                UserDTO.UserID = UserID;
                                UserDTO.UserName = reader["UserName"].ToString() ;
                                UserDTO.Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : "";
                                UserDTO.HashPassword = reader["HashPassword"].ToString();
                                UserDTO.PasswordSalt = reader["PasswordSalt"].ToString();

                                UserDTO.IsActive = Convert.ToBoolean(reader["IsActive"]);
                                UserDTO.PersonID = Convert.ToInt32(reader["PersonID"]);
                                UserDTO.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                                UserDTO.PermissionInBinary = Convert.ToInt32(reader["PermissionInBinary"]);

                            }
                            else
                            {
                                UserDTO = null;
                            }


                        }


                    }



                }

            }

           catch(Exception ex)
            {
                //Log in event Log
                UserDTO=null;
            }

            return UserDTO;



        }

        public static clsUserDTO GetUserByUserName(string UserName)
        {


            clsUserDTO UserDTO;



            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using (SqlCommand command = new SqlCommand("[Users].[SP_GetUserByUserName]", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserName", UserName);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UserDTO = new clsUserDTO();

                                UserDTO.UserID = Convert.ToInt32(reader["UserID"]);
                                UserDTO.UserName = UserName;
                                UserDTO.Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString():"";
                                UserDTO.HashPassword = reader["HashPassword"].ToString();
                                UserDTO.PasswordSalt = reader["PasswordSalt"].ToString();

                                UserDTO.IsActive = Convert.ToBoolean(reader["IsActive"]);
                                UserDTO.PersonID = Convert.ToInt32(reader["PersonID"]);
                                UserDTO.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                                UserDTO.PermissionInBinary = Convert.ToInt32(reader["PermissionInBinary"]);

                            }
                            else
                            {
                                UserDTO = null;
                            }


                        }


                    }



                }

            }

            catch (Exception ex)
            {
                //Log in event Log
                UserDTO = null;
            }

            return UserDTO;


        }
        public static DataTable GetAllUsers()
        {

            DataTable dt;


            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using (SqlCommand command = new SqlCommand("[Users].[SP_GetAllUsers]", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
 
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt= new DataTable();    
                          
                                dt.Load(reader);

                            }
                            else
                            {
                                dt = null;                            }


                        }


                    }



                }

            }

            catch (Exception ex)
            {
                //Log in event Log
               dt=null;
            }

            return dt;


        }

        public static bool DeleteUserByID(int UserID)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using (SqlCommand command = new SqlCommand("[Users].[SP_DeleteUserByID]", connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", UserID);
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

        public static int AddNewUser(clsUserDTO UserDTO)
        {
            int UserID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("[Users].[SP_AddNewUser]", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", UserDTO.PersonID);
                        command.Parameters.AddWithValue("@UserName", UserDTO.UserName);
                        command.Parameters.AddWithValue("@HashPassword", UserDTO.HashPassword);
                        command.Parameters.AddWithValue("@PasswordSalt", UserDTO.PasswordSalt);

                        command.Parameters.AddWithValue("@PermissionInBinary", UserDTO.PermissionInBinary);



                        if (!string.IsNullOrEmpty(UserDTO.Notes))
                        {
                            command.Parameters.AddWithValue("@Notes", UserDTO.Notes);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Notes", DBNull.Value);

                        }




                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out UserID))
                        {

                        }
                        else
                        {
                            UserID = -1;
                        }


                    }



                }


            }

            catch(Exception ex)
            {
                //LogInEventLog;
                UserID = -1;
            }

            return UserID;

        }

        public static bool UpdateUserByID(clsUserDTO UserDTO)
        {
            int RowAffected = 0;

            try
            {



                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using (SqlCommand command = new SqlCommand("[People].[SP_UpdatePersonByID]", connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", UserDTO.PersonID);
                        command.Parameters.AddWithValue("@UserID", UserDTO.UserID);
                        command.Parameters.AddWithValue("@UserName", UserDTO.UserName);
                        command.Parameters.AddWithValue("@HashPassword", UserDTO.HashPassword);
 
                        command.Parameters.AddWithValue("@PermissionInBinary", UserDTO.PermissionInBinary);
                        command.Parameters.AddWithValue("@IsActive", UserDTO.IsActive);



                        if (!string.IsNullOrEmpty(UserDTO.Notes))
                        {
                            command.Parameters.AddWithValue("@Notes", UserDTO.Notes);
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

        public static bool IsUserExistByUserNameAndHashPassword(string UserName,string HashPassword)
        {

            bool IsFound = false ;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("[Users].[SP_IsUserExistByUserNameAndHashPassword]", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                         command.Parameters.AddWithValue("@UserName", UserName);
                        command.Parameters.AddWithValue("@HashPassword",  HashPassword);
 

                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null && bool.TryParse(result.ToString(), out IsFound))
                        {

                        }
                        else
                        {
                            IsFound =false;
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

        public static bool IsUserExistByUserID(int UserID)  
        {

            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("[Users].[SP_IsUserExistByID]", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", UserID);
 

                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null && bool.TryParse(result.ToString(), out IsFound))
                        {

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
