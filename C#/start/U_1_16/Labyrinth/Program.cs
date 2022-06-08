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
            map.Print();
        }
    }
}
