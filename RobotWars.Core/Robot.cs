namespace RobotWars.Core
{
    public class Robot : Player
    {
        public Robot(Location location, Direction direction) 
            : base(location, direction)
        {            
        }

        public override Location Move()
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

        public override void ChangeDirection(Action action)
        {
            switch (action)
            {
                case Action.L:
                    if (Direction == Direction.N)
                    {
                        Direction = Direction.W;
                    }
                    else 
                    {
                        Direction -= 9;
                    }                    
                    break;

                case Action.R:
                    if (Direction == Direction.W)
                    {
                        Direction = Direction.N;
                    }
                    else
                    {
                        Direction += 9;
                    }                                        
                    break;
            }
        }
    }
}
