using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_10
{
    class Image 
    {
        private string _type;
        public string Type
        {
            get => _type;
        }

        public Image (string type)
        {
            _type = type;
        }

        public override string ToString() => "Image";
    }
}
