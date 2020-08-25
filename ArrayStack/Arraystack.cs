using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ArrayStack
{
    class Arraystack
    {
        private object[] a;
        private int _top, max;

        public Arraystack(int max)
        {
            this.max = max;
            a = new object[max];
            _top = -1;
        }

        public Arraystack(): this(50)
        {

        }

        public bool isEmpty()
        {
            return _top == -1;
        }

        public bool isFull()
        {
            return _top == max - 1;
        }

        
        public void clear()
        {
            _top = -1;
        }

        public bool grow()
        {
            int max1 = max + max / 2;
            object[] a1 = new object[max1];
            if (a1 == null)
            {
                return false;
            }
            //Array.Copy(a, a1, max);
            for (int i = 0; i < _top; i++)
            {
                a1[i] = a[i];
            }
            a = a1;
            max = max1;
            return true;
        }

        public void push(object x)
        {
            if (isFull() && !grow()) 
                return;
            
            a[++_top] = x;
        }

        public object top()
        {
            if (isEmpty())
                return null;
            return (a[_top]);
        }

        public object pop()
        {
            if (isEmpty())
                return null;
            object x = a[_top];
            _top--;
            return x;
        }


    }
}
