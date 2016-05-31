using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var human1 = new Human(new DateTime(1990, 10, 10), "Ivan", "Ivanov");
            var human2 = new Human(new DateTime(1990, 10, 10), "Ivan", "Ivanov", 25);
            Console.WriteLine("Human 1 = {0} {1} {2} {3}", human1.Name, human1.LastName, human1.Age, human1.BirthDate);
            Console.WriteLine("Human 2 = {0} {1} {2} {3}", human2.Name, human2.LastName, human2.Age, human2.BirthDate);
            Console.WriteLine("Human 1 = Human 2 ?: {0}", human1.Equals(human2));
            Console.ReadKey();
        }
    }
}
