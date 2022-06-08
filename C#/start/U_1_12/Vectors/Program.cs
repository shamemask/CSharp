using System;
using Geometry;

namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2 a = new Vector2(2, 3);
            Vector2 b = new Vector2(2, 1);
            //Console.WriteLine(a);
            Console.WriteLine(GeoCalculator.GetLength(a));
            Console.WriteLine(GeoCalculator.GetLength(b));
            Console.WriteLine(GeoCalculator.Add(a, b));

            Vector3 c = new Vector3(1, 1, 1);
            Vector3 d = new Vector3(2, 2, 2);
            Console.WriteLine(c.GetLength());
            Console.WriteLine(d.GetLength());
            Console.WriteLine(c.Add(d));
        }
    }
}
