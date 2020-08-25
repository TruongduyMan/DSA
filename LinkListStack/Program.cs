using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkListStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so: ");
            int n = Convert.ToInt32(Console.ReadLine());
        }
        static string convertBin(int n)
        {
            Stack<int> s = new Stack<int>();
            while (n > 0)
            {
                s.Push(n % 2);
                    n /= 2;
            }
            string st = "";
            for (int i = 0; i < s.Count; i++)
            {
                st += s.Pop();
            }
            return st;
        }
    }
}
