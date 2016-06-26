using System;
using System.IO;

namespace HW25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter directory path: ");
            var path = Console.ReadLine();

            if (!string.IsNullOrEmpty(path))
            {
                var dir = new DirectoryInfo(path);

                if (dir.Exists)
                {
                    var arc = new Archivator();
                    arc.Archive(dir);
                }
                else
                {
                    Console.WriteLine("Directory does not exists!");
                }
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }

            Console.ReadKey();
        }
    }
}
