using System.ComponentModel;

namespace InvoiceCreatorApp.ViewModels // Bindeglied zwischen der Benutzeroberfläche (View) und den Daten (Model)
{
    public class InvoiceViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged; // abchecken ob null ist

        private string _companyName = "WPFBau";
        private string _customerName;
        private string _customerNumber;
        private string _productName;
        private int _quantity;
        private decimal _pricePerUnit;
        private decimal _totalPrice;

        public string CompanyName
        {
            get => _companyName;
            set
            {
                _companyName = value;
                OnPropertyChanged(nameof(CompanyName));
            }
        }

        public string CustomerName
        {
            get => _customerName;
            set
            {
                _customerName = value;
                OnPropertyChanged(nameof(CustomerName));
            }
        }

        public string CustomerNumber
        {
            get => _customerNumber;
            set
            {
                _customerNumber = value;
                OnPropertyChanged(nameof(CustomerNumber));
            }
        }

        public string ProductName
        {
            get => _productName;
            set
            {
                _productName = value;
                OnPropertyChanged(nameof(ProductName));
            }
        }

        public int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
                CalculateTotalPrice();
            }
        }

        public decimal PricePerUnit
        {
            get => _pricePerUnit;
            set
            {
                _pricePerUnit = value;
                OnPropertyChanged(nameof(PricePerUnit));
                CalculateTotalPrice();
            }
        }

        public decimal TotalPrice
        {
            get => _totalPrice;
            private set
            {
                _totalPrice = value;
                OnPropertyChanged(nameof(TotalPrice));
            }
        }

        private void CalculateTotalPrice()
        {
            TotalPrice = Quantity * PricePerUnit * 1.20m; // 20% Mehrwertsteuer
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name)); // überprüft ob auf alle Properties zugegriffen wird 
        }
    }
}
