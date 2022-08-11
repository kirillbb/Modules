namespace ORM
{
    public partial class Comment
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public EmotionType Emotion { get; set; }

        public int Evaluation { get; set; }
    }

    public class MovieComment : Comment
    {
        public Movie Movie { get; set; }
    }

    public class ActorComment : Comment
    {
        public Actor Actor { get; set; }
    }
}
