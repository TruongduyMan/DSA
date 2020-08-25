using System;
using System.Xml;

namespace Menu
{
    class MyList
    {
        public class Node
        {
            int info;
            Node next;

            public Node(int info, Node next)
            {
                this.info = info;
                this.next = next;

            }

            public Node(int info)
            {
                this.info = info;
                this.next = null;

            }

        }

        public class MyList
        {
            Node head, tail;
            public MyList()
            {
                head = tail = null;
            }
            public Boolean isEmpty()
            {
                return (head == null);
            }
            public void Add(int x)
            {
                Node q = new Node(x);
                if (isEmpty())
                {
                    head = tail = q;
                }
                else
                {
                    tail.next = q;
                    tail = q;
                }
            }
            public void addMany(int[] a)
            {
                foreach(int i in a)
                    Add(i);
            }
            public void traverse()
            {
                Node p = head;
                while (p != null)
                {
                    Console.WriteLine(value: p.info);
                    p = p.next;
                }
            }
        }

        internal void addTail(int x)
        {
            throw new NotImplementedException();
        }
    }
}