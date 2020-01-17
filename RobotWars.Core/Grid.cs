namespace RobotWars.Core
{
    public class Grid
    {        
        public Location bottomLeft { get; private set; }
        
        public Location TopRight { get; private set; }        

        public Grid(Location topRight)
        {
            this.bottomLeft = new Location(0, 0);
            this.TopRight = topRight;            
        }

        public bool IsValidLocation(Location location)
        {
            return location.X <= TopRight.X && location.Y <= TopRight.Y;
        }
    }
}