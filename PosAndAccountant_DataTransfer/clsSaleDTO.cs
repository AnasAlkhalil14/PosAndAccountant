using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_DataTransfer
{
    public class clsSaleDTO
    {


        public clsSaleDTO(int saleID, int userID, int  customerID, int paymentMethodID , decimal totalAmount, decimal paidAmount, decimal discountAmount ,string notes, BindingList<clsSaleDetailDTO> saleDetails)
        {
            SaleID = saleID;
            UserID = userID;
            CustomerID = customerID;
            PaymentMethodID = paymentMethodID;
             TotalAmount = totalAmount;
            PaidAmount = paidAmount;
            DiscountAmount = discountAmount;
              Notes = notes;
            SaleDetails= saleDetails;
        }

        // Parameterless Constructor (Default values)
        public clsSaleDTO()
        {
            SaleID = -1;
            UserID = -1;
            CustomerID = -1; 
            PaymentMethodID = -1;
             TotalAmount = 0;
            PaidAmount = 0;
            DiscountAmount = 0;  
            CreateDate = DateTime.Now;
            Notes = "";
        }
        public int SaleID { get; set; }
        public int UserID { get; set; }
        public int   CustomerID { get; set; }   
        public int PaymentMethodID { get; set; }
         public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal  DiscountAmount { get; set; }
        public DateTime CreateDate { get; set; }
        public string Notes { get; set; }
        public BindingList<clsSaleDetailDTO> SaleDetails { get; set; }

    }
}