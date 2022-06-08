using System;
using System.Collections.Generic;

namespace Battleship
{

    class Program
    {
        static void Main(string[] args)
        {
            Battlefield area = new Battlefield();
            area.PlaceShips();
            area.Print();
            int turns = 30;
            for (int turn = 0; turn < turns; turn++)
            {
                Console.WriteLine($"Осталось попыток: {turns - turn}");
                Console.Write("Куда стрелять? ");
                string input = Console.ReadLine();
                Console.Clear();
                if (area.ShootAt(input)) turn--;
                area.Print();
                if (area.CheckVictory())
                {
                    Console.WriteLine("Победа!");
                    break;
                }
            }
        }
    }
}
