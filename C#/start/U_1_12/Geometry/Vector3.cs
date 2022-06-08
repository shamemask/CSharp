using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class Vector3
    {
        public float X { get; private set; }
        public float Y { get; private set; }
        public float Z { get; private set; }

        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }

        public double GetLength()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public Vector3 Add(Vector3 other)
        {
            return new Vector3(X + other.X, Y + other.Y, Z + other.Z);
        }
    }
}
