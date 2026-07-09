using System.ComponentModel;

namespace PosAndAccountant_DataTransfer
{
    public class clsPurchaseDetailsDTO : INotifyPropertyChanged
    {
        private int _quantity;
        private int _returnQ;

        public int Counter { get; set; }
        public string ProductName { get; set; }
        public decimal CostPrice { get; set; }

        public int Quantity
        {
            get => _quantity;
            set
            {
                if (_quantity == value) return;

                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
                OnPropertyChanged(nameof(TotalPrice));
            }
        }

        public decimal TotalPrice => CostPrice * (Quantity-ReturnQ);

        

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

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}