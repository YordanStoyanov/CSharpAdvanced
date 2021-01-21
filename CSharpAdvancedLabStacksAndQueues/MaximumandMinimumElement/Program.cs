using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumandMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] parts = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int command = parts[0];
                if (command == 1)
                {
                    int number = parts[1];
                    stack.Push(number);
                }
                else if (command == 2)
                {
                    if (stack.Count != 0)
                    {
                        stack.Pop();
                    }
                }
                else if (command == 3)
                {
                    int maxElement = stack.Max();
                    Console.WriteLine(maxElement);
                }
                else if (command == 4)
                {
                    int minElement = stack.Min();
                    Console.WriteLine(minElement);
                }
            }

            string elements = string.Join(", ", stack);
            Console.WriteLine(elements);
        }
    }
}
