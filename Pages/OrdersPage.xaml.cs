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
        /// <summary>
        /// обработчик нажатия кнопки "Поиск"
        /// </summary>
        private void SearchClick(object sender, RoutedEventArgs e)
        {
            _vm.UpdateListOrders();
        }
        /// <summary>
        /// обработчик нажатия кнопки "Удалить"
        /// </summary>
        private void DeleteOrders_Click(object sender, RoutedEventArgs e)
        {
            _vm.SelectedOrders = OrdersLV.SelectedItems.Cast<Order>().ToList();
            _vm.DeleteOrders();
        }
        /// <summary>
        /// обработчик нажатия кнопки "Изменить"
        /// </summary>
        private void ModifyOrder_Click(object sender, RoutedEventArgs e)
        {
            _vm.SelectedOrders = OrdersLV.SelectedItems.Cast<Order>().ToList();
            // выбираем первую запись из списка заказов
            Order order = _vm.SelectedOrders.FirstOrDefault();
            if (order != null)
            {
                // страница, отв. за создание заказа
                var page = new OrderCRUD(order);
                PageContext.CurrentPageContext.AddPage(page);
            }
        }
    }
}
