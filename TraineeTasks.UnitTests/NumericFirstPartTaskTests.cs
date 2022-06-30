using NUnit.Framework;
using System;

namespace TraineeTasks.UnitTests
{
    public class NumericFirstPartTaskTests
    {
        [TestCase(2657857, "1010001000101000000000")]
        [TestCase(255, "10101010")]
        public void WhenChangeEvenBitsToZero_ThenReturnStringWithEvenBitsAsZero(int number, string expected)
        {
            // Arrange
            var tasks = new NumericFirstPartTasks();

            // Act
            var actual = tasks.ChangeEvenBitsToZero(number);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(-5)]
        public void WhenChangeEvenBitsToZero_ThenReturnThrows(int number)
        {
            Assert.That(() => new NumericFirstPartTasks().ChangeEvenBitsToZero(number),
                        Throws.TypeOf<ArgumentException>());
        }

        [TestCase(255, 8)]
        [TestCase(10, 2)]
        public void WhenFindCountBitsEqualOne_ThenReturnCountBitsEqualOne(int number, int expected)
        {
            // Arrange
            var tasks = new NumericFirstPartTasks();

            // Act
            var actual = tasks.FindCountBitsEqualOne(number);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(-10)]
        public void WhenFindCountBitsEqualOne_ThenReturnThrows(int number)
        {
            Assert.That(() => new NumericFirstPartTasks().FindCountBitsEqualOne(number),
                        Throws.TypeOf<ArgumentException>());
        }
    }
}
