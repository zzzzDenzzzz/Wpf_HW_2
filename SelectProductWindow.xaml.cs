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
        }

        List<INode> _nodes;
    }
}
