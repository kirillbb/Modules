using System.Diagnostics;
namespace Threads
{
    class Program
    {
        public static decimal sum = 0;
        private readonly static object sumLock = new ();
        static void Main(string[] args)
        {
            Random randomNumber = new Random();

            decimal[] array = Enumerable.Range(0, 1000000).Select(_ => (decimal)randomNumber.NextDouble()).ToArray();
            
            var sw = Stopwatch.StartNew();

            //default 25 - 32
            //best 7 - 8

            Thread thread1 = new Thread(() => SumResult(0, array.Length / 4, array));
            Thread thread2 = new Thread(() => SumResult(array.Length / 4, array.Length / 2, array));
            Thread thread3 = new Thread(() => SumResult(array.Length / 2, array.Length - array.Length / 4, array));
            Thread thread4 = new Thread(() => SumResult(array.Length - array.Length / 4, array.Length, array));

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();
            thread4.Join();

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.WriteLine(sum);
        }

        private static void SumResult(int startIndex, int endIndex, decimal[] array)
        {
            decimal result = 0;
            for (int i = startIndex; i < endIndex; i++)
            {
                result += array[i];
            }

            lock (sumLock)
            {
                sum += result;
            }
        }
    }
}


