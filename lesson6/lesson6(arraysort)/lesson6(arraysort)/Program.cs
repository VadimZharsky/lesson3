using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6_ArraySort_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[20];
            for (int i = 0; i <= arr.Length - 1; i++)
                arr[i] = rnd.Next(0, 50);
            Writer(arr);
            Console.WriteLine();
            Console.WriteLine("Select a way to sort:\n1.BubbleSort\n2.QuickSort\n3.InsertionSort");
            Byte choise = Convert.ToByte(Console.ReadLine());
            if (choise == 1) { BubbleSort(arr); }
            if (choise == 2) { QuickSort(arr, 0, arr.Length - 1); }
            if (choise == 3) { InsertionSort(arr); }
            Writer(arr);
            Console.ReadKey();
        }

        private static void QuickSort(int[] arr, int left, int right)
        {
            int i = left;
            int j = right;
            int aver = arr[(i + j) / 2];
            while (i <= j)
            {
                while (arr[i] < aver) i++;
                while (arr[j] > aver) j--;
                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++; j--;
                }
            }
            if (left < j)
            {
                QuickSort(arr, left, j);
            }

            if (i < right)
            {
                QuickSort(arr, i, right);
            }
        }
        public static void BubbleSort(int [] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public static void InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

        }
            public static void Writer(int[]arr)
        {
            foreach (int i in arr)
                Console.Write(i + "||");
        }
    }
}