using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    internal class DNode
    {
        public int data;
        public DNode prev;
        public DNode next;
        public DNode(int d)
        {
            data = d;
            next = null;
            prev = null;
        }
    }
    internal class DoublyLinkedList
    {
        DNode head;
        internal void InsertAtFront(DoublyLinkedList doublyLinkedList, int newData)
        {
            DNode new_node = new DNode(newData);

            new_node.next = head;
            new_node.prev = null;
            if (head != null)
            {
                head.prev = new_node;
            }
            head = new_node;
        }
        internal void AddNodeAfterGivenNode(DoublyLinkedList doublyLinkedList,int newData,DNode prev_node)
        {
            DNode new_node = new DNode(newData);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
            new_node.prev = prev_node;
            if (new_node.next != null)
            {
                new_node.next.prev = new_node;
            }
        }
        internal void AddNodeAtEnd(int newData)
        {
            DNode new_node = new DNode(newData);
            DNode last = head;
            new_node.next = null;
            if (head == null)
            {
                new_node.prev = null;
                head = new_node;
            }
            while (last != null)
            {
                last = last.next;
            }
            last.next = new_node;
        }
        internal void AddNodeBeforeGivenNode(DoublyLinkedList doublyLinkedList, int newData, DNode next_node)
        {
            DNode new_node = new DNode(newData);
            new_node.prev = next_node.prev;
            next_node.prev = new_node;
            new_node.next = next_node;
            if (new_node.prev != null)
            {
               new_node.prev.next = new_node;
            }
            else
            {
                head = new_node;
            }

        }

        /* Doubly Linked List Deletion
        *  Can be divided into three sections
        *  1) After the deletion of head node
        *  2) After the deletion of middle node
        *  3) After the deletion of last node

        /* All the three cases can be handled if pointer of the node to be deleted and head node is known
         *  1) If the node to be deleted is the head node the make the next node as head
         *  2) If a node is deleted , connect the next and previous nodes of the deleted node
         */

    }


}
