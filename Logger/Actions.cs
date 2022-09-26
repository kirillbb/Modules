using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW1
{
    public static class Actions
    {
        public static Result InfoMethod()
        {
            string message = "Start method: \t\t\tInfoMethod ";
            Logger.WriteLog(Logger.LogType.Info, message);

            return new Result(true, message);
        }

        public static Result WarningMethod()
        {
            string message = "Skipped logic in method: \t\tWarningMethod";
            Logger.WriteLog(Logger.LogType.Warning, message);

            return new Result(true, message);
        }

        public static Result ErrorMethod()
        {
            string message = "I broke a logic..";

            Logger.WriteLog(Logger.LogType.Error, $"Action failed by a reason: \t{message}");

            return new Result(false, message);
        }
    }
}
