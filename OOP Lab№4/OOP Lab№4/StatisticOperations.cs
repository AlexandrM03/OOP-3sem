using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_4
{
    class StatisticOperations
    {
        public string Concat(List list)
        {
            string result = "";
            Node _node = list.GetHead;
            while(_node != null)
            {
                result += _node.Info;
                _node = _node.GetNextNode;
            }

            return result;
        }

        public int Difference(List list)
        {
            int min = list.GetHead.Info.Length;
            int max = list.GetHead.Info.Length;
            Node _node = list.GetHead;
            while (_node != null)
            {
                if (_node.Info.Length > max)
                    max = _node.Info.Length;
                if (_node.Info.Length < min)
                    min = _node.Info.Length;
                _node = _node.GetNextNode;
            }

            return max - min;
        }

        public int GetSize(List list)
        {
            Node _node = list.GetHead;
            int count = 0;
            while (_node != null)
            {
                count++;
                _node = _node.GetNextNode;
            }

            return count;
        }
    }
}
