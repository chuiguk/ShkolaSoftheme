using System;

namespace HW16
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> queue = new MyQueue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            Console.WriteLine(queue.Dequeue());
            queue.Enqueue(40);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(queue.Dequeue());
            }
            Console.ReadKey();
        }
    }
}
