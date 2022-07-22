using NUnit.Framework;
using System;

namespace TraineeTasks.UnitTests
{
    public class RegexTaskTests
    {
#pragma warning disable NUnit1001 // The individual arguments provided by a TestCaseAttribute must match the type of the corresponding parameter of the method
        [TestCase("aahhuaa aahaa aahuuaa dggd ahuhu", new string[] { "aahhuaa", "aahaa", "ahuhu" })]
        [TestCase("aahhuaa aahaa aahuuaa dggd", new string[] { "aahhuaa", "aahaa" })]
        [TestCase("dggd", new string[] { })]
#pragma warning restore NUnit1001 // The individual arguments provided by a TestCaseAttribute must match the type of the corresponding parameter of the method
        public void WhenFindWords_ThenReturnTheseWords(string str, string[] expected)
        {
            var tasks = new RegexTasks();

            var actual = tasks.FindWords(str);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("")]
        [TestCase(null)]
        public void WhenFindWords_ThenReturnThrows(string str)
        {
            var tasks = new RegexTasks();

            Assert.Throws<ArgumentException>(() => tasks.FindWords(str));
        }

        [TestCase("+375 25 555 55 55", true)]
        [TestCase("+375 44 444 44 44", true)]
        [TestCase("+375 (44) 444-44-44", false)]
        [TestCase("+375 25 555 55 558", false)]
        public void WhenValidateBelarusianPhoneNumber_ThenReturnThisNumber(string phoneNumber, bool expected)
        {
            var tasks = new RegexTasks();

            var actual = tasks.ValidateBelarusianPhoneNumber(phoneNumber);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("")]
        [TestCase(null)]
        public void WhenValidateBelarusianPhoneNumber_ThenReturnThrows(string phoneNumber)
        {
            var tasks = new RegexTasks();

            Assert.Throws<ArgumentException>(() => tasks.ValidateBelarusianPhoneNumber(phoneNumber));
        }

        [TestCase("https://metanit.com", true)]
        [TestCase("http://docs.microsoft.us", true)]
        [TestCase("https://docs.microsoft.ru", false)]
        public void WhenValidateURL_ThenReturnThisURL(string url, bool expected)
        {
            var tasks = new RegexTasks();

            var actual = tasks.ValidateUrl(url);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("")]
        [TestCase(null)]
        public void WhenValidateURL_ThenReturnThrows(string url)
        {
            var tasks = new RegexTasks();

            Assert.Throws<ArgumentException>(() => tasks.ValidateUrl(url));
        }
    }
}
