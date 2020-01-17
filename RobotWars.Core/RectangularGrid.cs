namespace RobotWars.Core
{
    public class RectangularGrid : IGrid
    {        
        private Location bottomLeft { get; set; }
        
        private Location TopRight { get; set; }        

        public RectangularGrid(Location topRight)
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