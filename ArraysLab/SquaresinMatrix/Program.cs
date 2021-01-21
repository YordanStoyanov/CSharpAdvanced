using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresinMatrix
{
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

            char[,] matrix = new char[rows, cols];

            InitializeMatrix(matrix);
            int result = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    bool areEqual = 
                        matrix[row + 0, col + 0] == 
                        matrix[row + 0, col + 1] &&
                        matrix[row + 1, col + 0] == 
                        matrix[row + 1, col + 1];

                    if (areEqual)
                    {
                        result++;
                    }
                }
            }
            Console.WriteLine(result);
        }

        private static void InitializeMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine()
                    .Split(' ')
                    .Select(char.Parse)
                    .ToArray();
                    
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col]; 
                }
            }
        }
    }
}
