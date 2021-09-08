using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_4
{
    class Node
    {
        private Node _next;
        private string _info;
        public Node GetNextNode
        {
            get => _next;
        }
        public string Info
        {
            get => _info;
            set => _info = value;
        }
        public Node SetNextNode(Node node) => _next = node;
    }
}
