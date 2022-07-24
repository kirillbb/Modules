using System.Text;

namespace FileHierarchy
{
    public static class Explorer
    {
        static string currentPath = "";
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
                        {
                            currentPath = control[1].Replace("\"", "");

                            bool isFile = IsFile(currentPath);
                            bool isDirectory = IsDirectory(currentPath);

                            Console.WriteLine();
                            if (isDirectory)
                            {
                                FindDirectories(currentPath);
                                FindFiles(currentPath);
                            }
                            else if (isFile)
                                OpenReadFile(currentPath);
                            else
                                throw new DirectoryNotFoundException();

                            Logger.AddLogToLogList(control[0], currentPath);
                            break;
                        }
                    case "sort":
                        {
                            currentPath += control[1].Replace("\"", "");
                            //
                            //
                        }
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
        private static void FindFiles(string path)
        {
            string[] files = Directory.GetFiles(path);
            //DateTime timeCreation = File.GetCreationTimeUtc(files[0]);
            //DateTime time = File.GetLastWriteTimeUtc(files[0]);

            PrintItems(files, path);
        }

        private static void FindDirectories(string path)
        {
            string[] directories = Directory.GetDirectories(path);

            PrintItems(directories, path);
        }

        private static void PrintItems(string[] items, string path)
        {
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }

        private static bool IsDirectory(string path) => Directory.Exists(path);

        private static bool IsFile(string path) => File.Exists(path);

        private static bool HasBinaryContent(string content) => content.Any(ch => char.IsControl(ch) && ch != '\r' && ch != '\n' && ch != '\t');

        private static void OpenReadFile(string path)
        {
            string text; // for check //open "C:\Programs\7-Zip\readme.txt"

            using (StreamReader reader = new StreamReader(path))
            {
                text = reader.ReadToEnd();
            }

            text = text.Substring(0, 500);

            if (HasBinaryContent(text))
            {
                text = DecodeBinaryCode(path);
            }

            Console.WriteLine($"File {path} content:");
            Console.WriteLine("\n" + text + "\n");
        }
        
        private static string DecodeBinaryCode(string path)
        {
            string text = ""; // for check //open "C:\Programs\7-Zip\7z.dll"
            byte[] byteArray;

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                fs.Read(byteArray = new byte[4096]);
            }

            text = Encoding.ASCII.GetString(byteArray);
            text = text.Substring(0, 500);
            return text;
        }
    }
}
