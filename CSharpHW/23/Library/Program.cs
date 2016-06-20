using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using System.IO.Compression;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using ProtoBuf;
using Library.Services;
using Library.Models;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new LibraryManager();

            

            library.Authorize();

            Console.ReadKey();
        }
    }
}
