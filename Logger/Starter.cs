using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW1
{
    public class Starter
    {
        public static void Run()
        {
            Random random = new ();

            for (int i = 0; i < 100; i++)
            {
                int action = random.Next(1, 4);

                switch (action)
                {
                    case 1:
                        Actions.InfoMethod();
                        break;
                    case 2:
                        Actions.WarningMethod();
                        break;
                    case 3:
                        Actions.ErrorMethod();
                        break;
                }
            }

            Logger.SaveLogsToFile();
        }
    }
}
