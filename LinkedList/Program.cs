using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }

    class DNode
    {
        private int data;
        private Node prev;
        private Node next;
        public DNode(int d)
        {
            data = d;
            next = null;
            prev = null;
        }
    }
    class DoublyLinkedList
    {
        Node head;
    }
}
