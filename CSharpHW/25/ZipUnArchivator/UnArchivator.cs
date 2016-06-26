using System;
using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Threading.Tasks;

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

            Parallel.ForEach(files, (file) =>
            {
                if (Path.GetExtension(file.Name) == ".zip")
                {
                    var task = new Task(() => UnZip(file));
                    task.Start();
                    Console.WriteLine("Thread {0} started. Unzipping file: {1}",Thread.CurrentThread.ManagedThreadId, file.Name);
                }
            });
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
