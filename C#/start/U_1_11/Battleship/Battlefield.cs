using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    class Battlefield
    {
        List<string> letters = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
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
                    //if (area[i, j]) visibleArea[i, j] = 'O';
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

        public bool ShootAt(string location)
        {
            var row = letters.IndexOf(location[0].ToString().ToUpper());
            var column = int.Parse(location[1].ToString());
            if (area[row, column])
                foreach (Ship ship in ships)
                    foreach (int[] coords in ship.Coords)
                        if (coords[0] == row && coords[1] == column)
                        {
                            ship.ShotCoords.Add(coords);
                            area[row, column] = false;
                            if (ship.Coords.Count == ship.ShotCoords.Count)
                            {
                                Console.WriteLine("Убил!");
                                ShipKilled(ship);
                            }
                            else
                            {
                                Console.WriteLine("Попал!");
                                visibleArea[row, column] = 'O';
                            }
                            return true;
                        }
            Console.WriteLine("Мимо!");
            visibleArea[row, column] = 'X';
            return false;
        }

        void ShipKilled(Ship ship)
        {
            ships.Remove(ship);
            for (int i = ship.Coords[0][0] - 1; i <= ship.Coords[0][0] + ship.SizeX; i++)
                for (int j = ship.Coords[0][1] - 1; j <= ship.Coords[0][1] + ship.SizeY; j++)
                    if (i >= 0 && i < 10 && j >= 0 && j < 10)
                        visibleArea[i, j] = 'X';
            foreach (int[] coords in ship.Coords)
                visibleArea[coords[0], coords[1]] = '+';
        }

        public bool CheckVictory()
        {
            return ships.Count == 0;
        }
    }
}
