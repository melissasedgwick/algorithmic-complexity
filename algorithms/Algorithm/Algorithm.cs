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
    }
}
