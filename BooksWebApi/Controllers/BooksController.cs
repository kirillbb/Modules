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
            //// remove it if need to work with DataBase
            if(context.Books.Count() == 0)
            {
                AddTestDataAsync(context);
            }

            this.context = context;
        }

        private void AddTestDataAsync(BooksAppContext context)
        {
            List<Book> books = JsonConvert.DeserializeObject<List<Book>>((System.IO.File.ReadAllText("books.json")));
             
            context.Books.AddRange(books);
            context.SaveChanges();
        }

        [HttpGet]
        public async Task<IActionResult> GetBooksAsync([FromQuery] BooksParams @params)
        {
            var books = context.Books;

            var metadata = new PaginationMetadata(books.Count(), @params.Page, @params.PageSize);
            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));

            var items = await books
                .Skip((@params.Page - 1) * @params.PageSize)
                .Take(@params.PageSize)
                .ToListAsync();

            return Ok(items);
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
        public async Task<IActionResult> AddBookAsync(AddBookRequest request)
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
        public async Task<IActionResult> UpdateBookAsync([FromRoute] Guid id, UpdateBookRequest request)
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
