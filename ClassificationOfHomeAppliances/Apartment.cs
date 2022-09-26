namespace Module2HW6
{
    internal class Apartment : IApartment
    {
        private readonly AbstractAppliance[] _appliances;
        public Apartment()
        {
            _appliances = new AbstractAppliance[10];

            _appliances[0] = new KitchenApplianceFactory(KindOfAppliance.KitchenAppliance).GetAppliance("teapot", "Gorenje", 1200);
            _appliances[1] = new KitchenApplianceFactory(KindOfAppliance.LargeKitchenAppliance).GetAppliance("fridge", "LG", 350);
            _appliances[2] = new KitchenApplianceFactory(KindOfAppliance.Combined).GetAppliance("combine", "Bosch", 1400);
            _appliances[3] = new KitchenApplianceFactory(KindOfAppliance.KitchenAppliance).GetAppliance("microwave", "Xiaomi", 700);
            _appliances[4] = new LargeApplianceFactory(KindOfAppliance.SanitaryWare).GetAppliance("boiler", "Atlantic", 1500);
            _appliances[5] = new LargeApplianceFactory(KindOfAppliance.SanitaryWare).GetAppliance("washer", "Indesit", 1100);
            _appliances[6] = new KitchenApplianceFactory(KindOfAppliance.KitchenAppliance).GetAppliance("multicooker", "Samsung", 899);
            _appliances[7] = new KitchenApplianceFactory(KindOfAppliance.Shreders).GetAppliance("blender", "Gorenje", 1200);
            _appliances[8] = new LargeApplianceFactory(KindOfAppliance.LargeAppliance).GetAppliance("imac-pro", "Apple", 650);
            _appliances[9] = new SmallApplianceFactory(KindOfAppliance.SmallAppliance).GetAppliance("robot-vacuum", "Xiaomi", 200);
        }

        public int TotalPower { get; private set; }
        public int CalculateTotalPower(AbstractAppliance[] appliances)
        {
            foreach (var item in appliances)
            {
                TotalPower += item.PowerInWatts;
            }

            return TotalPower;
        }

        public AbstractAppliance[] GetApplianceArray()
        {
            return _appliances;
        }
    }
}
