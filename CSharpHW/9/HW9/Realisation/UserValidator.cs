using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW9.Abstract;

namespace HW9
{
    class UserValidator : IValidator
    {
        public bool ValidateUser(IUser user, IEnumerable<IUser> _users)
        {
            foreach (var item in _users)
            {
                if (item.Name == user.Name | item.Email == user.Email)
                {
                    if (item.Password == user.Password)
                    {
                        Console.WriteLine("Hello, {0}! Your last visit: {1}", item.Name, item.LastVisit);
                        item.LastVisit = DateTime.Now;
                    }
                    else
                    {
                        Console.WriteLine("Wrong password!");
                    }

                    return true;
                }
            }

            return false;
        }
    }
}
