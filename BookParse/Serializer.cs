using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookParse
{
    internal class Serializer
    {
        public void BookSerialize(Book book)
        {
            try
            {
                string json = JsonConvert.SerializeObject(book);

                using (System.IO.StreamWriter writer = new(@"books.json", true))
                {
                    writer.WriteLine(json);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
