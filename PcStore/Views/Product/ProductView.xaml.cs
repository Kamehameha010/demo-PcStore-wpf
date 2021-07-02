
using PcStore.Models;
using PcStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PcStore.Views.Product
{
    /// <summary>
    /// Lógica de interacción para ProductView.xaml
    /// </summary>
    public partial class ProductView : Page
    {
        private int? id;
        public ProductView()
        {
            InitializeComponent();
        }
        public ProductView(int? id)
        {
            this.id = id;
            InitializeComponent();
        }


        
        private void Save(ProductViewModel model)
        {
            using var context = new Pc_StoreContext();
            context.Add(model);
            context.SaveChanges();
        }
        private async Task UpdateAsync(int id)
        {
            using var context = new Pc_StoreContext();
            var product = await context.Products.FindAsync(id);
            context.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
