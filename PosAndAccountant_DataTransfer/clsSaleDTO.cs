using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_DataTransfer
{
    public class clsSaleDTO
    {


        public clsSaleDTO(int saleID, int userID, int  customerID, int paymentMethodID, byte status, double totalAmount, double paidAmount, double discountAmount, DateTime createDate, string notes)
        {
            SaleID = saleID;
            UserID = userID;
            CustomerID = customerID;
            PaymentMethodID = paymentMethodID;
            Status = status;
            TotalAmount = totalAmount;
            PaidAmount = paidAmount;
            DiscountAmount = discountAmount;
            CreateDate = createDate;
            Notes = notes;
        }

        // Parameterless Constructor (Default values)
        public clsSaleDTO()
        {
            SaleID = -1;
            UserID = -1;
            CustomerID = -1; 
            PaymentMethodID = -1;
            Status = 0;
            TotalAmount = 0d;
            PaidAmount = 0d;
            DiscountAmount = 0d;  
            CreateDate = DateTime.Now;
            Notes = "";
        }
        public int SaleID { get; set; }
        public int UserID { get; set; }
        public int   CustomerID { get; set; }   
        public int PaymentMethodID { get; set; }
        public byte Status { get; set; } 
        public double TotalAmount { get; set; }
        public double PaidAmount { get; set; }
        public double  DiscountAmount { get; set; }
        public DateTime CreateDate { get; set; }
        public string Notes { get; set; }
    }
}