using System;
using System.Linq;
using System.Collections.Generic;
namespace EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray()
                .Where(x => x % 2 == 0);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
