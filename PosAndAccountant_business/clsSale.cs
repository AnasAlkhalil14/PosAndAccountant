//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using PosAndAccountant_DataTransfer;
//using PosAndAccountant_DataAccess;
//using System.Data;
//using System.Runtime.CompilerServices;
//using System.Runtime.InteropServices;

//namespace PosAndAccountant_business
//{
//    //This class will be refactor soon like we did for clsPurchase 
//    public class clsSale
//    {
//        public enum enMode { eAdd = 0, eUpdate,eUpdate2 }
//        public enMode Mode = enMode.eAdd;

//        private int _SaleID;

//        // Properties
//        public int SaleID { get { return _SaleID; } }
//        public int UserID { get; set; }
//        public int  CustomerID { get; set; }
//        public clsCustomer CustomerInfo { get;private set;  }
//        public int PaymentMethodID { get; set; }
//        public byte Status { get; set; }
//        public double TotalAmount { get; set; }
//        public double PaidAmount { get; set; }
//        public double DiscountAmount { get; set; }
//        public DateTime CreateDate { get; set; }
//        public string Notes { get; set; }

//        public DataTable dtSaleDetails {  get; set; }
//        // Private Add Method using the DTO
//        private bool _AddSale()
//        {

//            // Call Data Access Layer
//            this._SaleID = clsSaleData.AddNewSale(UserID);

//            return this._SaleID != -1;
//        }

//        // Private Update Method Placeholder
//        private bool _UpdateSale()
//        {
//           clsSaleDTO saleDTO=new clsSaleDTO();
//            saleDTO.SaleID = this._SaleID;
//            saleDTO.CustomerID = this.CustomerID;
//            saleDTO.UserID = this.UserID;
//            saleDTO.Notes = this.Notes;
//            saleDTO.Status = this.Status;
//            saleDTO.TotalAmount = this.TotalAmount;
//            saleDTO.DiscountAmount = this.DiscountAmount;
//            saleDTO.PaymentMethodID = this.PaymentMethodID;
//            saleDTO.PaidAmount = this.PaidAmount;

//            return clsSaleData.SaveSale(saleDTO,dtSaleDetails);
//        }
//        private bool _UpdateSale2()
//        {
//            clsSaleDTO saleDTO = new clsSaleDTO();
//            saleDTO.SaleID = this._SaleID;
//            saleDTO.CustomerID = this.CustomerID;
//            saleDTO.UserID = this.UserID;
//            saleDTO.Notes = this.Notes;
//            saleDTO.Status = this.Status;
//            saleDTO.TotalAmount = this.TotalAmount;
//            saleDTO.DiscountAmount = this.DiscountAmount;
//            saleDTO.PaymentMethodID = this.PaymentMethodID;
//            saleDTO.PaidAmount = this.PaidAmount;

//            return clsSaleData.UpdateSale(saleDTO, dtSaleDetails);
//        }

//        // Constructor 1: From DTO (Used when retrieving an existing sale)


//        public clsSale(clsSaleDTO dto,DataTable Details,enMode Mode=enMode.eUpdate)
//        {
//            _SaleID = dto.SaleID;
//            UserID = dto.UserID;
//            CustomerID = dto.CustomerID;
//            CustomerInfo = clsCustomer.FindCustomerByID(CustomerID);
//            PaymentMethodID = dto.PaymentMethodID;
//            Status = dto.Status;
//            TotalAmount = dto.TotalAmount;
//            PaidAmount = dto.PaidAmount;
//            DiscountAmount = dto.DiscountAmount ; 
//            CreateDate = dto.CreateDate;
//            Notes = dto.Notes;
//            dtSaleDetails= Details;

//        }

//        // Constructor 2: Parameterless (Used when creating a new sale)
//        public clsSale()
//        {
//            _SaleID = -1;
//            UserID = -1;
//            CustomerID = -1;
//            PaymentMethodID = -1;
//            Status = 0;
//            TotalAmount = 0;
//            PaidAmount = 0;
//            DiscountAmount = 0;
//            CreateDate = DateTime.Now;
//            Notes = "";
//            dtSaleDetails = new DataTable();
//            DataColumn[] dc = new DataColumn[] { new DataColumn(), new DataColumn(), new DataColumn(), new DataColumn(), new DataColumn() };

//            dtSaleDetails.Columns.AddRange(dc);

//            Mode = enMode.eAdd;
//        }

//        // Public Save Method matching your business state machine pattern
//        public static clsSale Find(int SaleID)
//        {
//          clsSaleDTO SaleDTO=clsSaleData.GetSaleByID(SaleID);
//            if (SaleDTO == null) return null;

//            DataTable SaleDetails=clsSaleData.GetSaleDetailBySaleID(SaleID);
//            return new clsSale(SaleDTO, SaleDetails,enMode.eUpdate2);
//        }
//        public bool Save()
//        {

//            switch (Mode)
//            {
//                case enMode.eAdd:
//                    {
//                        if (_AddSale())
//                        {
//                            Mode = enMode.eUpdate;
//                            return true;
//                        }
//                        break;
//                    }
//                case enMode.eUpdate:
//                    {
//                        if (_UpdateSale())
//                        {
//                            Mode = enMode.eUpdate2;
//                            return true;
//                        }
//                        break;
//                    }
//                case enMode.eUpdate2:
//                    {

//                        return _UpdateSale2();
//                    }
//            }
//            return false;
//        }
//    }
//}



using PosAndAccountant_DataAccess;
using PosAndAccountant_DataTransfer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_business
{
    public class clsSale
    {
        public enum enMode { eAdd, eUpdate }
        public enMode Mode;

        private int _CustomerID;
        public int SaleID { get; set; }
        public int UserID { get; set; }
        public int CustomerID
        {
            get { return _CustomerID; }
            set
            {
                if (value != _CustomerID)
                {
                    _CustomerID = value;
                    if (value != -1)
                    {
                        CustomerInfo = clsCustomer.FindCustomerByID(value);
                        if (CustomerInfo == null) _CustomerID = -1;
                    }
                }
            }
        }
        public clsCustomer CustomerInfo { get; set; }

        public int PaymentMethodID { get; set; }

        public decimal TotalAmount => Details.Sum(p => p.TotalPrice);
        public decimal PaidAmount { get; set; }

        public decimal NetTotalAmount { get { return TotalAmount - DiscountAmount; } }

        public decimal NetTotalWithDebt { get { return NetTotalAmount + RemainingAmountDebt; } }
        public clsSale()
        {
            SaleID = -1; UserID = clsUser.CurrentUser.UserID; CustomerID = -1; PaymentMethodID = -1;
            PaidAmount = 0; DiscountAmount = 0; Notes = "";
            Details = new BindingList<clsSaleDetailDTO>();
            Mode = enMode.eAdd;
            SetAllProducts();
        }

        public clsSale(clsSaleDTO SaleDTO)
        {
            SaleID = SaleDTO.SaleID;
            UserID = SaleDTO.UserID;
            CustomerID = SaleDTO.CustomerID;
            PaymentMethodID = SaleDTO.PaymentMethodID;
            PaidAmount = SaleDTO.PaidAmount;
            DiscountAmount = SaleDTO.DiscountAmount;

            Notes = SaleDTO.Notes;
            Details = SaleDTO.SaleDetails;
            Mode = enMode.eUpdate;
            SetAllProducts();
        }

        public void SetAllProducts()
        {
            ProductList = new BindingList<clsProductDTO>();
            DataTable AllProducts = clsProduct.GetAllProducts();

            foreach (DataRow item in AllProducts.Rows)
            {
                clsProductDTO productDTO = new clsProductDTO();

                productDTO.ProductID = Convert.ToInt32(item["ProductID"]);
                productDTO.ProductName = item["ProductName"].ToString();
                productDTO.QuantityInStock = Convert.ToInt32(item["QuantityInStock"]);
                productDTO.MinimumQuantityForWarning = Convert.ToInt32(item["MinimumQuantityForWarning"]);
                productDTO.SellingPrice = Convert.ToDecimal(item["SellingPrice"]);
                productDTO.CostPrice = Convert.ToDecimal(item["CostPrice"]);
                productDTO.UnitOfSale = Convert.ToString(item["UnitOfSale"]);
                productDTO.ImagePath = Convert.ToString(item["ImagePath"]);
                productDTO.BarCode = Convert.ToString(item["BarCode"]);
                productDTO.CreateDate = Convert.ToDateTime(item["CreateDate"]);
                productDTO.CategoryName = item["CategoryName"].ToString();
                productDTO.ProductCategoryID = Convert.ToInt32(item["ProductCategoryID"]);
                ProductList.Add(productDTO);

            }



        }
        public decimal DiscountAmount { get; set; }
        //public decimal RemainingAmountDebt => (decimal)SuplierInfo.TotalRemainingDebt;
        public decimal RemainingAmountDebt
        {
            get
            {
                if (CustomerInfo == null)
                    return 0;
                return (decimal)CustomerInfo.TotalRemainingDebt;
            }
        }
        public DateTime CreateDate { get; set; }
        public string Notes { get; set; }

        public BindingList<clsSaleDetailDTO> Details;
        public BindingList<clsProductDTO> ProductList;

        public int TotalQ => Details.Sum(p => p.Quantity - p.ReturnQ);

        public bool EditQuantity(int ProductID, int NewQ)
        {
            var item = Details.FirstOrDefault(d => d.ProductID == ProductID);
            int Index = Details.IndexOf(item);
            if (Index >= 0)
            {
                if (item.ReturnQ > NewQ) return false;

                bool EditQ = false;

                if (item.Quantity == NewQ) return true;
                else if (item.Quantity > NewQ)
                {
                    EditQ = IncreaseFreeProductQuantity(ProductID, item.Quantity - NewQ);
                }
                else
                {
                    EditQ = DecreaseFreeProductQuantity(ProductID, NewQ - item.Quantity);

                }


                if (EditQ)
                    Details[Index].Quantity = NewQ;
                return EditQ;
            }
            else
            {
                return false;
            }
        }
        public bool EditReturnQ(int ProductID, int NewRQ)
        {

            var item = Details.FirstOrDefault(d => d.ProductID == ProductID);
            int Index = Details.IndexOf(item);
            if (Index >= 0)
            {
                if (Details[Index].Quantity < NewRQ)

                    return false;

                bool EditQ = false;
                if (item.ReturnQ == NewRQ) return true;

                else if (item.ReturnQ > NewRQ)
                {
                    EditQ = DecreaseFreeProductQuantity(ProductID, item.ReturnQ - NewRQ);
                }
                else
                {
                    EditQ = IncreaseFreeProductQuantity(ProductID, NewRQ - item.ReturnQ);

                }


                if (EditQ)
                    Details[Index].ReturnQ = NewRQ;
                return EditQ;
            }
            return false;

        }

        public bool RemoveDetail(int ProductID)
        {
            clsSaleDetailDTO item = Details.FirstOrDefault(p => p.ProductID == ProductID);
            if (item != null)
            {
                Details.Remove(item);
                return IncreaseFreeProductQuantity(item.ProductID, item.Quantity - item.ReturnQ);
            }
            else
            {
                return false;
            }

        }
        public bool AddToSale(clsSaleDetailDTO detail)
        {
            if (!Details.Any(d => d.ProductID == detail.ProductID))
            {
                if (Details.Count > 0)
                {
                    detail.Counter = Details.Max(p => p.Counter) + 1;

                }
                else
                    detail.Counter = 1;

                Details.Add(detail);
            }
            else
            {
                var item = Details.FirstOrDefault(d => d.ProductID == detail.ProductID);
                int index = Details.IndexOf(item);
                Details[index].Quantity += detail.Quantity;
            }

            return DecreaseFreeProductQuantity(detail.ProductID, detail.Quantity - detail.ReturnQ);
        }

        public bool _AddSale()
        {
            clsSaleDTO SaleDTO = new clsSaleDTO(-1, UserID, CustomerID, PaymentMethodID, TotalAmount, PaidAmount, DiscountAmount, Notes, Details);

            SaleID = clsSaleData.AddSale(SaleDTO);
            return SaleID != -1;
        }
        public bool _UpdateSale()
        {
            clsSaleDTO SaleDTO = new clsSaleDTO(SaleID, UserID, CustomerID, PaymentMethodID, TotalAmount, PaidAmount, DiscountAmount, Notes, Details);

            return clsSaleData.UpdateSale(SaleDTO);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.eAdd:
                    if (_AddSale())
                    {
                        Mode = enMode.eUpdate;
                        return true;
                    }
                    return false;

                case enMode.eUpdate:
                    return _UpdateSale();

                default:
                    return false;
            }
        }


        public static clsSale Find(int SaleID)
        {
            clsSaleDTO SaleDTO = clsSaleData.GetSale(SaleID);
            if (SaleDTO == null) return null;

            return new clsSale(SaleDTO);

        }


        public bool DecreaseFreeProductQuantity(int ProductID, int NumberProductToTake)
        {
            if (!ProductList.Any(p => p.ProductID == ProductID)) return false;
            if (NumberProductToTake < 0) return false;
            var product = ProductList.FirstOrDefault(p => p.ProductID == ProductID);
            if (product == null || product.QuantityInStock < NumberProductToTake) return false;

            int index = ProductList.IndexOf(product);
            ProductList[index].QuantityInStock -= NumberProductToTake;
            return true;
        }
        public bool IncreaseFreeProductQuantity(int ProductID, int NumberToAdd)
        {
            if (!ProductList.Any(p => p.ProductID == ProductID)) return false;
            if (NumberToAdd < 0) return false;
            var product = ProductList.FirstOrDefault(p => p.ProductID == ProductID);
            if (product == null) return false;

            int index = ProductList.IndexOf(product);
            ProductList[index].QuantityInStock += NumberToAdd;
            return true;


        }

        public bool IsNotZeroQuantity(int ProductID)
        {
            clsProductDTO productDTO = ProductList.FirstOrDefault(p => p.ProductID == ProductID);
            return productDTO != null && productDTO.QuantityInStock != 0;
        }

        public clsProductDTO GetProductDTObyID(int ProductID)
        {
            return ProductList.FirstOrDefault(p => p.ProductID == ProductID);

        }
        public static decimal GetDaySale()
        { return clsSaleData.GetDaySale(); }
        public static decimal GetYesterdaySale()
        {
            return clsSaleData.GetYesterdaySale();
        }
        public static decimal GetDiffPercentDaySale()
        {
            return (GetDaySale()/GetYesterdaySale())*100-100;
        }
 
        public static decimal GetDayPaid()
        {
            return clsSaleData.GetDayPaid();
        }
        public static decimal GetYesterdayPaid()
        {
            return clsSaleData.GetYesterdayPaid();
        }
        public static decimal GetDiffPercentDayPaid()
        {
            return (GetDayPaid() / GetYesterdayPaid()) * 100 - 100;
        }
    }

}

