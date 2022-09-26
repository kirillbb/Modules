namespace Module2HW6
{
    public class Shredders : SmallKitchenAppliance
    {
        public Shredders(string name, string manufacturer, int powerInWatts)
            : base(name, manufacturer, powerInWatts)
        {
        }

        public override void TurnOn()
        {
            Console.WriteLine("I will be making a lot of noise!");
            base.TurnOn();
        }
    }
}