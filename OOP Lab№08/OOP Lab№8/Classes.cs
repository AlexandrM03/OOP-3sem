using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_8
{
    class Pastry
    {
    }

    class Sweets : Pastry
    {
        public override string ToString() => "Sweets";
    }

    class Cake : Pastry
    {
        public override string ToString() => "Cake";
    }
}
