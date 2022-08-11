namespace ORM
{
    using Microsoft.EntityFrameworkCore;

    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
        }

        public DbSet<Movie> Movies { get; set; } = null!;

        public DbSet<Actor> Actors { get; set; } = null!;

        public DbSet<Comment> Comments { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-6KJ2COE;Database=ORMdb;Trusted_Connection=True;");
        }
    }
}
