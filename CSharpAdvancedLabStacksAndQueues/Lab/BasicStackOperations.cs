using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            int[] parts = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int numberOfElements = parts[0];
            int elementsToPop = parts[1];
            int elementToFind = parts[2];
            int[] elementToPush = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(elementToPush);

            for (int i = 0; i < elementsToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(elementToFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
