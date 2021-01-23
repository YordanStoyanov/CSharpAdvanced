using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.SetsofElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] num = line.Split(' ');
            int n = int.Parse(num[0]);
            int m = int.Parse(num[1]);
            Dictionary<int, int> nNumbers = new Dictionary<int, int>();
            Dictionary<int, int> mNumbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int nNumber = int.Parse(Console.ReadLine());

                if (!nNumbers.ContainsKey(nNumber))
                {
                    nNumbers.Add(nNumber, 0);
                }

                nNumbers[nNumber]++;
            }

            for (int i = 0; i < m; i++)
            {
                int mNumber = int.Parse(Console.ReadLine());
                if (!mNumbers.ContainsKey(mNumber))
                {
                    mNumbers.Add(mNumber, 0);
                }
                mNumbers[mNumber]++;
            }
            foreach (var bothSet in nNumbers)
            {
                if (mNumbers.ContainsKey(bothSet.Key))
                {
                    Console.Write(bothSet.Key + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
/*
4 3
1
3
5
7
3
4
5
*/
