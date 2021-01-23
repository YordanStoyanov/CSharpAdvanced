using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, decimal>> shopAndProduct =
                new SortedDictionary<string, Dictionary<string, decimal>>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Revision")
                {
                    break;
                }

                string[] parts = command.Split(',');
                string shopName = parts[0];
                string productName = parts[1];
                decimal productPrice = decimal.Parse(parts[2]);

                if (!shopAndProduct.ContainsKey(shopName))
                {
                    shopAndProduct.Add(shopName, new Dictionary<string, decimal>());
                    //shopAndProduct[shopName] = new Dictionary<string, decimal>();
                }
                shopAndProduct[shopName][productName] = productPrice;
                /*
                Dictionary<string, decimal> shop = shopAndProduct[shopName];
                if (!shop.ContainsKey(productName))
                {
                    shop[productName] = productPrice;
                }
                else
                {
                    shop[productName] = productPrice;
                }
                */
            }

            foreach (var shop in shopAndProduct)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product:{product.Key}, Price: {product.Value:f1}");
                }
            }
        }
    }
}

