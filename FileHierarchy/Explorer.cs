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

        public static void Controller(string command)
        {
            string[] control = command.Split(' ');

            if (currentPath != "")
                currentPath += "\\";

            

            try
            {
                switch (control[0])
                {
                    case "open":
                        currentPath += control[1].Replace("\"", "");

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

                        Logger.AddLogToLogList(control[0], control[1]);

                        break;
                    case "sort":
                        currentPath += control[1].Replace("\"", "");
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

            if (HasBinaryContent(text))
            {
                text = DecodeBinaryCode(path);
            }

            Console.WriteLine("\n" + text + "\n");
        }
        private static bool HasBinaryContent(string content)
        {
            return content.Any(ch => char.IsControl(ch) && ch != '\r' && ch != '\n' && ch != '\t');
        }

        private static string DecodeBinaryCode(string path)
        {
            string text = "";

            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                text = reader.ReadString();
            }
            byte[] byteArray = Encoding.ASCII.GetBytes(text); ////open "C:\Programs\7-Zip\7z.dll"
            text = Encoding.ASCII.GetString(byteArray);

            return text;
        }
    }
}
