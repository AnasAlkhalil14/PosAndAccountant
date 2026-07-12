using PosAndAccountant_DataAccess;
using PosAndAccountant_DataTransfer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_business
{
    public class clsPurchase
    {
         public enum enMode { eAdd,eUpdate}
        public enMode Mode;

        private int _SupplierID;
      public int PurchaseID {  get; set; }
        public int UserID {  get; set; }
        public int  SupplierID { get { return _SupplierID; }
            set
            {
                if (value != _SupplierID)
                    _SupplierID = value;
                if (value != -1) { SuplierInfo = clsSupplier.FindSupplierByID(value);
                    if (SuplierInfo == null) _SupplierID = -1;
                }
            } }
        public clsSupplier SuplierInfo { get; set; }

        public int PaymentMethodID { get; set; }
            
        public decimal TotalAmount => Details.Sum(p => p.CostPrice * (p.Quantity - p.ReturnQ));
        public decimal PaidAmount {  get; set; }

        public decimal NetTotalAmount { get { return TotalAmount - DiscountAmount; } }

        public decimal NetTotalWithDebt { get { return NetTotalAmount + RemainingAmountDebt; } }
        public clsPurchase()
        {
            PurchaseID = -1;UserID = clsUser.CurrentUser.UserID;SupplierID = -1;PaymentMethodID = -1;
            PaidAmount = 0;DiscountAmount = 0;Notes = "";
            Details = new BindingList<clsPurchaseDetailsDTO>();
            Mode = enMode.eAdd;
        }

        public clsPurchase(clsPurchaseDTO purchaseDTO)
        {
            PurchaseID = purchaseDTO.PurchaseID;
            UserID = purchaseDTO.UserID;
            SupplierID = purchaseDTO.SupplierID;
            PaymentMethodID = purchaseDTO.PaymentMethodID;
            PaidAmount = purchaseDTO.PaidAmount;
            DiscountAmount = purchaseDTO.DiscountAmount;
            
            Notes = purchaseDTO.Notes;
            Details = purchaseDTO.PurchaseDetails;
            Mode = enMode.eUpdate;
        }

        public decimal DiscountAmount { get; set; }
        //public decimal RemainingAmountDebt => (decimal)SuplierInfo.TotalRemainingDebt;
        public decimal RemainingAmountDebt { get {
                if (SuplierInfo==null)
                    return 0;
                return (decimal)SuplierInfo.TotalRemainingDebt;
            } }
        public DateTime CreateDate { get; set; }
        public string Notes { get; set; }
        
        public BindingList< clsPurchaseDetailsDTO> Details;

        public int TotalQ=>Details.Sum(p=>p.Quantity-p.ReturnQ);

        public bool EditQuantity(int ProductID,int NewQ)
        {
            var item = Details.FirstOrDefault(d => d.ProductID == ProductID);
            int Index = Details.IndexOf(item);
            if (Index >= 0)
            {
                if(item.ReturnQ>NewQ)return false;

                Details[Index].Quantity = NewQ;
                return true;
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
            if (Index>=0)
            {
                if (Details[Index].Quantity<NewRQ)
               
                    return false;
                
                else

                Details[Index].ReturnQ = NewRQ;
                return true;
            }
            return false;
               
        }

        public  bool RemoveDetail(int ProductID)
        {
            clsPurchaseDetailsDTO item = Details.FirstOrDefault(p => p.ProductID == ProductID);
           if (item!=null)
            {
                Details.Remove(item);
           return true;
            }else
            {
                return false;
            }

        }
        public void AddToPurchase(clsPurchaseDetailsDTO detail)
        {
            if(!Details.Any(d=>d.ProductID==detail.ProductID))
            {
                if(Details.Count>0)
                {
                    detail.Counter = Details.Max(p => p.Counter) + 1;

                }
                else
                    detail.Counter = 1;

                Details.Add( detail);
            }
            else
            {
                var item= Details.FirstOrDefault(d => d.ProductID == detail.ProductID);
                int index= Details.IndexOf(item);
                Details[index].Quantity += detail.Quantity;
            }
        }

        public bool _AddPurchase()
        {
            clsPurchaseDTO purchaseDTO = new clsPurchaseDTO(-1,UserID, SupplierID, PaymentMethodID, TotalAmount, PaidAmount, DiscountAmount, RemainingAmountDebt, Notes, Details);

            PurchaseID= clsPurchaseData.AddPurchase(purchaseDTO);
            return PurchaseID != -1;
        }
        public bool _UpdatePurchae()
        {
            clsPurchaseDTO purchaseDTO = new clsPurchaseDTO(PurchaseID, UserID, SupplierID, PaymentMethodID, TotalAmount, PaidAmount, DiscountAmount, RemainingAmountDebt, Notes, Details);

            return clsPurchaseData.UpdatePurchase(purchaseDTO);
        }
         
               public bool Save()
        {
            switch (Mode)
            {
                case enMode.eAdd:
                    if (_AddPurchase())
                    {
                        Mode = enMode.eUpdate;
                        return true;
                    }
                    return false;

                case enMode.eUpdate:
                    return _UpdatePurchae();

                default:
                    return false;
            }
        }


        public static clsPurchase Find(int PurchaseID)
        {
            clsPurchaseDTO purchaseDTO = clsPurchaseData.GetPurchase(PurchaseID);
            if (purchaseDTO == null) return null;

            return new clsPurchase(purchaseDTO);

        }

    }

    }
 
