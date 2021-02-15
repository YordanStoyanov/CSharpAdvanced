using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int numbers = input[0];
            int popElements = input[1];
            int findElement = input[2];

            Stack<int> stack = new Stack<int>(numbers);

            for (int i = 0; i < popElements; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(findElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                int minNumberInStack = stack.Min();
                Console.WriteLine(minNumberInStack);
            }
        }
    }
}
