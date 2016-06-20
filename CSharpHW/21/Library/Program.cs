using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using System.IO.Compression;
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

            var swach = new Stopwatch();
            swach.Start();
            
            //XML

            var xmlSer = new XmlSerializer(typeof(List<Book>));

            using (var serializetion = new FileStream("BooksXMLSerialization.xml", FileMode.Create))
            {
                xmlSer.Serialize(serializetion, library.Books);
            }

            using (var deserialization = new FileStream("BooksXMLSerialization.xml", FileMode.Open))
            {
                library.Books = xmlSer.Deserialize(deserialization) as List<Book>;
            }

            swach.Stop();
            Console.WriteLine("XML serialization: " + swach.ElapsedMilliseconds);
            swach.Reset();

            //JSON

            var jsonSer = new DataContractJsonSerializer(typeof(List<Book>));

            swach.Start();

            using (var serialization = new FileStream("BooksJSONSerialization.json", FileMode.Create))
            {
                jsonSer.WriteObject(serialization, library.Books);
            }

            library.Books = null;

            using (var deserialization = new FileStream("BooksJSONSerialization.json", FileMode.Open))
            {
                library.Books = jsonSer.ReadObject(deserialization) as List<Book>;
            }

            swach.Stop();
            Console.WriteLine("JSON serialization: " + swach.ElapsedMilliseconds);
            swach.Reset();

            //BINARY

            var binarySer = new BinaryFormatter();

            swach.Start();

            using (var serialization = new FileStream("BooksBINARYSerialization", FileMode.Create))
            {
                binarySer.Serialize(serialization, library.Books);
            }

            library.Books = null;

            using (var deserialization = new FileStream("BooksBINARYSerialization", FileMode.Open))
            {
                library.Books = binarySer.Deserialize(deserialization) as List<Book>;
            }
            
            
            swach.Stop();
            Console.WriteLine("BINARY serialization: " + swach.ElapsedMilliseconds);
            swach.Reset();

            //PROTOBUF

            swach.Start();

            using (var serialization = new FileStream("BooksPROTOBUFSerialization.proto", FileMode.Create))
            {
                Serializer.Serialize(serialization, library.Books);
            }

            library.Books = null;

            using (var deserialization = new FileStream("BooksPROTOBUFSerialization.proto", FileMode.Open))
            {
                library.Books = Serializer.Deserialize<List<Book>>(deserialization);
            }

            swach.Stop();
            Console.WriteLine("PROTOBUF serialization: " + swach.ElapsedMilliseconds);

            // ZIP

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (var serialization = new FileStream("archive.zip", FileMode.Create))
            {
                using (var zip = new GZipStream(serialization, CompressionMode.Compress))
                {

                    binaryFormatter.Serialize(zip, library.Books);
                }
            }

            library.Books = null;

            using (var deserialization = new FileStream("archive.zip", FileMode.Open))
            {
                using (var zip = new GZipStream(deserialization, CompressionMode.Decompress))
                {
                   library.Books = binaryFormatter.Deserialize(zip) as List<Book>;
                }
            }


            library.Authorize();

            Console.ReadKey();
        }
    }
}
