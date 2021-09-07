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
        private uint price;
        private string number;

        // Свойства
        public int Id {
            get { return id; }
            set {
                if (value <= maxId)
                    id = value;
                else
                    Console.WriteLine("Неверный ID!");
            }
        }
        public string Model { get { return Model; } }
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
            set { color = value; }
        }
        public uint Price { 
            get { return price; }
            set { Price = value; }
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
            Console.WriteLine("Статический конструктор сработал!");
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
        public Car(string brand, ushort year, uint price, string color = "unknown", string number = "unknown")
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
        public Car(int id, string brand, string model, ushort year, string color, uint price, string number)
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
            Console.WriteLine($"\nID: {this.id}\n" +
                $"Бренд: {this.brand}\n" +
                $"Модель: {this.model}\n" +
                $"Год выпуска: {this.year}\n" +
                $"Цвет: {this.color}\n" +
                $"Цена: {this.price}$\n" +
                $"Номер машины: {this.number}\n");
        }

        // Override
        public override bool Equals (Object obj)
        {
            if (obj == null)
                return false;
            Car car = obj as Car;
            if (car as Car == null)
                return false;
            return car.id == this.id;
        }

        public override int GetHashCode()
        {
            if (this.id == -1)
                return 0;
            else
                return 1;
        }
    }
}
