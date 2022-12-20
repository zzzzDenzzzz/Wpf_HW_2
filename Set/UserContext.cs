using System.ComponentModel;
using System.Runtime.CompilerServices;
using Wpf_HW_2.Model;

namespace Wpf_HW_2
{
    internal class UserContext
    {
        static UserContext _currentUserContext;

        public static UserContext CurrentUserContext
        {
            get => _currentUserContext;
        }

        User _user;

        public User User
        {
            get => _user;
        }

        UserContext(User user)
        {
            _user = user;
            _currentUserContext = this;
            OnPropertyChanged("CurrentUserContext");
        }

        public void ClearUser()
        {
            _currentUserContext = null;
        }

        public static void CreateUserContext(User user)
        {
            if (CurrentUserContext != null)
            {
                new UserContext(user);
            }
        }
        /// <summary>
        /// при изменениии значений свойств объекта генерируется это событие 
        /// </summary>
        public static event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// когда объект класса изменяет значение свойства, то он через событие PropertyChanged извещает систему об изменении свойства.
        /// А система обновляет все привязанные объекты
        /// </summary>
        protected static void OnPropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(CurrentUserContext, new PropertyChangedEventArgs(property));
        }
    }
}
