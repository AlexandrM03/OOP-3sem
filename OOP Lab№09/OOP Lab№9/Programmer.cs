using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_9
{
    class Programmer
    {
        public delegate void Language(List<string> list);
        public event Language Delete;
        public event Language Shuffle;

        public void Remove(List<string> list)
        {
            Console.Write("Enter the index of element you want to remove: ");
            int index = int.Parse(Console.ReadLine());
            list.RemoveAt(index);

            Delete?.Invoke(list);
        }

        public void Mutate(List<string> list)
        {
            Random random = new Random();
            List<string> NewList = list.OrderBy(item => random.Next()).ToList();
            list.Clear();
            list.AddRange(NewList);

            Shuffle?.Invoke(list);
        }
    }
}
