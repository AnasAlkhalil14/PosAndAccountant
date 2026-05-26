using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosAndAccountant_DataTransfer;
using PosAndAccountant_DataAccess;
using System.Data;

namespace PosAndAccountant_business
{
    public class clsSale
    {
        public enum enMode { eAdd = 0, eUpdate }
        public enMode Mode = enMode.eAdd;

        private int _SaleID;

        // Properties
        public int SaleID { get { return _SaleID; } }
        public int UserID { get; set; }
        public int  CustomerID { get; set; }
        public int PaymentMethodID { get; set; }
        public byte Status { get; set; }
        public double TotalAmount { get; set; }
        public double PaidAmount { get; set; }
        public double DiscountAmount { get; set; }
        public DateTime CreateDate { get; set; }
        public string Notes { get; set; }

        // Private Add Method using the DTO
        private bool _AddSale()
        {
             
            // Call Data Access Layer
            this._SaleID = clsSaleData.AddNewSale(UserID);

            return this._SaleID != -1;
        }

        // Private Update Method Placeholder
        private bool _UpdateSale()
        {
            // Placeholder: Implement when you add Update functionality to your Data Access Layer
            return false;
        }

        // Constructor 1: From DTO (Used when retrieving an existing sale)
        public clsSale(clsSaleDTO dto)
        {
            _SaleID = dto.SaleID;
            UserID = dto.UserID;
            CustomerID = dto.CustomerID;
            PaymentMethodID = dto.PaymentMethodID;
            Status = dto.Status;
            TotalAmount = dto.TotalAmount;
            PaidAmount = dto.PaidAmount;
            DiscountAmount = dto.DiscountAmount ; 
            CreateDate = dto.CreateDate;
            Notes = dto.Notes;

            Mode = enMode.eUpdate;
        }

        // Constructor 2: Parameterless (Used when creating a new sale)
        public clsSale()
        {
            _SaleID = -1;
            UserID = -1;
            CustomerID = -1;
            PaymentMethodID = -1;
            Status = 0;
            TotalAmount = 0;
            PaidAmount = 0;
            DiscountAmount = 0;
            CreateDate = DateTime.Now;
            Notes = "";

            Mode = enMode.eAdd;
        }

        // Public Save Method matching your business state machine pattern
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.eAdd:
                    {
                        if (_AddSale())
                        {
                            Mode = enMode.eUpdate;
                            return true;
                        }
                        break;
                    }
                case enMode.eUpdate:
                    {
                        if (_UpdateSale())
                        {
                            return true;
                        }
                        break;
                    }
            }
            return false;
        }
    }
}