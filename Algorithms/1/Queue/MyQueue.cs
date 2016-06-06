using System;
using System.Collections.Generic;


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
            if (head.Count > 0)
            {
                return head.Pop();
            }
            else
            {
                throw new Exception("Queue is empty!");
            }
        }
    }
}
