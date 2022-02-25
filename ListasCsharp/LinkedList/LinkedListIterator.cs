using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCsharp.LinkedList
{
    public class LinkedListIterator
    {

        private Node currentNode;

        internal LinkedListIterator(Node startNode)
        {
            currentNode = startNode;
        }

        public bool hasNext()
        {
            return currentNode != null;
        }

        public string next()
        {
            string data = currentNode.data;

            currentNode = currentNode.next;

            return data;
        }
    }
}
