using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace LinkedList
{
    public class LinkedList
    {
        static int Menu(string[] items)
        {
            int choice;
            int len = items.Length;

            do
            {
                for (int i = 0; i < len; i++)
                {
                    Console.WriteLine($"{i}.{items[i]}");
                    Console.Write("Choose 1 function. ");
                    choice = Convert.ToInt16(Console.ReadLine());
                    if ((choice >= 0) && (choice <= len))
                    {
                        break;
                    }
                }
            } while (true);

        }

        static void Main(string[] args)
        {
            //int[] a = { 1, 2, 4, 5, 3, 6, 7, 8 };
            
            //ml.addManyTail(a);
            //ml.traverse();
            //Console.ReadKey();

            string[] items = { "In vao cuoi danh sach", "In danh sach" };
            int choice;
            MyList<int> ml = new MyList<int>();
            do
            {
                choice = Menu(items);
                switch (choice)
                {
                    case 0:
                        {
                            Console.Write("Nhap 1 so");
                            int x = Convert.ToInt32(Console.ReadLine());
                            ml.addTail(x);
                            break;
                        }
                    case 1:
                        {
                            Console.Write("Nhap so ke tiep");
                            int x = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                }
            } while (true);
        }
    }
}
