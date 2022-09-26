using System;

namespace Module2HW3
{
    public static class CandyExtension
    {
        public static Candy FindCandy(this Candy[] candies, string name)
        {
            if (name != null)
            {
                for (int i = 0; i < candies.Length; i++)
                {
                    if (candies[i].Name == name)
                    {
                        return candies[i];
                    }
                }
            }

            return null;
        }
    }
}
