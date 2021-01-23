using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> colorClothes = 
                new Dictionary<string, Dictionary<string, int>>();

            //4
            //Blue -> dress,jeans,hat
            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ".ToArray(), StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string color = input[0];
                string[] clothes = input[1].Split(",".ToArray(), StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (!colorClothes.ContainsKey(color))
                {
                    colorClothes.Add(color, new Dictionary<string, int>());
                }

                foreach (var clothing in clothes)
                {
                    if (!colorClothes[color].ContainsKey(clothing))
                    {
                        colorClothes[color].Add(clothing, 0);
                    }

                    colorClothes[color][clothing]++;
                }

                if (i == n)
                {
                    string lookingFor = Console.ReadLine();
                    string[] parts = lookingFor.Split(' ').ToArray();

                    string targetColor = parts[0];
                    string targetItem = parts[1];

                }
            }
        }
    }
}
/*
4
Blue -> dress,jeans,hat
Gold -> dress,t-shirt,boxers
White -> briefs,tanktop
Blue -> gloves
 */
