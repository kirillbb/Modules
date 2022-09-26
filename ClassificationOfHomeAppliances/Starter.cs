using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public class Starter
    {
        public static void Run()
        {
            Apartment apartment = new Apartment();
            var appliance = apartment.GetApplianceArray();

            Console.WriteLine($"Total power: {apartment.CalculateTotalPower(appliance)} watts");
            PrintApplianceArray(appliance);

            Console.WriteLine("\nSorted by name array:");
            Array.Sort(appliance);
            PrintApplianceArray(appliance);

            string name = string.Empty;

            while (name == string.Empty || name == null)
            {
                Console.WriteLine("\n\nWhat appliance can I find?");
                name = Console.ReadLine().ToLower();
            }

            try
            {
                Console.WriteLine($"\nWe find \"{name}\":");
                Console.WriteLine(appliance.FindAppliance(name).ToString());
                appliance.FindAppliance(name).TurnOn();
            }
            catch
            {
                Console.WriteLine("I can't find this animal!");
            }
        }

        public static void PrintApplianceArray(AbstractAppliance[] appliances)
        {
            foreach (var item in appliances)
            {
                Console.WriteLine($"{item.Name} ({item.Manufacturer}) - {item.PowerInWatts} watt");
            }
        }
    }
}
