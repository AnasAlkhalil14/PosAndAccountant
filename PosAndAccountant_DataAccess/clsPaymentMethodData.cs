using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_DataAccess
{
    public class clsPaymentMethodData
    {

        public static DataTable GetAllPaymetnMethods()
        {
            DataTable dt=new DataTable();
            string query = @"SELECT  [PaymentMethodID],[PaymentMethodName] FROM [AccountantDB].[dbo].[PaymentMethods]";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            dt.Load(reader);

                        }
                        else
                        {
                            return null;
                        }
                    }

                }


            }


            return dt;

        }



    }
}
