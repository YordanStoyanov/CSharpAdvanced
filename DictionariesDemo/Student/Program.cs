using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, List<double>> students = new SortedDictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] parts = line.Split(' ');
                string name = parts[0];
                double grade = double.Parse(parts[1]);

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                }

                students[name].Add(grade);
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(X => X.ToString("F2")))} (avg: {student.Value.Average():f2})");
            }
        }
    }
}
/*
6
Ivancho 5.20
Mariika 5.50
Mariika 2.50
Stamat 2.00
Mariika 3.46
Stamat 3.00
*/
