using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookParse
{
    internal class View
    {
        public List<Book> AddBooksFromFile(string path)
        {
            Serializer serializer = new Serializer();
            List<Book> books = serializer.BookDeserialize(path);
            return books;
        }

        public Book LastPublishedBook(List<Book> books)
        {
            Book lastPublishedBook = (from book in books
                                      orderby book.Date
                                      select book).LastOrDefault();

            return lastPublishedBook;
        }

        public void ShowBooks(List<Book> bookList)
        {
            foreach (var item in bookList)
            {
                Console.Clear();
                int i = 0;
                for(i = 0; i < 3; i++)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine("Press any button to go to the next page...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
