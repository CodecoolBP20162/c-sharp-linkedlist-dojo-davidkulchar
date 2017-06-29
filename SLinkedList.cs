using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class SinglyLinkedList<T>
    {
        public class SLinkedList
        {

            public class Node
            {
                public object NodeContent;
                public Node Next;
            }

            private int size;
            public int Count
            {
                get
                {
                    return size;
                }
            }

            private Node head;
            private Node current;

            public SLinkedList()
            {
                size = 0;
                head = null;
            }


            public void Add(T content)
            {
                size++;
                var node = new Node()
                {
                    NodeContent = content
                };

                if (head == null)
                {
                    head = node;
                }
                else
                {
                    current.Next = node;
                }
                current = node;
            }

            public bool Remove(int Position)
            {
                if (Position == 1)
                {
                    head = null;
                    current = null;
                    return true;
                }

                if (Position > 1 && Position <= size)
                {
                    Node tempNode = head;

                    Node lastNode = null;
                    int count = 0;

                    while (tempNode != null)
                    {
                        if (count == Position - 1)
                        {
                            lastNode.Next = tempNode.Next;
                            return true;
                        }
                        count++;

                        lastNode = tempNode;
                        tempNode = tempNode.Next;
                    }
                }

                return false;
            }
        }
    }
}
