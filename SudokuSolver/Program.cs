using System;
using System.Linq;
using System.Text;
using SudokuSolver.Strategies;
using SudokuSolver.Workers;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SudokuMapper sudokuMapper = new SudokuMapper();
                SudokuBoardStateManager sudokuBoardStateManager = new SudokuBoardStateManager();
                SudokuSolverEngine sudokuSolverEngine = new SudokuSolverEngine(sudokuBoardStateManager, sudokuMapper);
                SudokuFileReader sudokuFileReader = new SudokuFileReader();
                SudokuBoardDisplayer sudokuBoardDisplayer = new SudokuBoardDisplayer();

                Console.WriteLine("Please enter the filename containing the Sudoku Puzzle:");
                var filename = Console.ReadLine();

                var sudokuBoard = sudokuFileReader.ReadFile(filename);
                sudokuBoardDisplayer.Display("Initial state", sudokuBoard);

                bool isSudokuSolved = sudokuSolverEngine.Solve(sudokuBoard);
                sudokuBoardDisplayer.Display("Final State", sudokuBoard);

                Console.WriteLine(isSudokuSolved
                    ? "You have successfully solved this Sudoku Puzzle!"
                    : "Unfortunately, current algorithm(s) were not enough to solve the current Sudoku Puzzle :(");
            }
            catch (Exception ex)
            {
                // In real world would log this message
                Console.WriteLine($"Sudoku Puzzle cannot be solved because there was an error: {ex.Message}");

            }
        }
    }
}
