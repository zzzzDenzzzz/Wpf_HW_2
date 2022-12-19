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
    }
}
