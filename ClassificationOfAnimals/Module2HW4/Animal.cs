namespace Module2HW4
{
    public class Animal : IComparable<Animal>
    {
        public Animal(string name, int weightInKilograms, string size, int speed)
        {
            Name = name;
            WeightInKilograms = weightInKilograms;
            Size = size;
            Speed = speed;
        }

        public string Name { get; set; }
        public int WeightInKilograms { get; set; }
        public string Size { get; set; }
        public int Speed { get; set; }

        public int CompareTo(Animal? animal)
        {
            if (animal is null)
            {
                throw new ArgumentException("This isn't an animal!");
            }

            return Name.CompareTo(animal.Name);
        }

        public virtual void Motion()
        {
            Console.WriteLine($"I can run {Speed} km/h");
        }

        public override string ToString()
        {
            return $"{Name} weight {WeightInKilograms} kilograms, this is a {Size}, who has {Speed}km/h speed";
        }
    }
}
