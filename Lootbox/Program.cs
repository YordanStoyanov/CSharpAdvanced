using System;
using System.Collections.Generic;
using System.Linq;

namespace Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] queueNumbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int[] stackNumbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            Queue<int> queue = new Queue<int>(queueNumbers);
            Stack<int> stack = new Stack<int>(stackNumbers);
            int sum = 0;
            int result = 0;
            while (true)
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine("Second lootbox is empty");
                    break;
                }
                else if (queue.Count == 0)
                {
                    Console.WriteLine("First lootbox is empty");
                    break;
                }
                int stackNumber = stack.Peek();
                int queueNumber = queue.Peek();
                sum = stackNumber + queueNumber;
                if (sum % 2 == 0)
                {
                    result += sum;
                    stack.Pop();
                    queue.Dequeue();
                }
                else
                {
                    queue.Reverse();
                    queue.Enqueue(stackNumber);
                    queue.Reverse();
                    stack.Pop();
                }
            }
            if (result <= 100)
            {
                Console.WriteLine($"Your loot was poor... Value: {result}");
            }
            else
            {
                Console.WriteLine($"Your loot was epic! Value: {result}");
            }
        }
    }
}
