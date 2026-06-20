using Microsoft.SqlServer.Server;
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
            DataTable dt=new DataTable();
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
                            if(reader.HasRows)
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

        public static int AddExpneseType(string Type,string Note)
        {
            string query = @"Insert into ExpenseTypes values(@Type,@Description);
select SCOPE_IDENTITY();
 ";
            int TypeID = -1;
            try
            {
                using (SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@Type", Type);
                        if (string.IsNullOrEmpty(Note))
                            command.Parameters.AddWithValue("@Description", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Description", Note);
                        object result = command.ExecuteScalar();
                        if(result != null&&int.TryParse(result.ToString(),out int id))
                            {
                            TypeID = id;
                        }

                    }
                }

            }
            catch(Exception ex)
            {

            }
            return TypeID;

        }

    }
}

