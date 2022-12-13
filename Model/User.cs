namespace Wpf_HW_2.Model
{
    internal class User
    {
        /// <summary>
        /// имя пользователя
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// логин пользователя
        /// </summary>
        public string Login { get; private set; }
        /// <summary>
        /// пароль пользователя
        /// </summary>
        string Password { get; set; }

        public User(string name, string login, string password)
        {
            Name = name;
            Login = login;
            Password = password;
        }

        /// <summary>
        /// проверка пароля пользователя
        /// </summary>
        /// <returns>если пароль есть в UserDB возвращает true иначе false</returns>
        public bool IsAuhtorization(string password) => password == Password;
    }
}
