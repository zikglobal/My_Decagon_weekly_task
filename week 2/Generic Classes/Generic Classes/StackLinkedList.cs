using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Classes
{
    public class StackLinkedList <T>
    {
        Node<T> top;
        public StackLinkedList()
        {
            this.top = null;
        }
        public void Push(T item)
        {
            // the head of a stack has a top node and the tail has a bottom node. 
            // create a temp node and allocate memory
            Node<T> Temp = new Node<T>(item);
            if (top == null)
            {
                Temp.Next = null;
            }
            else
            {
                Temp.Next = top;
            }
            top = Temp;
        }
        // we use a boolean function to check if the stack is empty or not
        public bool IsEmpty() 
        {
            return top == null;
        }

        // function to return the top element in a stack
        public T Peek()
        { 
            // we check if the stack is empty
            if (!IsEmpty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack is Empty");
                return default;
            }
        }

        // a function to pop element from the stack
        public void Pop() // pop removes element at the beginning
        {

            // check for stack underflow
            if (top == null)
            {
                Console.WriteLine("\nStack UnderFlow");
                    return;
            }

            // update the top pointer to point to the next node
            top = top.Next;
            Console.WriteLine(top.data);
        }

        // a function to check the size of the stack
        public int Size()
        {
            Node<T> current = top;
            if (current == null)
            { 
            return 0;
            }
            int counter = 1;
            while (current.Next != null)
            {
                current = current.Next;
                counter++;
            }
            return counter;
        }
        public void PrintNode()
        {
            Node<T> current = top;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.Next;
            }
        }
    }
}
