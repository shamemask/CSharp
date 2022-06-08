using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    enum Symbol
    {
        _,
        X,
        O
    }

    class Area
    {
        Symbol[,] field = new Symbol[3, 3];

        public void Print()
        {
            Console.WriteLine();
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                    Console.Write($"{field[row, column]} ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public bool CheckMove(int row, int column)
        {
            if (row < 0 || row > 2 || column < 0 || column > 2) return false;
            return field[row, column] == Symbol._;
        }

        public void OccupyCell(int row, int column, Symbol playerSymbol)
        {
            field[row, column] = playerSymbol;
            Print();
        }

        public bool VictoryAchieved(Symbol playerSymbol)
        {
            //строки
            if (field[0, 0] == playerSymbol
                && field[0, 1] == playerSymbol
                && field[0, 2] == playerSymbol) return true;
            if (field[1, 0] == playerSymbol
                && field[1, 1] == playerSymbol
                && field[1, 2] == playerSymbol) return true;
            if (field[2, 0] == playerSymbol
                && field[2, 1] == playerSymbol
                && field[2, 2] == playerSymbol) return true;
            //колонки
            if (field[0, 0] == playerSymbol
                && field[1, 0] == playerSymbol
                && field[2, 0] == playerSymbol) return true;
            if (field[0, 1] == playerSymbol
                && field[1, 1] == playerSymbol
                && field[2, 1] == playerSymbol) return true;
            if (field[0, 2] == playerSymbol
                && field[1, 2] == playerSymbol
                && field[2, 2] == playerSymbol) return true;
            //диагонали
            if (field[0, 0] == playerSymbol
                && field[1, 1] == playerSymbol
                && field[2, 2] == playerSymbol) return true;
            return field[2, 0] == playerSymbol
                && field[1, 1] == playerSymbol
                && field[0, 2] == playerSymbol;
        }
    }
}
