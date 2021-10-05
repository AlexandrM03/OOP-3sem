using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_10
{
    class Comparer : IComparer<Image>
    {
        public int Compare(Image x, Image y)
        {
            return x.Type.CompareTo(y.Type);
        }
    }
}
