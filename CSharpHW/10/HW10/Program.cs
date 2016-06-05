using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseClass = new ResourceHolderBase();
            baseClass.Dispose();
            var derivedClass = new ResourceHolderDerived();
            derivedClass.Dispose();
            derivedClass.Dispose();
            derivedClass.Dispose();
            Console.ReadKey();
        }
    }
}
