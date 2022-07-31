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

                //CryptoAes aes = new CryptoAes();
                //byte[] crypted = aes.Create(json);

                //using var writer = new BinaryWriter(File.OpenWrite(@"books.json"));
                //writer.Write(crypted);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}