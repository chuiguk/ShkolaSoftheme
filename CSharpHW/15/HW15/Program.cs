using System;

namespace HW15
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Add(60);
            list.Add(70);
            Console.WriteLine(list.Contains(10));
            Console.WriteLine(list.Contains(40));
            Console.WriteLine(list.Contains(70));
            Console.WriteLine(list.Size);
            list.Delete(3);
            Console.WriteLine(list.Contains(10));
            Console.WriteLine(list.Contains(40));
            Console.WriteLine(list.Contains(70));
            Console.WriteLine(list.Size);
            list.Delete(3);
            list.Add(40);
            Console.WriteLine(list.Contains(10));
            Console.WriteLine(list.Contains(40));
            Console.WriteLine(list.Contains(50));
            Console.WriteLine(list.Contains(70));
            Console.WriteLine(list.Size);
            int[] arr = list.ToArray();
            foreach (var number in arr)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
