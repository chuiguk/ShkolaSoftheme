using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using System.ComponentModel.DataAnnotations;
namespace Library.Services
{
    public class LibraryManager
    {
        private List<User> _authorizedUsers = new List<User>
        {
            new User("User1", "Password"),
            new User("User2", "Password")
        };


        public List<Book> Books = new List<Book>
        {
            new Book("The Lord of the Rings", "Fantasy", "Tolkien", 1900, 1000),
            new Book("The Hobbit", "Fantasy", "Tolkien", 1800, 2000),
            new Book("The Da Vinci Code", "Detective", "Dan Brown", 2000, 500)
        };
        User _currentUser;

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
            var bookGenreGroups = Books.GroupBy(book => book.Genre);
            Console.WriteLine("Grouped count by genre:");
            foreach (var bookGenreGroup in bookGenreGroups)
            {
                Console.WriteLine("Genre: {0}. Count - {1}", bookGenreGroup.Key, bookGenreGroup.Count());
            }

            Book newestBook = Books.Aggregate((b1,b2) => b1.Year > b2.Year ? b1 : b2);
            Console.WriteLine("Newest book - {0}", newestBook);

            Book oldestBook = Books.Aggregate((b1, b2) => b1.Year < b2.Year ? b1 : b2);
            Console.WriteLine("Oldest book - {0}", oldestBook);

            Book mostPopularBook = Books.Aggregate((b1, b2) => b1.Popularity > b2.Popularity ? b1 : b2);
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

            if (Books.Any(b => b.Name.Equals(name)))
            {
                Console.WriteLine("Book not found!");
                return;
            }
            var books = Books.Where(b => b.Name.Equals(name));
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }          
        }

        void SearchByAuthor()
        {
            Console.WriteLine("Enter book author");
            var author = Console.ReadLine();

            if (!Books.Any(b => b.Author.Equals(author)))
            {
                Console.WriteLine("Book not found!");
                return;
            }
            IEnumerable<Book> books = Books.Where(b => b.Author.Equals(author));
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }     
        }
        //
        static bool Validate(Book book)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(book);
            if (!Validator.TryValidateObject(book, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
                return false;
            }
            else
            {
                Console.WriteLine("Book '{0}' is Valid", book.Name);
                return true;
            }
        }
        //
        void SearchByNameAndAuthor()
        {
            Console.WriteLine("Enter book name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter book author");
            var author = Console.ReadLine();

            if (Books.Any(b => b.Name.Equals(name) && b.Author.Equals(author)))
            {
                Console.WriteLine("Book not found!");
                return;
            }
            var books = Books.Where(b => b.Name.Equals(name) && b.Author.Equals(author));
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }     
        }
        void ShowMostPopularBook()
        {
            Console.WriteLine("Enter book genre:");
            var genre = Console.ReadLine();
            Book mostPopularBookInGenre = Books.Where(b => b.Genre == genre).Aggregate((b1, b2) => b1.Popularity > b2.Popularity ? b1 : b2);
            if (mostPopularBookInGenre == null)
            {
                Console.WriteLine("Genre not found!");
                return;
            }
            Console.WriteLine("Most popular - {0}", mostPopularBookInGenre);
        }
        void TakeABook()
        {
            Console.WriteLine("Enter book name:");
            var name = Console.ReadLine();

            if (!Books.Any(b => b.Name.Equals(name)))
            {
                Console.WriteLine("Book not found!");
                return;
            }
            else
            {
                if (!Validate(Books.FirstOrDefault(b => b.Name.Equals(name))))
                { return; } 
                Console.WriteLine("Here is your book. Have a good day!");
                Books.FirstOrDefault(b => b.Name.Equals(name)).Popularity++;
            }
        }
        void ReturnABook()
        {
            Console.WriteLine("Enter book name:");
            var name = Console.ReadLine();
            if (!Books.Any(b => b.Name.Equals(name)))
            {
                Console.WriteLine("The book is not from out library!");
                return;
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
                Books.Add(new Book(name, genre, author, year, pages));
            }
            catch(InvalidCastException e)
            { Console.WriteLine(e.Message); return; }           
        }
    }
}
