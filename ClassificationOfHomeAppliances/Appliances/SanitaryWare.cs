namespace Module2HW6
{
    public class SanitaryWare : LargeAppliance
    {
        public SanitaryWare(string name, string manufacturer, int powerInWatts)
            : base(name, manufacturer, powerInWatts)
        {
        }

        public override void TurnOn()
        {
            Console.WriteLine("I need a water conection!");
            WaterConection();

            base.TurnOn();
        }

        private void WaterConection()
        {
            Console.WriteLine("Water connected");
        }
    }
}
