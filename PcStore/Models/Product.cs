using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace PcStore.Models
{
    public partial class Product : INotifyPropertyChanged
    {
        public Product()
        {
            SaleDetails = new HashSet<SaleDetail>();
        }

        public int ProductId
        {
            get => _ProductId;
            set
            {
                _ProductId = value;
                OnPropertyChanged(nameof(ProductId));
            }
        }
        private int _ProductId;
        public string Code
        {
            get => _Code;
            set
            {
                _Code = value;
                OnPropertyChanged(nameof(Code));
            }
        }
        private string _Code;
        public string Description
        {
            get => _Description;
            set
            {
                _Description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
        private string _Description;
        public int? Stock
        {
            get => _Stock;
            set
            {
                _Stock = value;
                OnPropertyChanged(nameof(Stock));
            }
        }
        private int? _Stock;
        public int? Price
        {
            get => _Price;
            set
            {
                _Price = value;
                OnPropertyChanged(nameof(Price));
            }
        }

        private int? _Price;

        public virtual ICollection<SaleDetail> SaleDetails { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
