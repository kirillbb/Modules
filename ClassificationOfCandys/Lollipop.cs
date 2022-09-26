using System;

namespace Module2HW3
{
    public class Lollipop : Caramel
    {
        public Lollipop(string name, string manufacturer, int weightInGrams, int price)
            : base(name, manufacturer, weightInGrams, price)
        {
        }

        public override void EatCandy(Candy candy)
        {
            Warning();

            int timeToEat = candy.WeightInGrams * 4;

            Console.WriteLine($"Candy \"{candy.Name}\" eaten in {timeToEat} seconds!");
        }

        private static void Warning()
        {
            Console.WriteLine("Be careful, don't break your teeth!");
        }
    }
}
