namespace ActionPoint
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //pesho ivan gosho
            Action<string[]> printName = items =>
            Console.WriteLine(string.Join(Environment.NewLine, items));
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            printName(input);
            */

            Action<string> printName = items =>
            Console.WriteLine(string.Join(Environment.NewLine, items));

            Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(printName);
        }
    }
}
