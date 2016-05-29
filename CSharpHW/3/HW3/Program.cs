using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.Write("Set figure size: ");
            try
            {
                size = Convert.ToInt32(Console.ReadLine());
                var paint = new FigurePaint(size);
                paint.PrintAll();
            }
            catch(FormatException e)
            { Console.WriteLine(e.Message); }           
            Console.ReadKey();
        }
    }
}
