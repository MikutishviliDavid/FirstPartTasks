using NUnit.Framework;
using System;

namespace TraineeTasks.UnitTests
{
    public class StringTaskTests
    {
        [TestCase("Hello World!", "hELLO wORLD!")]
        [TestCase("DeVeLoPeR", "dEvElOpEr")]
        public void WhenChangeLetterCaseInString_ThenReturnStringWithChangedLetterCase(string str, string expected)
        {
            // Arrange
            var tasks = new StringTasks();

            // Act
            var actual = tasks.ChangeLetterCase(str);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("")]
        [TestCase(null)]
        public void WhenChangeLetterCaseInString_ThenReturnThrows(string str)
        {
            Assert.That(() => new StringTasks().ChangeLetterCase(str),
                        Throws.TypeOf<ArgumentException>());
        }

        [TestCase("qwe asdf zxcvb", "ewq fdsa bvcxz")]
        [TestCase("7788", "8877")]
        public void WhenReverseEachWordInString_ThenReturnStringWithReversedWords(string str, string expected)
        {
            // Arrange
            var tasks = new StringTasks();

            // Act
            var actual = tasks.ReverseEachWord(str);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("")]
        [TestCase(null)]
        public void WhenReverseEachWordInString_ThenReturnThrows(string str)
        {
            Assert.That(() => new StringTasks().ChangeLetterCase(str),
                        Throws.TypeOf<ArgumentException>());
        }

        [TestCase("aSSa sdadda ffffff 123454321", "123454321")]
        [TestCase("abba peeweep", "peeweep")]
        public void WhenFindLongestPalindromeSubstring_ThenReturnThisSubstring(string str, string expected)
        {
            // Arrange
            var tasks = new StringTasks();

            // Act
            var actual = tasks.FindLongestPalindrome(str);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("")]
        [TestCase(null)]
        public void WhenFindLongestPalindromeSubstring_ThenReturnThrows(string str)
        {
            Assert.That(() => new StringTasks().ChangeLetterCase(str),
                        Throws.TypeOf<ArgumentException>());
        }

        [TestCase("/once/upon/a/time", "/", 4)]
        [TestCase("/once/upon/a/time", "on", 2)]
        [TestCase("H e ll o", " ", 3)]
        public void WhenFindSubstring_ThenReturnCountTheseSubstrings(string str, string substr, int expected)
        {
            // Act
            var actual = str.GetNumberOfOccurrences(substr);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("H e ll o", "")]
        [TestCase("234", null)]
        public void WhenFindSubstring_ThenReturnThrows(string str, string substr)
        {
            Assert.That(() => str.GetNumberOfOccurrences(substr), Throws.TypeOf<ArgumentException>());
        }
    }
}
