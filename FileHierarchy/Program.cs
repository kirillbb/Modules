namespace FileHierarchy
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("C:\\...");
            Console.WriteLine("D:\\...");
            do
            {
                Explorer.Controller();
            } while (true);

            Console.WriteLine();
        }
    }
}