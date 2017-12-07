using System;

namespace TreasureHunt
{
    class Program
    {
        static void Main()
        {
            int[,] treasureArray = new int[5, 5] {
                    {34, 21, 32, 41, 25},
                    {14, 42, 43, 14, 31},
                    {54, 45, 52, 42, 23},
                    {33, 15, 51, 31, 35},
                    {21, 52, 33, 13, 23 }};

            int row = 1;
            int col = 1;
            bool isValidCell = true;

            while (isValidCell && (treasureArray[row - 1, col - 1] != 0))
            {
                int cellValue = treasureArray[row - 1, col - 1];
                bool isTreasure = (cellValue == row * 10 + col);

                Console.WriteLine("Cell [{0}, {1}] with value {2} is {3} treasure .", row, col, cellValue, isTreasure ? "WITH" : "WITHOUT");

                treasureArray[row - 1, col - 1] = 0; // Assign 0 to visited cells;

                row = cellValue / 10;
                col = cellValue % 10;

                isValidCell = (row >= 1 && row <= 5 && col >= 1 && col <= 5);

            }

            if (isValidCell)
            {
                Console.WriteLine("All lines checked.");
            }
            else
            {
                Console.WriteLine("Cell [{0}, {1}] is not valid.", row, col);
            }
            Console.ReadLine();
        }
    }
}
