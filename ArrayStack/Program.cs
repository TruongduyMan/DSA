using System;
using System.Collections;

namespace ArrayStack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rd = new Random();
            //int[] a = new int[15];

            //Console.Write("Mang phat sinh: ");
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = rd.Next(-100, 100);
            //}
            //Console.WriteLine();
            //Arraystack ar = new Arraystack();
            //foreach (int i in a)
            //{
            //    ar.push(i);
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = (int)ar.pop();
            //}
            //Console.Write("Mang sau khi duoc dua vao Stack: ");
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write($"{a[i]}");
            //}
            //Console.WriteLine();

            Console.Write("Nhap 1 so: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int b;
            do
            {
                Console.Write("Nhap co so (2, 8 haoc 16): ");
                b = Convert.ToInt32(Console.ReadLine());
                if ((b == 2) || (b == 8) || (b == 16))
                    break;
            } while (true);
            Console.WriteLine($"So trong he tuong ung: {convert2816(n,b)}");
        }

        //static string convertBinary(int n)
        //{
        //    Arraystack stack = new Arraystack();
            
        //    while (n>0)
        //    {
        //        stack.push(n % 2);
        //        n = n / 2;
        //    }
        //    string s = "";
        //    object x;
        //    do
        //    {
        //        x = stack.pop();
        //        if (x == null)
        //            break;
        //        s += ((int)x).ToString();
        //    } while (true);
        //    return s;

        //}

        static string convert2816(int n, int b)
        {
            Arraystack stack = new Arraystack();

            while (n > 0)
            {
                stack.push(n % b);
                n = n / b;
            }
            string s = "";
            object x;
            string digit = "0123456789ABCDEF";
            do
            {
                x = stack.pop();
                if (x == null)
                    break;
                s += digit[(int)x];
            } while (true);
            return s;

        }
    }
}
