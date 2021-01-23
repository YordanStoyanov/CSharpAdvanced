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
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ")
                    .ToArray();
                string color = input[0];
                string[] clothes = input[1]
                    .Split(",")
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

            }

            string lookingFor = Console.ReadLine();
            string[] parts = lookingFor
                .Split(" ")
                .ToArray();

            string targetColor = parts[0];
            string targetItem = parts[1];

            foreach (var (color, clothes) in colorClothes)
            {
                Console.WriteLine($"{color} clothes:");

                foreach (var clothing in clothes)
                {
                    string resultText = string.Empty;

                    resultText = $"* {clothing.Key} - {clothing.Value}";

                    if (targetColor == color && targetItem == clothing.Key)
                    {
                        resultText += " (found!)";
                    }
                    Console.WriteLine(resultText);
                }
            }
            ;
        }
    }
}
/*
4
Blue -> dress,jeans,hat
Gold -> dress,t-shirt,boxers
White -> briefs,tanktop
Blue -> gloves
Blue dress

4
Red -> hat
Red -> dress,t-shirt,boxers
White -> briefs,tanktop
Blue -> gloves
White tanktop
 */
