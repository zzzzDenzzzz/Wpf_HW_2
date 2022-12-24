using System.Collections.Generic;
using System.Windows;
using Wpf_HW_2.Model;

namespace Wpf_HW_2
{
    /// <summary>
    /// Логика взаимодействия для SelectProductWindow.xaml
    /// </summary>
    public partial class SelectProductWindow : Window
    {
        public SelectProductWindow()
        {
            InitializeComponent();
            _nodes = new List<INode>(UsersDB.Context.Folders);
            ProductsTree.ItemsSource = _nodes;
        }

        List<INode> _nodes;

        Product _selectProduct;
        public Product SelectProduct { get => _selectProduct; }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            ProductNode product = ProductsTree.SelectedItem as ProductNode;
            // является ли папка ProductNode
            if (product != null)
            {
                _selectProduct = product.Product;
            }

            Close();
        }
    }
}
