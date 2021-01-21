
namespace Miner
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Program
    {
        static char[,] matrix;
        static int minerRow;
        static int minerCol;
        static int coals;

        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            string[] direction = Console.ReadLine()
                .Split(' ')
                .ToArray();
            matrix = new char[size, size];
            PopulateMatrix();

            foreach (var currentDirection in direction)
            {
                switch (currentDirection)
                {
                    case "left":
                        break;
                    case "right":
                        break;
                    case "up":
                        break;
                    case "down":
                        break;
                }
            }

        }

        private static bool IsInside(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) 
                && col >= 0 && col < matrix.GetLength(1);
        }

        private static void PopulateMatrix()
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

                    if (matrix[row, col] == 's')
                    {
                        minerRow = row;
                        minerCol = col;
                    }

                    if (matrix[row, col] == 'c')
                    {
                        coals++;
                    }
                }
            }
        }
    }
}
