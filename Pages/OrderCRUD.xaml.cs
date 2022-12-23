using System.Windows.Controls;
using Wpf_HW_2.Model;
using Wpf_HW_2.ViewModel;

namespace Wpf_HW_2.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrderCRUD.xaml
    /// </summary>
    public partial class OrderCRUD : UserControl
    {
        OrderCRUD_VM _vm;

        public OrderCRUD(Order order = null)
        {
            InitializeComponent();
            _vm = new OrderCRUD_VM(order);
            DataContext = _vm;
        }

        private void DeleteProduct_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _vm.DeleteProduct();
        }

        private void DG_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            _vm.OnPropertyChanged(nameof(_vm.Price));
        }
    }
}
