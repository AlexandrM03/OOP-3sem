using System;

namespace OOP_Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection<Product> products = new Collection<Product>();
            products.Add(new Flowers());
            products.Add(new Clocks());
            products.Show();
            Console.WriteLine($"Current size: {products.GetSize()}");
            Console.WriteLine();
            products.Delete(0);
            products.Show();
            Console.WriteLine($"Current size: {products.GetSize()}");
        }
    }
}
