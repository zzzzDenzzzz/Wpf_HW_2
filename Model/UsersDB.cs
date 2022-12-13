using System.Collections.Generic;

namespace Wpf_HW_2.Model
{
    internal class UsersDB
    {
        /// <summary>
        /// база данных пользователей
        /// </summary>
        public List<User> Users { get; set; } = new List<User>()
        {
            new User("Name1","Login1","Password1"),
            new User("Name2","Login2","Password2"),
            new User("Name3","Login3","Password3"),
            new User("Name4","Login4","Password4"),
            new User("Name5","Login5","Password5"),
        };
    }
}
