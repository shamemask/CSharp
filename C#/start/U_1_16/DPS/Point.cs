using System;
using System.Collections.Generic;
using System.Text;

namespace Labyrinth
{
    public class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public List<Point> Path { get; set; } // путь к этой точке
                                              // через какие точки мы пришли в эту

        public Point(int x, int y, List<Point> path = null)
        {
            X = x;
            Y = y;
            Path = path == null? new List<Point>() : path;
        }
    }
}
