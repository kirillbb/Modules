namespace Module2HW4
{
    public static class AnimalExtension
    {
        public static Animal FindAnimal(this Animal[] animals, string name)
        {
            if (name != null)
            {
                for (int i = 0; i < animals.Length; i++)
                {
                    if (animals[i].Name == name)
                    {
                        return animals[i];
                    }
                }
            }

            return null;
        }
    }
}
