using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Wpf_HW_2
{
    /// <summary>
    /// класс, реализующий интерфейс INotifyPropertyChanged
    /// </summary>
    public class NotifyClass : INotifyPropertyChanged
    {
        /// <summary>
        /// при изменениии значений свойств объекта генерируется это событие 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// когда объект класса изменяет значение свойства, то он через событие PropertyChanged извещает систему об изменении свойства.
        /// А система обновляет все привязанные объекты
        /// </summary>
        public virtual void OnPropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
