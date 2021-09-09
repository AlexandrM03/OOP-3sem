using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_5
{
    class Classes
    {
        abstract class Product
        {
            protected int countOfProducts = 0;
            public override string ToString() => GetType().Name;
        }

        class Goods : Product
        {

        }

        class Pastry : Goods
        {

        }

        class Flowers : Goods
        {

        }

        class Clocks : Goods
        {

        }

        class Cake : Pastry
        {

        }

        sealed class Sweets : Pastry
        {

        }
    }
}
