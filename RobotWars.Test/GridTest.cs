using NUnit.Framework;

namespace RobotWars.Core.Test
{
    public class GridTest
    {
        [TestCase(0, 5)]
        [TestCase(1, 4)]
        [TestCase(2, 3)]
        [TestCase(3, 2)]
        [TestCase(4, 0)]
        [TestCase(5, 1)]
        [TestCase(6, 2)]
        [TestCase(8, 5)]
        [TestCase(0, 0)]
        public void IsValidCoordinateTrue(int x, int y)
        {
            // Arrange
            var grid = new Grid(new Location(8, 5));

            // Act
            var result = grid.IsValidLocation(new Location(x, y));

            // Assert
            Assert.IsTrue(result);
        }

        [TestCase(0, 9)]
        [TestCase(11, 4)]
        [TestCase(11, 4)]
        [TestCase(2, 15)]
        public void IsValidCoordinateFalse(int x, int y)
        {
            // Arrange
            var grid = new Grid(new Location(10, 8));

            // Act
            var result = grid.IsValidLocation(new Location(x, y));

            // Assert
            Assert.IsFalse(result);
        }
    }
}