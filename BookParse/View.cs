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

        public Book FindLastPublishedBook(List<Book> books)
        {
            Book lastPublishedBook = (from book in books
                                      orderby book.Date
                                      select book).LastOrDefault();

            return lastPublishedBook;
        }

        public List<Book> FindBooksBetweenYears(int startYear, int endYear, List<Book> books)
        {
            List<Book> foundedBooks = new List<Book>();
            if (books.Count != 0)
            {
                foreach (var book in books)
                {
                    if (book.Date.Year >= startYear && book.Date.Year <= endYear)
                        foundedBooks.Add(book);
                }
            }
            else
            {
                throw new Exception(message:"Books list are empty");
            }

            if (foundedBooks.Count == 0)
                throw new Exception(message:"No books for this time range");

            return foundedBooks; 
        }

        public void ShowBooks(List<Book> bookList)
        {
            int i = 1;
            foreach (var item in bookList)
            {
                Console.WriteLine(item.ToString());

                if (i == 3)
                {
                    Console.WriteLine("Press any button to go to the next page...");
                    Console.ReadKey();
                    Console.Clear();
                    i = 1;
                }
                i++;
            }
        }
    }
}
