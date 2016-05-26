using System;


namespace Calculator
{
    class Calculator
    {
        public void Calculate()
        {      
            try
            {
                Console.Write("Input first number: ");
                double numberOne = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input second number: ");
                double numberTwo = Convert.ToDouble(Console.ReadLine());
                Console.Write("What to do? (-+*/): ");
                string action = Console.ReadLine();
                switch(action)
                {
                    case "+":
                        Sum(numberOne, numberTwo);
                        break;
                    case "-":
                        Sub(numberOne, numberTwo);
                        break;
                    case "*":
                        Mul(numberOne, numberTwo);
                        break;
                    case "/":
                        Div(numberOne, numberTwo);
                        break;
                    default:
                        Console.WriteLine("Wrong input!");
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        void Sum(double number1, double number2)
        {
            Console.WriteLine("{0} + {1} = {2}", number1, String.Format("{0:0.00}", number1 + number2));
        }
        void Sub(double number1, double number2)
        {
            Console.WriteLine("{0} - {1} = {2}", number1, number2, String.Format("{0:0.00}", number1 - number2));
        }
        void Mul(double number1, double number2)
        {
            Console.WriteLine("{0} * {1} = {2}", number1, number2, String.Format("{0:0.00}", number1 * number2));
        }
        void Div(double number1, double number2)
        {
            Console.WriteLine("{0} / {1} = {2}", number1, number2, String.Format("{0:0.00}", number1 / number2));
        }
    }
}
