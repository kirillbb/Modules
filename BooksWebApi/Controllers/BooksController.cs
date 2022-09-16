using BooksWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BooksWebApi.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : Controller
    {
        private readonly BooksAppContext context;

        public BooksController(BooksAppContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooksAsync()
        {
            return Ok(await context.Books.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddContactAsync(AddBookRequest request)
        {
            var book = new Book()
            {
                Id = new Guid(),
                Title = request.Title,
                Author = request.Author
            };

            await context.Books.AddAsync(book);
            await context.SaveChangesAsync();
            return Ok(book);
        }
    }
}
