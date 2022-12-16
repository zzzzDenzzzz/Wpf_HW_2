using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Wpf_HW_2.Model;

namespace Wpf_HW_2.ViewModel
{
    internal class OrdersVM : NotifyClass
    {
        public OrdersVM()
        {
            Orders = UsersDB.Context.Orders.ToList();
        }

        public List<Order> Orders { get; set; }

        string _searchText;
        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                Orders = UsersDB.Context.Orders.Where(x => (int.TryParse(_searchText, out int id) && x.Id == id) || _searchText == string.Empty).ToList();
                OnPropertyChanged("Orders");
                OnPropertyChanged();
            }
        }
    }
}
