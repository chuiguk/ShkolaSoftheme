using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("BMW", 2000, "Black");
            Console.WriteLine("Before tuning: {0}, {1}, {2}", car.Model, car.Year, car.Color);
            TuningAtelier.TuneCar(ref car);
            Console.WriteLine("After tuning: {0}, {1}, {2}", car.Model, car.Year, car.Color);
            Console.ReadKey();
        }
    }
}
