using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookParse
{
    internal class BookCreator
    {
        public Book Create(string bookInfo)
        {
            var bookInfoLines = Parse(bookInfo);

            bookInfoLines = EditBookInfo(bookInfoLines);

            Book book = SetBookFields(bookInfoLines);
            return book;
        }
        public string[] Parse(string bookInfo)
        {
            char[] delimiterChars = { '-', ',', '(', ')'};
            string[] bookInfoLines = bookInfo.Split(delimiterChars);

            return bookInfoLines;
        }
        public Book SetBookFields(string[] bookInfo)
        {
            try
            {
                if (bookInfo.Length != 5)
                {
                    Console.WriteLine("Incorrect book info!");
                    return null;
                }

                Book book = new Book(bookInfo[0], bookInfo[1], int.Parse(bookInfo[2]), DateOnly.Parse(bookInfo[3]), bookInfo[4]);

                BookValidator validator = new BookValidator();

                ValidationResult results = validator.Validate(book);

                if (!results.IsValid)
                {
                    foreach (var failure in results.Errors)
                    {
                        Console.WriteLine(failure.PropertyName + ": " + failure.ErrorMessage);
                    }
                }
                else
                {
                    Console.WriteLine("Book added");
                    return book;
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        public string[] EditBookInfo(string[] bookInfoLines)
        {
            string word = "";

            for (int i = 0; i < bookInfoLines.Length; i++)
            {
                word = bookInfoLines[i];

                if (word == "" || word == " ")
                    break;

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
