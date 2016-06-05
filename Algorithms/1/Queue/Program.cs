using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack1 = new Stack<int>();
            var stack2 = new Stack<int>();
            for (int i = 0; i < 100; i++)
            {
                stack1.Push(i);
            }
            for (int i = 0; i < 100; i++)
            {
                stack2.Push(stack1.Pop());
            }
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(stack2.Pop());
            }
            Console.ReadKey();
        }
    }
}
