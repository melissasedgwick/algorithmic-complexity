using NUnit.Framework;
using System.Collections.Generic;

namespace Algorithm.Tests
{
    [TestFixture]
    public class Algorithm_ContainsDuplicates
    {
        private readonly Algorithms _algorithms;

        public Algorithm_ContainsDuplicates()
        {
            _algorithms = new Algorithms();
        }

        [Test]
        public void ReturnsFalseForUniqueIntList()
        {
            var result = _algorithms.Duplicates<int>(new List<int>{1, 2, 3});

            Assert.AreEqual(false, result);
        }

        [Test]
        public void ReturnsFalseForUniqueStringList()
        {
            var result = _algorithms.Duplicates<string>(new List<string> { "should", "be", "false" });

            Assert.AreEqual(false, result);
        }

        [Test]
        public void ReturnsTrueForDuplicateIntList()
        {
            var result = _algorithms.Duplicates<int>(new List<int> { 1, 2, 2, 3 });

            Assert.AreEqual(true, result);
        }

        [Test]
        public void ReturnsTrueForDuplicateStringList()
        {
            var result = _algorithms.Duplicates<string>(new List<string> { "should", "be", "true", "as", "is", "true"});

            Assert.AreEqual(true, result);
        }
    }
}