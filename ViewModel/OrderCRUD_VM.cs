using System;
using System.Collections.ObjectModel;
using Wpf_HW_2.Model;

namespace Wpf_HW_2.ViewModel
{
    internal class OrderCRUD_VM : NotifyClass
    {
        public OrderCRUD_VM(Order order = null)
        {
            _currentOrder = new Order();
            if (order != null)
            {
                _currentOrder.Products = new ObservableCollection<OrderProduct>(order.Products);
                _currentOrder.Client = order.Client;
                _currentOrder.Date = order.Date;
                _currentOrder.Id = order.Id;
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
            set
            {
                _currentOrder.Date = value;
                OnPropertyChanged();
            }
        }

        public decimal Price => _currentOrder.Price;

        public ObservableCollection<OrderProduct> Products
        {
            get => _currentOrder.Products;
            set
            {
                _currentOrder.Products = value;
                OnPropertyChanged(nameof(Price));
            }
        }

        OrderProduct _selectProduct;
        public OrderProduct SelectProduct
        {
            get => _selectProduct;
            set
            {
                _selectProduct = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// добавляет новый товар в заказ
        /// </summary>
        public void AddProduct()
        {

        }
        /// <summary>
        /// удаляет товар из заказа
        /// </summary>
        public void DeleteProduct()
        {
            Products.Remove(SelectProduct);
            OnPropertyChanged(nameof(Price));
        }
    }
}
