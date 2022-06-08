using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class GeoCalculator
    {
        public static double GetLength(Vector2 vector)
        {
            return Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
        }

        public static Vector2 Add(Vector2 A, Vector2 B)
        {
            return new Vector2(A.X + B.X, A.Y + B.Y);
        }
    }
}
