using FluentValidation;

namespace BookParse
{
    internal class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(book => book.Author)
                .NotEmpty()
                .When(book => book.Author.Replace(" ", "").Length == 0).WithMessage("должно быть заполнено")
                .MaximumLength(50);
            RuleFor(book => book.BookName)
                .NotEmpty()
                .When(book => book.BookName.Replace(" ", "").Length == 0).WithMessage("должно быть заполнено")
                .MaximumLength(100);
            RuleFor(book => book.Date)
                .NotEmpty();
            RuleFor(book => book.BookFormat)
                .NotEmpty()
                .When(book => book.BookFormat.Replace(" ", "").Length == 0).WithMessage("должно быть заполнено");
        }
    }
}
