using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace PcStore.Models
{
    public partial class Sale : INotifyPropertyChanged
    {
        public Sale()
        {
            SaleDetails = new HashSet<SaleDetail>();
        }

        public int SaleId
        {
            get => _SaleId;
            set
            {
                _SaleId = value;
                OnPropertyChanged(nameof(SaleId));
            }
        }
        private int _SaleId;
        public DateTime? Date
        {
            get => _Date;
            set
            {
                _Date = value;
                OnPropertyChanged(nameof(Date));
            }
        }
        private DateTime? _Date;
        public decimal? Total
        {
            get => _Total;
            set
            {
                _Total = value;
                OnPropertyChanged(nameof(Total));
            }
        }
        private decimal? _Total;
        public virtual ICollection<SaleDetail> SaleDetails { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
