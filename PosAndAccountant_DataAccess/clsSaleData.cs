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
    public class clsSaleData
    {
 
        public static int AddNewSale(int UserID)
        {
            int newSaleID = -1;

             

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("Sales.SP_AddNewSale", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Pass Input Parameters directly from the DTO properties
                    command.Parameters.AddWithValue("@UserID", UserID);

           
                    // Setup the OUTPUT Parameter to capture the new identity
                    SqlParameter outputIdParameter = new SqlParameter();
                    outputIdParameter.ParameterName = "@NewSaleID";
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
                            newSaleID = (int)outputIdParameter.Value;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log your exception here
                        newSaleID = -1;
                    }
                }
            }

            return newSaleID;
        }
    }
}