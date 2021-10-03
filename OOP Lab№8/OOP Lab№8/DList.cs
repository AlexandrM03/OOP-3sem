using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_8
{
    class MyList<T> : IGeneric<T>
    {
        private Node<T> _head;
        private Node<T> _tail;

        public int Length { get; private set; }
        public Node<T> GetHead() => _head;

        public MyList()
        {
            Length = 0;
            _head = null;
            _tail = null;
        }

        public T this[int index]
        {
            get
            {
                if (index > Length - 1) throw new ArgumentOutOfRangeException("index");

                Node<T> temp = GetHead();
                for (int i = 0; i < index; i++)
                {
                    temp = temp.NextNode;
                }

                return temp.Data;
            }
            set
            {
                if (index > Length - 1) throw new ArgumentOutOfRangeException("index");

                Node<T> temp = GetHead();
                for (int i = 0; i < index; i++)
                {
                    temp = temp.NextNode;
                }

                temp.Data = value;
            }
        }

        public void Add(T item)
        {
            if (_head == null)
            {
                _head = new Node<T>(item);
                _tail = _head;
            }
            else
            {
                Node<T> temp = new Node<T>(item);
                _tail.NextNode = temp;
                _tail = temp;
            }

            Length++;
        }

        public void Delete(T item)
        {
            Node<T> node = GetHead();
            if (node.Data.Equals(item))
            {
                _head = node.NextNode;
                Length--;
                return;
            }
            Node<T> nodeNext = node.NextNode;

            while (nodeNext != null)
            {
                if (nodeNext.Data.Equals(item))
                {
                    node.NextNode = nodeNext.NextNode;
                    Length--;
                    return;
                }

                node = nodeNext;
                nodeNext = nodeNext.NextNode;
            }

            throw new Exception(""); // TODO
        }

        public void Delete(int index)
        {
            Delete(this[index]);
        }

        public void Show()
        {
            if (Length == 0)
            {
                Console.WriteLine("Empty list!");
                return;
            }
            
            Node<T> temp = GetHead();
            while (temp.NextNode != null)
            {
                Console.Write($"{temp.Data} --> ");
                temp = temp.NextNode;
            }
            Console.WriteLine(temp.Data);
        }
    }
}
