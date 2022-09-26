using System;

namespace Module2HW3
{
    public class Gift : IGift
    {
        private readonly Candy[] _candies = new Candy[10];

        private int Weight { get; set; }
        public Candy[] Collect()
        {
            _candies[0] = new Caramel("apple", "roshen", 7, 5);
            _candies[1] = new Chocolate("choko", "milka", 100, 30);
            _candies[2] = new StuffedChokolate("nuts", "konti", 50, 15);
            _candies[3] = new Lollipop("chups", "chupa", 12, 7);
            _candies[4] = new StuffedCaramel("rak", "roshen", 3, 3);
            _candies[5] = new LiqueurCaramel("drunkcherry", "avk", 12, 10);
            _candies[6] = new Chocolate("chokoloko", "milka", 110, 35);
            _candies[7] = new StuffedChokolate("nuts", "konti", 55, 20);
            _candies[8] = new Lollipop("chups", "chupa", 13, 8);
            _candies[9] = new Caramel("orange", "roshen", 8, 5);

            return _candies;
        }

        public Candy[] GetGift()
        {
            return _candies;
        }

        public int WeightOfTheGift(Candy[] candies)
        {
            foreach (var item in candies)
            {
                Weight += item.WeightInGrams;
            }

            return Weight;
        }

        public void PrintGift(Candy[] candies)
        {
            foreach (var item in candies)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
