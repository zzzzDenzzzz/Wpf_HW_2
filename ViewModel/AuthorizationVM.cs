using System.Linq;
using System.Threading.Tasks;
using Wpf_HW_2.Model;

namespace Wpf_HW_2.ViewModel
{
    internal class AuthorizationVM : NotifyClass
    {
        // количество попыток
        const int FAIL_COUNT = 3;
        // количество секунд блокировки окна авторизации
        const int PAUSE = 10;

        public AuthorizationVM()
        {
            Message = $"У Вас {FAIL_COUNT} попыток!";
            FailCount = FAIL_COUNT;
            IsEnabledAuth = true;
        }

        /// <summary>
        /// логин, получаемый из TextBox страницы авторизации
        /// </summary>
        public string LoginUser { get; set; }

        /// <summary>
        /// имя пользователя, которое будет выводится при успешной регистрации
        /// </summary>
        string _userName;
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// сообщение, которое выводится при авторизации
        /// </summary>
        string _message;
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// оставшееся количество попыток авторизации
        /// </summary>
        int _failCount;
        public int FailCount
        {
            get { return _failCount; }
            set
            {
                if (value > 0)
                {
                    _failCount = value;
                    Message = $"Количество неудачных попыток {_failCount}";
                }
                else
                {
                    var t = StartPause();
                    _failCount = FAIL_COUNT;
                }
            }
        }

        /// <summary>
        /// состояние кнопки Войти окна авторизации
        /// </summary>
        bool _isEnabledAuth;
        public bool IsEnabledAuth
        {
            get { return _isEnabledAuth; }
            set
            {
                _isEnabledAuth = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// проверка логина и пароля, введенных в окне авторизации
        /// </summary>
        /// <returns>если логин и пароль совпадают возвращает true иначе false</returns>
        public bool Authorization(string password)
        {
            if (LoginUser == null)
            {
                return false;
            }
            if (password == null)
            {
                return false;
            }
            var context = UsersDB.Context;
            // проверяет логин, введеный в окне авторизации на соответсвие логину из UsersDB
            var access = context.Users.Where(x => x.Login == LoginUser).FirstOrDefault();
            // если логин и пароль совпадают
            if (access != null && access.IsAuhtorization(password))
            {
                UserContext.CreateUserContext(access);
                // присваиваем текущему пользователю имя из UsersDB
                UserName = access.Name;
                return true;
            }
            // если логин или пароль не совпадают уменьшаем количество попыток
            FailCount--;
            return false;
        }

        /// <summary>
        /// отключает кнопку Войти окна авторизации на 10 с после 3 неудачных попыток авторизации
        /// </summary>
        async Task StartPause()
        {
            IsEnabledAuth = false;
            for (int i = PAUSE; i > 0; i--)
            {
                Message = $"Авторизация заблокирована на {i} секунд";
                await Task.Delay(1000);
            }
            IsEnabledAuth = true;
            Message = "Повторите попытку!";
        }
    }
}
