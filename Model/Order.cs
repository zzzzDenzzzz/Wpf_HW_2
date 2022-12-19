using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Wpf_HW_2.Model
{
    /// <summary>
    /// заказ
    /// </summary>
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Client { get; set; }
        public ObservableCollection<OrderProduct> Products { get; set; }

        public decimal Price => Products.Sum(p => p.Product.Price * p.Quantity);

        //public decimal QuantityProducts => Products.Count;
    }
}
