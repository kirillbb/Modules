using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW1
{
    public class Log
    {
        public string Time { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
        public override string ToString()
        {
            return $"{Time} : {Type} : {Message}";
        }
    }
}
