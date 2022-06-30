using NUnit.Framework;
using System;

namespace TraineeTasks.UnitTests
{
    public class RegexTasksTests
    {
        [TestCase("aahhuaa aahaa aahuuaa dggd ahuhu ahuhuuu", "aahhuaa, aahaa, ahuhu")]
        [TestCase("aahHUaa aaHaa aahuuaa dggd", "aahHUaa, aaHaa")]
        [TestCase("dggd", "There are no matches")]
        public void WhenFindWords_ThenReturnTheseWords(string str, string expected)
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

        [TestCase("+375 25 555 55 55", "+375 25 555 55 55")]
        [TestCase("+375 44 444 44 44", "+375 44 444 44 44")]
        [TestCase("+375 (44) 444-44-44", "It is not valid phone number")]
        [TestCase("+375 25 555 55 558", "It is not valid phone number")]
        public void WhenValidateBelarusianPhoneNumber_ThenReturnThisNumber(string phoneNumber, string expectedNumber)
        {
            // Arrange
            var tasks = new RegexTasks();

            // Act
            var actual = tasks.ValidateBelarusianPhoneNumber(phoneNumber);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedNumber));
        }

        [TestCase("")]
        [TestCase(null)]
        public void WhenValidateBelarusianPhoneNumber_ThenReturnThrows(string phoneNumber)
        {
            Assert.That(() => new RegexTasks().ValidateBelarusianPhoneNumber(phoneNumber), Throws.TypeOf<ArgumentException>());
        }

        [TestCase("https://metanit.com", "https://metanit.com")]
        [TestCase("http://docs.microsoft.us", "http://docs.microsoft.us")]
        [TestCase("https://docs.microsoft.ru", "It is not valid url")]
        public void WhenValidateURL_ThenReturnThisURL(string url, string expectedUrl)
        {
            // Arrange
            var tasks = new RegexTasks();

            // Act
            var actual = tasks.ValidateURL(url);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedUrl));
        }

        [TestCase("")]
        [TestCase(null)]
        public void WhenValidateURL_ThenReturnThrows(string phoneNumber)
        {
            Assert.That(() => new RegexTasks().ValidateURL(phoneNumber), Throws.TypeOf<ArgumentException>());
        }
    }
}
