using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookParse
{
    internal class BookManager
    {
        public List<Book> AddBooksFromFile(string path)
        {
            Serializer serializer = new Serializer();
            List<Book> bookList = serializer.BookDeserialize(path);
            return bookList;
        }

        public Book FindLastPublishedBook(List<Book> bookList)
        {
            Book lastPublishedBook = (from book in bookList
                                      orderby book.Date
                                      select book).LastOrDefault();

            return lastPublishedBook;
        }

        public List<Book> FindBooksBetweenYears(int startYear, int endYear, List<Book> bookList)
        {
            List<Book> foundedBooks = new List<Book>();
            if (bookList.Count == 0)
                throw new Exception(message: "Books list are empty");

            foreach (var book in bookList)
            {
                if (book.Date.Year >= startYear && book.Date.Year <= endYear)
                    foundedBooks.Add(book);
            }

            if (foundedBooks.Count == 0)
                throw new Exception(message:"No books for this time range");

            return foundedBooks; 
        }


        public Book FindBookByName(string name, List<Book> bookList)
        {
            if (bookList.Count == 0)
                throw new Exception(message: "Books list are empty");

            foreach (var book in bookList)
            {
                if (book.BookName.ToLower() == name.ToLower())
                {
                    return book;
                }
            }
            throw new Exception(message: "Book not found");
        }

        public Dictionary<string, IOrderedEnumerable<Book>> GroupBooksByAuthors(DateTime date, List<Book> bookList)
        {
            if (bookList.Count == 0)
                throw new Exception(message: "Books list are empty");

            Dictionary<string, Book[]> bookDictionary = new Dictionary<string, Book[]>();

            var grouped = from book in bookList
                          where book.Date >= date
                          group book by book.Author into k
                          orderby k.Key descending
                          select new
                          {
                              Author = k.Key,
                              Books = from bk in k
                                      where bk.Date >= date
                                      orderby bk.BookName
                                      select bk
                          };
            return grouped.ToDictionary(book => book.Author, x => x.Books);
        }

        public string FindAuthors(List<Book> bookList)
        {
            if (bookList.Count == 0)
                throw new Exception(message: "Books list are empty");

            var authorsList = from b in bookList
                              orderby b.Author
                              select b.Author;

            string authorsString = "";
            foreach (var author in authorsList)
            {
                if (!authorsString.Contains(author))
                {
                    if (author != authorsList.Last())
                    {
                        authorsString += $"{author}, ";
                    }
                    else
                    {
                        authorsString += $"{author}.";
                    }
                }
            }
            return authorsString;
        }

        public void ShowBooks(List<Book> bookList)
        {
            if (bookList.Count == 0)
                throw new Exception(message: "Books list are empty");

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
