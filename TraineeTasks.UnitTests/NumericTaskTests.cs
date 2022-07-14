using NUnit.Framework;
using System;

namespace TraineeTasks.UnitTests
{
    public class NumericTaskTests
    {
        [TestCase(2657857, 2656768)]
        [TestCase(255, 170)]
        public void WhenChangeEvenBitsToZero_ThenReturnStringWithEvenBitsAsZero(int number, int expected)
        {
            var tasks = new NumericTasks();

            var actual = tasks.ChangeEvenBitsToZero(number);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(-5)]
        public void WhenChangeEvenBitsToZero_ThenReturnThrows(int number)
        {
            var tasks = new NumericTasks();

            Assert.Throws<ArgumentException>(() => tasks.ChangeEvenBitsToZero(number));
        }

        [TestCase(255, 8)]
        [TestCase(10, 2)]
        public void WhenFindCountBitsEqualOne_ThenReturnCountBitsEqualOne(int number, int expected)
        {
            var tasks = new NumericTasks();

            var actual = tasks.FindCountBitsEqualOne(number);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(-10)]
        public void WhenFindCountBitsEqualOne_ThenReturnThrows(int number)
        {
            var tasks = new NumericTasks();

            Assert.Throws<ArgumentException>(() => tasks.FindCountBitsEqualOne(number));
        }
    }
}
