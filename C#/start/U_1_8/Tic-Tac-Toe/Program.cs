using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) GameLoop();
        }

        static void GameLoop()
        {
            Area area = new Area();
            area.Print();
            for (int turn = 1; turn < 10; turn++)
            {
                Symbol player = turn % 2 == 0 ? Symbol.O : Symbol.X;
                //if (turn % 2 == 0) move = Symbol.O;
                //else move = Symbol.X;

                WriteTextWithBorder($"Ходят {player}");
                Console.Write("Введите ряд: ");
                int row = int.Parse(Console.ReadLine()) - 1;
                Console.Write("Введите столбик: ");
                int column = int.Parse(Console.ReadLine()) - 1;

                if (!area.CheckMove(row, column))
                {
                    Console.WriteLine("Ход невозможен");
                    turn--;
                    continue;
                }

                area.OccupyCell(row, column, player);

                if (area.VictoryAchieved(player))
                {
                    WriteTextWithBorder($"{player} победили");
                    break;
                }
                if (turn == 9) WriteTextWithBorder("Ничья");
            }
        }

        static void WriteTextWithBorder(string text)
        {
            string top = "+", middle = $"| {text} |";
            for (int i = 0; i < text.Length + 2; i++)
                top += "-";
            top += "+";
            Console.WriteLine($"{top}\n{middle}\n{top}");
        }
    }
}
