using System;
using System.Collections.Generic;
using System.Text;

namespace LinkListStack
{
    class LinkListStack<T>
    {
        LinkedList<T> h;

        public LinkListStack()
        {
            h = new LinkedList<T>();
        }
        public bool isEmpty()
        {
            return h.Count == 0;
        }
        public void push(T x)
        {
            h.AddLast(x);
        }
        public T pop()
        {
            if (isEmpty())
                return (T)(object)null;
            T x = h.Last.Value;
            h.RemoveLast();
            return x;
        }
        public T top()
        {
            if (isEmpty())
                return (T)(object)null;
            return h.Last.Value;
        }

    }
}
