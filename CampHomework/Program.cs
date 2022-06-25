using System;

namespace CampHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Laptop";
            product1.ProductBrand = "HP";
            product1.Price = 10000;

            Product product2 = new Product();
            product2.ProductName = "Monitor";
            product2.ProductBrand = "Asus";
            product2.Price = 8500;

            Product[] products = new Product[] { product1, product2 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Product Brand : "+products[i].ProductBrand);
            }

            Console.WriteLine("---for end----");

            Product[] products2 = new Product[] { product1, product2 };
            foreach (var item in products2)
            {
                Console.WriteLine(item.ProductName+" : "+item.Price);
            }

            Console.WriteLine("---ForeachEnd----");

            int j = 0;

            while (j<products2.Length)
            {
                Console.WriteLine(products2[j].Price);
                
                j++;
            }

            Console.WriteLine("While END");
        }
    }
    class Product
    {
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public int Price { get; set; }
    }
}
