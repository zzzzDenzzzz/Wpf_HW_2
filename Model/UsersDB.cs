using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_HW_2.Model
{
    internal class UsersDB
    {
        public List<User> Users { get; set; } = new List<User>()
        {
            new User("1","111","111"),
            new User("2","222","222"),
            new User("3","333","333"),
            new User("4","444","444"),
            new User("5","555","555"),
        };
    }
}
