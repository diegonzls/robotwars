using NUnit.Framework;

namespace RobotWars.Core.Test
{
    class RobotTest
    {        
        [TestCase(Direction.N, Direction.W)]
        [TestCase(Direction.E, Direction.N)]
        [TestCase(Direction.S, Direction.E)]
        [TestCase(Direction.W, Direction.S)]
        public void ChangeDirectionLeftTest(Direction initial, Direction expected)
        {
            // Arrange
            var robot = new Robot(new Location(0, 0), initial);

            // Act
            robot.ChangeDirection(Action.L);

            // Assert
            Assert.AreEqual(expected, robot.Direction);
        }


        [TestCase(Direction.N, Direction.E)]
        [TestCase(Direction.E, Direction.S)]
        [TestCase(Direction.S, Direction.W)]
        [TestCase(Direction.W, Direction.N)]
        public void ChangeDirectionRightTest(Direction initial, Direction expected)
        {
            // Arrange
            var robot = new Robot(new Location(0, 0), initial);

            // Act
            robot.ChangeDirection(Action.R);

            // Assert
            Assert.AreEqual(expected, robot.Direction);
        }
    }
}
