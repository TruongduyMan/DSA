using System;

namespace Menu
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
                {
                    Console.WriteLine($"{i}.{items[i]}");
                    Console.Write("Choose 1 function. ");
                    choice = Convert.ToInt16(Console.ReadLine());
                    if ((choice >= 0)&& (choice <= len)){
                        break;
                    }
                }
            } while (true);

        }
		
        static void Main(string[] args)
        {
            string[] items = { "In vao cuoi danh sach", "In danh sach" };
            int choice;
            MyList ml = new MyList();
            do
            {
                choice = Menu(items);
                switch(choice){
                    case 0:
                        {
                            Console.Write("Nhap 1 so");
                            int x = Convert.ToInt32(Console.ReadLine());
                            ml.addTail(x);
                            break;
                        }
                }
            } while (true);
        }
    }
}
