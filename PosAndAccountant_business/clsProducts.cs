using PosAndAccountant_DataAccess;
using PosAndAccountant_DataTransfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_business
{
    public class clsProduct
    {
        public enum enMode { eAdd, eUpdate }
        public enMode Mode;

        // Properties
        public int ProductID { get; set; }
        public int ProductCategoryID { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public string UnitOfSale { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string BarCode { get; set; }
        public int QuantityInStock { get; set; }
        public int MinimumQuantityForWarning { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public bool IsActive { get; set; }

        // Default Constructor
        public clsProduct()
        {
            this.ProductID = -1;
            this.ProductCategoryID = -1;
            this.CostPrice = 0;
            this.SellingPrice = 0;
            this.UnitOfSale = "";
            this.ProductName = "";
            this.Description = "";
            this.ImagePath = "";
            this.BarCode = "";
            this.QuantityInStock = 0;
            this.MinimumQuantityForWarning = 0;
            this.CreateDate = DateTime.Now;
            this.ModifyDate = DateTime.Now;
            this.IsActive = true;

            Mode = enMode.eAdd;
        }

        // Constructor for Internal Business Mapping (via DTO)
        private clsProduct(clsProductDTO ProductDTO)
        {
            this.ProductID = ProductDTO.ProductID;
            this.ProductCategoryID = ProductDTO.ProductCategoryID;
            this.CostPrice = ProductDTO.CostPrice;
            this.SellingPrice = ProductDTO.SellingPrice;
            this.UnitOfSale = ProductDTO.UnitOfSale;
            this.ProductName = ProductDTO.ProductName;
            this.Description = ProductDTO.Description;
            this.ImagePath = ProductDTO.ImagePath;
            this.BarCode = ProductDTO.BarCode;
            this.QuantityInStock = ProductDTO.QuantityInStock;
            this.MinimumQuantityForWarning = ProductDTO.MinimumQuantityForWarning;
            this.CreateDate = ProductDTO.CreateDate;
            this.ModifyDate = ProductDTO.ModifyDate;
            this.IsActive = ProductDTO.IsActive;

            Mode = enMode.eUpdate;
        }

        private bool _AddProduct()
        {
            clsProductDTO ProductDTO = new clsProductDTO();

            // Map business properties to DTO
            ProductDTO.ProductCategoryID = this.ProductCategoryID;
            ProductDTO.CostPrice = this.CostPrice;
            ProductDTO.SellingPrice = this.SellingPrice;
            ProductDTO.UnitOfSale = this.UnitOfSale;
            ProductDTO.ProductName = this.ProductName;
            ProductDTO.Description = this.Description;
            ProductDTO.ImagePath = this.ImagePath;
            ProductDTO.BarCode = this.BarCode;
            ProductDTO.QuantityInStock = this.QuantityInStock;
            ProductDTO.MinimumQuantityForWarning = this.MinimumQuantityForWarning;

            this.ProductID = clsProductData.AddNewProduct(ProductDTO);
            return (this.ProductID != -1);
        }

        private bool _UpdateProduct()
        {
            clsProductDTO ProductDTO = new clsProductDTO();

            ProductDTO.ProductID = this.ProductID;
            ProductDTO.ProductCategoryID = this.ProductCategoryID;
            ProductDTO.CostPrice = this.CostPrice;
            ProductDTO.SellingPrice = this.SellingPrice;
            ProductDTO.UnitOfSale = this.UnitOfSale;
            ProductDTO.ProductName = this.ProductName;
            ProductDTO.Description = this.Description;
            ProductDTO.ImagePath = this.ImagePath;
            ProductDTO.BarCode = this.BarCode;
            ProductDTO.QuantityInStock = this.QuantityInStock;
            ProductDTO.MinimumQuantityForWarning = this.MinimumQuantityForWarning;
            ProductDTO.IsActive = this.IsActive;

            return clsProductData.UpdateProductByID(ProductDTO);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.eAdd:
                    if (_AddProduct())
                    {
                        Mode = enMode.eUpdate;
                        return true;
                    }
                    return false;

                case enMode.eUpdate:
                    return _UpdateProduct();

                default:
                    return false;
            }
        }

        // --- Static Methods for Bulk/Search Operations ---

        public static DataTable GetAllProducts()
        {
            return clsProductData.GetAllProducts();
        }

        public static DataTable GetLowStockProducts()
        {
            return clsProductData.GetLowStockProducts();
        }

        public static DataTable GetProductsByName(string ProductName)
        {
            return clsProductData.GetProductsByName(ProductName);
        }

        public static bool DeleteProduct(int ProductID)
        {
            return clsProductData.DeleteProductByID(ProductID);
        }

        public static clsProduct FindByID(int ProductID)
        {
            clsProductDTO ProductDTO = clsProductData.GetProductByID(ProductID);
            if (ProductDTO != null)
                return new clsProduct(ProductDTO);

            return null;
        }

        public static clsProduct FindByBarCode(string BarCode)
        {
            clsProductDTO ProductDTO = clsProductData.GetProductByBarCode(BarCode);
            if (ProductDTO != null)
                return new clsProduct(ProductDTO);

            return null;
        }

        public static bool IsProductExistByName(string ProductName)
        {
            return clsProductData.DoesProductExistByName(ProductName);
        }

        public static bool IsProductExistByID(int ProductID)
        {
            return clsProductData.DoesProductExistByID(ProductID);
        }
    }
}
