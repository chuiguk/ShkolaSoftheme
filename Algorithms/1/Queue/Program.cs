using System;

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
            try
            {
                for (int i = 0; i < 15; i++)
                {
                    Console.WriteLine(queue.Dequeue());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
