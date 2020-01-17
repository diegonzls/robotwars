using NUnit.Framework;

namespace RobotWars.Core.Test
{
    public class ArenaTest
    {
        [Test]
        public void AddPlayerSuccess()
        {
            // Arrange
            var arena = new Arena(new Grid(new Location(10, 5)));

            // Act
            arena.AddRobot(new Robot(new Location(2, 2), Direction.S));

            // Assert
            Assert.AreEqual(1, arena.Robots.Count);
        }

        [Test]
        public void AddPlayerFail()
        {
            // Arrange
            var arena = new Arena(new Grid(new Location(10, 5)));
            
            // Assert
            Assert.Throws<OutOfArenaException>(
                () => { arena.AddRobot(new Robot(new Location(11, 0), Direction.S)); });
        }
    }
}