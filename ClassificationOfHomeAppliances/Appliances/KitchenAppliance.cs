namespace Module2HW6
{
    public class KitchenAppliance : AbstractAppliance
    {
        public KitchenAppliance(string name, string manufacturer, int powerInWatts)
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
            base.TurnOn();
        }
    }
}
