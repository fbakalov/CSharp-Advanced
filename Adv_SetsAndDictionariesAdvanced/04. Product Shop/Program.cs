using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> nana = new Dictionary<string, Dictionary<string, double>>();

            string enter;
            while ((enter = Console.ReadLine()) != "Revision")
            {
                string[] arguments = enter.Split(", ");
                string shop = arguments[0];
                string product = arguments[1];
                double price = double.Parse(arguments[2]);

                if (!nana.ContainsKey(shop))
                {
                    nana.Add(shop, new Dictionary<string, double>());
                }



                nana[shop].Add(product, price);



            }

            nana = nana.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in nana)
            {
                Console.WriteLine(item.Key + "->");

                foreach (var product in item.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
