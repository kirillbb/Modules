namespace FileHierarchy
{
    public class Log
    {
        public DateTime Time { get; set; }
        public string Command { get; set; } = "";
        public string Path { get; set; } = "";

        public override string ToString() => $"{Time.ToString()} : {Command} : {Path}";
    }
}
