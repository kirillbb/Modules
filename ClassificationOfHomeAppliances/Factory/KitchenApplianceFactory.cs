namespace Module2HW6
{
    public class KitchenApplianceFactory : AbstractFactory
    {
        public KitchenApplianceFactory(KindOfAppliance kindOfAppliance)
        {
            KindOfAppliance = kindOfAppliance;
        }

        public override KindOfAppliance KindOfAppliance { get; }
        public override AbstractAppliance GetAppliance(string name, string manufacturer, int power)
        {
            switch (KindOfAppliance)
            {
                case KindOfAppliance.KitchenAppliance: return new KitchenAppliance(name, manufacturer, power);
                case KindOfAppliance.SmallKitchenAppliance: return new SmallKitchenAppliance(name, manufacturer, power);
                case KindOfAppliance.LargeKitchenAppliance: return new LargeKitchenAppliance(name, manufacturer, power);
                case KindOfAppliance.Shreders: return new Shredders(name, manufacturer, power);
                case KindOfAppliance.Combined: return new Combined(name, manufacturer, power);
            }

            return null;
        }
    }
}
