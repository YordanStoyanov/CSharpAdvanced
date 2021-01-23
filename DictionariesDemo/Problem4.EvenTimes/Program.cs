using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<int, int> numbers = new SortedDictionary<int, int>();
            int evenNumber = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                int number = Math.Abs(num);
                if (numbers.ContainsKey(number))
                {
                    numbers.Add(number, i);
                }
                else
                {
                    numbers.Add(number, i);
                }
            }

            foreach (var number in numbers.Keys)
            {
                if (number % 2 == 0)
                {
                    evenNumber++;
                }
            }
            Console.WriteLine(evenNumber);
        }
    }
}
/*
5
1
2
3
1
5
 */
