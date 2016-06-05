using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            var readWrite = FileHandle.OpenFile(@"C:\New_Folder\New_File.txt");
            Console.WriteLine("File {0} is open with {1} rights.", readWrite.FileName, readWrite.FileAccess);
            Console.ReadKey();
        }
    }
}
