using System;
using System.Collections.Generic;

namespace CS_CollectionList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            //var numbers  = new List<int>() {1,2,3,4};
            //var products = new List<Product>();

            var products = new List<Product>() { new Product(1, "Iphone 6", 100, "China") };

            // Add elements
            var p = new Product(2, "IPhone 7", 200, "China");
            products.Add(p);
            products.Add(new Product(3, "IPhone 8", 400, "China"));

            // Add elements with array
            var arrayProducts = new Product[]
                                {
                                    new Product(4, "Glaxy 7", 500, "VietNam"),
                                    new Product(5, "Glaxy 8", 700, "VietNam"),
                                };

            products.AddRange(arrayProducts);

            // Add element at index
            products.Insert(3, new Product(6, "Macbook Pro", 1000, "Mỹ"));

            // Read element
            var pro = products[2];
            System.Console.WriteLine(pro.ToString());

            // Read all
            for (int i = 0; i < products.Count; i++)
            {
                var pi = products[i];
                System.Console.WriteLine(pi.ToString());
            }

            foreach (var pi in products)
            {
                System.Console.WriteLine(pi.ToString());
            }

            //Remove
            //The first element
            products.RemoveAt(0);

            //Range element
            products.RemoveRange(products.Count - 2, 2);

            //Reference element
            var pro_rm = products[1];
            products.Remove(pro_rm);


            //Delegate with Predicate
            (Product ob) => (ob.Name == "Galaxy 8");
        }
    }
}
