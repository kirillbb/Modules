using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookParse
{
    internal class Parser
    {
        public string[] Parse(string bookInfo)
        {
            char[] delimiterChars = { '-', ',', '(', ')'};

            string[] bookInfoLines = bookInfo.Split(delimiterChars);

            return bookInfoLines;
        }
    }
}
