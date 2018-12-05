using System;
using System.Collections.Generic;

namespace timings
{
    public class RandomListsAndArrays
    {

        public static List<int> GetRandomList(int length)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < length; i++)
            {
                Random rand = new Random();
                list.Add(rand.Next(10));
            }
            return list;
        }

        public static int[] GetRandomArray(int length)
        {
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Random rand = new Random();
                array[i] = rand.Next(10);
            }
            return array;
        }
    }
}
