using System.Diagnostics;

namespace ReactionTimeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Luodaan uusi random-olio
            Random random = new Random();
            // Asettaa satunnaisen ajan 1-5 sekuntia.
            int sleepTime = random.Next(1000, 5000); 
            // Odottaa satunnaisen ajan 1-5 sekuntia.
            Thread.Sleep(sleepTime);

            // Aloittaa ajanoton.
            Stopwatch stopwatch = Stopwatch.StartNew();
            //Lopettaa ajanoton
            stopwatch.Stop();
            //Otetaan talteen reaktioaika
            double reactionTime = stopwatch.Elapsed.TotalMilliseconds;
        }
    }
}