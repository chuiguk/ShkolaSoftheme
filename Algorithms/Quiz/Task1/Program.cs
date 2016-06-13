using System;


namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers(1000);
            Console.ReadKey();
        }
        public static void PrintNumbers(int n)
        {
            for (int a = 0; a < n; a++)
            {
                int a3 = a * a * a;
                for (int b = a + 1; b < n; b++)
                {
                    int b3 = b * b * b;
                    for (int c = a + 1; c < n; c++)
                    {
                        int c3 = c * c * c;
                        for (int d = c + 1; d < n; d++)
                        {
                            int d3 = d * d * d;
                            if (a3 + b3 == c3 + d3)
                            {
                                Console.WriteLine("{0}^3 + {1}^3 = {2}^3 + {3}^3", a, b, c, d);
                            }
                        }
                    }
                }
            }
        }
        
    }
}
