using RobotWars.Core;
using System;

namespace RobotsWarsGame
{
    public class Game
    {
        private static readonly int _numberOfPlayer = 2; // This could be configurable

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter arena Top Right Corner Coordinate");
            
            var arenaTR = Console.ReadLine().Split(' ');

            var arena = new Arena(new Grid(new Location(Convert.ToInt32(arenaTR[0]), Convert.ToInt32(arenaTR[1]))));

            for (int i = 0; i < _numberOfPlayer; i++)
            {
                Console.WriteLine($"Please enter Robot{i + 1} location and direction");

                var robot1 = Console.ReadLine().Split(' ');

                arena.AddRobot(new Robot(new Location(Convert.ToInt32(robot1[0]), Convert.ToInt32(robot1[1])), GetDirection(robot1[2])));

                Console.WriteLine("Please provide operations, Valid operations are L, M, R");

                var operations = Console.ReadLine().ToCharArray();

                foreach (var action in operations)
                {
                    if (action == 'L')
                    {
                        arena.ChangeDirection(RobotWars.Core.Action.L);
                    }

                    if (action == 'R')
                    {
                        arena.ChangeDirection(RobotWars.Core.Action.R);

                    }

                    if (action == 'M')
                    {
                        arena.MoveRobot();
                    }
                }
            }
            
            Console.WriteLine($" Robot1: {arena.Robots[0].Location} {arena.Robots[0].Direction}");
            Console.WriteLine($" Robot2: {arena.Robots[1].Location} {arena.Robots[1].Direction}");

            Console.ReadLine();
        }

        internal static Direction GetDirection(string direction)
        {
            if (Enum.TryParse(direction, out Direction result))            
                return result;
            
            throw new InvalidOperationException($"Couldn't parse the direction from the provided input {direction}.");
        }
    }
}
