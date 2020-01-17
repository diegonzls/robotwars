using System;

namespace RobotWars.Core
{
    internal static class Contract
    {
        public static void Validate(bool assertion, string message)
        {
            if (!assertion)
            {
                throw new InvalidOperationException(message);
            }
        }
    }
}   