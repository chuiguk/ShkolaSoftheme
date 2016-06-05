using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyList();
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);
            Console.WriteLine("MyList contains 30? -{0}; 25? -{1}", myList.Contains(30), myList.Contains(25));
            Console.WriteLine("Get item from MyList with index [1] = {0}", myList.GetByIndex(1));
            try
            {
                Console.Write("Get item from MyList with index [10] = ");
                Console.WriteLine(myList.GetByIndex(10));
            }
            catch(IndexOutOfRangeException e)
            { Console.WriteLine(e.Message); }
            Console.ReadKey();
        }
    }
}
