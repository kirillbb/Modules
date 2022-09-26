namespace Module2HW6
{
    public abstract class AbstractAppliance : IComparable<AbstractAppliance>
    {
        public abstract string Name { get; set; }
        public abstract string Manufacturer { get; set; }
        public abstract int PowerInWatts { get; set; }

        public int CompareTo(AbstractAppliance appliance)
        {
            if (appliance is null)
            {
                throw new ArgumentException("That's not name!");
            }

            return Name.CompareTo(appliance.Name);
        }

        public virtual void TurnOn()
        {
            Console.WriteLine($"{Name} is on, consumes {PowerInWatts} watts per hour");
        }

        public override string ToString()
        {
            return $"{Name} ({Manufacturer}) - {PowerInWatts} watt";
        }
    }
}
