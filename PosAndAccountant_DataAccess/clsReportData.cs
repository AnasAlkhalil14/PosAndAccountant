using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_DataAccess
{
    public class clsReportData
    {
        public static DataTable GetDataTable(string sqlQuery)
        {
            DataTable dt = new DataTable();

            // استخدام using يضمن إغلاق الاتصال وتحرير الموارد فوراً حتى لو حدث خطأ
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                        
                    }
                }
            }

            return dt;
        }




    }
}
