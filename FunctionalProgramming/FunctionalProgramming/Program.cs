using System;
using System.Linq;
namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
Func<int, bool> predicate = x => x % 2 == 0;

Console.WriteLine(predicate(5));
Console.WriteLine(predicate(10));
*/
            Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray()
                .Where(num => num % 2 == 0, Console.WriteLine());
        }
    }
}
