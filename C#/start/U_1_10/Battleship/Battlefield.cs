using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    class Battlefield
    {
        string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        char[,] visibleArea = new char[10, 10];
        List<Ship> ships = new List<Ship>();
        bool[,] area = new bool[10, 10];

        public void Print()
        {
            string areaString = "  0 1 2 3 4 5 6 7 8 9\n";
            for (int i = 0; i < 10; i++)
            {
                areaString += $"{letters[i]} ";
                for (int j = 0; j < 10; j++)
                {
                    if (visibleArea[i, j] == '\0') visibleArea[i, j] = '~';
                    if (area[i, j]) visibleArea[i, j] = 'O';
                    areaString += $"{visibleArea[i, j]} ";
                }
                areaString += "\n";
            }
            Console.WriteLine(areaString);
        }

        public void PlaceShips()
        {
            Ship battleShip1 = new Ship(4);
            Ship battleShip2 = new Ship(4);
            Ship destroyer1 = new Ship(3);
            Ship destroyer2 = new Ship(3);
            Ship destroyer3 = new Ship(3);
            Ship submarine1 = new Ship(2);
            Ship submarine2 = new Ship(2);
            Ship submarine3 = new Ship(2);
            Ship patrolBoat1 = new Ship(1);
            Ship patrolBoat2 = new Ship(1);
            Ship patrolBoat3 = new Ship(1);
            Ship patrolBoat4 = new Ship(1);
            
            ships.Add(battleShip1);
            ships.Add(battleShip2);

            ships.Add(destroyer1);
            ships.Add(destroyer2);
            ships.Add(destroyer3);

            ships.Add(submarine1);
            ships.Add(submarine2);
            ships.Add(submarine3);
            
            ships.Add(patrolBoat1);
            ships.Add(patrolBoat2);
            ships.Add(patrolBoat3);
            ships.Add(patrolBoat4);

            foreach (Ship ship in ships)
                PlaceShip(ship);
        }

        void PlaceShip(Ship ship)
        {
            Random r = new Random();
            int row, column;
            while (true)
            {
                if (ship.Horizontal)
                {
                    row = r.Next(0, 10);
                    column = r.Next(0, 11 - ship.SizeX);
                }
                else
                {
                    row = r.Next(0, 11 - ship.SizeY);
                    column = r.Next(0, 10);
                }
                if (CheckPlacement(column, row, ship))
                {
                    for (int i = 0; i < ship.SizeX; i++)
                        for (int j = 0; j < ship.SizeY; j++)
                        {
                            area[column + i, row + j] = true;
                            ship.Coords.Add(new int[] { column + i, row + j });
                        }
                    break;
                }
            }
        }

        bool CheckPlacement(int column, int row, Ship ship)
        {
            for (int i = column - 1; i <= column + ship.SizeX; i++)
                for (int j = row - 1; j <= row + ship.SizeY; j++)
                    if (i >= 0 && i < 10 && j >= 0 && j < 10)
                        if (area[i, j]) return false;
            return true;
        }
    }
}
