using System;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int stephenRow = 0;
            int stephenCol = 0;
            char[][] field = new char[size][];
            for (int r = 0; r < size; r++)
            {
                field[r] = new char[size];
                char[] col = Console.ReadLine().ToCharArray();
                for (int c = 0; c < size; c++)
                {
                    char ch = col[c];
                    if (ch == 'S')
                    {
                        stephenRow = r;
                        stephenCol = c;
                    }

                    field[r][c] = ch;
                }
            }
            int stars = 0;
            while (true)
            {
                field[stephenRow][stephenCol] = '-';
                string command = Console.ReadLine();
                if (command.Contains("right"))
                {
                    stephenCol += 1;
                }
                if (command.Contains("left"))
                {
                    stephenCol -= 1;
                }
                if (command.Contains("up"))
                {
                    stephenRow -= 1;
                }
                if (command.Contains("down"))
                {
                    stephenRow += 1;
                }
                if (IsOutside(size, stephenRow, stephenCol))
                {
                    Console.WriteLine("Bad news, you are out of the bakery.");
                    break;
                }
                char element = field[stephenRow][stephenCol];
                if (element == 'O')
                {
                    field[stephenRow][stephenCol] = '-';
                    for (int r = 0; r < size; r++)
                    {
                        bool found = false;
                        for (int c = 0; c < size; c++)
                        {

                            char currentElement = field[r][c];
                            if (currentElement == 'O')
                            {
                                stephenRow = r;
                                stephenCol = c;
                                field[stephenRow][stephenCol] = 'S';
                                found = true;
                                break;
                            }
                        }
                        if (found)
                        {
                            break;
                        }
                    }
                }
                else if (char.IsDigit(element))
                {
                    stars += element - '0';
                    if (stars >= 50)
                    {
                        Console.WriteLine("Good news! You succeeded in collecting enough money!");
                        field[stephenRow][stephenCol] = 'S';
                        break;
                    }
                }
            }
            Console.WriteLine($"Money: {stars}");
            foreach (char[] col in field)
            {
                Console.WriteLine(string.Join("", col));
            }
        }
        public static bool IsOutside(int size, int stephenRow, int stephenCol)
        {
            return stephenRow >= size || stephenRow < 0
                || stephenCol >= size || stephenCol < 0;
        }
    }
}
