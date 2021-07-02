using PcStore.Views.Product;
using PcStore.Views.Sale;
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

namespace PcStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItemProducts_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Content = new ProductView();
        }
        private void MenuItemSale_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Content = new SaleView();
        }

    }
}
