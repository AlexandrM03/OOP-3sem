using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_12
{
    class Car
    {
        private string _brand;
        private string _model;

        private Car()
        {

        }

        public Car (string brand, string model)
        {
            _brand = brand;
            _model = model;
        }

        public string Brand => _brand;
        public string Model => _model;

        public string Drive() => "Driving";
        public string Stop() => "Stopped";
    }
}
