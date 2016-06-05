using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW9.Abstract;

namespace HW9
{
    class User : IUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime LastVisit { get; set; }
        public string GetFullInfo()
        {
            return string.Format("User Name - {0}, user e-mail - {1}, password - {2}", Name, Email, Password);
        }
    }
}
