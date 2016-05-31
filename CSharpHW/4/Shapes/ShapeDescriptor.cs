using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ShapeDescriptor
    {
        Point[] points;
        public string ShapeType { get; private set; }
        public ShapeDescriptor(Point point1, Point point2)
        {
            points = new Point[] { point1, point2 };
            ShapeType = "Square";
        }
        public ShapeDescriptor(Point point1, Point point2, Point point3)
        {
            points = new Point[] { point1, point2, point3 };
            ShapeType = "Triangle";
        }
        public ShapeDescriptor(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[] { point1, point2, point3, point4 };
            ShapeType = "Rectangle or rhomb";
        }
    }
}
