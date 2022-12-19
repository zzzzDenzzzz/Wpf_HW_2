using System;
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
        public List<Order> SelectedOrders { get; set; }

        string _searchText;
        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;

                OnPropertyChanged();
            }
        }

        public void UpdateListOrders()
        {
            Orders = UsersDB.Context.Orders
                .Where(x => _searchText == string.Empty || _searchText == null
                    || (int.TryParse(_searchText, out int id) && x.Id == id)
                    || x.Client.ToLower().Contains(_searchText.ToLower())
                    || (DateTime.TryParse(_searchText, out DateTime date) && date == x.Date)
                    || (x.Products.FirstOrDefault(y => y.Product.Name.ToLower().Contains(_searchText.ToLower())) != null))
                .ToList();
            OnPropertyChanged("Orders");
        }

        public void DeleteOrders()
        {
            foreach (var item in SelectedOrders)
            {
                UsersDB.Context.Orders.Remove(item);
            }

            Orders = UsersDB.Context.Orders.ToList();

            SelectedOrders.Clear();
            OnPropertyChanged(nameof(Orders));
        }
    }
}
