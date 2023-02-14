using PolimorfismoProduto.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace PolimorfismoProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the number of products: ");
            int numberProducts = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 1; i <= numberProducts; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.WriteLine("Common, used or imported (c/u/i) ?");
                char cui = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(cui == 'c') 
                {
                    products.Add(new Product(name, price));
                }
                else if (cui == 'u')
                {
                    Console.WriteLine("Manufactured data: (DD/MM/YYYY): " );
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProducts(name, price, date));
                }
                else
                {
                    Console.WriteLine("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsFee));
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Price Tags");
                foreach (Product product in products) 
                {
                    Console.WriteLine(product.priceTag());
                }



            }


        }
    }
}