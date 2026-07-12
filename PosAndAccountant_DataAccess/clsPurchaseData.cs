using PosAndAccountant_DataTransfer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PosAndAccountant_DataAccess
{
    public class clsPurchaseData
    {
        public static int AddPurchase(clsPurchaseDTO purchaseDTO)
        {
            int PurchaseID = -1;

            DataTable PurchaseDetails=new DataTable ();
            PurchaseDetails.Columns.Add("ProductID", typeof(int));
            PurchaseDetails.Columns.Add("ProductName", typeof(string));
            PurchaseDetails.Columns.Add("CostPrice", typeof(decimal));
            PurchaseDetails.Columns.Add("Quantity", typeof(int));
            PurchaseDetails.Columns.Add("TotalPrice", typeof(decimal));
            PurchaseDetails.Columns.Add("ReturnQuantity", typeof(int));

            foreach (var item in purchaseDTO.PurchaseDetails)
            {
                PurchaseDetails.Rows.Add(item.ProductID, item.ProductName, item.CostPrice, item.Quantity, item.TotalPrice, item.ReturnQ);
                
            }



            try
            {  // Send everything in ONE call
                using (var conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (var cmd = new SqlCommand("[Purchases].[SP_SavePurchase]", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", purchaseDTO.UserID);
                    cmd.Parameters.AddWithValue("@SupplierID", purchaseDTO.SupplierID);
                    if (string.IsNullOrEmpty(purchaseDTO.Notes.Trim()))
                        cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@Notes", purchaseDTO.Notes);
                    cmd.Parameters.AddWithValue("@PaymentMethodID", purchaseDTO.PaymentMethodID);
                    cmd.Parameters.AddWithValue("@TotalAmount", purchaseDTO.TotalAmount);
                    cmd.Parameters.AddWithValue("@PaidAmount", purchaseDTO.PaidAmount);
                    cmd.Parameters.AddWithValue("@DiscountAmount", purchaseDTO.DiscountAmount);
                    cmd.Parameters.AddWithValue("@RemainingAmountDebt", purchaseDTO.RemainingAmountDebt);
                  

                    var p = cmd.Parameters.AddWithValue("@PurchaseDetailsTVP", PurchaseDetails); // ✅ DataTable directly
                    p.SqlDbType = SqlDbType.Structured;
                    p.TypeName = "PurchaseDetailsTVP";


                    // Setup the OUTPUT Parameter to capture the new identity
                    SqlParameter outputIdParameter = new SqlParameter();
                    outputIdParameter.ParameterName = "@PurchaseID";
                    outputIdParameter.SqlDbType = SqlDbType.Int;
                    outputIdParameter.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputIdParameter);


                    conn.Open();
                    cmd.ExecuteNonQuery();
                    // Retrieve the value returned from the stored procedure
                    if (outputIdParameter.Value != DBNull.Value)
                    {
                        PurchaseID= (int)outputIdParameter.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                //loging erro
                return -1;
            }


            return PurchaseID;





        }

        public static bool UpdatePurchase(clsPurchaseDTO purchaseDTO)
        {
          

            DataTable PurchaseDetails = new DataTable();
            PurchaseDetails.Columns.Add("ProductID", typeof(int));
            PurchaseDetails.Columns.Add("ProductName", typeof(string));
            PurchaseDetails.Columns.Add("CostPrice", typeof(decimal));
            PurchaseDetails.Columns.Add("Quantity", typeof(int));
            PurchaseDetails.Columns.Add("TotalPrice", typeof(decimal));
            PurchaseDetails.Columns.Add("ReturnQuantity", typeof(int));

            foreach (var item in purchaseDTO.PurchaseDetails)
            {
                PurchaseDetails.Rows.Add(item.ProductID, item.ProductName, item.CostPrice, item.Quantity, item.TotalPrice, item.ReturnQ);

            }



            try
            {  // Send everything in ONE call
                using (var conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (var cmd = new SqlCommand("[Purchases].[SP_UpdatePurchase]", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", purchaseDTO.UserID);
                    cmd.Parameters.AddWithValue("@SupplierID", purchaseDTO.SupplierID);
                    if (string.IsNullOrEmpty(purchaseDTO.Notes.Trim()))
                        cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@Notes", purchaseDTO.Notes);
                    cmd.Parameters.AddWithValue("@PaymentMethodID", purchaseDTO.PaymentMethodID);
                    cmd.Parameters.AddWithValue("@TotalAmount", purchaseDTO.TotalAmount);
                    cmd.Parameters.AddWithValue("@PaidAmount", purchaseDTO.PaidAmount);
                    cmd.Parameters.AddWithValue("@DiscountAmount", purchaseDTO.DiscountAmount);
                    cmd.Parameters.AddWithValue("@RemainingAmountDebt", purchaseDTO.RemainingAmountDebt);


                    var p = cmd.Parameters.AddWithValue("@Details", PurchaseDetails); // ✅ DataTable directly
                    p.SqlDbType = SqlDbType.Structured;
                    p.TypeName = "PurchaseDetailsTVP";

                   
                    cmd.Parameters.AddWithValue("@PurchaseID",purchaseDTO.PurchaseID);


                    conn.Open();
                    cmd.ExecuteNonQuery();
                   
                }
            }
            catch (Exception ex)
            {
                //loging erro
                return false;
            }


            return true ;





        }

        public static DataTable GetPurchaseDetails(int purchaseID)
        {
            DataTable detailsDT = new DataTable();
            string query = @"Select * from PurchaseDetails where PurchaseID=@PurchaseID";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@PurchaseID", purchaseID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                detailsDT.Load(reader);

                            }
                        }
                    }
                    catch { return null; }
                }
            }
            return detailsDT;
        }
 
        public static clsPurchaseDTO GetPurchase(int  purchaseID)
        {
            clsPurchaseDTO purchaseDTO = null;
            string query = @"Select * from Purchases where PurchaseID=@PurchaseID";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@PurchaseID", purchaseID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                purchaseDTO = new clsPurchaseDTO();
                                purchaseDTO.SupplierID = Convert.ToInt32(reader["SupplierID"]);
                                purchaseDTO.UserID = Convert.ToInt32(reader["UserID"]);
                                purchaseDTO.PaymentMethodID = Convert.ToInt32(reader["PaymentMethodID"]);
                                purchaseDTO.Notes = reader["Notes"] == DBNull.Value ? "" : reader["Notes"].ToString();
                                purchaseDTO.DiscountAmount = Convert.ToDecimal(reader["DiscountAmount"]);
                                purchaseDTO.PaidAmount = Convert.ToDecimal(reader["PaidAmount"]);
                                purchaseDTO.TotalAmount = Convert.ToDecimal(reader["TotalAmount"]);
                                purchaseDTO.RemainingAmountDebt = Convert.ToDecimal(reader["RemainingAmountDebt"]);
                                purchaseDTO.PurchaseID = purchaseID;
                                DataTable detailsDT= GetPurchaseDetails(purchaseID);
                                if(detailsDT != null)
                                {
                                    int Counter = 0;
                                    purchaseDTO.PurchaseDetails = new System.ComponentModel.BindingList<clsPurchaseDetailsDTO>();
                                foreach(DataRow row in detailsDT.Rows)
                                {
                                        Counter++;
                                        purchaseDTO.PurchaseDetails.Add(new clsPurchaseDetailsDTO(Counter, row["ProductName"].ToString(), Convert.ToDecimal(row["CostPrice"]), (int)row["Quantity"], (int)row["ReturnedQuantity"], (int)row["ProductID"]));

                                }
                                }

                            }
                        }
                    }
                    catch { return null; }
                }
            }
            return purchaseDTO;


        }



    }
}
