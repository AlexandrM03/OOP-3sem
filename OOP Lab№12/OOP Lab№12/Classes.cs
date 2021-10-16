using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_12
{
    class Car : ICloneable
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

        public string Brand 
        {
            get => _brand;
            set => _brand = value;
        }
        public string Model => _model;

        public void GetId(int i) => Console.WriteLine(Convert.ToInt32(_model[0]) * i);
        public object Clone() => MemberwiseClone();
    }
}
