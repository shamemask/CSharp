using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labyrinth
{
	public enum State
	{
		Empty,
		Wall,
		Visited,
		Exit,
		Path
	}

	public class Labyrinth
    {
		public State[,] StateMap { get; set; }

		public Labyrinth(string[] stringMap)
        {
			StateMap = new State[stringMap[0].Length, stringMap.Length];
			for (int x = 0; x < StateMap.GetLength(0); x++) 
				for (int y = 0; y < StateMap.GetLength(1); y++)
					StateMap[x, y] = stringMap[y][x] == ' ' ? State.Empty
						: stringMap[y][x] == 'X' ? State.Wall
						: State.Exit;
		}

		public void Print()
        {
            Console.CursorLeft = 0;
            Console.CursorTop = 0;
            PrintBorder(); //печатаем верхнюю границу
            for (int y = 0; y < StateMap.GetLength(1); y++)
            {
                Console.Write("X"); //начинаем каждый ряд со стены
                for (int x = 0; x < StateMap.GetLength(0); x++)
                    switch (StateMap[x, y])
                    {
                        case State.Wall:
                            Console.Write("X");
                            break;
                        case State.Empty:
                            Console.Write(" ");
                            break;
                        case State.Visited:
                            Console.Write(".");
                            break;
                        case State.Exit:
                            Console.Write("o");
                            break;
                        case State.Path:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(".");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                    }
                Console.WriteLine("X");  //заканчиваем каждый ряд стеной
            }
            PrintBorder(); //печатаем нижнюю границу
            Thread.Sleep(100);
        }

        void PrintBorder()
        {
            for (int x = 0; x < StateMap.GetLength(0) + 2; x++)
                Console.Write("X");
            Console.WriteLine();
        }
    }
}
