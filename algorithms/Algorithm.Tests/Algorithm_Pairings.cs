using NUnit.Framework;
using System.Collections.Generic;
using System;

namespace Algorithm.Tests
{
    [TestFixture]
    public class Algorithm_Pairings
    {
        private readonly Algorithms _algorithms;

        public Algorithm_Pairings()
        {
            _algorithms = new Algorithms();
        }

        [Test]
        public void ReturnsListOfPairings()
        {
            var result = _algorithms.Pairing(new List<string> { "Bill", "Bob", "Ben"});
            var expected = new List<string[]> { new[] { "Bill", "Bob" },
                new[] { "Bill", "Ben"}, new[] { "Bob", "Ben"} };

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ReturnsListOfPairings2()
        {
            var result = _algorithms.Pairing(new List<string> { "Harry", "Hermione",
                "Ron", "Ginny"});
            var expected = new List<string[]> { new[] { "Harry", "Hermione" },
                new[] { "Harry", "Ron" }, new[] { "Harry", "Ginny" },
                new[] { "Hermione", "Ron" }, new[] { "Hermione", "Ginny" },
                new[] { "Ron", "Ginny" } };

            Assert.AreEqual(expected, result);
        }

    }
}