using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Classes
{
    public class Node<T>
    {
        public T data;
        public Node<T> Next;
        public Node(T value)
        {
            data = value;
            Next = null;
        }
        
    }
}
