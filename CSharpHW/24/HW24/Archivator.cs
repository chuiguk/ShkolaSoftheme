using System;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace HW24
{
    class Archivator
    {
        public void Archive(DirectoryInfo dir)
        {
            var directories = dir.GetDirectories();

            if (directories.Length > 0)
            {
                foreach (var directory in directories)
                {
                    Archive(directory);
                }
            }

            var files = dir.GetFiles();

            foreach (var file in files)
            {
                var th = new Thread(() => Zip(file));
                th.Start();
                Console.WriteLine("Thread {0} started. Zipping file: {1}", th.ManagedThreadId, file.Name);
            }
        }

        void Zip(FileInfo fileInfo)
        {
            var fileName = Path.ChangeExtension(fileInfo.FullName, ".zip");

            try
            {
                using (ZipArchive zip = ZipFile.Open(fileName, ZipArchiveMode.Create))
                {
                    zip.CreateEntryFromFile(fileInfo.FullName, fileInfo.Name);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Can't create zip archive! " + e.Message);
            }
            
            Console.WriteLine("Thread {0} finished.", Thread.CurrentThread.ManagedThreadId);
        }      
    }
}
