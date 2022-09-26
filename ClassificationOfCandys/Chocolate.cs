using System;

namespace Module2HW3
{
    public class Chocolate : Candy
    {
        public Chocolate(string name, string manufacturer, int weightInGrams, int price)
            : base(name, manufacturer, weightInGrams, price)
        {
        }

        public override void EatCandy(Candy candy)
        {
            int timeToEat = candy.WeightInGrams / 4;

            Console.WriteLine($"Candy \"{candy.Name}\" eaten in {timeToEat} seconds!");
        }
    }
}
