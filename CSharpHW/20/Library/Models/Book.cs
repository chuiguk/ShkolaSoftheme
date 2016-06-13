using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Library.Models
{
    [BookAtribbute]
    public class Book
    {
        [Required]
        public string Name { get; set; }
        
        public string Genre { get; set; }
        [Required]
        public string Author { get; set; }

        public int Year { get; set; }
        [Required]
        public int PagesCount { get; set; }

        public int Popularity { get; set; }
        public User LastUser { get; set; }
        public Book(string name, string genre, string author, int year, int pagesCount)
        {
            Name = name;
            Genre = genre;
            Author = author;
            Year = year;
            PagesCount = pagesCount;
        }

        public override string ToString()
        {
            return string.Format(
                @"Name - {0}, Genre - {1}, Author - {2}, Year - {3}
                Pages - {4}, Popularity count - {5}",
                Name, Genre, Author, Year, PagesCount, Popularity);
        }
    }
}
