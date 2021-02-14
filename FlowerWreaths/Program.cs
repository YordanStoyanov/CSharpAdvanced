using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerWreaths
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] lilies = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            int[] roses = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(lilies);
            Queue<int> queue = new Queue<int>(roses);
            int stackNumber = 0;
            int queueNumber = 0;
            int sum = 0;
            int otherSum = 0;
            int match = 0;
            int oneWreath = 15;
            while (true)
            {
                stackNumber = stack.Peek();
                queueNumber = queue.Peek();
                sum = stackNumber + queueNumber;
                while (sum > 15)
                {
                    sum = 0;
                    stackNumber -= 2;
                    sum = stackNumber + queueNumber;
                }

                if (sum == 15)
                {
                    match++;
                    stack.Pop();
                    queue.Dequeue();
                    sum = 0;
                }
                else
                {
                    otherSum += stackNumber + queueNumber;
                    stack.Pop();
                    queue.Dequeue();
                }

                if (stack.Count == 0 || queue.Count == 0)
                {
                    while (otherSum >= 15)
                    {
                        if (otherSum > oneWreath)
                        {
                            match++;
                            otherSum -= oneWreath;
                        }
                    }
                    break;
                }
            }

            if (match == 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {match} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - match} wreaths more!");
            }
        }
    }
}
