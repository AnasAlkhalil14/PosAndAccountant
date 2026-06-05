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
    
       public static bool SaveSale(clsSaleDTO SaleDTO,DataTable SaleDetails)
        {


            try
            {  // Send everything in ONE call
                using (var conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (var cmd = new SqlCommand("Sales.SP_SaveSale", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SaleID", SaleDTO.SaleID);  
                       cmd.Parameters.AddWithValue("@PaidAmount", SaleDTO.PaidAmount);
                    cmd.Parameters.AddWithValue("@CustomerID", SaleDTO.CustomerID);
                    cmd.Parameters.AddWithValue("@PaymentMethodID", SaleDTO.PaymentMethodID);
                    cmd.Parameters.AddWithValue("@Status", SaleDTO.Status);
                    cmd.Parameters.AddWithValue("@TotalAmount", SaleDTO.TotalAmount);
                    cmd.Parameters.AddWithValue("@DiscountAmount", SaleDTO.DiscountAmount);
                    cmd.Parameters.AddWithValue("@Notes", SaleDTO.Notes);


                    var p = cmd.Parameters.AddWithValue("@Details", SaleDetails); // ✅ DataTable directly
                    p.SqlDbType = SqlDbType.Structured;
                    p.TypeName = "SaleDetailType";

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                //loging erro
            return false;
            }


            return true;

        }
        public static bool UpdateSale(clsSaleDTO SaleDTO, DataTable SaleDetails)
        {


            try
            {  // Send everything in ONE call
                using (var conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (var cmd = new SqlCommand("[Sales].[SP_UpdateSale]", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SaleID", SaleDTO.SaleID);
                    cmd.Parameters.AddWithValue("@PaidAmount", SaleDTO.PaidAmount);
                    cmd.Parameters.AddWithValue("@CustomerID", SaleDTO.CustomerID);
                    cmd.Parameters.AddWithValue("@PaymentMethodID", SaleDTO.PaymentMethodID);
                    cmd.Parameters.AddWithValue("@Status", SaleDTO.Status);
                    cmd.Parameters.AddWithValue("@TotalAmount", SaleDTO.TotalAmount);
                    cmd.Parameters.AddWithValue("@DiscountAmount", SaleDTO.DiscountAmount);
                    cmd.Parameters.AddWithValue("@Notes", SaleDTO.Notes);


                    var p = cmd.Parameters.AddWithValue("@Details", SaleDetails); // ✅ DataTable directly
                    p.SqlDbType = SqlDbType.Structured;
                    p.TypeName = "SaleDetailType";

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //loging erro
                return false;
            }


            return true;

        }
        public static DataTable GetSaleDetailBySaleID(int SaleID)
        {

            DataTable dt = new DataTable();
            string query = "SELECT   ProductID, ProductName, SellingPrice, Quantity, ReturnedQuantity, DiscountAmount FROM  SaleDetails where SaleID=@SaleID";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SaleID", SaleID);   
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

        public static clsSaleDTO GetSaleByID(int SaleID)
        {
            clsSaleDTO SaleDTO = null;
            string query = @"Select * from Sales where SaleID=@SaleID";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@SaleID", SaleID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                SaleDTO = new clsSaleDTO();
                                SaleDTO.SaleID = SaleID;
                                SaleDTO.TotalAmount = Convert.ToDouble(reader["TotalAmount"]);
                                SaleDTO.Status = Convert.ToByte(reader["Status"]);
                                SaleDTO.CreateDate = Convert.ToDateTime(reader["CreateDate"]);
                                SaleDTO.Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : "";
                                SaleDTO.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                                SaleDTO.DiscountAmount = Convert.ToDouble(reader["DiscountAmount"]);
                                SaleDTO.PaymentMethodID = Convert.ToInt16(reader["PaymentMethodID"]);
                                SaleDTO.PaidAmount = Convert.ToDouble(reader["PaidAmount"]);
                                
                            }
                        }
                    }
                    catch { return null; }
                }
            }
            return SaleDTO;
        }

    }
}