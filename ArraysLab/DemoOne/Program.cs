namespace DemoOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /*
3, 6
7, 1, 3, 3, 2, 1
1, 3, 9, 8, 5, 6
4, 6, 7, 9, 1, 0
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split(',');
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);
            int[,] matrix = new int[rows, cols];
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            long sum = 0;
            long newSum = 0;
            for (int row = 0; row < rows; row++)
            {
                string[] rowElements = Console.ReadLine().Split(',');
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(rowElements[col]);
                    sum += matrix[row, col];
                } 
            }

            foreach (var number in matrix)
            {
                newSum += number;
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
            Console.WriteLine(newSum);

        }
    }
}
