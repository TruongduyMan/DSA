using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static int Menu(string[] items)
        {
            int choice;
            int len = items.Length;

            do
            {
                for (int i = 0; i < len; i++)
                    Console.WriteLine($"{i}. {items[i]}");
                Console.WriteLine($"{len}. Thoat");
                Console.Write("Chon 1 chuc nang: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if ((choice >= 0) && (choice <= len))
                {
                    break;
                }

            } while (true);

            return choice;
        }

        static void Main(string[] args)
        {
            string[] items = {"Them vao cuoi danh sach","Them vao dau danh sach"
            ,"Xoa nut dau","Xoa nut cuoi", "In danh sach"};
            int choice;
            LinkedList<int> ml = new LinkedList<int>();

            do
            {
                choice = Menu(items);
                switch (choice)
                {
                    case 0:
                        {
                            Console.Write("Nhap 1 so: ");
                            int x = Convert.ToInt32(Console.ReadLine());
                            ml.AddLast(x);
                            break;

                        }
                    case 1:
                        {
                            Console.Write("Nhap 1 so: ");
                            int x = Convert.ToInt32(Console.ReadLine());
                            ml.AddFirst(x);
                            break;

                        }
                    case 2:
                        {
                            ml.RemoveFirst(); break;
                        }
                    case 3:
                        {
                            ml.RemoveLast(); break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Noi dung danh sach: ");
                            for (LinkedListNode<int> node = ml.First; node != null;)
                            {
                                Console.Write($"{node.Value} ");
                                node = node.Next;
                            }
                            break;
                        }
                    case 5: return;

                }
            } while (true);
        }
    }
}
