using System.Windows;
using Wpf_HW_2.ViewModel;

namespace Wpf_HW_2
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        AuthorizationVM vm;

        public AuthorizationWindow()
        {
            InitializeComponent();
            vm = new AuthorizationVM();
            DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (vm.Authorization(passwordBox.Password))
            {
                new UserWindow().Show();
                Owner.Close();
                Close();
            }
        }
    }
}
