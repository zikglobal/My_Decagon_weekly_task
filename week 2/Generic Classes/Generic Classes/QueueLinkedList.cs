using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Classes
{
    internal class QueueLinkedList<T>
    {
        Node<T> front, rear;
        public QueueLinkedList()
        {
            this.front = this.rear = null;
        }
        //Method to add a key to the Queue.
        public void Enqueue(T key) 
        
        {
            // Create a new Node
            Node<T>temp = new Node<T>(key);

            // if Queue is empty, then new node is both front and rear

            if (this.rear == null)
            {
                this.front = this.rear = temp;
                return;
            }
            // Add the new node at the end of the Queue and change rear

            this.rear.Next = temp;
            this.rear = temp;

        }
        // Method to remove a key from Queue
        public void Dequeue()
        {
            // if queue is empty, return null
            if (this.front == null)
                return;

            //Store previous front and move front one node ahead
            Node<T> temp = this.front;
            this.front = this.front.Next;

            // if front becomes null then change rear also as null
            if (this.front == null)
                this.rear = null;
        }
        public bool IsEmpty()
        {
            return this.front == null; 
        }
        public int Size()
        {
            Node<T> current = front;
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
            Node<T> current = front;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.Next;
            }
        }
    }
}
