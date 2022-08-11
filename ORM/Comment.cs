namespace ORM
{
    public partial class Comment
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public EmotionType Emotion { get; set; }

        public int Evaluation { get; set; }
    }
}
