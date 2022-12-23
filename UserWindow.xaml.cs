using System.Windows;
using Wpf_HW_2.Pages;

namespace Wpf_HW_2
{
    /// <summary>
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();
            DataContext = PageContext.CurrentPageContext;
            PageContext.CurrentPageContext.AddPage(new MainPage());
        }

        private void MainPageClick(object sender, RoutedEventArgs e)
        {
            PageContext.CurrentPageContext.ChangeRootPage(new MainPage());
        }

        private void OrdersPageClick(object sender, RoutedEventArgs e)
        {
            PageContext.CurrentPageContext.ChangeRootPage(new OrdersPage());
        }
    }
}
