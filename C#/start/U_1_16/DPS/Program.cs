using System;
using System.Collections.Generic;

namespace Labyrinth
{
	public class Program
	{
		static void Main()
        {
            string[] labyrinth = new string[]
                {
                    " X   X   o",
                    " X XXXXX X",
                    "      X   ",
                    "XXXX XXX X",
                    "         X",
                    " XXX XXXXX",
                    "oX       o"
                };
            Labyrinth map = new Labyrinth(labyrinth);
            BreadthFirstSearch(map);
        }

        static void BreadthFirstSearch(Labyrinth map)
        {
            var stack = new Stack<Point>();
            stack.Push(new Point(0, 0));
            while (stack.Count != 0)
            {
                var point = stack.Pop();
                if (map.StateMap[point.X, point.Y] != State.Exit)
                {
                    map.StateMap[point.X, point.Y] = State.Visited;
                    map.Print();
                }
                else
                {
                    foreach (var dot in point.Path)
                        map.StateMap[dot.X, dot.Y] = State.Path;
                    map.Print();
                    Console.WriteLine("Путь найден!");
                    break;
                }
                EnqueueNextPoint(map, stack, point);
            }
        }

        static void EnqueueNextPoint(Labyrinth map, Stack<Point> stack, Point point)
        {
            List<Point> path = new List<Point>();
            foreach (var dot in point.Path)
                path.Add(dot);
            path.Add(point);
            for (var dy = -1; dy <= 1; dy++)
                for (var dx = -1; dx <= 1; dx++)
                    if (dx != 0 && dy != 0) continue;
                    else
                    {
                        var nextPoint = new Point(point.X + dx, point.Y + dy, path);
                        if (nextPoint.X < 0
                            || nextPoint.X >= map.StateMap.GetLength(0)
                            || nextPoint.Y < 0
                            || nextPoint.Y >= map.StateMap.GetLength(1)
                            || map.StateMap[nextPoint.X, nextPoint.Y] == State.Wall
                            || map.StateMap[nextPoint.X, nextPoint.Y] == State.Visited) continue;
                        stack.Push(nextPoint);
                    }
        }
    }
}
