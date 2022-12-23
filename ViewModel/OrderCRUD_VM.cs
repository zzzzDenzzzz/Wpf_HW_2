using System;
using System.Collections.ObjectModel;
using System.Windows.Data;
using Wpf_HW_2.Model;

namespace Wpf_HW_2.ViewModel
{
    internal class OrderCRUD_VM : NotifyClass
    {
        public OrderCRUD_VM(Order order = null)
        {
            if (order == null)
            {
                _currentOrder = new Order();
            }
            else
            {
                _currentOrder = order;
            }
        }

        Order _currentOrder;
        public Order CurrentOrder
        {
            get => _currentOrder;
            private set
            {
                _currentOrder = value;
            }
        }

        public int Id
        {
            get => _currentOrder.Id;
            set
            {
                _currentOrder.Id = value;
                OnPropertyChanged();
            }
        }

        public string Client
        {
            get => _currentOrder.Client;
            set
            {
                _currentOrder.Client = value;
                OnPropertyChanged();
            }
        }

        public DateTime Date
        {
            get => _currentOrder.Date;
            set { }
        }

        public decimal Price => _currentOrder.Price;

        public ObservableCollection<OrderProduct> Products
        {
            get => _currentOrder.Products;
            set
            {
                _currentOrder.Products = value;
                OnPropertyChanged();
            }
        }

        OrderProduct _selectProduct;
        public OrderProduct SelectProduct
        {
            get => _selectProduct;
            set
            {
                _selectProduct = value;
                OnPropertyChanged(nameof(_selectProduct));
            }
        }

        /// <summary>
        /// добавляем новый товар в заказ
        /// </summary>
        public void AddProduct()
        {

        }

        public void DeleteProduct()
        {
            Products.Remove(SelectProduct);
        }
    }
}
