using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_10
{
    class MyLinkedList<T> : LinkedList<T>
    {
        public void Show()
        {
            Console.Write("Linked list: ");
            foreach (T i in this)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
