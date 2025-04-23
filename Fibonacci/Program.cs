using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace FibonacciApp
{
    class Program
    {
        static List<double> FibonacciSequence()
        {
            double limit = Math.Pow(10, 55);
            List<double> Sequence = new List<double>() { 0, 1 };
            while (true)
            {
                Sequence.Add(Sequence[Sequence.Count - 1] + Sequence[Sequence.Count - 2]);
                if (Sequence[Sequence.Count - 1] > limit)
                {
                    break;
                }
            }
            return Sequence;
        }
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            List<double> newSequence = FibonacciSequence();
            foreach (double value in newSequence)
            {
                Console.WriteLine(value);
            }
            stopwatch.Stop();
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds} ms");
            Console.ReadLine(); //Naudojama kad konsole neuzsidarytu ir butu galima paziureti rezultatus
        }
    }
}
