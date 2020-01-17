using NUnit.Framework;
using System.Linq;

namespace RobotWars.Core.Test
{
    /// <summary>
    ///  Testing the two scenarios for OpenTable Test.
    /// </summary>
    class OpenTableExpectedTest
    {
        /// <summary>
        //  Input 5 5
        //  1 2 N
        //  LMLMLMLMM
        //  Excpedted --> 1 3 N
        /// </summary>
        [Test]
        public void Robot1()
        {
            // Arrange
            var arena = new Arena(new Grid(new Location(5, 5)));
            arena.AddRobot(new Robot(new Location(1, 2), Direction.N));

            // Act
            arena.ChangeDirection(Action.L);
            arena.MoveRobot();
            arena.ChangeDirection(Action.L);
            arena.MoveRobot();
            arena.ChangeDirection(Action.L);
            arena.MoveRobot();
            arena.ChangeDirection(Action.L);
            arena.MoveRobot();
            arena.MoveRobot();
            
            // Assert
            Assert.AreEqual(1, arena.Robots.Last().Location.X);
            Assert.AreEqual(3, arena.Robots.Last().Location.Y);
            Assert.AreEqual(Direction.N, arena.Robots.Last().Direction);
        }


        /// <summary>
        //  Input 5 5
        //  3 3 E
        //  MMRMMRMRRM
        //  Excpedted --> 5 1 E
        /// </summary>
        [Test]
        public void Robot2()
        {
            // Arrange
            var arena = new Arena(new Grid(new Location(5, 5)));
            arena.AddRobot(new Robot(new Location(3, 3), Direction.E));

            // Act
            arena.MoveRobot();
            arena.MoveRobot();
            arena.ChangeDirection(Action.R);
            arena.MoveRobot();
            arena.MoveRobot();
            arena.ChangeDirection(Action.R);
            arena.MoveRobot();
            arena.ChangeDirection(Action.R);
            arena.ChangeDirection(Action.R);
            arena.MoveRobot();

            // Assert
            Assert.AreEqual(5, arena.Robots.Last().Location.X);
            Assert.AreEqual(1, arena.Robots.Last().Location.Y);
            Assert.AreEqual(Direction.E, arena.Robots.Last().Direction);
        }
    }
}
