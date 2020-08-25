using System;

namespace ArrayListStack
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
            ArrayListStack ar = new ArrayListStack();
            foreach (int i in a)
            {
                ar.push(i);
            }
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = (int)ar.pop();
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
