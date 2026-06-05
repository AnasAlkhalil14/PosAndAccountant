using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosAndAccountant_DataTransfer;
using PosAndAccountant_DataAccess;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PosAndAccountant_business
{
    public class clsSale
    {
        public enum enMode { eAdd = 0, eUpdate,eUpdate2 }
        public enMode Mode = enMode.eAdd;

        private int _SaleID;

        // Properties
        public int SaleID { get { return _SaleID; } }
        public int UserID { get; set; }
        public int  CustomerID { get; set; }
        public clsCustomer CustomerInfo { get;private set;  }
        public int PaymentMethodID { get; set; }
        public byte Status { get; set; }
        public double TotalAmount { get; set; }
        public double PaidAmount { get; set; }
        public double DiscountAmount { get; set; }
        public DateTime CreateDate { get; set; }
        public string Notes { get; set; }

        public DataTable dtSaleDetails {  get; set; }
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
           clsSaleDTO saleDTO=new clsSaleDTO();
            saleDTO.SaleID = this._SaleID;
            saleDTO.CustomerID = this.CustomerID;
            saleDTO.UserID = this.UserID;
            saleDTO.Notes = this.Notes;
            saleDTO.Status = this.Status;
            saleDTO.TotalAmount = this.TotalAmount;
            saleDTO.DiscountAmount = this.DiscountAmount;
            saleDTO.PaymentMethodID = this.PaymentMethodID;
            saleDTO.PaidAmount = this.PaidAmount;

            return clsSaleData.SaveSale(saleDTO,dtSaleDetails);
        }

        // Constructor 1: From DTO (Used when retrieving an existing sale)

     
        public clsSale(clsSaleDTO dto,DataTable Details)
        {
            _SaleID = dto.SaleID;
            UserID = dto.UserID;
            CustomerID = dto.CustomerID;
            CustomerInfo = clsCustomer.FindCustomerByID(CustomerID);
            PaymentMethodID = dto.PaymentMethodID;
            Status = dto.Status;
            TotalAmount = dto.TotalAmount;
            PaidAmount = dto.PaidAmount;
            DiscountAmount = dto.DiscountAmount ; 
            CreateDate = dto.CreateDate;
            Notes = dto.Notes;
            dtSaleDetails= Details;
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
            dtSaleDetails = new DataTable();
            DataColumn[] dc = new DataColumn[] { new DataColumn(), new DataColumn(), new DataColumn(), new DataColumn(), new DataColumn() };
            
            dtSaleDetails.Columns.AddRange(dc);

            Mode = enMode.eAdd;
        }

        // Public Save Method matching your business state machine pattern
        public static clsSale Find(int SaleID)
        {
          clsSaleDTO SaleDTO=clsSaleData.GetSaleByID(SaleID);
            if (SaleDTO == null) return null;

            DataTable SaleDetails=clsSaleData.GetSaleDetailBySaleID(SaleID);
            return new clsSale(SaleDTO, SaleDetails);
        }
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
                case enMode.eUpdate2:
                    {
                        break;
                    }
            }
            return false;
        }
    }
}