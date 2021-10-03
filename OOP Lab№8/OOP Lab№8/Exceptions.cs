using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_8
{
    class WrongIndexException : Exception
    {
        public WrongIndexException(string message) : base(message) => Console.WriteLine(message);
    }

    class WrongElementException : Exception 
    {
        public WrongElementException(string message) : base(message) => Console.WriteLine(message);
    }
}
