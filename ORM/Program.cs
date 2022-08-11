namespace ORM
{
    public static class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                //Movie movie1 = new Movie { Name = "Spider man", Country = "USA", Date = new DateTime(2004, 5, 5), Genre = "action" };
                //Movie movie2 = new Movie { Name = "Spider man 2", Country = "USA", Date = new DateTime(2006, 5, 5), Genre = "action" };

                //List<Movie> movies = new List<Movie>();
                //movies.Add(movie1);
                //movies.Add(movie2);

                //Actor actor1 = new Actor { BirthDate = DateTime.Now, Name = "Jack Russel", Country = "USA", Gender = "male", Movies = movies};
                //Actor actor2 = new Actor { BirthDate = DateTime.Now, Name = "Skotch Terier", Country = "Ireland", Gender = "male", Movies = movies };

                //List<Actor> actors = new List<Actor>();
                //actors.Add(actor1);
                //actors.Add(actor2);

                //Movie movie = db.Movies.FirstOrDefault();
                //db.Movies.Remove(movie);

                //movie1.Actors = actors;
                //movie2.Actors = actors;
                //db.Movies.Add(movie2);
                //db.Actors.AddRange(actors);

                Comment comment = new Comment { Emotion = Comment.EmotionType.positive, Evaluation = 5, Movie = db.Movies.FirstOrDefault(), Text = "great movie!!" };

                db.Comments.Add(comment);

                db.SaveChanges();
            }
        }
    }
}