namespace ORM
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? Date { get; set; }

        public string Genre { get; set; }

        public string Country { get; set; }

        public List<Actor> Actors { get; set; } = new();
        
        public List<Comment> Comments { get; set; } = new();
    }
}
