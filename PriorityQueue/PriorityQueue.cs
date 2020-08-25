using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PriorityQueue
{
    public class PriorityQueue<T> where T: IComparable
    {
        private T[] a;
        int top, max;
        public PriorityQueue(int max)
        {
            this.max = max;
            a = new T[max];
            top = -1;
        }
        public PriorityQueue(): this(50) { }
        public bool grow()
        {
            int max1 = max + max / 2;
            T[] a1 = new T[max1];
            if (a1 == null) return false;
            for (int i = 0; i < top; i++)
            {
                a1[i] = a[i];
            }
            max = max1;
            a = a1;
            return true;
        }
        public bool isEmpty()
        {
            return (top == -1);
        }
        public bool isFull()
        {
            return (top == max-1);
        }
        public bool Clear()
        {
            return (top == -1);
        }
        public void enqueue(T x)
        {
            if (isFull() || !grow())
                return;
            if (top == -1)
            {
                a[0] = x;
                top = 0;
                return;
            }
            int i = top;
            while ((i >= 0) && (x.CompareTo(a[i]) < 0))
            {
                a[i + 1] = a[i];
                i--;
            }
            a[i + 1] = a[i];
            top++;
        }
        public T dequeue()
        {
            if (isEmpty())
                return (T)(object)(null);
            T x = a[top--];
            return x;
        }
        public T front()
        {
            if (isEmpty())
                return (T)(object)(null);
            return a[top];
        }
    }
}
