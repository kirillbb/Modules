using System.Text;

namespace FileHierarchy
{
    public class Explorer
    {
        public List<FileInfo> FindFiles(string path)
        {
            var defaultSortedFiles = new DirectoryInfo(path).GetFiles()
                                                              .ToList();

            return defaultSortedFiles;
        }

        public List<DirectoryInfo> FindDirectories(string path)
        {
            var defaultSortedDirectories = new DirectoryInfo(path).GetDirectories()
                                                                    .ToList();

            return defaultSortedDirectories;
        }

        public bool IsDirectory(string path) => Directory.Exists(path);

        public bool IsFile(string path) => File.Exists(path);

        private bool HasBinaryContent(string content) => content.Any(ch => char.IsControl(ch) && ch != '\r' && ch != '\n' && ch != '\t');

        public string OpenReadFile(string path)
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

            return text;
        }
        
        private string DecodeBinaryCode(string path)
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
