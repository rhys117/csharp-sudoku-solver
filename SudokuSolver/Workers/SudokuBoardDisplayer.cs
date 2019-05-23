using System;

namespace SudokuSolver.Workers
{
    class SudokuBoardDisplayer
    {
        public void Display(string title, int[,] sudokuBoard)
        {
            if (!title.Equals(string.Empty)) Console.WriteLine($"{title} {Environment.NewLine}");

            for (int row = 0; row < sudokuBoard.GetLength(0); row++)
            {
                Console.Write("|");
                for (int col = 0; row < sudokuBoard.GetLength(1); row++)
                {
                    Console.WriteLine($"{sudokuBoard[row, col]}|");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
