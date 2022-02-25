using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCsharp.LinkedList
{
    class Node
    {//  -> Las clases solo pueden ser públicas o package-private
        internal string data;
        internal Node next;
        internal Node previous;

        internal Node(string data)
        {
            this.data = data;
        }
    }
}
