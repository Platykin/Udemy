using System.Diagnostics.Metrics;
using System.Diagnostics;

namespace Do_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Stopwatch timer = new Stopwatch();
            timer.Start();
            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter < 5);
            timer.Stop();

            long timerMS = timer.ElapsedMilliseconds;
            Console.WriteLine("O tempo percorrido foi de {0}ms", timerMS);

        }
    }
}