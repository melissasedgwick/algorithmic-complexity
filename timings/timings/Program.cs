using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace timings
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer();
        }

        static List<int> GetRandomList(int length)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < length; i++)
            {
                Random rand = new Random();
                list.Add(rand.Next(10));
            }

            return list;
        }

        static void Timer()
        {
            List<double> list = new List<double>();

            for (int i = 0; i < 10; i++)
            {
                var listOfNumbers = GetRandomList(10000);

                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                //METHOD HERE

                stopWatch.Stop();
                list.Add(stopWatch.Elapsed.TotalMilliseconds);
            }

            Console.WriteLine("Times to execute:");

            foreach (var time in list)
            {
                Console.WriteLine("{0}ms", time);
            }
        }
    }
}
