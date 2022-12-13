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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Width = 800;
            Height = 650;
        }

        private void AuthorizationClick(object sender, RoutedEventArgs e)
        {
            Window authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Owner = this;
            authorizationWindow.ShowDialog();
        }
    }
}
