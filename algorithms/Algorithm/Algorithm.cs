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

        public T[] ShuffleArray<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Random rand = new Random();
                int positionOne = rand.Next(array.Length);
                int positionTwo = rand.Next(array.Length);

                var temp = array[positionOne];
                array[positionOne] = array[positionTwo];
                array[positionTwo] = temp;
            }
            return array;
        }

        public List<Array> Pairing(List<string> students)
        {
            List<Array> pairings = new List<Array>();

            for (int i = 0; i < students.Count; i++)
            {
                var studentOne = students[i];

                for (int j = i + 1; j < students.Count; j++)
                {
                    var studentTwo = students[j];
                    string[] pairing = new string[] { studentOne, studentTwo };
                    pairings.Add(pairing);
                }
            }
            return pairings;
        }
    }
}
