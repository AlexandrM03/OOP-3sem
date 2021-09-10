using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_5
{
    class Collection<T> : IGeneric<T> where T:class
    {
        private int size;
        public List<T> list;

        public Collection()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            list.Add(item);
            size++;
        }
        public void Delete(int index)
        {
            try
            {
                list.RemoveAt(index);
                size--;
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
        public int GetSize() => size;
    }
}
