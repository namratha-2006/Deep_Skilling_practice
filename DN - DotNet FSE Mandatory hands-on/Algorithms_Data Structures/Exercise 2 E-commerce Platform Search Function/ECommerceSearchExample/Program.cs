using System;

namespace ECommerceSearchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product(101,"Laptop","Electronics"),
                new Product(102,"Shoes","Fashion"),
                new Product(103,"Watch","Accessories"),
                new Product(104,"Phone","Electronics"),
                new Product(105,"Bag","Fashion")
            };

            Product linear = Search.LinearSearch(products, 104);

            Console.WriteLine("Linear Search");

            if (linear != null)
                Console.WriteLine(linear.ProductName);

            Product binary = Search.BinarySearch(products, 104);

            Console.WriteLine("Binary Search");

            if (binary != null)
                Console.WriteLine(binary.ProductName);

            Console.ReadKey();
        }
    }
}