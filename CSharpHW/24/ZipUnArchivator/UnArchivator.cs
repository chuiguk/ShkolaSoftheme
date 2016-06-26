using System;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace ZipUnArchivator
{
    class UnArchivator
    {
        public void UnArchive(DirectoryInfo dir)
        {
            var directories = dir.GetDirectories();

            if (directories.Length > 0)
            {
                foreach (var directory in directories)
                {
                    UnArchive(directory);
                }
            }

            var files = dir.GetFiles();

            foreach (var file in files)
            {
                if (Path.GetExtension(file.Name) == ".zip")
                {
                    var th = new Thread(() => UnZip(file));
                    th.Start();
                    Console.WriteLine("Thread {0} started. Unzipping file: {1}", th.ManagedThreadId, file.Name);
                }
            }
        }
        void UnZip(FileInfo fileInfo)
        {
            try
            {
                using (ZipArchive zip = ZipFile.Open(fileInfo.FullName, ZipArchiveMode.Read))
                {
                    zip.ExtractToDirectory(fileInfo.Directory.FullName);
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
