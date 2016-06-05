using System;


namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[100];
            var rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1000);
            }
            Sort(ref arr);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
        static void Sort(ref int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)           
            {                                                   
                for (int j = 0; j < arr.Length - i - 1; j++)   
                {                                           
                    if (arr[j] > arr[j + 1])
                    {                                      
                        var temp = arr[j];            
                        arr[j] = arr[j + 1];       
                        arr[j + 1] = temp; 
                    }                                       
                }                                             
            }
        }
    }
}
