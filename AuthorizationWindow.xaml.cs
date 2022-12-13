using System.Windows;
using Wpf_HW_2.ViewModel;

namespace Wpf_HW_2
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        /// <summary>
        /// объект ViewModel, связывающий данные(Model) и интерфейс(View)
        /// </summary>
        AuthorizationVM vm;

        public AuthorizationWindow()
        {
            InitializeComponent();
            vm = new AuthorizationVM();
            DataContext = vm;
        }

        /// <summary>
        /// обработка нвжатия кновки Войти окна авторизации
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // при успешной авторизации
            if (vm.Authorization(passwordBox.Password))
            {
                // вызов окна пользователя
                new UserWindow().Show();
                // закрытия окна регистрации
                Owner.Close();
                // закрытие стартового окна
                Close();
            }
        }
    }
}
