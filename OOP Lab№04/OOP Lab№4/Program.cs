using System;

namespace OOP_Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            List firstLPList = new List();
            firstLPList.AddNode("Python");
            firstLPList.AddNode("Java");
            firstLPList.AddNode("C#");
            firstLPList.AddNode("C++");
            firstLPList.AddNode("Kotlin");
            firstLPList.ShowInfo();

            List secondLPList = new List();
            secondLPList.AddNode("JavaScript");
            secondLPList.AddNode("Swift");
            secondLPList.AddNode("Ruby");
            secondLPList.AddNode("Pascal");
            secondLPList.AddNode("VisualBasic");
            secondLPList.ShowInfo();

            List generalLPList = firstLPList + secondLPList;
            generalLPList.ShowInfo();
            generalLPList = -generalLPList;
            generalLPList.Remove("Pascal");
            generalLPList.Remove(3);
            generalLPList.ShowInfo();

            if (firstLPList == secondLPList)
                Console.WriteLine("Первый список равен второму!");
            else if (firstLPList != secondLPList)
                Console.WriteLine("Первый спискок не равен второму!");

            Console.WriteLine();
            List FL = new List();
            List SL = new List();
            FL.AddNode("123");
            FL.AddNode("456");
            SL.AddNode("123");
            SL.AddNode("456");
            FL.ShowInfo();
            SL.ShowInfo();

            if (FL == SL)
                Console.WriteLine("Первый список равен второму!");
            else if (FL != SL)
                Console.WriteLine("Первый спискок не равен второму!");

            Console.WriteLine();
            List emptyList = new List();
            if (emptyList)
                Console.WriteLine("Список пустой!");

            Console.WriteLine();
            List HL = new List();
            HL.AddNode("1aa23");
            HL.AddNode("ggf5");
            HL.AddNode("ddd");
            HL.AddNode("545");
            HL.ShowInfo();
            HL.Highlight();
            Console.WriteLine();

            StatisticOperations statisticOperations = new StatisticOperations();
            Console.WriteLine($"Конкатенация элементов: {statisticOperations.Concat(HL)}");
            Console.WriteLine($"Разница между длинами максимальной и минимальной строк: {statisticOperations.Difference(HL)}");
            Console.WriteLine($"Размер списка: {statisticOperations.GetSize(HL)}");
        }
    }
}
