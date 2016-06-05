using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new ArrayHandler();
            foreach (var item in arr._counter)
            {
                if(item.Value % 2 != 0)
                Console.WriteLine("Array contains number {0} {1} times.", item.Key, item.Value);
            }
            Console.ReadKey();
        }
    }
}
