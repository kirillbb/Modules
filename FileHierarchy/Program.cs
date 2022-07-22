namespace FileHierarchy
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("C:\\...");
            Console.WriteLine("D:\\...");
            string command;
            do
            {
                Console.WriteLine("Enter a command: (0 to exit)");
                command = Console.ReadLine();
                if (command == "0")
                    break;

                Explorer.Controller(command);
            } while (true);

            Logger.SaveLogsToFile();

            Console.WriteLine();
        }
    }
}