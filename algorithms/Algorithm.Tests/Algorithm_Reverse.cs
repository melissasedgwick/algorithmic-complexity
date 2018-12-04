using NUnit.Framework;
using System.Collections.Generic;

namespace Algorithm.Tests
{
    [TestFixture]
    public class Algorithm_Reverse
    {
        private readonly Algorithms _algorithms;

        public Algorithm_Reverse()
        {
            _algorithms = new Algorithms();
        }

        [Test]
        public void ReturnsReversedArray1()
        {
            var result = _algorithms.Reverse(new [] {1, 2, 3});

            Assert.AreEqual(new [] {3, 2, 1}, result);
        }

        [Test]
        public void ReturnsReversedArray2()
        {
            var result = _algorithms.Reverse(new[] { 1, 7, 3, 9, 4 });

            Assert.AreEqual(new[] { 4, 9, 3, 7, 1 }, result);
        }

    }
}