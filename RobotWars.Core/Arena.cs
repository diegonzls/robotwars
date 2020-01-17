using System.Collections.Generic;
using System.Linq;

namespace RobotWars.Core
{
    public class Arena
    {
        public IList<Player> Robots { get; private set; }

        public IGrid _grid;
        
        public Arena(IGrid grid)
        {
            _grid = grid;
            Robots = new List<Player>();
        }
        
        public void AddRobot(Player robot)
        {
            CheckLocation(robot.Location);

            Robots.Add(robot);            
        }
        
        public void MoveRobot()
        {
            var newLocation = this.Robots.Last().Move();

            CheckLocation(newLocation);
        }
        
        public void ChangeDirection(Action action)
        {
            this.Robots.Last().ChangeDirection(action);
        }

        private void CheckLocation(Location location)
        {
            if (!_grid.IsValidLocation(location))
            {
                throw new OutOfArenaException("Player is located outsite the arena.");
            }
        }
    }
}