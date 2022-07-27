using FluentValidation.Results;

namespace BookParse
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the information about the book:");
            Console.WriteLine("Example:  Е. Таненбаум – Сучасні операційні системи, 1365 (12.05.2013).pdf");

            BookCreator bookCreator = new BookCreator();

            string bookInfo = Console.ReadLine();   //Е. Таненбаум – Сучасні операційні системи, 1365 (12.05.2013).pdf
            var book = bookCreator.Create(bookInfo);
        }

        
    }
}