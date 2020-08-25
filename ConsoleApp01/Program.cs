using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhap du lieu
            
            Console.WriteLine("Nhap a: ");
            double a = 0;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            double b = 0;
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap c: ");
            double c = 0;
            c = Convert.ToInt32(Console.ReadLine());

            // Dieu kien a=0
            if (a == 0)
            {
                double x = -(c / b);

                if (b == 0)
                {
                    Console.WriteLine("Ptvn");
                }
                else
                {
                    Console.WriteLine("Ptvd");
                }
                if (b != 0)
                {
                    Console.WriteLine("X = {0}", x);
                }
                
            }

            // Dieu kien a!=0
            if (a != 0)
            {
                double delta = b*b - 4*(a)*(c);
                if (delta < 0)
                    Console.WriteLine("Phuong trinh vo  nghiem");
                if (delta == 0)
                {
                    double x =-b/(2*a);
                    Console.WriteLine("Phuong trinh co nghiem kep: x1=x2=X = {0}", x);
                }
                else // delta > 0
                {
                    double delta2= Math.Sqrt(delta);
                    double x1 = (-b + delta2) / (2 * a);
                    double x2 = (-b - delta2) / (2 * a);

                    Console.Write($"Phuong trinh co 2 nghiem phan biet: x1={x1}, x2={x2}", x1, x2);
                }
                
            }
            Console.ReadKey();
        }
    }
}
