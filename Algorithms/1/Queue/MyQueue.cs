using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class MyQueue <T> : IQueue<T>
    {
        Stack<T> tail = new Stack<T>();
        Stack<T> head = new Stack<T>();
        public void Enqueue(T item)
        {
            tail.Push(item);
        }
        public T Dequeue()
        {
            if (head.Count == 0)
            {
                while (tail.Count > 0)
                    head.Push(tail.Pop());
            }
            return head.Pop();
        }
    }
}
