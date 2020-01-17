namespace RobotWars.Core
{
    public abstract class Player
    {
        public Location Location { get; protected set; }

        public Direction Direction { get; protected set; }

        public Player(Location location, Direction direction)
        {
            Location = location;
            Direction = direction;
        }

        public abstract Location Move();

        public abstract void ChangeDirection(Action action);
    }
}
