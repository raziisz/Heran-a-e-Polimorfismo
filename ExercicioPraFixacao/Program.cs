using ExercicioPraFixacao.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioPraFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> listProducts = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(op == 'i' || op == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listProducts.Add(new ImportedProduct(name, price, customsFee));
                } else if(op == 'u' || op == 'U')
                {
                    Console.WriteLine("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    listProducts.Add(new UsedProduct(name, price, manufactureDate));
                } else if(op == 'c' || op == 'C')
                {
                    listProducts.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS");

            foreach (Product product in listProducts)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
