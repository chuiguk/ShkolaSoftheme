using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    [Flags]
    enum FileAccessEnum
    {
        Read = 2, Write = 4
    }
    class FileHandle
    {
        public int FileSize { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public FileAccessEnum FileAccess { get; set; }
        public FileHandle(string filePath, FileAccessEnum fileAccess)
        {
            this.FilePath = filePath;
            this.FileAccess = fileAccess;
            FileSize = new Random().Next(100000);
            string[] arr = filePath.Split('\\');
            FileName = arr[arr.Length - 1];
        }
        public static FileHandle OpenForRead(string filePath)
        {
            return new FileHandle(filePath, FileAccessEnum.Read);
        }
        public static FileHandle OpenForWrite(string filePath)
        {
            return new FileHandle(filePath, FileAccessEnum.Write);
        }
        public static FileHandle OpenFile(string filePath)
        {
            return new FileHandle(filePath, FileAccessEnum.Read | FileAccessEnum.Write);
        }
    }
}
