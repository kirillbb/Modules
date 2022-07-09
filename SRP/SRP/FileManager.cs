using Newtonsoft.Json;
using System.IO;

namespace SRP
{
    internal class FileManager
    {
        public void SaveToFile(string fileName, User user)
        {
            File.WriteAllText(fileName, JsonConvert.SerializeObject(user));
        }
    }
}
