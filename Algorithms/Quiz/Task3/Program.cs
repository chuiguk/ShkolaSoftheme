using System;


namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "aabccccaaaa";
            var str = new StringCutter(s);
            string newStr = str.Cut();
            Console.WriteLine(newStr);
            Console.ReadKey();
        }
    }
}
