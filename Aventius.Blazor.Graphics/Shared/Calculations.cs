#region Namespaces

using System;

#endregion

namespace Aventius.Blazor.Graphics.Shared
{
    public static class Calculations
    {
        /// <summary>
        /// Returns the angle of the line at the specified coordinates
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        public static double AngleBetweenTwoPoints(int x1, int y1, int x2, int y2)
        {
            return Math.Atan2(y1 - y2, x1 - x2) * (180 / Math.PI);
        }

        /// <summary>
        /// Returns the distance between 2 points (x1,y1) and (x2,y2)
        /// </summary>
        /// <param name="x1">Start x coordinate</param>
        /// <param name="y1">Start y coordinate</param>
        /// <param name="x2">End x coordinate</param>
        /// <param name="y2">End y coordinate</param>
        /// <returns></returns>
        public static double DistanceBetweenTwoPoints(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
        }
    }
}
