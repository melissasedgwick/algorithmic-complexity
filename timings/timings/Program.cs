using System;
using System.Diagnostics;

namespace timings
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer();
        }

        static void Timer()
        {
            Console.WriteLine("Times to execute:");

            for (int i = 0; i < 10; i++)
            {
                var listOfNumbers = RandomListsAndArrays.GetRandomList(20000);
                var arrayOfNumbers = RandomListsAndArrays.GetRandomArray(20000);
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                //METHOD TO TIME HERE

                stopWatch.Stop();
                Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);
            }
        }
    }
}
