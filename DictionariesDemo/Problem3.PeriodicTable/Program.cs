using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, int> chemicalCompounds = new SortedDictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < line.Length; j++)
                {
                    if (!chemicalCompounds.ContainsKey(line[j]))
                    {
                        chemicalCompounds.Add(line[j], 0);
                    }
                    chemicalCompounds[line[j]]++;
                }
            }

            foreach (var components in chemicalCompounds)
            {
                Console.Write(components.Key + " ");
            }
            Console.WriteLine();
        }
    }
}
