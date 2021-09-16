using Microsoft.EntityFrameworkCore;
using PcStore.Commands;
using PcStore.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PcStore.ViewModels
{
    class ProductViewModel : ViewModelBase
    {

        public ProductViewModel()
        {
            _Product = new Product();
            LoadData();
            _saveCommand = new RelayCommand(x => Save(), () => true);
            _searchCommand = new RelayCommand(x => Search(x), () => true);
            _updateCommand = new RelayCommand(x => Update(), () => true);
            _deleteCommand = new RelayCommand(x => Delete(x), () => true);
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
        private ObservableCollection<Product> _products;
        public ObservableCollection<Product> Products
        {
            get => _products;
            set
            {
                _products = value;
                OnPropertyChanged(nameof(Products));
            }
        }

        private readonly ICommand _saveCommand;
        public ICommand SaveCommand { get => _saveCommand; }


        private readonly ICommand _searchCommand;
        public ICommand SearchCommand { get => _searchCommand; }

        private readonly ICommand _updateCommand;
        public ICommand UpdateCommand { get => _updateCommand; }
        private readonly ICommand _deleteCommand;
        public ICommand DeleteCommand { get => _deleteCommand; }

        #endregion Propeties
        private void LoadData()
        {
            using var db = new Pc_StoreContext();
            Products = new ObservableCollection<Product>(db.Products.ToList());
        }

        #region Commands

        public void Save()
        {
            try
            {
                using var db = new Pc_StoreContext();
                db.Add(Product);
                db.SaveChanges();
                LoadData();
                Product = new Product();
            }
            catch (System.Exception e)
            {
                MessageBox.Show("Error: {0}", e.InnerException.Message);
            }

        }

        public void Search(object parameter)
        {
            try
            {
                using var db = new Pc_StoreContext();
                var result = db.Products.Find(int.Parse(parameter.ToString()));
                Product.ProductId = result.ProductId;
                Product.Code = result.Code;
                Product.Description = result.Description;
                Product.Stock = result.Stock;
                Product.Price = result.Price;

            }
            catch (System.Exception e)
            {
                MessageBox.Show("Error: {0}", e.InnerException.Message);
            }
        }

        public void Update()
        {
            try
            {
                using var db = new Pc_StoreContext();
                db.Entry(Product).State = EntityState.Modified;
                db.SaveChanges();
                LoadData();
                //Product = new Product();
            }
            catch (System.Exception e)
            {
                MessageBox.Show("Error: {0}", e.Message);
            }
        }

        public void Delete(object parameter)
        {
            try
            {
                var result = MessageBox.Show("Do you want delete?", "", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    using var db = new Pc_StoreContext();
                    var oProduct = db.Products.Find(int.Parse(parameter.ToString()));
                    db.Remove(oProduct);
                    db.SaveChanges();
                    LoadData();
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show("Error: {0}", e.Message);
            }
        }
        #endregion Commands
    }
}
