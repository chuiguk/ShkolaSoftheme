using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    interface IUser
    {
         string Name { get; set; }
         string Email { get; set; }
         string Password { get; set; }
         DateTime LastVisit { get; set; }
         string GetFullInfo();
    }
}
