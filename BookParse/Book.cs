﻿using System.Collections.Generic;

namespace BookParse
{
    public class Book
    {
        public string Author { get; set; }
        public string BookName { get; set; }
        public DateTime Date { get; set; }
        public int Pages { get; set; }
        public string BookFormat { get; set; }

        public Book(string author, string name, int pages, DateTime date, string format)
        {
            Author = author;
            BookName = name;
            Date = date;
            Pages = pages;
            BookFormat = format;
            
        }
        public override string ToString()
        {
            return $"{Author} – {BookName}, {Pages} ({Date.ToString(format:"d")}){BookFormat}";
        }
    }
}
