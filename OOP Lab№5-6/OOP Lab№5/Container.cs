using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_5
{
    class Present<T> : ICloneable, IGeneric<T> where T:Goods
    {
        private float _price = 0;
        public List<T> list;

        public Present()
        {
            list = new List<T>();
        }
        public object Clone()
        {
            return MemberwiseClone();
        }
        public void Sort()
        {
            list = list.OrderByDescending(w => w.Weight()).ToList();
        }
        public void Add(T item)
        {
            list.Add(item);
            _price += item.Price();
        }

        public void Add(T item, int count)
        {
            for (int i = 0; i < count - 1; i++)
            {
                list.Add(item);
                _price += item.Price();
            }
        }

        public void Delete(int index)
        {
            try
            {
                _price -= list[index].Price();
                list.RemoveAt(index);
            }
            catch
            {
                Console.WriteLine("Incorrect index!");
            }
        }

        public void Show()
        {
            foreach (T item in list)
                Console.WriteLine(item.ToString());
        }
        public void ShowPrice()
        {
            Console.WriteLine($"Current price: {_price}$");
        }
    }
}
