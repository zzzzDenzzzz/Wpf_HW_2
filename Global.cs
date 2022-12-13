using Wpf_HW_2.Model;

namespace Wpf_HW_2
{
    internal class Global
    {
        static User _user;

        public static User User
        {
            get
            {
                return _user;
            }
            set
            {
                if (value != null)
                {
                    _user = value;
                }
            }
        }
    }
}
