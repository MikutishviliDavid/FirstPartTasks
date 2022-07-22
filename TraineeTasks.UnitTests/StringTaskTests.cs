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
            var tasks = new StringTasks();

            var actual = tasks.ChangeLetterCase(str);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("")]
        [TestCase(null)]
        public void WhenChangeLetterCaseInString_ThenReturnThrows(string str)
        {
            var tasks = new StringTasks();

            Assert.Throws<ArgumentException>(() => tasks.ChangeLetterCase(str));
        }

        [TestCase("qwe asdf zxcvb", "ewq fdsa bvcxz")]
        [TestCase("7788", "8877")]
        public void WhenReverseEachWordInString_ThenReturnStringWithReversedWords(string str, string expected)
        {
            var tasks = new StringTasks();

            var actual = tasks.ReverseEachWord(str);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("")]
        [TestCase(null)]
        public void WhenReverseEachWordInString_ThenReturnThrows(string str)
        {
            var tasks = new StringTasks();

            Assert.Throws<ArgumentException>(() => tasks.ReverseEachWord(str));
        }

        [TestCase("aSSa sdadda ffffff 123454321", "123454321")]
        [TestCase("abba peeweep", "peeweep")]
        public void WhenFindLongestPalindromeSubstring_ThenReturnThisSubstring(string str, string expected)
        {
            var tasks = new StringTasks();

            var actual = tasks.FindLongestPalindrome(str);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("")]
        [TestCase(null)]
        public void WhenFindLongestPalindromeSubstring_ThenReturnThrows(string str)
        {
            var tasks = new StringTasks();

            Assert.Throws<ArgumentException>(() => tasks.FindLongestPalindrome(str));
        }
    }
}
