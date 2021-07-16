using Microsoft.EntityFrameworkCore;
using PcStore.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PcStore.ViewModels
{
    class ProductViewModel : INotifyPropertyChanged
    {

        public ProductViewModel()
        {
            LoadData();

        }
        #region Propeties
        private Product _Product;
        public Product Product
        {
            get => _Product;
            set
            {
                _Product = value;
                OnPropertyChanged(nameof(Product));
            }
        }

        //private ObservableCollection<Product> observable;
        private List<Product> _Products;
        public List<Product> Products
        {
            get => _Products;
            set
            {
                _Products = value;
                OnPropertyChanged(nameof(Products));
            }
        }

        #endregion Propeties


        #region LoadData
        private void LoadData()
        {
            using var db = new Pc_StoreContext();
            Products = db.Products.ToList();
        }

        #endregion LoadData

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
