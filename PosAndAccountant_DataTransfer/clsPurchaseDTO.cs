using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_DataTransfer
{ 
    public class clsPurchaseDTO
    {
        public int PurchaseID {  get; set; }
        public clsPurchaseDTO(int purchaseID,int userID, int supplierID, int paymentMethodID, decimal totalAmount, decimal paidAmount, decimal discountAmount, decimal remainingAmountDebt, string notes, BindingList<clsPurchaseDetailsDTO> purchaseDetails)
        {
            PurchaseID = purchaseID;
            UserID = userID;
            SupplierID = supplierID;
            PaymentMethodID = paymentMethodID;
            TotalAmount = totalAmount;
            PaidAmount = paidAmount;
            DiscountAmount = discountAmount;
            RemainingAmountDebt = remainingAmountDebt;
            Notes = notes;
            PurchaseDetails = purchaseDetails;
        }

        public clsPurchaseDTO()
        {
        }

        public int UserID {  get; set; }
        public int SupplierID { get; set; }
        public int  PaymentMethodID { get; set; }
        public decimal  TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal  DiscountAmount { get; set; }
        public decimal  RemainingAmountDebt { get; set; }
        public string Notes { get; set; }
       public BindingList<clsPurchaseDetailsDTO> PurchaseDetails { get; set; }

    }
}
