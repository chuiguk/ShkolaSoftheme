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
            var queue = new MyQueue<int>();
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
            }
            Console.WriteLine(queue.Dequeue());
            queue.Enqueue(155);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(queue.Dequeue());
            }
            Console.ReadKey();
        }
    }
}
