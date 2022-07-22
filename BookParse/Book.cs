using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookParse
{
    public class Book
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public int Pages { get; set; }
        public string BookFormat { get; set; }
        public int Id { get; set; }
        
        public Book(string author, string name, int pages, string date, string format)
        {
            Author = author;
            Name = name;
            Date = date;
            Pages = pages;
            BookFormat = format;
        }
    }
}
