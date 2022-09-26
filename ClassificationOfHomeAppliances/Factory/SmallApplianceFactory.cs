namespace Module2HW6
{
    internal class SmallApplianceFactory : AbstractFactory
    {
        public SmallApplianceFactory(KindOfAppliance kindOfAppliance)
        {
            KindOfAppliance = kindOfAppliance;
        }

        public override KindOfAppliance KindOfAppliance { get; }
        public override AbstractAppliance GetAppliance(string name, string manufacturer, int power)
        {
            return new SmallAppliance(name, manufacturer, power);
        }
    }
}
