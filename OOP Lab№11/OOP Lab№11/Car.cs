using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_11
{
    class Car
    {
        public int id;
        public string brand;
        public string model;
        public ushort year;
        public string color;
        public int price;
        public string number;

        public Car(int id, string brand, string model, ushort year, string color, int price, string number)
        {
            this.id = id;
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.color = color;
            this.price = price;
            this.number = number;
        }

        public override string ToString()
        {
            return $"ID: {this.id}\n" +
                $"Бренд: {this.brand}\n" +
                $"Модель: {this.model}\n" +
                $"Год выпуска: {this.year}\n" +
                $"Цвет: {this.color}\n" +
                $"Цена: {this.price}$\n" +
                $"Номер машины: {this.number}\n";
        }
    }
}
