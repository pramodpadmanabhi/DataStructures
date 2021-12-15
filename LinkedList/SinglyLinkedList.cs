using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class SinglyLinkedList
    {
        internal Node head;

        //Insert at Front of SingleLinkedList
        internal void InsertFront(SinglyLinkedList singleLinkedList, int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = singleLinkedList.head;
            singleLinkedList.head = new_node;
        }
        //Insert at Last of SingleLinkeList
        internal void InsertLast(SinglyLinkedList singleLinkedList, int new_data)
        {
            Node new_node = new Node(new_data);
            if (singleLinkedList.head == null)
            {
                singleLinkedList.head = new_node;
                return;
            }
            Node lastNode = GetLastNode(singleLinkedList);
            lastNode.next = new_node;

        }
        //Returns lastNode of LinkedList
        internal Node GetLastNode(SinglyLinkedList singleLinkedList)
        {
            Node temp = singleLinkedList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        //Insert Data After a Given Node of LinkedList
        internal void InsertAfter(Node prev_node, int new_data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node cannot be null");
                return;
            }
            Node new_node = new Node(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }

        //Delete a Node From a SinglyLinkedList using a given key value
        internal void DeleteNodeByKey(SinglyLinkedList singleLinkedList, int key)
        {
            Node temp = singleLinkedList.head;
            Node prev = null;
            if (temp == null)
            {
                return;
            }
            if (temp != null && temp.data == key)
            {
                singleLinkedList.head = temp.next;
            }
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = prev.next;
            }
            prev.next = temp.next;
        }
        //Reverse a LinkedList
        // 1) We need two pointers to keep track of Previous and next nodes and initialize them to null
        // 2) Start Traversing the list from head node to the last node and reverse the pointer of one node in each iteration
        // 3) Once the list is exhausted , set the last node as the head node
        internal void ReverseLinkedList(SinglyLinkedList singleLinkedList)
        {
            Node prev = null;
            Node current = singleLinkedList.head;
            Node temp = null;
            while (current != null)
            {
                temp = current.next; //Temp Next Pointer
                current.next = prev; // LinkChanger
                prev = current; //Change current pointer status
                current = temp; // set current to temp next pointer
            }
            singleLinkedList.head = prev;
        }
    }
    internal class Node
    {
        internal int data;
        internal Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }

    internal class Questions
    {
        //Function that counts the number of times a given int occurs in a LinkedList for a given key
        internal void NumberIntCount(Node head,int key)
        {
            Node temp = head;
            int count = 0;
            if (head == null)
            {
                return;
            }
            while (temp != null)
            {
                if (temp.data == key)
                {
                    count++;
                }
                temp = temp.next;
            }
            Console.WriteLine("frequency of a numbers is:",count);
        }

        //Remove Duplicates Elements from a Unsorted LinkedList
        internal Node RemoveDuplicatesUnsorted(Node head)
        {
            //Your code here
            HashSet<int> set = new HashSet<int>();
            Node temp = head;
            Node prev = null;

            while (temp != null)
            {
                if (set.Contains(temp.data))
                {
                    prev.next = temp.next;
                }
                else
                {
                    set.Add(temp.data);
                    prev = temp;
                }
                temp = temp.next;
            }
            return head;

        }

        //Remove Duplicates Elements from a Unsorted LinkedList
        internal Node RemoveDuplicatesSorted(Node head)
        {
            //Your code here
            Node temp = head;
            while (temp.next != null)
            {
                if (temp.data == temp.next.data)
                {
                    temp.next = temp.next.next;
                }
                else
                {
                    temp = temp.next;
                }
            }
            return head;
        }

    }
}
