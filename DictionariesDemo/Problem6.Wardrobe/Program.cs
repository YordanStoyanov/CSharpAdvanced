using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, Dictionary<string, int>> gardrobe =
            //    new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            //string[] two = input.Split(":::".ToArray(),StringSplitOptions.RemoveEmptyEntries);
            int[] two = input.Split(">>>".ToArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            foreach (var item in two)
            {
                Console.Write(item + " ");
            }
            //IEnumerable<string> numbers = Console.ReadLine().Split(">>>".ToArray());
            //int[] parts = numbers.Select(int.Parse).ToArray();
            ;
        }
    }
}
//Blue:::dress:::jeans:::hat
//1>>>1>>>2>>>3