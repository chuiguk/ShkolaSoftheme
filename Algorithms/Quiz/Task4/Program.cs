using System;
using System.Collections.Generic;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            GetNode(7);
            Console.ReadKey();
        }
        static void GetNode(int k)
        {     
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i < 10; i++)
            {
                list.AddLast(i);
            }

            if(k >= list.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            LinkedListNode<int> node1 = list.First;
            LinkedListNode<int> node2 = list.First;

            for (int j = 0; j < k; ++j)
            {
                node2 = node2.Next;
            }

            while (node2 != null)
            {
                node1 = node1.Next;
                node2 = node2.Next;
            }

            Console.WriteLine(node1.Value);
        }
    }
}
