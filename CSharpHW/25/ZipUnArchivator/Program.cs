using System;
using System.IO;

namespace ZipUnArchivator
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
                    var arc = new UnArchivator();
                    arc.UnArchive(dir);
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
