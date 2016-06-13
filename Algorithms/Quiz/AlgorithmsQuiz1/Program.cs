using System;

namespace AlgorithmsQuiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5] { 1, 3, 5, 6, 8 };
            int[] b = new int[5] { 2, 3, 5, 6, 9 };
            GetCommonNumbers(a, b);
            Console.ReadKey(); 

        }
        private static void GetCommonNumbers(int[] arr1, int[] arr2)
        {
            var arr = new int[arr1.Length + arr2.Length];
            int arr1Position = 0, arr2Position = 0, counter = 0;
            while (counter < arr.Length)
            {
                if (arr2Position == arr2.Length || ((arr1Position < arr1.Length) && (arr1[arr1Position] < arr2[arr2Position])))
                {
                    arr[counter] = arr1[arr1Position];
                    arr1Position++;
                }
                else
                {
                    arr[counter] = arr2[arr2Position];
                    arr2Position++;
                }
                counter++;
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if(arr[i] == arr[i+1])
                { Console.WriteLine(arr[i]); }
            }
        }
    }
}
