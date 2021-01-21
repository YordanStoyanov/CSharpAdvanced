namespace MaximalSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows, cols];

            InizializeMatrix(matrix);
            int sum = 0;
            int result = int.MinValue;
            int currentRow = 0;
            int currentCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    sum = matrix[row + 0, col + 0] + matrix[row + 0, col + 1] + matrix[row + 0, col + 2] +
                        matrix[row + 1, col + 0] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col + 0] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > result)
                    {
                        result = sum;
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {result}");
            Console.WriteLine($"{matrix[currentRow + 0, currentCol + 0]} {matrix[currentRow + 0, currentCol + 1]} {matrix[currentRow + 0, currentCol + 2]}");
            Console.WriteLine($"{matrix[currentRow + 1, currentCol + 0]} {matrix[currentRow + 1, currentCol + 1]} {matrix[currentRow + 1, currentCol + 2]}");
            Console.WriteLine($"{matrix[currentRow + 2, currentCol + 0]} {matrix[currentRow + 2, currentCol + 1]} {matrix[currentRow + 2, currentCol + 2]}");
        }

        private static void InizializeMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
