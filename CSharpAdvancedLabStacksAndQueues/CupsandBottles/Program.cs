using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CupsandBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            //4 2 10 5
            //3 15 15 11 6

            int[] queueNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] stackNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(queueNumbers);
            Stack<int> stack = new Stack<int>(stackNumbers);
            int result = 0;
            int count = 0;
            while (true)
            {
                if (queue.Count == 0 || stack.Count == 0)
                {
                    break;
                }
                int stackNumber = stack.Peek();
                int queueNumber = queue.Peek();
                int sum = stackNumber - queueNumber;
                result += sum;
                count++;
                stack.Pop();
                queue.Dequeue();
            }
            Console.WriteLine($"Bottles: {count}");
            Console.WriteLine($"Wasted litters of water: {result}");
        }
    }
}
