namespace Module2HW4
{
    public class Feline : Predator
    {
        public Feline(string name, int weightInKilograms, string size, int speed)
            : base(name, weightInKilograms, size, speed)
        {
        }

        public override void Motion()
        {
            Console.WriteLine($"I can run {Speed} km/h and be graceful");
        }
    }
}
