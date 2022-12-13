using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_HW_2.Model;

namespace Wpf_HW_2
{
    internal class Global
    {
        static User _user;

        public static User User
        {
            get { return _user; }
            set { if(value != null) _user = value; }
        }
    }
}
