using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_11
{
    class Person
    {
        public string Name { get; set; }
        public Car Car { get; set; }

        public Person (string Name, Car Car)
        {
            this.Name = Name;
            this.Car = Car;
        }
    }
}
