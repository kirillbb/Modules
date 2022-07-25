using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHierarchy
{
    public static class Controller
    {

        private static List<DirectoryInfo> directoriesList;
        private static List<FileInfo> filesList;

        static string currentPath = "";
        public static void Control(string command)
        {
            Explorer explorer = new Explorer();

            string[] control = command.Split(' ', 2);

            if (currentPath != "")
                currentPath += "\\";
            try
            {
                switch (control[0])
                {
                    case "open":
                        Open(control, explorer);
                        PrintItems(filesList, directoriesList);
                        Logger.AddLogToLogList(control[0], currentPath);
                        break;
                    case "sort":
                        Open(control, explorer);
                        Sort(control);
                        PrintItems(filesList, directoriesList);
                        break;
                    default:
                        Logger.AddLogToLogList($"Error! Unknown command \"{command}\"", " ");
                        Console.WriteLine($"Error! Unknown command \"{command}\"!");
                        break;
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                Logger.AddLogToLogList($"Error! {ex.Message}", $"{currentPath}");
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Logger.AddLogToLogList($"Error! {ex.Message}", $"{currentPath}");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Logger.AddLogToLogList($"Error! {ex.Message}", $"{currentPath}");
                Console.WriteLine(ex.Message);
            }
        }
        private static void Sort(string[] command)
        {
            switch (command[1])
            {
                case "filename":
                    directoriesList.OrderBy(f => f.Name)
                        .ToList();
                    filesList.OrderBy(f => f.Name)
                        .ToList();
                    break;
                case "created":
                    directoriesList.OrderBy(f => f.CreationTime)
                        .ToList();
                    filesList.OrderBy(f => f.CreationTime)
                        .ToList();
                    break;
                case "modified":
                    directoriesList = directoriesList.OrderBy(f => f.LastWriteTime)
                        .ToList();
                    filesList = filesList.OrderBy(f => f.LastWriteTime)
                        .ToList();
                    break;
                default:
                    Logger.AddLogToLogList($"Error! Unknown command \"{command}\"", " ");
                    Console.WriteLine($"Error! Unknown command \"{command}\"!");
                    break;
            }
        }
        private static void Open(string[] control, Explorer explorer)
        {
            if (control[0] != "sort")
            {
                currentPath = control[1].Replace("\"", "");
            }

            bool isFile = explorer.IsFile(currentPath);
            bool isDirectory = explorer.IsDirectory(currentPath);

            Console.WriteLine();
            if (isDirectory)
            {
                directoriesList = explorer.FindDirectories(currentPath);
                filesList = explorer.FindFiles(currentPath);
            }
            else if (isFile)
                Console.WriteLine($"File {currentPath} content:\n" + explorer.OpenReadFile(currentPath));
            else
                throw new DirectoryNotFoundException();
        }
        private static void PrintItems(List<FileInfo> filesList, List<DirectoryInfo> directoriesList)
        {
            foreach (var item in directoriesList)
            {
                Console.WriteLine(item.ToString());
            }
            foreach (var item in filesList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
