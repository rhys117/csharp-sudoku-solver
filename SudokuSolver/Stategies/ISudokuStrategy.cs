using System;

namespace SudokuSolver.Stategies
{
    interface ISudokuStrategy
    {
        int[,] Solve(int[,] sudokuBoard);
    }
}
