using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class Algorithms
    {
        public bool Duplicates<T>(List<T> list)
        {
            var uniqueItems = new List<T>();

            foreach (var item in list)
            {
                if (uniqueItems.Contains(item)) { return true; }
                uniqueItems.Add(item);
            }

            return false;
        }

        public int[] Reverse(int[] array)
        {
            int[] result = new int[array.Length];

            int n = array.Length - 1;

            for (int i = 0; i < array.Length; i++)
            {
                result[n] = array[i];
                n--;
            }
            return result;
        }
    }
}
