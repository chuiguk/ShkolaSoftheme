using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class UserDataBase : IUser, IValidator
    {
        List<IUser> _users = new List<IUser>();
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime LastVisit { get; set; }
        public string GetFullInfo()
        {
            string s = null;
            foreach (var user in _users)
            {
                s += string.Format("User Name - {}, user e-mail - {}, password {}.\n", user.Name, user.Email, user.Password);
            }
            return s;
        }
        public void Authorisation()
        {
            string name = null;
            string password = null;
            string email = null;
            while(name != "exit" && password != "exit" && email != "exit")
            {
                Console.Write("Enter your user name: ");
                name = Console.ReadLine();
                Console.Write("Enter your e-mail: ");
                email = Console.ReadLine();
                Console.Write("Enter your password: ");
                password = Console.ReadLine();
                if(name != null | email != null && password != null)
                {
                    ValidateUser(new UserDataBase() { Name = name, Email = email, Password = password });
                }
                else
                {
                    Console.WriteLine("Wrong Input!");
                }
            }
        }
        public void ValidateUser(IUser user)
        {
            bool isValidated = false;
            foreach (var item in _users)
            {
                if(item.Name == user.Name | item.Email == user.Email)
                {
                    if (item.Password == user.Password)
                    {
                        Console.WriteLine("Hello, {0}! Your last visit: {1}", item.Name, item.LastVisit);
                        item.LastVisit = DateTime.Now;
                        isValidated = true;
                    }
                    else
                    {
                        Console.WriteLine("Wrong password!");
                        isValidated = true;
                    }
                }
            }
            if(!isValidated)
            {
                if(user.Name == "")
                {
                    string[] s = user.Email.Split('@');
                    user.Name = s[0];
                }
                _users.Add(new UserDataBase() {Name= user.Name, Email = user.Email, Password = user.Password, LastVisit = DateTime.Now });
                Console.WriteLine("Greetings, {0}!", user.Name);
            }
            
        }
    }
}
