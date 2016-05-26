using System;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            while(true)
            {
                calc.Calculate();
                Console.ReadKey();
            }
        }
    }
}
