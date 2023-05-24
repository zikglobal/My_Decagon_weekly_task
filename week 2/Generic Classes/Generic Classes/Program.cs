namespace Generic_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList<int> LinkedList = new SinglyLinkedList<int>();
            LinkedList.AddToTail(1);
            LinkedList.AddToTail(2);
            LinkedList.AddToTail(3);
            LinkedList.AddToTail(4);

            Console.WriteLine(LinkedList.CheckValue(3));


            LinkedList.PrintNode();
            LinkedList.RemoveFirstOccurance(3);
            LinkedList.PrintNode();

            StackLinkedList<int> stacklist = new StackLinkedList<int>();
            stacklist.Push(1);
            stacklist.Push(2);
            stacklist.Push(3);
            stacklist.Push(4);
            stacklist.PrintNode();
            stacklist.Pop();
            Console.WriteLine (stacklist.Size());
            Console.WriteLine(stacklist.Peek());
            stacklist.PrintNode();

            QueueLinkedList<string> queuelist = new QueueLinkedList<string>();
            queuelist.Enqueue("Ruth");
            queuelist.Enqueue("Sunday");
            queuelist.Enqueue("Emmanuel");
            queuelist.Enqueue("Sarah");
            queuelist.PrintNode();
            queuelist.Dequeue();

            Console.WriteLine(queuelist.IsEmpty());
            Console.WriteLine(queuelist.Size);
            Console.WriteLine();
            queuelist.PrintNode();


        }
    }
}