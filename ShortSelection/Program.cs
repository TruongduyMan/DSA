using System;

namespace ShortSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            int chon;
            Console.WriteLine("Chon cac lenh sau: ");
            Console.WriteLine("1. Selection Sort");
            Console.WriteLine("2. Insert Sort");
            Console.WriteLine("3. Bubble Sort");
            Console.WriteLine("4. Bubble sort(2)");
            Console.WriteLine("5. Quick Sort");
            chon = int.Parse(Console.ReadLine());
            switch (chon)
            {
                case 1:
                    Console.WriteLine("1. Selection Sort");
                    break;
                case 2: Console.WriteLine("2. Insert Sort");
                    break;
                case 3: Console.WriteLine("3. Bubble Sort"); 
                    break;
                case 4: Console.WriteLine("4. Bubble sort(2)"); 
                    break;
                case 5: Console.WriteLine("5. Quick Sort"); break;
                default: 
                    break;
            }
            int[] a = new int[] { -1, 3, 4, 2, 6, 8, 12, 7, 0, 9 };
            Console.Write("Mang ban dau: ");
            foreach (var item in a)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            QuickSort(a, 0, a.Length - 1);

            Console.WriteLine();
            Console.WriteLine("Mang sau khi phan hach: ");

            foreach (var item in a)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine(a);
            
            //Console.Write("Nhap mang: ");
            //Random rd = new Random();
            //int[] a = new int[10];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = rd.Next(-10, 10);
            //}
            //Console.WriteLine("Mang phat sinh ngau nhien: ");
            //outputArray(a);
            //insertShort(a);
            //shortSelection(a);
            //Console.WriteLine("Mang sau khi xap sep: ");
            
            outputArray(a);

            bubbleSort(a);
            Console.WriteLine("Sorted array: ");
            outputArray(a);
            bubbleSort2(a);
            Console.WriteLine("Sorted array {2}: ");
            outputArray(a);

        }


        static void shortSelection<T>(T[] a) where T : IComparable
        {
            int n = a.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int i_min = i;
                for (int j = i + 1; j < n; j++)
                    if (a[i_min].CompareTo(a[j]) > 0)
                        i_min = j;
                swap(a, i, i_min);

            }
        }

        private static void swap<T>(T[] a, int i, int j) where T : IComparable
        {
            T tmp = a[i];
            a[i] = a[j];
            tmp = a[j];

        }

        static void insertShort<T>(T[] a) where T : IComparable
        {

            for (int i = 0; i < a.Length; i++)
            {
                T tmp = a[i];
                int j = i - 1;
                while (j >= 0 && a[j].CompareTo(tmp) > 0)
                {
                    a[j + 1] = a[i];
                    j--;
                }
                a[j++] = tmp;
            }
        }

        static void swap(int[] a, int i, int j)
        {
            int tmp = a[i];
            a[i] = a[j];
            tmp = a[j];

        }


        static void bubbleSort<T>(T[] a) where T : IComparable
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (a[j].CompareTo(a[j - 1]) < 0)
                        swap(a, j, j - 1);

                }
            }
        }

        static void bubbleSort2<T>(T[] a) where T : IComparable
        {
            int n = a.Length;
            for (int i = n-1; i>=1; i--)
            {
                for (int j = 0; j <i; j++)
                {
                    if (a[j].CompareTo(a[j + 1]) > 0)
                        swap(a, j, j + 1);
                }
            }
        }

        static void QuickSort(int[] a, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(a, left, right);

                if (pivot > 1)
                {
                    QuickSort(a, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(a, pivot + 1, right);
                }
            }
        }

        static int Partition(int[] a,int left, int right)
        {
            int pivot = a[left];
            while (true)
            {
                while (a[left] < pivot)
                {
                    left++;
                }
                while (a[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (a[left] == a[right]) return right;

                    int tmp = a[left];
                    a[left] = a[right];
                    a[left] = tmp;
                }
                else
                {
                    return right;
                }
            }
        }

        static void outputArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]}");
            }
            Console.WriteLine();
        }

        //static void printArray(int[] a)
        //{
        //    int n = a.Length;
        //    for (int i = 0; i < n; ++i)
        //        Console.Write(a[i] + " ");
        //    Console.WriteLine();
        //}

    }
}
