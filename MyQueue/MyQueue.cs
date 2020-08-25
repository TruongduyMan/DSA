using System;
using System.Collections.Generic;
using System.Text;

namespace MyQueue
{
    class MyQueue
    {
        private class Node
        {
            public object info;
            public Node next;
            public Node(object info, Node next)
            {
                this.info = info;
                this.next = next;
            }
            public Node(object info): this(info, null) { }

        }
            private Node head, tail;
            public MyQueue()
            {
                head = tail = null;
            }
            public bool isEmpty()
            {
                return head == null;
            }
            public void Enqueue(object x)
            {
                if (isEmpty())
                   head=tail=new Node(x);
                else
                {
                    tail.next = new Node(x);
                    tail = tail.next;
                }
            }
            public object dequeue()
            {
                if (isEmpty())
                    throw new Exception();
                object x = head.info;
                head = head.next;
                if (head == null) {
                    tail = null;
                }
                return x;
            }
            public object font()
            {
                if (isEmpty())
                    return null;
                return head.info;
            }
            
        
    }
}
