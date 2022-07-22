using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHierarchy
{
    public static class Explorer
    {
        static string currentPath = "";
        public static void FindFiles(string path)
        {
            string[] files = Directory.GetFiles(path);
            
            PrintItems(files, path);
        }

        public static void FindDirectories(string path)
        {
            string[] directories = Directory.GetDirectories(path);

            PrintItems(directories, path);
        }

        public static void PrintItems(string[] items, string path)
        {
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsDirectory(string path)
        {
            return Directory.Exists(path);
        }

        public static bool IsFile(string path)
        {
            return File.Exists(path);
        }

        public static void Controller()
        {
            Console.WriteLine("Enter a command:");
            string command = Console.ReadLine();

            string[] control = command.Split(' ');

            if (currentPath != "")
                currentPath += "\\";

            try
            {
                currentPath += control[1].Replace("\"", "");

                switch (control[0])
                {
                    case "open":

                        Console.WriteLine();
                        if (IsDirectory(currentPath))
                        {
                            FindDirectories(currentPath);
                            FindFiles(currentPath);
                            break;
                        }
                        else if (IsFile(currentPath))
                        {
                            OpenReadFile(currentPath);
                            break;
                        }

                        break;
                    case "sort":
                        //
                        //
                        break;
                    default:
                        Console.WriteLine("Unknown command \"{0}\" !", command);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nError! Incorrect command! Try again:\n");
            }
        }

        private static void OpenReadFile(string path)
        {
            string text;

            using (StreamReader reader = new StreamReader(path))
            {
                text = reader.ReadToEnd();
                text = text.Substring(0, 500);
            }

            Console.WriteLine("\n" + text + "\n");
        }
    }
}
