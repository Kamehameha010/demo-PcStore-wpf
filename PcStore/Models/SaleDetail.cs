using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace PcStore.Models
{
    public partial class SaleDetail : INotifyPropertyChanged
    {
        public int SaleDetailId
        {
            get => _SaleDetailId;
            set
            {
                _SaleDetailId = value;
                OnPropertyChanged(nameof(SaleDetailId));
            }
        }
        private int _SaleDetailId;
        public int? SaleId
        {
            get => _SaleId;
            set
            {
                _SaleId = value;
                OnPropertyChanged(nameof(SaleId));
            }
        }
        private int? _SaleId;
        public int? ProductId
        {
            get => _ProductId;
            set
            {
                _ProductId = value;
                OnPropertyChanged(nameof(ProductId));
            }
        }
        private int? _ProductId;
        public int? Qty
        {
            get => _Qty;
            set
            {
                _Qty = value;
                OnPropertyChanged(nameof(Qty));
            }
        }
        private int? _Qty;

        

        public virtual Product Product { get; set; }
        public virtual Sale Sale { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
