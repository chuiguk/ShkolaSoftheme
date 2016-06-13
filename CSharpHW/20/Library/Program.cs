using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Services;
using Library.Models;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new LibraryManager();
            library.Authorize();
            //Console.WriteLine("Enter Name: ");
            //var name = Console.ReadLine();

            //Console.WriteLine("Enter Password: ");
            //var password = Console.ReadLine();

            //var user = new User(name, password);
            //if (library.TryAuthorizeUser(user))
            //{
            //    Console.WriteLine("You authorized successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("You didn't authorize.");
            //}

            //Console.WriteLine("Enter Y for exit");
            Console.ReadKey();
        }
    }
}
