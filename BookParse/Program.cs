using FluentValidation.Results;

namespace BookParse
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the information about the book:");
            Console.WriteLine("Example:  Е. Таненбаум – Сучасні операційні системи, 1365 (12.05.2013).pdf");

            //BookCreator bookCreator = new BookCreator();

            //string bookInfo = Console.ReadLine();   //Е. Таненбаум – Сучасні операційні системи, 1365 (12.05.2013).pdf
            //var book = bookCreator.Create(bookInfo);

            //Serializer serializer = new Serializer();
            //if (book != null)
            //    serializer.BookSerialize(book);

            View bookView = new View();
            var bookList = bookView.AddBooksFromFile(@"books.json");

            //bookView.ShowBooks(bookList);

            //var lastPublishedBook = bookView.FindLastPublishedBook(bookList);
            //Console.WriteLine("Last published book is:");
            //Console.WriteLine(lastPublishedBook.ToString());

            try
            {
                List<Book> booksYears = bookView.FindBooksBetweenYears(1969, 1970, bookList);
                bookView.ShowBooks(booksYears);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
    }
}