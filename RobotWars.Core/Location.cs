namespace RobotWars.Core
{
    public sealed class Location
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Location(int x, int y)
        {
            Contract.Validate(x >= 0, $"Argument X {x} must be greater or equal to 0");
            Contract.Validate(y >= 0, $"Argument y {y} must be greater or equal to 0");            

            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{X} {Y}";
        }
    }
}   