using System;

namespace Module2HW3
{
    public class Candy : IComparable<Candy>
    {
        public Candy(string name, string manufacturer, int weightInGrams, int price)
        {
            Name = name;
            Manufacturer = manufacturer;
            WeightInGrams = weightInGrams;
            Price = price;
        }

        public int Price { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int WeightInGrams { get; set; }

        public virtual void EatCandy(Candy candy)
        {
            Console.WriteLine($"Candy \"{candy.Name}\" eaten!");
        }

        public int CompareTo(Candy candy)
        {
            if (candy is null)
            {
                throw new ArgumentException("This isn't a candy!");
            }

            return Name.CompareTo(candy.Name);
        }

        public override string ToString()
        {
            return $"{Name} ({Manufacturer}) {WeightInGrams} grams - {Price}$";
        }
    }
}
