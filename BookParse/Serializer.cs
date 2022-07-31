using Newtonsoft.Json;

namespace BookParse
{
    internal class Serializer
    {
        public void BookSerialize(Book book, string path)
        {
            try
            {
                string json = JsonConvert.SerializeObject(book);

                using (System.IO.StreamWriter writer = new(path, true))
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

            IEnumerable<string>? jsons = File.ReadLines(path);
            foreach (string s in jsons)
            {
                books.Add(JsonConvert.DeserializeObject<Book>(s.ToString()));
            }
            return books;
        }
    }
}