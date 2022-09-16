using Microsoft.EntityFrameworkCore;

namespace BooksWebApi.Models
{
    public class BooksAppContext : DbContext
    {
        public BooksAppContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } = null!;
    }
}
