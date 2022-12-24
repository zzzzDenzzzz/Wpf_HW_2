using System;
using System.Globalization;
using System.Windows.Data;

namespace Wpf_HW_2.Converters
{
    public class QuantityConverter : IValueConverter
    {
        /// <summary>
        /// из источника на форму
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
        /// <summary>
        /// из формы  в источник
        /// </summary>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString() == "" || int.TryParse(value.ToString(), out int v))
            {
                return value;
            }
            else
            {
                return 1;
            }
        }
    }
}
