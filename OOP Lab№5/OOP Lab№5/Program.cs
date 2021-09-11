using System;

namespace OOP_Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();

            Collection<Product> products = new Collection<Product>();
            products.Add(new Flowers());
            products.Add(new Clocks());
            products.Show();
            Console.WriteLine($"Current size: {products.GetSize()}");
            Console.WriteLine();
            products.Delete(0);
            products.Show();
            Console.WriteLine($"Current size: {products.GetSize()}");
            Console.WriteLine();

            Cake cake = new Cake();
            IPastry cakeInterface = new Cake();
            Sweets sweets = new Sweets();
            IPastry sweetsInterface = new Sweets();
            cake.Print();
            cakeInterface.Print();
            sweets.Print();
            sweetsInterface.Print();
            Console.WriteLine();

            printer.IAmPrinting(sweets);
            printer.IAmPrinting(cake);
        }
    }
}
