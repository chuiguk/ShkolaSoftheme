using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape1 = new ShapeDescriptor(new Point(10, 20), new Point(20, 40));
            var shape2 = new ShapeDescriptor(new Point(10, 20), new Point(20, 40), new Point(40, 60));
            var shape3 = new ShapeDescriptor(new Point(10, 20), new Point(20, 40), new Point(40, 60), new Point(60,80));
            Console.WriteLine("Shape 1 - {0}, Shape 2 - {1}, Shape 3 - {2}", shape1.ShapeType, shape2.ShapeType, shape3.ShapeType);
            Console.ReadKey();
        }
    }
}
