using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cooking
{
    public class Program
    {
        private static object StringBulder;

        static void Main(string[] args)
        {
            /* 
            10 20 30 40 50
            50 40 30 30 15
            */
            //if no match -> dueue.Dequeue and steck number increas by 3
            int[] liquids = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] ingredients = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(liquids);
            Stack<int> stack = new Stack<int>(ingredients);

            int bread = 0;//25
            int cake = 0;//50
            int pastry = 0;//75
            int fruitPie = 0;//100
            int stackNumber = 0;
            int queueNumber = 0;
            int sum = 0;
            while (true)
            {
                stackNumber = stack.Peek();
                queueNumber = queue.Peek();
                sum = stackNumber + queueNumber;
                if (sum == 25)
                {
                    bread++;
                    stack.Pop();
                    queue.Dequeue();
                }
                else if (sum == 50)
                {
                    cake++;
                    stack.Pop();
                    queue.Dequeue();
                }
                else if (sum == 75)
                {
                    pastry++;
                    stack.Pop();
                    queue.Dequeue();
                }
                else if (sum == 100)
                {
                    fruitPie++;
                    stack.Pop();
                    queue.Dequeue();
                }
                else
                {
                    queue.Dequeue();
                    stack.Pop();
                    stack.Push(stackNumber + 3);
                }

                if (queue.Count == 0 || stack.Count == 0)
                {
                    StringBuilder sb = new StringBuilder();
                    if (bread != 0 && cake != 0 && fruitPie != 0 && pastry != 0)
                    {
                        Console.WriteLine("Wohoo! You succeeded in cooking all the food!");

                    }
                    else
                    {
                        Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");

                    }
                    if (queue.Count == 0)
                    {
                        Console.WriteLine("Liquids left: none");
                    }
                    else
                    {
                        Console.WriteLine(string.Join("Ingredients left:  ", queue));
                    }

                    if (stack.Count == 0)
                    {
                        Console.WriteLine("Ingredients left: none");
                    }
                    else
                    {
                        Console.Write("Ingredients left: ");
                        Console.WriteLine(string.Join(", ", stack));
                    }
                    sb.AppendLine($"Bread: {bread}");
                    sb.AppendLine($"Cake: {cake}");
                    sb.AppendLine($"Fruit Pie: {fruitPie}");
                    sb.AppendLine($"Pastry: {pastry}");
                    Console.WriteLine(sb.ToString().TrimEnd());
                    break;
                }
            }
        }
    }
}
