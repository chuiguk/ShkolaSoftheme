using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW9.Realisation;

namespace HW9
{
    class Program
    {
        static void Main(string[] args)
        {
            var usersManager = new UsersManager();
            usersManager.StartManaging();
            Console.ReadKey();
        }
    }
}
