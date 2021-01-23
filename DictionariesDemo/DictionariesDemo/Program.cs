namespace DictionariesDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse);
            var doubles = new Dictionary<double, int>();
            foreach (var number in numbers)
            {
                if (!doubles.ContainsKey(number))
                {
                    doubles.Add(number, 0);
                }

                doubles[number]++;
            }

            foreach (var keyValuePair in doubles)
            {
                Console.WriteLine($"{keyValuePair.Key} - {keyValuePair.Value} times");
            }
        }
    }
}
