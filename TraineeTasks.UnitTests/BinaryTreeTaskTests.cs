using NUnit.Framework;
using System;

namespace TraineeTasks.UnitTests
{
    public class BinaryTreeTaskTests
    {
        [TestCase(new string[] { "5", "1", "6", "3", "4" }, 10)]
        [TestCase(new string[] { "1", "2", "4", "3", "5", "7", "6", "8" }, 17)]
        [TestCase(new string[] { "5", "1", "6", "3", "4", "7a", "6R", "TT" }, 4)]
        [TestCase(new string[] { "h", "e", "l", "l", "o" }, 0)]
        public void WhenGetLeafSum_ThenReturnLeafSum(string[] nodeValues, int expectedLeafSum)
        {
            // Arrange
            var tasks = new BinaryTreeTasks();

            int leafSum = 0;
            var node = tasks.InitializeTree(nodeValues);

            var actualLeafSum = tasks.GetLeafSum(ref leafSum, node);

            // Assert
            Assert.That(actualLeafSum, Is.EqualTo(expectedLeafSum));
        }

        [TestCase(null)]
        public void WhenIntilializeTree_ThenReturnThrows(string[] nodeValues)
        {
            Assert.That(() => new BinaryTreeTasks().InitializeTree(nodeValues), Throws.TypeOf<ArgumentNullException>());
        }
    }
}
