using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class PhotoPrinter : Printer
    {
        public override void Print(string img)
        {
            Console.WriteLine(img);
        }
    }
}
