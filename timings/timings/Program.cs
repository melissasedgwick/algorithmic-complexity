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
            Console.WriteLine("Times to execute:");

            for (int i = 0; i < 10; i++)
            {
                var listOfNumbers = GetRandomList(20000);
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                //METHOD TO TIME HERE

                stopWatch.Stop();
                Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);
            }
        }

        static List<E> ShuffleList<E>(List<E> inputList)
        {
            List<E> randomList = new List<E>();
            Random r = new Random();
            int randomIndex = 0;
            while (inputList.Count > 0)
            {
                randomIndex = r.Next(0, inputList.Count);
                randomList.Add(inputList[randomIndex]);
                inputList.RemoveAt(randomIndex);
            }
            return randomList;
        }
    }
}
