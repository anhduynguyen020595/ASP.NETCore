using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace CS_Linq
{
    public class Products
    {
        public static List<Product> products;

        static Products()
        {
            products = new List<Product>(){
                                            new Product(1, "Table",    200, new string[] {"White", "Blue"},1),
                                            new Product(2, "Leather bag",     300, new string[] {"Red", "Black", "Yellow"},2),
                                            new Product(3, "Tea Table",    400, new string[] {"Gray", "Blue"},2),
                                            new Product(4, "Paintings", 400, new string[] {"Yellow", "Blue"},1),
                                            new Product(5, "Chandeliers",   500, new string[] {"White"},3),
                                            new Product(6, "Bed", 500, new string[] {"White"},2),
                                            new Product(7, "Wardrobe",      600, new string[] {"White"},3),
                                          };
        }

        public static void Price500()
        {
            var products = Products.products;
            var result = from product in products
                         where product.Price == 500
                         select product;

            foreach (var product in result)
            {
                System.Console.WriteLine(product.ToString());
            }
        }

        public static void GetNameAndColor()
        {
            var products = Products.products;

            var result = from product in products
                         select new
                         {
                             name = product.Name.ToUpper(),
                             color = string.Join(',', product.Colors)
                         };
            foreach (var item in result)
                System.Console.WriteLine(item.name + " - " + item.color);
        }

        public static void GetProductWithYellowColor()
        {
            var products = Products.products;

            var result = from product in products
                         from color in product.Colors
                         where product.Price < 500
                         where color == "Yellow"
                         select product;

            foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }
        }

        public static void SortDescending()
        {
            var products = Products.products;

            var result = from product in products
                         where product.Price <= 300
                         orderby product.Price descending
                         select product;

            foreach (var item in result)
            {
                System.Console.WriteLine($"{item.Name} - {item.Price}");
            }
        }

        public static void GroupBy()
        {
            var products = Products.products;

            // Solution 1
            var result = from product in products
                         where product.Price >= 400 && product.Price <= 500
                         group product by product.Price;

            // Solution 2
            result = from product in products
                     where product.Price >= 400 && product.Price <= 500
                     group product by product.Price into gr
                     orderby gr.Key descending
                     select gr;

            foreach (var item in result)
            {
                System.Console.WriteLine(item.Key);
                foreach (var product in item)
                {
                    System.Console.WriteLine($"{product.Name} - {product.Price}");
                }
            }
        }

        public static void LetLinq()
        {
            var products = Products.products;

            var result = from product in products
                         group product by product.Price into gr
                         let count = gr.Count()
                         select new
                         {
                             price = gr.Key,
                             number_product = count
                         };

            foreach (var item in result)
            {
                System.Console.WriteLine($"{item.price} - {item.number_product}");
            }
        }


        public static void InnerJoin()
        {
            var products = Products.products;
            var brands = Brand.brands;

            var result = from product in products
                         join brand in brands on product.Brand equals brand.ID
                         select new { name = product.Name, brand = brand.Name, price = product.Price };

            foreach (var item in result)
            {
                System.Console.WriteLine($"{item.name,12} { item.price,4} {item.brand,12}");
            }
        }

        public static void LeftJoin()
        {
            var products = Products.products;
            var brands = Brand.brands;

            var result = from product in products
                         join brand in brands on product.Brand equals brand.ID into t
                         from brand in t.DefaultIfEmpty()
                         select new
                         {
                             name = product.Name,
                             brand = (brand == null) ? "NO-BRAND" : brand.Name,
                             price = product.Price
                         };

            foreach (var item in result)
            {
                System.Console.WriteLine($"{item.name,12} { item.price,4} {item.brand,12}");
            }
        }
    }
}