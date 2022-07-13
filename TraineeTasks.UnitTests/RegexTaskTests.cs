using NUnit.Framework;
using System;

namespace TraineeTasks.UnitTests
{
    public class RegexTaskTests
    {
#pragma warning disable NUnit1001 // The individual arguments provided by a TestCaseAttribute must match the type of the corresponding parameter of the method
        [TestCase("aahhuaa aahaa aahuuaa dggd ahuhu", new string[] { "aahhuaa", "aahaa", "ahuhu" })]
        [TestCase("aahHUaa aaHaa aahuuaa dggd", new string[] { "aahHUaa", "aaHaa" })]
        [TestCase("dggd", new string[] { })]
#pragma warning restore NUnit1001 // The individual arguments provided by a TestCaseAttribute must match the type of the corresponding parameter of the method
        public void WhenFindWords_ThenReturnTheseWords(string str, string[] expected)
        {
            // Arrange
            var tasks = new RegexTasks();

            // Act
            var actual = tasks.FindWords(str);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("")]
        [TestCase(null)]
        public void WhenFindWords_ThenReturnThrows(string str)
        {
            Assert.That(() => new RegexTasks().FindWords(str), Throws.TypeOf<ArgumentException>());
        }

        [TestCase("+375 25 555 55 55", true)]
        [TestCase("+375 44 444 44 44", true)]
        [TestCase("+375 (44) 444-44-44", false)]
        [TestCase("+375 25 555 55 558", false)]
        public void WhenValidateBelarusianPhoneNumber_ThenReturnThisNumber(string phoneNumber, bool expected)
        {
            // Arrange
            var tasks = new RegexTasks();

            // Act
            var actual = tasks.ValidateBelarusianPhoneNumber(phoneNumber);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("")]
        [TestCase(null)]
        public void WhenValidateBelarusianPhoneNumber_ThenReturnThrows(string phoneNumber)
        {
            Assert.That(() => new RegexTasks().ValidateBelarusianPhoneNumber(phoneNumber), Throws.TypeOf<ArgumentException>());
        }

        [TestCase("https://metanit.com", true)]
        [TestCase("http://docs.microsoft.us", true)]
        [TestCase("https://docs.microsoft.ru", false)]
        public void WhenValidateURL_ThenReturnThisURL(string url, bool expected)
        {
            // Arrange
            var tasks = new RegexTasks();

            // Act
            var actual = tasks.ValidateURL(url);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("")]
        [TestCase(null)]
        public void WhenValidateURL_ThenReturnThrows(string phoneNumber)
        {
            Assert.That(() => new RegexTasks().ValidateURL(phoneNumber), Throws.TypeOf<ArgumentException>());
        }
    }
}
