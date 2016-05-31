using System;


namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a;
            b = 20;
            var user1 = new User("Ivan", "Ivanov");
            var user2 = user1;
            user2.LastName = "Pupkin";
            Console.WriteLine("Value Types: a = 10; b = a; b = 20; Output: a = {0}, b = {1}", a, b);
            Console.WriteLine("Reference Types: user1 Name = Ivan, LastName = Ivanov; user2 = user1; user2.LastName = Pupkin");
            Console.WriteLine("Output: user1.Name = {0}, user1.LastName = {1}; user2.Name = {2}, user2.LastName = {3}", user1.Name, user1.LastName, user2.Name, user2.LastName);
            Console.ReadKey();
        }
    }
}
