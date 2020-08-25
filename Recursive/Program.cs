using System;

namespace Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luy thua

            //Console.Write("Nhap co so: ");
            //int a = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Nhap so mu: ");
            //int n = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine($"{a}^{n} ={powerth(a, n)} ");

            // Chuyen so thanh ma nhi phan

            //Console.Write("Nhap so can chuyen: ");
            //int decimalNum = Convert.ToInt32(Console.ReadLine());
            //Console.Write("So nhi phan tuong ung: ");
            //convertBin(decimalNum);
            //Console.WriteLine();

            //
            Console.Write("Nhap so dia: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Tower(n, 'A', 'B', 'C');
            Console.ReadLine();
            
        }

        static int powerth(int n, int a)
        {
            if (n == 0) return 1;
            return a* powerth(n - 1, a);
        }

        static void convertBin(int decimalNum)
        {
            int q = decimalNum / 2;
            int p = decimalNum % 2;
            if (q > 0)
            {
                convertBin(q);
            }
            Console.WriteLine(p);
        }

        static long fibo(long n)
        {
            if (n < 2) return n;
            return (fibo(n - 1) + fibo(n - 2));
        }

        static void Tower(int n, char a, char b, char c)
        {
            if (n == 1)
                Console.WriteLine($"Di chuyen dia tu {a} qua {c}");
            else
            {
                Tower(n - 1, a, c, b);
                Tower(1, a, b, c);
                Tower(n-1, b, a, c);
            }
        }

    }
}
