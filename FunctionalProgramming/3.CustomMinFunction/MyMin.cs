using System;
using System.Collections.Generic;
using System.Text;

namespace _3.CustomMinFunction
{
    static class Min
    {
        public static int MyMin(this IEnumerable<int> source)
        {
            int minValue = int.MaxValue;

            foreach (var currentNumber in source)
            {
                if (currentNumber < minValue)
                {
                    minValue = currentNumber;
                }
            }
            return minValue;
        }
    }
}
