using Microsoft.SqlServer.Server;
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
    public class clsExpneseData
    {

        public static DataTable GetAllExpenseTypes()
        {
            DataTable dt = new DataTable();
            string query = @"Select ExpenseTypeID,Type from ExpenseTypes";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                                return dt;
                            }

                        }

                    }
                }
            }
            catch (Exception ex)
            {

            }
            return null;


        }
        public static DataTable GetAllExpenses()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT   Expenses.ExpenseID, Expenses.Amount, ExpenseTypes.Type, Expenses.ExpenseDescription, Expenses.CreatedDate, Users.UserName
FROM         Expenses INNER JOIN
                         ExpenseTypes ON Expenses.ExpenseTypeID = ExpenseTypes.ExpenseTypeID INNER JOIN
                         Users ON Expenses.UserID = Users.UserID";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                                return dt;
                            }

                        }

                    }
                }
            }
            catch (Exception ex)
            {

            }
            return null;


        }
        public static int AddExpneseType(string Type, string Note)
        {
            string query = @"Insert into ExpenseTypes values(@Type,@Description);
select SCOPE_IDENTITY();
 ";
            int TypeID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@Type", Type);
                        if (string.IsNullOrEmpty(Note))
                            command.Parameters.AddWithValue("@Description", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Description", Note);
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            TypeID = id;
                        }

                    }
                }

            }
            catch (Exception ex)
            {

            }
            return TypeID;

        }

        public static (string Type, string Note) GetTypeInfoByID(int TypeID)
        {

            string Type, Note;
            string query = @"SELECT [ExpenseTypeID]
      ,[Type]
      ,[Description]
  FROM [AccountantDB].[dbo].[ExpenseTypes] where ExpenseTypeID=@TypeID
";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {


                    command.Parameters.AddWithValue("@TypeID", TypeID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Type = reader["Type"].ToString();
                                Note = reader["Description"] == DBNull.Value ? "" : reader["Description"].ToString();
return (Type, Note);
                            }
                            else
                            {
                                return ("", "");
                            }

                        }



                    }
                    catch (Exception ex)
                    {
                        //Loging in event lopg
                        return ("", "");

                    }



                }
            }
        }






            

        public static int AddExpense(clsExpenseDTO expenseDTO)
        {
            int ExpenseID = -1;



            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("Expenses.SP_AddExpense", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Pass Input Parameters directly from the DTO properties
                    command.Parameters.AddWithValue("@UserID", expenseDTO.UserID);
                    command.Parameters.AddWithValue("@ExpenseTypeID", expenseDTO.ExpenseTypeID);
                    command.Parameters.AddWithValue("@Amount", expenseDTO.Amount);
                    command.Parameters.AddWithValue("@Notes", expenseDTO.ExpenseDescription);



                    // Setup the OUTPUT Parameter to capture the new identity
                    SqlParameter outputIdParameter = new SqlParameter();
                    outputIdParameter.ParameterName = "@ExpenseID";
                    outputIdParameter.SqlDbType = SqlDbType.Int;
                    outputIdParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputIdParameter);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        // Retrieve the value returned from the stored procedure
                        if (outputIdParameter.Value != DBNull.Value)
                        {
                            ExpenseID = (int)outputIdParameter.Value;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log your exception here
                        ExpenseID = -1;
                    }
                }
            }

            return ExpenseID;




        }


        public static clsExpenseDTO GetExpenseByID(int ExpenseID)
        {
            clsExpenseDTO ExpenseDTO = null;
            string query = @"SELECT   Expenses.*, Users.UserName
FROM Expenses INNER JOIN
  Users ON Expenses.UserID = Users.UserID
  where ExpenseID=@ExpenseID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {


                    command.Parameters.AddWithValue("@ExpenseID", ExpenseID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ExpenseDTO = new clsExpenseDTO();

                                ExpenseDTO.ExpenseID = ExpenseID;
                                ExpenseDTO.UserID = Convert.ToInt32(reader["UserID"]);
                                ExpenseDTO.Amount = Convert.ToDouble(reader["Amount"]);
                                ExpenseDTO.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                                ExpenseDTO.ExpenseTypeID = Convert.ToInt32(reader["ExpenseTypeID"]);
                                ExpenseDTO.ExpenseDescription = Convert.ToString(reader["ExpenseDescription"]);
                                return ExpenseDTO;
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
    }

}