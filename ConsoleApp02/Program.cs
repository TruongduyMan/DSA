using System;
using System.Threading;

namespace ConsoleApp02
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Random rd = new Random();
            
            Console.WriteLine($"So luong phan tu");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Mang phat sinh ngau nhien");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rd.Next(-20, 50);
                Console.Write($"{a[i]} ");
            }

            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                count = rd.Next(-20, 50);
                if (KiemTra(Math.Abs(a[i])))
                    ++count;
                Console.WriteLine($"{a[i]} ");
            }

            Console.WriteLine($"\nCo {count} so nguyen to trong mang");
            Console.ReadKey();
            
        }

        static bool KiemTra(int a)
        {
            if (a < 2)
                return false;
            if (a == 2)
                return true;

            // Kiem tra tung phan tu 
            for (int i = 2; i < (a-1); i++)
            {
                if (a%i == 0)
                    return false;
            }
            return true;
        }
    }
}
