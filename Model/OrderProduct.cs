namespace Wpf_HW_2.Model
{
    /// <summary>
    /// хранит количество товаров из заказа
    /// </summary>
    public class OrderProduct
    {
        /// <summary>
        /// товар
        /// </summary>
        public Product Product { get; set; }
        /// <summary>
        /// количество товаров
        /// </summary>
        public int Quantity { get; set; }
    }
}
