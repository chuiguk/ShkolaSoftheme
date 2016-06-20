using System;
using System.Collections.Generic;
using System.Linq;
using Library.Models;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Linq;
using ProtoBuf;


namespace Library.Services
{
    [Serializable]
    [ProtoContract]
    public class LibraryManager
    {
        private List<User> _authorizedUsers = new List<User>
        {
            new User("User1", "Password"),
            new User("User2", "Password")
        };


        public List<Book> Books;
        static string _backupXML = "BookCollection.xml";
        User _currentUser;
        static XElement xml = XDocument.Load(_backupXML).Element("ArrayOfBook");
        List<XElement> xmlListOfBooks = xml.Elements("Book").ToList();

        public LibraryManager()
        {
            var binarySer = new BinaryFormatter();

            using (var deserialization = new FileStream("BookCollection", FileMode.Open))
            {
                Books = binarySer.Deserialize(deserialization) as List<Book>;
            }
        }
        public void AddUser(User user)
        {
            _authorizedUsers.Add(user);
        }
        public void Authorize()
        {
            Console.WriteLine("Hello! Please authorize yourself.");
            Console.WriteLine("Enter your name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            var password = Console.ReadLine();
            var user = new User(name, password);
            bool isAuthorized = TryAuthorizeUser(user);
            if (isAuthorized)
            {
                _currentUser = user;
            }
            StartWorking(isAuthorized);
        }
        public bool TryAuthorizeUser(User user)
        {
            return _authorizedUsers.Any(u => u.Name.Equals(user.Name) && u.Password.Equals(user.Password));
        }

        public void StartWorking(bool isAuthorized)
        {
            if(!isAuthorized)
            {
                Console.WriteLine("Authorization failed!");
                Console.WriteLine("Choose action:\nSummary information(1)\nCheck for a book(2)\nCheck most popular book in genre(3)");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1": { SummaryInformation(); break; }
                    case "2": { SearchForBook(); break; }
                    case "3": { ShowMostPopularBook(); break; }
                }
            }
            else
            {
                Console.WriteLine("Choose action:\nTake a book(1)\nReturn a book(2)\nAdd a book in the library(3)");
                Console.WriteLine("Summary information(4)\nCheck for a book(5)\nCheck most popular book in genre(6)");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1": { TakeABook(); break; }
                    case "2": { ReturnABook(); break; }
                    case "3": { AddABook(); break; }
                    case "4": { SummaryInformation(); break; }
                    case "5": { SearchForBook(); break; }
                    case "6": { ShowMostPopularBook(); break; }
                }
            }
        }

        void SummaryInformation()
        {
            var bookGenreGroups = xmlListOfBooks.GroupBy(book => book.Element("Genre").Value);
            Console.WriteLine("Grouped count by genre:");
            foreach (var bookGenreGroup in bookGenreGroups)
            {
                Console.WriteLine("Genre: {0}. Count - {1}", bookGenreGroup.Key, bookGenreGroup.Count());
            }

            var newestBook = xmlListOfBooks.Max(x => (x.Element("Year").Value));

            Console.WriteLine("Newest book - {0}", newestBook);

            var oldestBook = xmlListOfBooks.Min(x => (x.Element("Year").Value));
            Console.WriteLine("Oldest book - {0}", oldestBook);

            var mostPopularBook = xmlListOfBooks.Max(x => x.Element("Popularity").Value);
            Console.WriteLine("Most popular - {0}", mostPopularBook);
        }
        void SearchForBook()
        {
            Console.WriteLine("How do you want to search?\nBy name(1)\nBy author(2)\nBy name & author(3)\n");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1": { SearchByName(); break; }
                case "2": { SearchByAuthor(); break; }
                case "3": { SearchByNameAndAuthor(); break; }
            }
        }

        void SearchByName()
        {
            Console.WriteLine("Enter book name");
            var name = Console.ReadLine();

            if (!xmlListOfBooks.Any(x => x.Element("Name").Value == name))
            {
                Console.WriteLine("Book not found!");
                return;
            }
            var books = xmlListOfBooks.Where(x => x.Element("Name").Value.Equals(name));
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }          
        }

        void SearchByAuthor()
        {
            Console.WriteLine("Enter book author");
            var author = Console.ReadLine();

            if (!xmlListOfBooks.Any(x => x.Element("Name").Value == author))
            {
                Console.WriteLine("Book not found!");
                return;
            }
            var books = xmlListOfBooks.Where(x => x.Element("Name").Value.Equals(author));
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }  
        }

        void SearchByNameAndAuthor()
        {
            Console.WriteLine("Enter book name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter book author");
            var author = Console.ReadLine();

            if (!xmlListOfBooks.Any(x => x.Element("Name").Value == name && x.Element("Author").Value == author))
            {
                Console.WriteLine("Book not found!");
                return;
            }
            var books = xmlListOfBooks.Where(x => x.Element("Name").Value.Equals(name) && x.Element("Author").Value.Equals(author));
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }  
        }
        void ShowMostPopularBook()
        {
            Console.WriteLine("Enter book genre:");
            var genre = Console.ReadLine();

            var mostPopular = xmlListOfBooks.Where(x => x.Element("Genre").Value == genre).Max(x => x.Element("Popularity").Value);
            if (mostPopular == null)
            {
                Console.WriteLine("Genre not found!");
                return;
            }
            var mostPopularBookInGenre =
                xmlListOfBooks.FirstOrDefault(
                    x => x.Element("Genre").Value == genre && x.Element("Popularity").Value == mostPopular);
            Console.WriteLine("Most popular - {0}", mostPopularBookInGenre);
        }
        void TakeABook()
        {
            Console.WriteLine("Enter book name:");
            var name = Console.ReadLine();

            if (!xmlListOfBooks.Any(x => x.Element("Name").Value == name))
            {
                Console.WriteLine("Book not found!");
            }
            else
            {
                Console.WriteLine("Here is your book. Have a good day!");
                Books.FirstOrDefault(b => b.Name.Equals(name)).Popularity++;
            }
        }
        void ReturnABook()
        {
            Console.WriteLine("Enter book name:");
            var name = Console.ReadLine();

            if (!xmlListOfBooks.Any(x => x.Element("Name").Value == name))
            {
                Console.WriteLine("The book is not from our library!");
            }
            else
            {
                Console.WriteLine("Thank you. Have a good day!");
                Books.FirstOrDefault(b => b.Name.Equals(name)).LastUser = _currentUser;
            }
        }
        void AddABook()
        {

            Console.WriteLine("Enter book name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter book genre:");
            var genre = Console.ReadLine();
            Console.WriteLine("Enter book author:");
            var author = Console.ReadLine();
            Console.WriteLine("Enter publishing year:");
            try
            {
                var year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter pages count:");
                var pages = Convert.ToInt32(Console.ReadLine());
             
                xml.Add(new XElement("Book", new XElement("Name", name), new XElement("Author", author),
                    new XElement("Genere", genre), new XElement("Year", year),
                    new XElement("PagesCount", pages), new XElement("Popularity", 0)));
                xml.Save(_backupXML);
            }
            catch(InvalidCastException e)
            { Console.WriteLine(e.Message); }           
        }

        ~LibraryManager()
        {
            var binarySer = new BinaryFormatter();


            using (var serialization = new FileStream("BookCollection", FileMode.Create))
            {
                binarySer.Serialize(serialization, Books);
            }
        }
    }
}
