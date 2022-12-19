namespace Wpf_HW_2.Model
{
    /// <summary>
    /// хранит количество товаров из заказа
    /// </summary>
    public class OrderProduct
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }
    }
}
