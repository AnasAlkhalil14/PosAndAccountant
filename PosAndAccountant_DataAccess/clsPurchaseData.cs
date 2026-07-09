using PosAndAccountant_DataTransfer;
using System;
using System.Collections.Generic;
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





    }
}
