using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW8;
namespace ExtensionMethods
{
    class Program
    {

        static void Main(string[] args)
        {
            Printer pr = new Printer();
            pr.PrintMore(new string[] { "Hello", "World" });
            ColourPrinter pr2 = new ColourPrinter();
            pr2.PrintMore(new string[] { "Hello", "World" }, new ConsoleColor[] { ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.Blue });
            PhotoPrinter pr3 = new PhotoPrinter();
            pr3.PrintMore(new string[] { "Pic1", "Pic2" });
            Console.ReadKey();

        }
    }
}
