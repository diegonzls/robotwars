using System.Collections.Generic;
using System.Linq;

namespace RobotWars.Core
{
    public class Arena
    {
        public IList<Robot> Robots { get; private set; }

        public  Grid _grid;
        
        public Arena(Grid grid)
        {
            _grid = grid;
            Robots = new List<Robot>();
        }
        
        public void AddRobot(Robot robot)
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