using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer pr1 = new Printer();
            pr1.Print("Hello world!");
            ColourPrinter pr2 = new ColourPrinter();
            pr2.Print("Hello World!", ConsoleColor.Red);
            PhotoPrinter pr3 = new PhotoPrinter();
            pr3.Print("Picture");
            Console.ReadKey();
        }
    }
}
