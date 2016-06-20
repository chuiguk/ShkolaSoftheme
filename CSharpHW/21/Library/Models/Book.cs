using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
using  Library.Models;
namespace Library.Models
{
    [Serializable]
    [ProtoContract]
    public class Book
    {
        [ProtoMember(1)]
        public string Name { get; set; }
        [ProtoMember(2)]
        public string Genre { get; set; }
        [ProtoMember(3)]
        public string Author { get; set; }
        [ProtoMember(4)]
        public int Year { get; set; }
        [ProtoMember(5)]
        public int PagesCount { get; set; }
        [ProtoMember(6)]
        public int Popularity { get; set; }
        [ProtoMember(7)]
        public User LastUser { get; set; }
        public Book(string name, string genre, string author, int year, int pagesCount)
        {
            Name = name;
            Genre = genre;
            Author = author;
            Year = year;
            PagesCount = pagesCount;
        }

        public Book()
        {
            
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
