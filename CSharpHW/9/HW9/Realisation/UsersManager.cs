using System;
using System.Collections.Generic;
using HW9.Abstract;

namespace HW9.Realisation
{
    class UsersManager
    {
        private List<IUser> _users = new List<IUser>();
        private IValidator _validator = new UserValidator();

        public void StartManaging()
        {
            string name = null;
            string password = null;
            string email = null;
            while (name != "exit" && password != "exit" && email != "exit")
            {
                Console.Write("Enter your user name: ");
                name = Console.ReadLine();
                Console.Write("Enter your e-mail: ");
                email = Console.ReadLine();
                Console.Write("Enter your password: ");
                password = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name) | !string.IsNullOrWhiteSpace(email) & !string.IsNullOrWhiteSpace(password))
                {
                    LoginUser(new User() { Name = name, Email = email, Password = password });
                }
                else
                {
                    Console.WriteLine("Wrong Input!");  
                }
            }
        }

        public void LoginUser(IUser user)
        {
            var loginUser = _validator.ValidateUser(user, _users);
            if (!loginUser)
            {
                Console.WriteLine("New user was creadted. {0}", user.GetFullInfo());
                user.LastVisit = DateTime.Now;
                _users.Add(user);
            }
        }
    }
}
