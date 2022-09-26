namespace Module2HW6
{
    public class LargeKitchenAppliance : KitchenAppliance
    {
        public LargeKitchenAppliance(string name, string manufacturer, int powerInWatts)
            : base(name, manufacturer, powerInWatts)
        {
            Name = name;
            Manufacturer = manufacturer;
            PowerInWatts = powerInWatts;
        }

        public override string Name { get; set; }
        public override string Manufacturer { get; set; }
        public override int PowerInWatts { get; set; }

        public override void TurnOn()
        {
            Console.WriteLine("Can you please don't turn me off next time?");
            Console.WriteLine("but anyway .. .");
            base.TurnOn();
        }
    }
}
