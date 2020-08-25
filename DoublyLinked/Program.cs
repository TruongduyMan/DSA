using System;

namespace DoublyLinked
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
                if((choice>=0) && (choice <= len)){
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
            MyList<int> ml = new MyList<int>();

            do
            {
                choice = Menu(items);
                switch(choice){
                    case 0:
                        {
                            Console.Write("Nhap 1 so: ");
                            int x = Convert.ToInt32(Console.ReadLine());
                            ml.addHead(x);
                            break;

                        }
                    case 1:
                        {
                            Console.Write("Nhap 1 so: ");
                            int x = Convert.ToInt32(Console.ReadLine());
                            ml.addHead(x);
                            break;

                        }
                    case 2:
                        {
                            ml.removeHead(); break;
                        }
                    case 3:
                        {
                            ml.removeTail(); break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Noi dung danh sach: ");
                            ml.traverse();
                            break;
                        }
                    case 5: return;
                        
                }                   
            } while (true);

        }
        
    }
}
