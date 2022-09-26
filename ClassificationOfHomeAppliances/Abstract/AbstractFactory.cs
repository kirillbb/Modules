namespace Module2HW6
{
    public abstract class AbstractFactory
    {
        public abstract KindOfAppliance KindOfAppliance { get; }

        public abstract AbstractAppliance GetAppliance(string name, string manufacturer, int power);
    }
}
