namespace Module2HW2
{
    public class Product
    {
        public Product(int index, string name, int price)
        {
            Index = index;
            Name = name;
            Price = price;
        }

        public int Index { get; }
        public string Name { get; }
        public int Price { get; }
    }
}
