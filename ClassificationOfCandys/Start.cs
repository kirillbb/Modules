using System;

namespace Module2HW3
{
    public static class Start
    {
        public static void Run()
        {
            Gift gift = new ();
            gift.Collect();
            var candies = gift.GetGift();

            gift.PrintGift(candies);
            Console.WriteLine($"\nWeight of the gift is {gift.WeightOfTheGift(candies)} grams");

            Array.Sort(candies);

            Console.WriteLine("\nSorted array:");
            gift.PrintGift(candies);

            string name = string.Empty;

            while (name == string.Empty)
            {
                Console.WriteLine("\n\nCandy with what name can I find?");
                name = Console.ReadLine();
                name = name.ToLower();
            }

            Console.WriteLine($"\nFind candy with name \"{name}\":");

            try
            {
                Console.WriteLine(candies.FindCandy(name).ToString());
            }
            catch
            {
                Console.WriteLine("I can't find this Candy!");
            }
        }
    }
}
