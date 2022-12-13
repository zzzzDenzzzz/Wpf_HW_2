using System.Windows;

namespace Wpf_HW_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// при загрузке окна устанавливает его размер
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Width = 800;
            Height = 650;
        }

        /// <summary>
        /// при нажатии на кнопку Войти вызывает окно авторизации
        /// </summary>
        private void AuthorizationClick(object sender, RoutedEventArgs e)
        {
            Window authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Owner = this;
            authorizationWindow.ShowDialog();
        }
    }
}
