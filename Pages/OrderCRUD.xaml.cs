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
    }
}
