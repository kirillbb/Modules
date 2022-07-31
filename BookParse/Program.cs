using FluentValidation.Results;

namespace BookParse
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"books.json";
            //Console.WriteLine("Enter the information about the book:");
            //Console.WriteLine("Example:  Е. Таненбаум – Сучасні операційні системи, 1365 (12.05.2013).pdf");

            //BookCreator bookCreator = new BookCreator();

            //string bookInfo = Console.ReadLine();   //Е. Таненбаум – Сучасні операційні системи, 1365 (12.05.2013).pdf
            //var book = bookCreator.Create(bookInfo);

            //Serializer serializer = new Serializer();
            //if (book != null)
            //    serializer.BookSerialize(book, path);

            BookManager bookManager = new BookManager();
            var bookList = bookManager.AddBooksFromFile(path);

            try
            {
                //bookManager.ShowBooks(bookList);

                //var lastPublishedBook = bookManager.FindLastPublishedBook(bookList);
                //Console.WriteLine("Last published book is:");
                //Console.WriteLine(lastPublishedBook.ToString());


                //List<Book> booksYears = bookManager.FindBooksBetweenYears(1969, 1970, bookList);
                //bookManager.ShowBooks(booksYears);

                //Book foundedBook = bookManager.FindBookByName("Born", bookList);
                //Console.WriteLine(foundedBook.ToString());
                //foundedBook = bookManager.FindBookByName("Bosdfsdfrn", bookList);
                //Console.WriteLine(foundedBook.ToString());

                //Console.WriteLine(bookManager.FindAuthors(bookList));


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
    }
}