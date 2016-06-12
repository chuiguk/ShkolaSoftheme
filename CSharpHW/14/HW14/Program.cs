using System;
using System.Text.RegularExpressions;

namespace HW14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 6 numbers: ");
            string numbers = Console.ReadLine();
            Regex validation = new Regex("^[1-9]{6}$");
            if (numbers != null && validation.IsMatch(numbers))
            {
                var lottery = new Lottery();
                lottery.Guess(numbers);
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
            Console.ReadKey();
        }
    }
}
