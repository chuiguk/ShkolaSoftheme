using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var ageCount = new AgeCount();
            ageCount.Count();
            Console.ReadKey();
        }
    }
}
