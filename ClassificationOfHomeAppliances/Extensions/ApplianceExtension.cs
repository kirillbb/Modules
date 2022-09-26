namespace Module2HW6
{
    public static class ApplianceExtension
    {
        public static AbstractAppliance FindAppliance(this AbstractAppliance[] appliances, string name)
        {
            if (name != null)
            {
                for (int i = 0; i < appliances.Length; i++)
                {
                    if (appliances[i].Name == name)
                    {
                        return appliances[i];
                    }
                }
            }

            return null;
        }
    }
}
