using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHierarchy
{
    internal class Logger
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
            string now = DateTime.Now.ToLongTimeString();

            LogList.Add(new Log
            {
                Time = now,
                Command = command,
                Path = path
            });
        }
        public static void SaveLogsToFile()
        {
            StringBuilder logString = new(string.Empty);
            for (int i = 0; i < LogList.Count; i++)
            {
                logString.AppendLine(LogList[i].ToString());
            }

            File.WriteAllText("log.txt", logString.ToString());
        }
    }
}
