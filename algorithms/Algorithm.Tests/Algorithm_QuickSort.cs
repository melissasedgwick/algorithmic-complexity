using NUnit.Framework;
using System.Collections.Generic;

namespace Algorithm.Tests
{
    [TestFixture]
    public class Algorithm_QuickSort
    {
        private readonly Algorithms _algorithms;

        public Algorithm_QuickSort()
        {
            _algorithms = new Algorithms();
        }

        [Test]
        public void ReturnsSortedList1()
        {
            var result = _algorithms.QuickSort(new List<int> { 1, 3, 11, 2, 7, 5 });

            Assert.AreEqual(new List<int> { 1, 2, 3, 5, 7, 11 }, result);
        }

        [Test]
        public void ReturnsSortedList2()
        {
            var result = _algorithms.QuickSort(new List<int> { 1, 7, 3, 9, 4 });

            Assert.AreEqual(new List<int> { 1, 3, 4, 7, 9 }, result);
        }

        [Test]
        public void ReturnsSortedList3()
        {
            var result = _algorithms.QuickSort(new List<int> { 51, 6, 29, 85, 1000, 7, 4, 360 });

            Assert.AreEqual(new List<int> { 4, 6, 7, 29, 51, 85, 360, 1000 }, result);
        }

    }
}