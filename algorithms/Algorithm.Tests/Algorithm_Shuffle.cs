using System;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace Algorithm.Tests
{
    [TestFixture]
    public class Algorithm_Shuffle
    {
        private readonly Algorithms _algorithms;

        public Algorithm_Shuffle()
        {
            _algorithms = new Algorithms();
        }

        [Test]
        public void ReturnsArrayOfSameLength()
        {
            var result = _algorithms.ShuffleArray(new[] { 1, 2, 3, 4 });

            Assert.AreEqual(4, result.Length);
        }

        [Test]
        public void ReturnsSameStringsInArray()
        {
            var result = _algorithms.ShuffleArray(new[] { "testing", "the", "shuffle" });

            Assert.AreEqual(true, result.Contains("testing"));
            Assert.AreEqual(true, result.Contains("the"));
            Assert.AreEqual(true, result.Contains("shuffle"));
        }
    }
}