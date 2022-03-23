using System;
using System.Collections.Generic;

namespace Trees
{
    public class Tree
    {
        public void PreOrderNAry(Node root)
        {
            Stack<Node> nodes = new Stack<Node>();
            nodes.Push(root);
            while (nodes.Count != 0)
            {
                Node curr = nodes.Pop();
                if (curr != null)
                {
                    Console.WriteLine(curr.key+" ");
                    for (int i = curr.child.Count - 1; i >= 0; i--)
                    {
                        nodes.Push(curr.child[i]);
                    }
                }

            }
        }

        public void CreateTree()
        {
            Node root = new Node('A');
            (root.child).Add(new Node('B'));
            (root.child).Add(new Node('F'));
            (root.child).Add(new Node('D'));
            (root.child).Add(new Node('E'));
            (root.child[0].child).Add(new Node('K'));
            (root.child[0].child).Add(new Node('J'));
            (root.child[2].child).Add(new Node('G'));
            (root.child[3].child).Add(new Node('C'));
            (root.child[3].child).Add(new Node('H'));
            (root.child[3].child).Add(new Node('I'));
            (root.child[0].child[0].child).Add(new Node('N'));
            (root.child[0].child[0].child).Add(new Node('M'));
            (root.child[3].child[0].child).Add(new Node('O'));
            (root.child[3].child[2].child).Add(new Node('L'));

            PreOrderNAry(root);
        }
    }
    public class Node
    {
        public char key;
        public List<Node> child;
        public Node(char key)
        {
            this.key = key;
            this.child = new List<Node>();
        }
    }
}
