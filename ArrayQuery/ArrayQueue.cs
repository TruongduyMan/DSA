using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayQuery
{
    class ArrayQueue
    {
        protected object[] a;
        protected int max;
        protected int first, last;
        public ArrayQueue(int max)
        {
            this.max = max;
            a = new object[max];
            first = last = -1;
        }
        public ArrayQueue() : this(10)
        {
            
        }
        public bool isEmpty()
        {
            return (first == -1);
        }
        public bool isFull()
        {
            return ((first == 0 && last == max - 1) || last == first - 1);    
        }
        public bool grow()
        {
            int i, j;
            int max1 = max + max / 2;
            object[] a1 = new object[max1];
            if (a1 == null)
                return false;
            if (first <= last)
            {
                for (i = first; i < max; i++)
                {
                    a1[i - first] = a[i];
                }
            }
            else
            {
                for (i = first; i < max; i++) a1[i - first] = a[i];
                for (j = first; j < max; j++)
                {
                    a1[j + max - first] = a[j];
                }
            }
            a = a1;
            max = max1;
            //
            int size;
            if (first <= last)
            {
                size = last - first + 1;
            }
            else
            {
                size = max-first+last+1;
            }
            first = 0;
            return true;
        }
        public void enqueue(object x)
        {
            if (isFull() && !grow()) return;
            if(last==max-1 || last == -1)
            {
                a[0] = x;
                last = 0;
                if (first == -1)
                    first = 0;
            }
            else
            {
                a[++last] = x;
            }
        }
        public object dequeue()
        {
            if(isEmpty())
              return null; 
            object x = a[first];
            if (first == last)
                first = last = -1;
            else if
                (first == max - 1)
                first = 0;
            else
                first++;
            return x;
            throw new Exception("The queue is Empty");
        }

    }
}
