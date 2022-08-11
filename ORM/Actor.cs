namespace ORM
{
    public class Actor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string Gender { get; set; }

        public string Country { get; set; }

        public List<Movie> Movies { get; set; } = new();

        public List<ActorComment> Comments { get; set; } = new();
    }
}
