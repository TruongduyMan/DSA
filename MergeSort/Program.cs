using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] digits = { 242, 3423, 1, 213, 45, 5653, 234 };
            int n = digits.Length;
            Console.WriteLine("Mang phat sinh: ");
            print(digits, n);
            
            //radixSort(digits, n);
            Array.Sort(digits);
            Console.WriteLine("Mang sau khi in: ");

            print(digits, n);
            
            #region
            //list<int> unsorted = new list<int>();
            //list<int> sorted;

            //random random = new random();

            //console.writeline("original array elements:");
            //for (int i = 0; i < 10; i++)
            //{
            //    unsorted.add(random.next(0, 100));
            //    console.write(unsorted[i] + " ");
            //}
            //console.writeline();

            //sorted = mergesort(unsorted);

            //console.writeline("sorted array elements: ");
            //foreach (int x in sorted)
            //{
            //    console.write(x + " ");
            //}
            //console.write("\n");
            #endregion

        }

        //private static List<int> mergeSort(List<int> unsorted)
        //{
        //    if (unsorted.Count <= 1)
        //        return unsorted;

        //    List<int> left = new List<int>();
        //    List<int> right = new List<int>();

        //    int middle = unsorted.Count / 2;
        //    for (int i = 0; i < middle; i++)
        //    {
        //        left.Add(unsorted[i]);
        //    }

        //    left = mergeSort(left);
        //    right = mergeSort(right);

        //    return Merge(left, right);
        //}

        //private static List<int> Merge(List<int> left, List<int> right)
        //{
        //    List<int> result = new List<int>();

        //    while (left.Count > 0 || right.Count > 0)
        //    {
        //        if (left.Count > 0 && right.Count > 0)
        //        {
        //            if (left.First() <= right.First())
        //            {
        //                result.Add(left.First());
        //                right.Remove(left.First());

        //            }
        //            else
        //            {
        //                result.Add(right.First());
        //                right.Remove(right.First());

        //            }

        //        }
        //        else if (left.Count > 0)
        //        {
        //            result.Add(left.First());
        //            right.Remove(left.First());
        //        }
        //        else if (right.Count > 0)
        //        {
        //            result.Add(right.First());
        //            right.Remove(right.First());

        //        }
        //    }
        //    return result;
        //}

        static int getMax(int[] digits, int n)
        {
            int max = digits[0];
            for (int i = 1; i < n; i++)
            {
                if (digits[i] > max)
                    max = digits[i];
            }
            return max;
        }
        public static void CountSort(int[] digits, int n, int exp)
        {
            int[] output = new int[n];
            int i;
            int[] count = new int[10];

            for (i = 0; i < 10; i++)
            {
                count[i] = 0;
            }

            for (i = 0; i < n; i++)
            {
                count[(digits[i] / exp) % 10]++;
            }

            for (i = 0; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (i = n-1; i >=0; i--)
            {
                output[count[(digits[i] / exp) % 10] - 1] = digits[i];
                count[(digits[i] / exp) % 10]--;
            }

            for (i = 0; i < n; i++)
            {
                digits[i] = output[i];
            }
            
        }

        public static void radixSort(int[] digits, int n)
        {
            
            int max = getMax(digits, n);

            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountSort(digits, n, exp);
            }

        }

        public static void print(int[] digits, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(digits[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
