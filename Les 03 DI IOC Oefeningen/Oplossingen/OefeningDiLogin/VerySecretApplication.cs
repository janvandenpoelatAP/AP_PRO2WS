using Interfaces;
using System;

namespace OefeningDiLogin
{
    public class VerySecretApplication
    {
        private readonly ILogin _login;

        public VerySecretApplication(ILogin login)
        {
            _login = login;
        }

        public void Start()
        {
            Console.WriteLine("Username:");
            var username = Console.ReadLine();
            Console.WriteLine("Password:");
            var password = Console.ReadLine();
            var loggedIn = _login.Login(username, password);
            if (!loggedIn)
            {
                Console.WriteLine("Invalid username/password");
            }
            Console.WriteLine("Secret program started");
        }
    }
}
