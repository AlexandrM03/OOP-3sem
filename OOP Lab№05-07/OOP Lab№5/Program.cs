using OOP_Lab_5.Exceptions;
using System;
using System.Linq;

namespace OOP_Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
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

                Clocks clocks = new Clocks();
                Flowers flowers = new Flowers();
                clocks.ShowMoney();
                clocks.Buy();
                clocks.TopUp(100);
                // clocks.TopUp(-1); /////////////////////////////////////////////////////////////////
                // clocks.TopUp(1000000); /////////////////////////////////////////////////////////////////
                flowers.Buy(50);
                // clocks.Buy(); /////////////////////////////////////////////////////////////////

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

                // (cake as IPastry).Print();
                // (cake is IPastry).Print(); // Не вызовет исключение

                printer.IAmPrinting(sweets);
                printer.IAmPrinting(cake);
                Console.WriteLine();

                Sweets candies = new Sweets();
                foreach (var candy in candies.companies)
                {
                    Console.WriteLine($"{$"Company: {candy.Type},".PadRight(25)}Price: {candy.Price}");
                }
                Console.WriteLine();

                Present<Goods> present = new Present<Goods>();
                present.Add(flowers, 4);
                present.Add(clocks);
                present.Add(flowers, 3);
                present.Show();
                present.ShowPrice();
                Console.WriteLine("\nСортируем по весу:");
                present.Sort();
                present.Show();
                Console.WriteLine();

                Console.WriteLine("Клонируем подарок:");
                var clone = (Present<Goods>)present.Clone();
                clone.Show();
                clone.ShowPrice();
                Console.WriteLine();

                Parser parser = new Parser();
                Console.WriteLine("\tFileParser");
                parser.ParseTextFile(present);
                present.Sort();
                present.Show();
                present.ShowPrice();
                Console.WriteLine();

                Console.WriteLine("\tJSONParser");
                parser.ParseJSON(present);
                present.Sort();
                present.Show();
                present.ShowPrice();
            }
            catch (TopUpEx ex)
            {
                Logger.WriteLog(ex);
            }
            catch (BuyEx ex)
            {
                Logger.WriteLog(ex);
            }
            finally
            {
                Console.WriteLine("\nEND");
            }
        }
    }
}
