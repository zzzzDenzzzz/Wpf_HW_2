using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_HW_2.Model
{
    /// <summary>
    /// заказ
    /// </summary>
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Client { get; set; }
        public List<OrderProduct> Products { get; set; }

        public decimal Price
        {
            get => Products.Sum(p => p.Product.Price * p.Quantity);
        }
    }
}
