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
    }
}
