using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_3
{
    public partial class Car
    {
        public void ShowCount()
        {
            Console.WriteLine($"Текущее количество машин: {count}\n");
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;
            Car car = obj as Car;
            if (car == null)
                return false;
            return car.id == this.id;
        }

        public override int GetHashCode()
        {
            return id == -1 ? 0 : id % 10;
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
