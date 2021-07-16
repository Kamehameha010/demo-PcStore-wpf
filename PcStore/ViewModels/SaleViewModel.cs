using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcStore.Models;

namespace PcStore.ViewModels
{
    public class SaleViewModel : INotifyPropertyChanged
    {
        public Sale Sale
        {
            get => _Sale;
            set
            {
                _Sale = value;
                OnPropertyChanged(nameof(Sale));
            }
        }
        private Sale _Sale;

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
