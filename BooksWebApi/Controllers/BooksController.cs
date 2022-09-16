using BooksWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace BooksWebApi.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : Controller
    {
        private readonly BooksAppContext context;

        public BooksController(BooksAppContext context)
        {
            AddTestDataAsync(context);

            this.context = context;
        }

        private void AddTestDataAsync(BooksAppContext context)
        {
            List<Book> books = JsonConvert.DeserializeObject<List<Book>>((System.IO.File.ReadAllText("books.json")));
             
            context.Books.AddRange(books);
            context.SaveChanges();
        }

        [HttpGet]
        public async Task<IActionResult> GetBooksAsync()
        {
            return Ok(await context.Books.ToListAsync());
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetBookAsync([FromRoute] Guid id)
        {
            var book = await context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
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

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateContactAsync([FromRoute] Guid id, UpdateBookRequest request)
        {
            var book = await context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            book.Title = request.Title;
            book.Author = request.Author;
            await context.SaveChangesAsync();
            return Ok(book);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteBookAsync([FromRoute] Guid id)
        {
            var book = await context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            context.Books.Remove(book);
            await context.SaveChangesAsync();
            return Ok(book);
        }
    }
}
