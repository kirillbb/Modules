namespace ORM
{
    public static class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Movie movie1 = new Movie { Name = "Spider man", Country = "USA", Date = new DateTime(2004, 5, 5), Genre = "action" };
                Movie movie2 = new Movie { Name = "Spider man 2", Country = "USA", Date = new DateTime(2006, 5, 5), Genre = "action" };

                List<Movie> movies = new List<Movie>();
                movies.Add(movie1);
                movies.Add(movie2);

                Actor actor1 = new Actor { BirthDate = DateTime.Now, Name = "Jack Russel", Country = "USA", Gender = "male", Movies = movies };
                Actor actor2 = new Actor { BirthDate = DateTime.Now, Name = "Skotch Terier", Country = "Ireland", Gender = "male", Movies = movies };

                List<Actor> actors = new List<Actor>();
                actors.Add(actor1);
                actors.Add(actor2);

                db.Movies.AddRange(movies);
                db.Actors.AddRange(actors);

                MovieComment comment = new MovieComment { Emotion = Comment.EmotionType.negative, Evaluation = 1, Movie = db.Movies.FirstOrDefault(), Text = "worse movie!!" };
                ActorComment actorComment = new ActorComment { Emotion = Comment.EmotionType.positive, Evaluation = 4, Actor = db.Actors.FirstOrDefault(), Text = "i love that actor! <3" };
                
                db.Comments.AddRange(comment, actorComment);
                db.SaveChanges();
            }
        }
    }
}