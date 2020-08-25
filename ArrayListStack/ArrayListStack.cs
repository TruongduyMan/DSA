using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayListStack
{
    class ArrayListStack
    {
        private ArrayList h;
        public ArrayListStack()
        {
            h = new ArrayList();
        }
        public bool isEmpty()
        {
            return h.Count == 0;
        }
        public void push(Object x)
        {
            h.Add(x);
        }
        public object pop()
        {
            if (isEmpty())
                return null;
            object x = h[h.Count - 1];
            h.RemoveAt(h.Count - 1);
            return x;
        }
        public object top()
        {
            if (isEmpty())
                return null;
            object x = h[h.Count - 1];
            return x;
        }
    }
}
