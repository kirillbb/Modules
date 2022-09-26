namespace Module2HW4
{
    public class Snake : ColdBlooded
    {
        public Snake(string name, int weightInKilograms, string size, int speed)
            : base(name, weightInKilograms, size, speed)
        {
        }

        public override void Motion()
        {
            Console.WriteLine($"I can crawl {Speed} km/h");
        }
    }
}
