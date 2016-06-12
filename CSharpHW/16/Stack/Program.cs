using System;


namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Console.WriteLine(stack.Pop());
            stack.Push(40);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.ReadKey();
        }
    }
}
