using System;

namespace RobotWars.Core
{
    public class OutOfArenaException : Exception
    {
        public OutOfArenaException(string message) : base(message)
        {
        }        
    }
}
