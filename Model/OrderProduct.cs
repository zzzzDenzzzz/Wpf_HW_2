namespace Wpf_HW_2.Model
{
    /// <summary>
    /// хранит количество товаров из заказа
    /// </summary>
    public class OrderProduct : NotifyClass
    {
        /// <summary>
        /// товар
        /// </summary>
        public Product Product { get; set; }
        /// <summary>
        /// количество товаров
        /// </summary>
        int _quantity;
        public int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Price));
            } 
        }
        /// <summary>
        /// общая стоимость товаров
        /// </summary>
        public decimal Price => Product.Price * Quantity;
    }
}
