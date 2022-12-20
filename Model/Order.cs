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
        /// <summary>
        /// id заказа
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// дата заказа
        /// </summary>
        public DateTime Date { get; set; }
        // клиент, сделавший заказ
        public string Client { get; set; }
        /// <summary>
        /// список товаров
        /// </summary>
        public ObservableCollection<OrderProduct> Products { get; set; }
        /// <summary>
        /// общая стоимость товаров в заказе
        /// </summary>
        public decimal Price => Products.Sum(p => p.Product.Price * p.Quantity);
    }
}
