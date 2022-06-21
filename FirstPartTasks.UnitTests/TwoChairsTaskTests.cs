using NUnit.Framework;

namespace FirstPartTasks.UnitTests
{
    public class TwoChairsTaskTests
    {
        [TestCase(2657857, "1010001000101000000000")]
        [TestCase(255, "10101010")]
        [TestCase(-1, "The number must be greater than zero")]
        public void WhenChangeEvenBitsToZero_ThenReturnStringWithEvenBitsAsZero(int number, string expected)
        {
            // Arrange
            var tasks = new TwoChairsTasks();

            // Act
            var actual = tasks.ChangeEvenBitsToZero(number);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(255, 8)]
        [TestCase(10, 2)]
        [TestCase(-25, -1)]
        public void WhenFindCountBitsEqualOne_ThenReturnCountBitsEqualOne(int number, int expected)
        {
            // Arrange
            var tasks = new TwoChairsTasks();

            // Act
            var actual = tasks.FindCountBitsEqualOne(number);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("Hello World!", "hELLO wORLD!")]
        [TestCase("DeVeLoPeR", "dEvElOpEr")]
        [TestCase("", "The string must not be Null or Empty")]
        [TestCase(null, "The string must not be Null or Empty")]
        public void WhenChangeLetterCaseInString_ThenReturnStringWithChangedLetterCase(string str, string expected)
        {
            // Arrange
            var tasks = new TwoChairsTasks();

            // Act
            var actual = tasks.ChangeLetterCase(str);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("qwe asdf zxcvb", "ewq fdsa bvcxz")]
        [TestCase("7788", "8877")]
        [TestCase("", "The string must not be Null or Empty")]
        [TestCase(null, "The string must not be Null or Empty")]
        public void WhenReverseEachWordInString_ThenReturnStringWithReversedWords(string str, string expected)
        {
            // Arrange
            var tasks = new TwoChairsTasks();

            // Act
            var actual = tasks.ReverseEachWord(str);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("aSSa sdadda ffffff 123454321", "123454321")]
        [TestCase("abba peeweep", "peeweep")]
        [TestCase("", "The string must not be Null or Empty")]
        [TestCase(null, "The string must not be Null or Empty")]
        public void WhenFindLongestPalindromeSubstring_ThenReturnThisSubstring(string str, string expected)
        {
            // Arrange
            var tasks = new TwoChairsTasks();

            // Act
            var actual = tasks.FindLongestPalindrome(str);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}