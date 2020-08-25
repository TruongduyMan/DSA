using System;

namespace ArrayQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int[] a = new int[15];
            Console.Write("Mang phat sinh: ");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rd.Next(-100, 100);
            }
            Console.WriteLine();
            var q = new ArrayQueue();
            foreach (int i in a)
            {
                q.enqueue(i);
            }
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = (int)q.dequeue();
            }
            Console.Write("Mang sau khi duoc dua vao Stack: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]}");
            }
            Console.WriteLine();

        }
    }
}
