using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperation
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
            Queue<int> queue = new Queue<int>(elementToPush);

            for (int i = 0; i < elementsToPop; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(elementToFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
