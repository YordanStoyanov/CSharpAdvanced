using System;

namespace _3.CustomMinFunction
{
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Func<int[], int> minFunc = inputNumber =>
            {
                int minValue = int.MaxValue;

                foreach (var currentNumber in inputNumber)
                {
                    if (currentNumber < minValue)
                    {
                        minValue = currentNumber;
                    }
                }
                return minValue;
            };
            */
            int numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .MyMin();

            //int result = minFunc(numbers);
            Console.WriteLine(numbers);
        } 

        
    }
}
