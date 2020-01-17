namespace RobotWars.Core
{
    public class Robot
    {
        public Location Location { get; private set; }

        public Direction Direction { get; private set; }

        public Robot(Location location, Direction direction)
        {
            Location = location;
            Direction = direction;
        }        

        public Location Move()
        {
            switch (Direction)
            {
                case Direction.N:
                    this.Location.Y += 1;
                    break;

                case Direction.S:
                    this.Location.Y -= 1;
                    break;

                case Direction.E:
                    this.Location.X += 1;
                    break;

                case Direction.W:
                    this.Location.X -= 1;
                    break;
            }

            return this.Location;
        }

        public void ChangeDirection(Action action)
        {
            switch (action)
            {
                case Action.L:
                    if (this.Direction == Direction.N)
                    {
                        this.Direction = Direction.W;
                    }
                    else 
                    {
                        this.Direction -= 9;
                    }                    
                    break;

                case Action.R:
                    if (this.Direction == Direction.W)
                    {
                        this.Direction = Direction.N;
                    }
                    else
                    {
                        this.Direction += 9;
                    }                                        
                    break;
            }
        }
    }
}
