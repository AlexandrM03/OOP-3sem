using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_5
{
    class Printer
    {
        public void IAmPrinting(Product obj)
        {
            Console.WriteLine($"Type: {obj.ToString()}");
        }
    }

    abstract class Product
    {
        protected int countOfSelledProducts = 0;

        public override string ToString() => GetType().Name;
        public override int GetHashCode() => countOfSelledProducts;
        public override bool Equals(object obj) => GetType().Name == obj.ToString();
        public virtual string Company => "Walmart";
    }

    abstract class Goods : Product
    {
        protected float _money = 150.75f;

        public void TopUp(float value)
        {
            _money += value;
            ShowMoney();
        }
        public void ShowMoney()
        {
            Console.WriteLine($"Now you have {_money}$");
        }
        public abstract void Buy(int amount = 1);
    }

    class Flowers : Goods
    {
        private float _cost = 2.5f;

        public override void Buy(int amount = 1)
        {
            if (_money >= amount * _cost)
            {
                _money -= amount * _cost;
                ShowMoney();
                countOfSelledProducts++;
            }
            else
                Console.WriteLine("You don't have enough money...");
        }
    }

    class Clocks : Goods
    {
        private float _cost = 149.55f;

        public override void Buy(int amount = 1)
        {
            if (_money >= amount * _cost)
            {
                _money -= amount * _cost;
                ShowMoney();
                countOfSelledProducts++;
            }
            else
                Console.WriteLine("You don't have enough money...");
        }
    }

    class Pastry
    {

    }

    sealed class Cake : Pastry
    {

    }

    sealed class Sweets : Pastry
    {

    }
}
