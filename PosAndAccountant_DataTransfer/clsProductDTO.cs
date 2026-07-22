using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_DataTransfer
{
    public class clsProductDTO : INotifyPropertyChanged
    {

        private int _Quantity;

        // Primary Key
        public int ProductID { get; set; }

        // Foreign Key
        public int ProductCategoryID { get; set; }

        // Financials
        public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }

        // Product Details
        public string UnitOfSale { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }

        // Identification & Assets
        public string ImagePath { get; set; }
        public string BarCode { get; set; }

        public string CategoryName {  get; set; }
        // Inventory
        public int QuantityInStock { get => _Quantity;
            set
            {
                if (_Quantity == value) return;

                _Quantity = value;
                OnPropertyChanged(nameof(QuantityInStock));
                OnPropertyChanged(nameof(QuantityInStock));
            }
        
        }
        public int MinimumQuantityForWarning { get; set; }

        // Audit & Status
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public bool IsActive { get; set; }

        public clsProductDTO()
        {
            this.ProductID = -1; 
            this.IsActive = true;
            this.CreateDate = DateTime.Now;
            this.ModifyDate = DateTime.Now;
        }

        public clsProductDTO(int productID, int productCategoryID, decimal costPrice,
                           decimal sellingPrice, string unitOfSale, string productName,
                           string description, string imagePath, string barCode,
                           int quantityInStock, int minimumQuantityForWarning,
                           DateTime createDate, DateTime modifyDate, bool isActive,string CategoryName="")
        {
            this.ProductID = productID;
            this.ProductCategoryID = productCategoryID;
            this.CostPrice = costPrice;
            this.SellingPrice = sellingPrice;
            this.UnitOfSale = unitOfSale;
            this.CategoryName = CategoryName;
            this.ProductName = productName;
            this.Description = description;
            this.ImagePath = imagePath;
            this.BarCode = barCode;
            this.QuantityInStock = quantityInStock;
            this.MinimumQuantityForWarning = minimumQuantityForWarning;
            this.CreateDate = createDate;
            this.ModifyDate = modifyDate;
            this.IsActive = isActive;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
