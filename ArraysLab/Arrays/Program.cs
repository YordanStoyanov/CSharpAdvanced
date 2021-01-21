using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           // int[,,,,] matrix = new int[4, 100, 100, 100, 5];
           
            int[,] matrix =
            {
                {1, 2, 3, 4, 5 },
                {6, 7, 8, 9, 10 },
                {11, 12, 13, 14, 15 }
            };
            Console.WriteLine(matrix.Length);
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.Rank);

            for (int i = 0; i < matrix.Rank; i++)
            {
                Console.WriteLine($"{i} => {matrix.GetLength(i)}");
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                   Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }

            foreach (var element in matrix)
            {
                Console.WriteLine($"{element} ");
            }
        }
    }
}
