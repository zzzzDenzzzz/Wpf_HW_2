using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Wpf_HW_2.Model;
using Wpf_HW_2.ViewModel;

namespace Wpf_HW_2.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : UserControl
    {
        OrdersVM _vm;

        public OrdersPage()
        {
            InitializeComponent();
            _vm = new OrdersVM();
            DataContext = _vm;
        }

        private void SearchClick(object sender, RoutedEventArgs e)
        {
            _vm.UpdateListOrders();
        }

        private void DeleteOrders_Click(object sender, RoutedEventArgs e)
        {
            _vm.SelectedOrders = OrdersLV.SelectedItems.Cast<Order>().ToList();
            _vm.DeleteOrders();
        }

        private void ModifyOrder_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
