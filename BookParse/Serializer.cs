using Newtonsoft.Json;

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
        public List<Book> BookDeserialize(string path)
        {
            List<Book> books = new List<Book>();

            //string json = File.ReadAllText(path);

            //books = JsonConvert.DeserializeObject<List<Book>>(json);

            IEnumerable<string>? jsons = File.ReadLines(path);
            foreach (string s in jsons)
            {
                books.Add(JsonConvert.DeserializeObject<Book>(s.ToString()));
            }
            return books;
        }
    }
}