using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int numbers = input[0];
            int dequeueElements = input[1];
            int findElement = input[2];

            Queue<int> queue = new Queue<int>(numbers);

            for (int i = 0; i < dequeueElements; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(findElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                int minNumberInStack = queue.Min();
                Console.WriteLine(minNumberInStack);
            }
        }
    }
}
