using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW1
{
    public class Result
    {
        public Result(bool status, string error)
        {
            Status = status;
            Error = error;
        }

        public bool Status { get; private set; }
        public string Error { get; set; }
    }
}
