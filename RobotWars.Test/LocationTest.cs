using NUnit.Framework;
using System;

namespace RobotWars.Core.Test
{
    public class LocationTest
    {        
        [TestCase(-1,0)]
        [TestCase(0, -1)]
        public void CreateObjectFail(int x, int y)
        {                                    
            Assert.Throws<InvalidOperationException>(() => { new Location(x, y);});
        }        
    }
}