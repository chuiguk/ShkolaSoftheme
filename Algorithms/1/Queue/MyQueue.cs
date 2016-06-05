using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class MyQueue
    {
        Stack firstStack = new Stack();
        Stack secondStack = new Stack();
        public void Enqueue(object item)
        {
            int count = secondStack.Count;
            for (int i = 0; i < count; i++)
            {
                firstStack.Push(secondStack.Pop());
            }
            firstStack.Push(item);
        }
        public object Dequeue()
        {          
            int count = firstStack.Count;
            for (int i = 0; i < count; i++)
            {
                secondStack.Push(firstStack.Pop());
            }
            return secondStack.Pop();
        }
    }
}
