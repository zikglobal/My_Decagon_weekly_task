using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Classes
{
    public class SinglyLinkedList<T>
    {
        Node<T> head;
        public SinglyLinkedList()
        {
            head = null;
        }
        public void AddToTail(T data) 
        {
            if (head == null)
            {
                head = new Node<T>(data);
                return;
            }
            Node<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node<T>(data);

        }
        public bool CheckValue(T value)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (value.Equals(current.data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public int Index(T value)
        {
            Node<T> current = head;
            int count = 0;
            while (current != null)
            {
                if (value.Equals(current.data))
                {
                    return count;
                }
                current = current.Next;
                count++;
            }
            return count;
        }
        public bool RemoveFirstOccurance(T value)
        {
            Node<T> current = head;
            Node<T> temp = null;
            while (current.Next != null)
            {
                if (value.Equals(current.data))
                {
                    temp.Next = current.Next;
                    return true;
                }
                else
                {
                    temp = current;
                    current = current.Next;
                }
                
            }
            return false;
        }
        public void PrintNode()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.WriteLine("value of a Node is {0}", current.data);
                current = current.Next;
            }
        }
        
    }
 }  
    

