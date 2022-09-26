using System;

namespace Module2HW3
{
    public class Caramel : Candy
    {
        public Caramel(string name, string manufacturer, int weightInGrams, int price)
            : base(name, manufacturer, weightInGrams, price)
        {
        }

        public override void EatCandy(Candy candy)
        {
            int timeToEat = candy.WeightInGrams / 2;

            Console.WriteLine($"Candy \"{candy.Name}\" eaten in {timeToEat} seconds!");
        }
    }
}
