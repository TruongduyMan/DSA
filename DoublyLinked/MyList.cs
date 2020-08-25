using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DoublyLinked
{


    class MyList<T>
    {
        private class Node
        {
            public T info;
            public Node next, prev;

            public Node(T info, Node next = null, Node prev = null)
            {
                this.info = info;
                this.next = next;
                this.prev = prev;
            }

        }
        private Node head, tail;
        public MyList()
        {
            head = tail = null;
        }
        public bool isEmpty()
        {
            return (head == null);
        }
        public void addTail(T x)
        {
            if (isEmpty())
            {
                head = tail = new Node(x);
            }
            else
            {
                Node p = new Node(x, null, tail);
                tail.next = p;
                tail = p;
            }
        }
        public void addManyTail(T[] x)
        {
            foreach (T i in x)
            {
                addTail(i);
            }
        }
        public void traverse()
        {
            Node p = head;
            while (p != null)
            {
                Console.Write($"{p.info} ");
                p = p.next;
            }
            Console.ReadLine();
        }

        public void addHead(T x)
        {
            if (isEmpty())
            {
                head = tail = new Node(x);
            }
            else
            {
                Node p = new Node(x, head, null);
                head.prev = p;
                head = p;
            }
        }
        public void removeHead()
        {
            if (!isEmpty())
            {
                head = head.next;
                if (isEmpty())
                    tail = null;
                else
                {
                    head.prev = null;
                }

        }    }
        public void removeTail()
        {
            if (!isEmpty())
            {
                tail = tail.prev;
                if (!isEmpty())
                {
                    head = null;
                }
                else
                {
                    tail.next = null;
                }
            }
        }

    } 
}
