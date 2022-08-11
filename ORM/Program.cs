namespace ORM
{
    public static class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Movie movie1 = new Movie { Name = "Spider man", Country = "USA", Date = new DateTime(2004, 5, 5), Genre = "action" };
                Movie movie2 = new Movie { Name = "Mr.Robot", Country = "GB", Date = new DateTime(2011, 4, 4), Genre = "drama" };
                Movie movie3 = new Movie { Name = "Big bang theory", Country = "USA", Date = new DateTime(2006, 6, 10), Genre = "comedy" };

                db.Movies.AddRange(movie1, movie2, movie3);
                db.SaveChanges();
            }
        }
    }
}