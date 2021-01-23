using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedNames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Ivo", "Viki", "Gosho", "Pesho" };
            Dictionary<string, int> dictionary = names.ToDictionary(x => x, x => x.Length);
            /*
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            */
            foreach (var name in names)
            {
                Console.WriteLine(name + " => " + name.Length);
            }
            
        } 
    }
}
