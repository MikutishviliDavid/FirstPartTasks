using NUnit.Framework;
using System;

namespace TraineeTasks.UnitTests
{
    public class StringExtensionTests
    {
        [TestCase("/once/upon/a/time", "/", 4)]
        [TestCase("/once/upon/a/time", "on", 2)]
        [TestCase("H e ll o", " ", 3)]
        public void WhenFindSubstring_ThenReturnCountTheseSubstrings(string str, string substr, int expected)
        {
            var actual = str.GetNumberOfOccurrences(substr);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("H e ll o", "")]
        [TestCase("234", null)]
        public void WhenFindSubstring_ThenReturnThrows(string str, string substr)
        {
            Assert.Throws<ArgumentException>(() => str.GetNumberOfOccurrences(substr));
        }
    }
}
