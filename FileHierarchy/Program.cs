namespace FileHierarchy
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("________________________________________________________________________________________");
            Console.WriteLine("C:\\...");
            Console.WriteLine("D:\\...");
            string command;

            do
            {
                Console.WriteLine("________________________________________________________________________________________");
                Console.WriteLine("\nEnter a command: (example: <<open \"c:\\\\programs\">>  *Enter \"close\" to exit)");
                Console.WriteLine(". . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ");
                command = Console.ReadLine();

                if (command == "close")
                    break;

                Explorer.Controller(command);
            } while (true);

            Logger.SaveLogsToFile();
        }
    }
}