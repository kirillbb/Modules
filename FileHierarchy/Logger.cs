using System.Xml.Serialization;

namespace FileHierarchy
{
    public class Logger
    {
        private static Logger instance = new();
        private static readonly List<Log> LogList = new();
        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }

                return instance;
            }
        }

        public static void AddLogToLogList(string command, string path)
        {
            DateTime time = DateTime.Now;

            LogList.Add(new Log
            {
                Time = time,
                Command = command,
                Path = path
            });
        }
        public static void SaveLogsToFile()
        {
            //string json = JsonConvert.SerializeObject(LogList.ToArray());
            //using (StreamWriter writer = new(@"logs.json", true))
            //{
            //    writer.WriteLine(json);
            //}

            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Log[]));
                using (FileStream fs = new FileStream("logs.xml", FileMode.OpenOrCreate))
                {
                    Log[] logArr = new Log[LogList.Count];
                    logArr = LogList.ToArray();
                    xmlSerializer.Serialize(fs, logArr);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
