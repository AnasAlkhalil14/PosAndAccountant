using System.ComponentModel;

namespace PosAndAccountant_DataTransfer
{
    public class clsSaleDetailDTO : INotifyPropertyChanged
    {
        private int _quantity;
        private int _returnQ;
        private decimal _discountAmount;
        public clsSaleDetailDTO()
        {
        }

        public clsSaleDetailDTO(int counter, string productName, decimal sellingPrice, int quantity, int returnQ, int productID)
        {
            Counter = counter;
            ProductName = productName;
           SellingPrice = sellingPrice;
            Quantity = quantity;
            ReturnQ = returnQ;
            ProductID = productID;
        }

        public int Counter { get; set; }
        public string ProductName { get; set; }
        public decimal SellingPrice { get; set; }

        public int Quantity
        {
            get => _quantity;
            set
            {
                if (_quantity == value) return;

                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
             }
        }

      

        public int ReturnQ
        {
            get => _returnQ;
            set
            {
                if (_returnQ == value) return;

                _returnQ = value;
                OnPropertyChanged(nameof(ReturnQ));
            }
        }

        public int ProductID { get; set; }
        public decimal DiscountAmount { get => _discountAmount;
            set
            {
                if (_discountAmount == value) return;
                _discountAmount=value; OnPropertyChanged(nameof(DiscountAmount));
            
            } }

        public decimal TotalPrice => SellingPrice * (Quantity - ReturnQ)-DiscountAmount;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}