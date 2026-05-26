using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_DataTransfer
{
    public class clsSaleDetailDTO
    {
        public int SaleDetailID { get; set; }
        public int SaleID { get; set; }
        public int ProductID { get; set; }
        public double CostPrice { get; set; }
        public double SellingPrice { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public int ReturnedQuantity { get; set; }
        public string ProductName { get; set; }
        public double  DiscountAmount { get; set; }

        // Parameterized Constructor
        public clsSaleDetailDTO(int saleDetailID, int saleID, int productID, double costPrice, double sellingPrice, int quantity, double totalPrice, int returnedQuantity, string productName, double discountAmount)
        {
            SaleDetailID = saleDetailID;
            SaleID = saleID;
            ProductID = productID;
            CostPrice = costPrice;
            SellingPrice = sellingPrice;
            Quantity = quantity;
            TotalPrice = totalPrice;
            ReturnedQuantity = returnedQuantity;
            ProductName = productName;
            DiscountAmount = discountAmount;
        }

        // Parameterless Constructor (Default values)
        public clsSaleDetailDTO()
        {
            SaleDetailID = -1;
            SaleID = -1;
            ProductID = -1;
            CostPrice = 0d;
            SellingPrice = 0d;
            Quantity = 0;
            TotalPrice = 0d;
            ReturnedQuantity = 0;
            ProductName = "";
            DiscountAmount = 0d; 
        }
    }
}



