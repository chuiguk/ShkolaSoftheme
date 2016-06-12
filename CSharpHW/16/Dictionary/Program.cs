using System;


namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> dictionary = new MyDictionary<string, int>();
            dictionary.Add("One", 1);
            try
            {
                dictionary.Add("One", 1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            dictionary.Add("Two", 2);
            dictionary.Add("Three", 3);
            Console.WriteLine("Does dictionary contains Two?: {0}", dictionary.ContainsKey("Two"));
            Console.WriteLine("Value of Two: {0}", dictionary["Two"]);
            Console.ReadKey();
        }
    }
}
