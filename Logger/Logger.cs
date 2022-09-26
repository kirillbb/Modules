using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW1
{
    public partial class Logger
    {
        private static Logger instance = new ();
        private static readonly List<Log> LogList = new ();

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

        public static void WriteLog(LogType type, string logMesage)
        {
            string logType = FormatLogTypeText((LogType)type);

            string now = DateTime.Now.ToLongTimeString();

            string logString = $"{now} : {logType} : {logMesage}";
            Console.WriteLine(logString);

            AddLogsToLogList(now, logType, logMesage);
        }

        public static void AddLogsToLogList(string now, string logType, string message)
        {
            LogList.Add(new Log
            {
                Time = now, Type = logType, Message = message
            });
        }

        public static void SaveLogsToFile()
        {
            StringBuilder logString = new (string.Empty);
            for (int i = 0; i < LogList.Count; i++)
            {
                logString.AppendLine(LogList[i].ToString());
            }

            File.WriteAllText("log.txt", logString.ToString());
        }

        private static string FormatLogTypeText(LogType type)
        {
            return type switch
            {
                LogType.Error => type.ToString() + "  ",
                LogType.Info => type.ToString() + "   ",
                LogType.Warning => type.ToString(),
                _ => null,
            };
        }
    }
}
