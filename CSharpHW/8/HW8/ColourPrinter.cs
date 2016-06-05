using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class ColourPrinter : Printer
    {
        public void Print(string str, ConsoleColor colour)
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.Gray; 
        }
    }
}
