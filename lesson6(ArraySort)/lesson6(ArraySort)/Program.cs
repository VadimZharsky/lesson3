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
            for (int i = 0; i<= arr.Length-1;i++)
            {
                arr[i] = rnd.Next(0,50);
            }
            foreach (int i in arr)
                Console.Write(i+"||");
            Console.WriteLine();
            QuickSort(arr, 0, arr.Length-1);
            foreach (int i in arr)
                Console.Write(i + "||");

            Console.ReadKey();
        }

        private static void QuickSort(int[] arr, int left, int right)
        {
            int i = left;
            int j = right;
            int aver = arr[(i + j) / 2];
            while(i<=j)
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
    }
}
