using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] month = new string[] 
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            var s1 = month.Where(n => n.Length == 7);
            var s2 = month.Where((n, i) => (i < 2) || (i > 4 && i < 8) || (i == 11));
            var s3 = month.OrderBy(x => x);
            //var s3 = from m in month
            //         orderby m
            //         select m;
            var s4 = month.Where(x => x.Contains("u") && x.Length >= 4);

            foreach (var i in s1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------------------");
            foreach (var i in s2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------------------");
            foreach (var i in s3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------------------");
            foreach (var i in s4)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            /////////////////////////////////////////////////////////
            Console.WriteLine();

            List<Car> cars = new List<Car>();
            cars.Add(new Car(1317777, "Porsche", "911", 2018, "Gold", 180000, "MB2332-6"));
            cars.Add(new Car(131344, "Toyota", "820", 2010, "Black", 13000, "MB2FD4-3"));
            cars.Add(new Car(1317723, "Mercedes", "AMG", 2016, "Silver", 40000, "MT2343-5"));
            cars.Add(new Car(131771, "Reno", "Logan", 1998, "Red", 12000, "MB2FV2-2"));
            cars.Add(new Car(131771, "Porsche", "920", 2012, "Red", 200000, "MB3HV2-2"));
            cars.Add(new Car(131771, "Porsche", "Panamera", 2016, "Blue", 220000, "MB2FV3-4"));
            cars.Add(new Car(131771, "Toyota", "Camry", 2020, "Red", 34000, "MG8FV2-2"));
            cars.Add(new Car(131771, "Toyota", "Camry", 2012, "Red", 24000, "MUIFV2-3"));

            var c1 = cars.Where(x => x.brand == "Porsche");
            var c2 = cars.Where(x => x.model == "Camry" && (2021 - x.year) >= 3);
            var c3 = cars.Count(x => x.color == "Red" && x.price > 15000);
            var c4 = cars.OrderByDescending(x => x.year).TakeLast(1);
            var c5 = cars.OrderByDescending(x => x.year).Take(5);
            var c6 = cars.OrderByDescending(x => x.price).Select(x => x.price);

            Console.WriteLine("-------------------------");
            Console.WriteLine();
            foreach (var i in c1)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            foreach (var i in c2)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.WriteLine(c3);
            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            foreach (var i in c4)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            foreach (var i in c5)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("-------------------------"); 
            Console.WriteLine();
            foreach (var i in c6)
            {
                Console.WriteLine(i.ToString());
            }

            var five = cars.Where(p => p.price > 185000)
                .Where(b => b.brand == "Porsche")
                .OrderBy(m => m.model)
                .Where(c => c.color == "Red")
                .Select(x => x);

            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            foreach (var i in five)
            {
                Console.WriteLine(i.ToString());
            }

            Person p1 = new Person("Artem", cars[0]);
            Person p2 = new Person("Stepa", cars[3]);
            Person p3 = new Person("Maks", cars[4]);
            Person p4 = new Person("Ira", cars[7]);
            List<Person> people = new List<Person>() { p1, p2, p3, p4 };
            var last = people.Join(cars, 
                p => p.Car,
                c => c,
                (p, c) => new { Name = p.Name, Brand = c.brand, Model = c.model }
                );
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            foreach (var i in last)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
