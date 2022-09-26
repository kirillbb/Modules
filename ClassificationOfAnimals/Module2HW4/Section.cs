namespace Module2HW4
{
    internal class Section : ISection
    {
        private readonly Animal[] _animals = new Animal[9];

        private int Count { get; set; }
        public Animal[] CollectSection()
        {
            _animals[0] = new Snake(name: "cobra", weightInKilograms: 5, size: "so looooong", speed: 6);
            _animals[1] = new Reptile("crocodile", 600, "not so long, like a cobra", 48);
            _animals[2] = new ColdBlooded("varan", 3, "big lizard", 91);
            _animals[3] = new Feline("lion", 150, "big cat", 80);
            _animals[4] = new Herbivorous("giraffe", 550, "so tall guy", 60);
            _animals[5] = new Predator("hippo", 1500, "so fat guy", 6);
            _animals[6] = new Herbivorous("rhino", 2300, "very big guy", 20);
            _animals[7] = new Feline("pantera", 40, "not very big black cat", 80);
            _animals[8] = new Feline("leopard", 50, "not very big cat", 58);

            return _animals;
        }

        public Animal[] GetSection()
        {
            return _animals;
        }

        public int CountOfAnimals(Animal[] animals)
        {
            foreach (var item in animals)
            {
                Count++;
            }

            return Count;
        }

        public void PrintSection(Animal[] animals)
        {
            foreach (var item in animals)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
