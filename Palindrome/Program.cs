using System;
using System.Collections;
using System.Collections.Generic;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao mot chuoi: ");
            string st = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();
            foreach (char ch in st)
            {
                stack.Push(ch);
                queue.Enqueue(ch);
            }

            while (stack.Count > 0)
                if (stack.Pop() != queue.Dequeue()) break;
            if (stack.Count == 0)
                Console.WriteLine("Chuoi co tinh chat Palindrome");
            else
                Console.WriteLine("Chuoi khong co tinh chat Palindrome");
        }
    }
}
