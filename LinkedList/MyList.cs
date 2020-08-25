using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class MyList<T>
    {
        /// <summary>
        /// node
        /// </summary>

        private class Node
        {
            public T info;
            public Node next;

            public Node(T info, Node next)
            {
                this.info = info;
                this.next = next;
            }

            public Node(T info)
            {
                this.info = info;
                this.next = null;
            }
        }
           
        /// <summary>
        /// Head and Tail
        /// </summary>
        Node head, tail;
              public MyList()
              {
                    head = tail = null;
              }
                public bool isEmpty()
                {
                    return (head == null);
                }

                public void Add(T x)
                {
                    Node q = new Node(x);
                    if (isEmpty())
                    {
                        head = tail = q;
                    }
                    else
                    {
                        tail.next = q;
                        tail=q;
                    }
                }
                public void addManyTail(T[] a)
                {
                    foreach (T i in a)
                    {
                        addManyTail(a);
                    }
                }

        public void addTail(T x)
        {
            Node q = new Node();

        }

        public void traverse()
        {

           Node p = head;
           while (p != null)
           {
               Console.Write($"{p.info} ");
               p = p.next;
           }
        }
                
        public void addHead(T x)
        {
            Node p = new Node(x);
            p.next = head;
            head = p;
        }
        
        

        public void removeHead()
        {
                if (! isEmpty())
                {
                    head = head.next;
                    if (isEmpty())
                        tail = null;
                }
        }
        
        public void removeTail()
        {
            Node p = head, q = null;
            while (p!=tail)
            {
                q = p;
                p = p.next;

            }
            if (q == null)
            {
                head = null;
            }
            else
            {
                q.next = null;
            }
            q = tail;
        }

        

    }
}
