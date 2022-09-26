namespace Module2HW4
{
    public static class Safari
    {
        public static void Start()
        {
            Section section = new ();
            section.CollectSection();
            var animals = section.GetSection();

            section.PrintSection(animals);
            Console.WriteLine($"\nSection has {section.CountOfAnimals(animals)} animals");

            Console.WriteLine("\nSorted by name array:");
            Array.Sort(animals);
            section.PrintSection(animals);

            string name = string.Empty;

            while (name == string.Empty || name == null)
            {
                Console.WriteLine("\n\nWhat animal can I find?");
                name = Console.ReadLine().ToLower();
            }

            try
            {
                Console.WriteLine($"\nWe find that animal \"{name}\":");
                Console.WriteLine(animals.FindAnimal(name).ToString());
                animals.FindAnimal(name).Motion();
            }
            catch
            {
                Console.WriteLine("I can't find this animal!");
            }
        }
    }
}
