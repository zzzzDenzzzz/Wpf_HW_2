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

        public string LoginUser { get; set; }
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
            var context = new UsersDB();
            var access = context.Users.Where(x => x.Login == LoginUser).FirstOrDefault();
            if (access != null && access.IsAuhtorization(password))
            {
                Global.User = access;
                UserName = access.Name;
                return true;
            }
            FailCount--;
            return false;
        }

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
