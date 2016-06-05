using System;

namespace HW9.Abstract
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
