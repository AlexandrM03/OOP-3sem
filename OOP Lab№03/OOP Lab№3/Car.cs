using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_3
{
    public partial class Car
    {
        // Поля
        private const int maxId = 9999999; // id - из 7 цифр
        private static readonly string country;
        private static int count;

        private int id;
        private string brand;
        private string model;
        private ushort year;
        private string color;
        private int price;
        private string number;

        // Свойства
        public int Id {
            get => id;
            set {
                if (value <= maxId)
                    id = value;
                else
                    Console.WriteLine("Неверный ID!");
            }
        }
        public string Model { get => model; set { model = value; } }
        public ushort Year { 
            get { return year; }
            set { 
                if (value >= 1980 && value <= 2021)
                    year = value;
                else
                    Console.WriteLine("Неверная дата!");
            }
        } 
        public string Color { 
            get { return color; }
            private set { }
        }
        public int Price { 
            get { return price; }
            set { price = value; }
        }
        public string Number { 
            get { return number; }
            set { number = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int Count
        {
            get { return count; }
        }

        // Конструкторы
        static Car()
        {
            Console.WriteLine("Статический конструктор сработал!\n");
            country = "Belarus";
            count = 0;
        }
        public Car()
        {
            id = -1;
            Car.count++;
        }
        private Car(int id)
        {
            this.id = id;
            Car.count++;
        }
        public Car(string brand, ushort year, int price, string color = "unknown", string number = "unknown")
        {
            if (year >= 1991 && year <= 2021 && id <= maxId)
            {
                this.brand = brand;
                this.year = year;
                this.price = price;
                this.color = color;
                this.id = -1;
                this.number = number;
                Car.count++;
            }
            else
                throw new Exception("Некорректный ввод!");
        }
        public Car(int id, string brand, string model, ushort year, string color, int price, string number)
        {
            if (year >= 1991 && year <= 2021 && id <= maxId)
            {
                this.id = id;
                this.brand = brand;
                this.model = model;
                this.year = year;
                this.color = color;
                this.price = price;
                this.number = number;
                Car.count++;
            }
            else
                throw new Exception("Некорректный ввод!");
        }

        // Методы
        public void IncreasePrice(ref int price, int percent = 10)
        {
            price += price * percent / 100;
        }

        public void DecresePrice(ref int price, int percent = 10)
        {
            price -= price * percent / 100;
        }

        public void ChangeModel(out string model, string newModel)
        {
            model = newModel;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
