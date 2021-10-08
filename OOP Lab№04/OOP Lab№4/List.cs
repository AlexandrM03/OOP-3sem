using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_4
{
    class List
    {
        public class Owner
        {
            private string _name;
            private string _organization;
            private static int Id;

            Owner(string name, string organization)
            {
                this._name = name;
                this._organization = organization;
                Id++;
            }
            public void Print()
            {
                Console.WriteLine($"ID: {Id}\n" +
                    $"Name: {_name}\n" +
                    $"Organization: {_organization}");
            }
        }

        public class Date
        {
            private DateTime _time;

            public Date()
            {
                _time = DateTime.Now;
            }

            public void ShowDate()
            {
                Console.WriteLine(_time);
            }
        }

        private Node _tail;
        private Node _head;
        public Owner _Owner { get; set;}
        public Date _Date { get; set;}
        public int Length { get; private set; }

        public List()
        {
            _head = null;
            _tail = null;
            Length = 0;
        }

        public Node GetHead => _head;
        public Node GetTail => _tail;
        public void AddNode(string info)
        {
            if (_head == null)
            {
                _head = new Node();
                _head.Info = info;
                _tail = _head;
                _head.SetNextNode(null);
            }
            else
            {
                Node tempNode = new Node();
                tempNode.Info = info;
                _tail.SetNextNode(tempNode);
                _tail = tempNode;
                tempNode.SetNextNode(null);
            }

            Length++;
        }
        public string GetByIndex(int index)
        {
            Node node = _head;
            for(int i = 0; i < index; i++)
            {
                node = node.GetNextNode;
            }

            return node.Info;
        }
        public void ShowInfo()
        {
            Node node = _head;
            while(node.GetNextNode != null)
            {
                Console.Write(node.Info + " --> ");
                node = node.GetNextNode;
            }
            Console.WriteLine(node.Info);
        }
        public void Remove(string info)
        {
            Node node = _head;
            Node nextNode = _head.GetNextNode;

            if (node.Info == info)
            {
                _head = node.GetNextNode;
                Console.WriteLine($"Узел {info} удалён!");
                Length--;
                return;
            }
            while (nextNode != null)
            {
                if (nextNode.Info == info)
                {
                    node.SetNextNode(nextNode.GetNextNode);
                    Console.WriteLine($"Узел {info} удалён!");
                    Length--;
                    return;
                }
                node = node.GetNextNode;
                nextNode = nextNode.GetNextNode;
            }

            Console.WriteLine($"Узел {info} не найден!");
        }

        public void Remove(int index)
        {
            if (this.Length == 0)
            {
                Console.WriteLine("Список пуст!");
            }
            if (this.Length == 1)
            {
                _head = null;
            }
            if (index == 1)
            {
                Console.WriteLine($"Узел {_head.Info} удалён!");
                _head = _head.GetNextNode;
                return;
            }

            Node node = _head;
            Node nextNode = _head.GetNextNode;

            for (int i = 0; i < index - 2; i++) {
                node = node.GetNextNode;
                nextNode = nextNode.GetNextNode;
            }
            Console.WriteLine($"Узел {nextNode.Info} удалён!");
            node.SetNextNode(nextNode.GetNextNode);
        }

        public void Highlight()
        {
            Node node = _head;
            while (node != null)
            {
                string number = "";
                for (int i = node.Info.Length - 1; i >= 0; i--)
                {
                    if (char.IsDigit(node.Info[i]))
                    {
                        number = number.Insert(0, node.Info[i].ToString());
                        if (i > 0 && char.IsDigit(node.Info[i - 1]))
                            continue;
                        else
                            break;
                    }
                }
                if (number != "")
                    Console.Write(number + "   ");
                node = node.GetNextNode;
            }
        }

        // --------------------- Перегрузки ---------------------
        public static List operator +(List first, List second)
        {
            List newList = new List();
            for (int i = 0; i < first.Length; i++)
            {
                newList.AddNode(first.GetByIndex(i));
            }
            for (int i = 0; i < second.Length; i++)
            {
                newList.AddNode(second.GetByIndex(i));
            }

            return newList;
        }

        public static List operator -(List list)
        {
            list.Remove(1);
            return list;
        }

        public static bool operator ==(List first, List second)
        {
            if (first.Length != second.Length)
                return false;

            Node firstTemp = first.GetHead;
            Node secondTemp = second.GetHead;
            for(int i = 0; i < first.Length; i++)
            {
                if (firstTemp.Info != secondTemp.Info)
                    return false;
            }

            return true;
        }

        public static bool operator !=(List first, List second)
        {
            if (first.Length != second.Length)
                return true;

            Node firstTemp = first.GetHead;
            Node secondTemp = second.GetHead;
            for (int i = 0; i < first.Length; i++)
            {
                if (firstTemp.Info == secondTemp.Info)
                    continue;

                return true;
            }

            return false;
        }

        public static bool operator true(List list)
        {
            return list.Length == 0;
        }

        public static bool operator false(List list)
        {
            return list.Length != 0;
        }
    }
}
