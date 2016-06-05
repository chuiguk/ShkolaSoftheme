using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW8;
namespace ExtensionMethods
{
    static class Extension
    {
        public static void PrintMore(this Printer printer, string[] str)
        {
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }
        }
        public static void PrintMore(this ColourPrinter printer, string[] str, ConsoleColor[] colours)
        {
            Random rand = new Random();
            foreach (var item in str)
            {
                Console.ForegroundColor = colours[rand.Next(colours.Length)];
                Console.WriteLine(item);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void PrintMore(this PhotoPrinter printer, string[] pic)
        {
            foreach (var item in pic)
            {
                Console.WriteLine(item);
            }
        }
    }
}
