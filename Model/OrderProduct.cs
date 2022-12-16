using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_HW_2.Model
{
    /// <summary>
    /// хранит количество товаров из заказа
    /// </summary>
    internal class OrderProduct
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }
    }
}
