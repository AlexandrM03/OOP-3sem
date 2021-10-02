using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_5.Exceptions
{
    class BuyEx : Exception
    {
        public BuyEx(string message) : base(message) { }
    }
}
