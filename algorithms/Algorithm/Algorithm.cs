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

        public List<int> SelectionSort(List<int> unsortedList)
        {
            List<int> sortedList = new List<int>();

            while (unsortedList.Count > 0)
            {
                int minValue = unsortedList[0];

                foreach (var num in unsortedList)
                {
                    if (num < minValue)
                    {
                        minValue = num;
                    }
                }
                sortedList.Add(minValue);
                unsortedList.Remove(minValue);
            }
            return sortedList;
        }

        public List<int> QuickSort(List<int> list)
        {
            if (list.Count <= 1)
            {
                return list;
            }
            else
            {
                int pivot = list[0];
                List<int> l1 = Partition(list, pivot)[0];
                List<int> l2 = Partition(list, pivot)[1];

                List<int> sortedl1 = QuickSort(l1);
                List<int> sortedl2 = QuickSort(l2);

                sortedl1.Add(pivot);
                sortedl1.AddRange(sortedl2);

                return sortedl1;
            }
        }

        public static List<List<int>> Partition(List<int> list, int pivot)
        {
            List<int> l1 = new List<int>();
            List<int> l2 = new List<int>();

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < pivot)
                {
                    l1.Add(list[i]);
                }
                else
                {
                    l2.Add(list[i]);
                }
            }

            return  new List<List<int>> { l1, l2 };
        }
    }
}
