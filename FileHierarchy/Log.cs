using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHierarchy
{
    internal class Log
    {
        public string Time { get; set; } = "";
        public string Command { get; set; } = "";
        public string Path { get; set; } = "";
        public override string ToString()
        {
            return $"{Time} : {Command} : {Path}";
        }
    }
}
