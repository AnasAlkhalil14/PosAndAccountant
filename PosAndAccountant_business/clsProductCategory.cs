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
    public class clsProductCategory
    {

        public enum enMode { eAdd,eUpdate}
        public enMode Mode { get; set; }
        public clsProductCategory()
        {
            CategoryID = -1;
            CategoryName = "";
            Description = "";
            CreateDate = DateTime.Now;
            Mode=enMode.eAdd;
        }
        public clsProductCategory(clsProductCategoryDTO categoryDTO)
        {
            CategoryID=categoryDTO.CategoryID;
            CategoryName=categoryDTO.CategoryName;
            Description=categoryDTO.Description;
            CreateDate=categoryDTO.CreateDate;
            Mode = enMode.eUpdate;
        }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }

        public static DataTable GetAllProductsCategory()
        {
            return clsProductCategoryData.GetAllProductsCategory();
        }

        public static bool Delete(int CategoryID)
        {
            return clsProductCategoryData.DeleteProductCategoryByID(CategoryID);
        }
        private bool _AddProductCategory()
        {
            clsProductCategoryDTO categoryDTO = new clsProductCategoryDTO();

            // Map business properties to DTO
            categoryDTO.CategoryName = this.CategoryName;
            categoryDTO.Description = this.Description;
            

            this.CategoryID = clsProductCategoryData.AddNewProductCategory(categoryDTO);
            return (this.CategoryID != -1);
        }

        private bool _UpdateProductCategory()
        {
            clsProductCategoryDTO categoryDTO = new clsProductCategoryDTO();


            // Map business properties to DTO
            categoryDTO.CategoryName = this.CategoryName;
            categoryDTO.Description = this.Description;
            categoryDTO.CategoryID=this.CategoryID;


            return clsProductCategoryData.UpdateProducCategorytByID(categoryDTO);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.eAdd:
                    if (_AddProductCategory())
                    {
                        Mode = enMode.eUpdate;
                        return true;
                    }
                    return false;

                case enMode.eUpdate:
                    return _UpdateProductCategory();

                default:
                    return false;
            }
        }

        public static clsProductCategory FindByID(int CategoryID)
        {
            clsProductCategoryDTO CategoryDTO = clsProductCategoryData.GetProductCategoryByID(CategoryID);
            if (CategoryDTO != null)
                return new clsProductCategory(CategoryDTO);

            return null;
        }




    }
}
