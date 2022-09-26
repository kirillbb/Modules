namespace Module2HW6
{
    internal class LargeApplianceFactory : AbstractFactory
    {
        public LargeApplianceFactory(KindOfAppliance kindOfAppliance)
        {
            KindOfAppliance = kindOfAppliance;
        }

        public override KindOfAppliance KindOfAppliance { get; }
        public override AbstractAppliance GetAppliance(string name, string manufacturer, int power)
        {
            switch (KindOfAppliance)
            {
                case KindOfAppliance.LargeAppliance: return new LargeAppliance(name, manufacturer, power);
                case KindOfAppliance.SanitaryWare: return new SanitaryWare(name, manufacturer, power);
            }

            return null;
        }
    }
}
