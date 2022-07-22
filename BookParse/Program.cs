namespace BookParse
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the information about the book:");
            string bookInfo = Console.ReadLine();   //Е. Таненбаум – Сучасні операційні системи, 1365 (12.05.2013).pdf

            Parser parser = new Parser();
            var bookInfoLines = parser.Parse(bookInfo);
            
            bookInfoLines = EditBookInfo(bookInfoLines);

            SetBookFields(bookInfoLines);
        }

        public static Book SetBookFields(string[] bookInfo)
        {
            Book book = new Book(bookInfo[0], bookInfo[1], int.Parse(bookInfo[2]), bookInfo[3], bookInfo[4]);

            return book;
        }

        public static string[] EditBookInfo(string[] bookInfoLines)
        {
            string word = "";

            for (int i = 0; i < bookInfoLines.Length; i++)
            {
                word = bookInfoLines[i];

                if (word[word.Length - 1] == ' ')
                {
                    word = word.Remove(word.Length - 1, 1);
                }
                if (word[0] == ' ')
                {
                    word = word.Remove(0, 1);
                }

                bookInfoLines[i] = word;
            }

            return bookInfoLines;
        }
    }
}