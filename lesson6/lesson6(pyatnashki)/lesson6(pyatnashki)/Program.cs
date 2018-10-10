using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6_pyatnashki_
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] sets = new char[] { 'w','a','d','s','q'};
            int[,] arr = new int[3,3];
            int size = arr.GetLength(0);
            int size2 = size;
            ArrCreator(arr, size, size2);
            Writer(arr, size, size2);
            int index1 = 1;
            int index2 = 1;
            ArrayGamer(arr, size, size2, sets, index1, index2);
            Console.ReadKey();
        }

        private static void ArrayGamer(int[,] arr, int size, int size2, char[] sets, int index1, int index2)
        {
            Console.WriteLine("press key to play: ...");
            string temp = Convert.ToString(Console.ReadLine());
            try
            {
                char choise = Convert.ToChar(temp);
                switch (choise)
                {
                    case 'w':
                        {
                            int iter = index1-1;
                            if ((iter >= 0 && iter <= size - 1) && (index2 >= 0 && index2 <= size2 - 1))
                            {
                                arr[index1, index2] = 1;
                                index1--;
                                arr[index1,index2]=0;
                            }
                            break;
                        }
                    case 's':
                        {
                            int iter = index1+1;
                            if ((iter>=0 && iter <= size - 1) && (index2>=0 && index2 <= size2 - 1))
                            {
                                arr[index1, index2] = 1;
                                index1++;
                                arr[index1, index2] = 0;
                            }
                            break;
                        }
                    case 'a':
                        {
                            int iter = index2-1;
                            if ((index1 >= 0 && index1 <= size - 1) && (iter >= 0 && iter <= size2 - 1))
                            {
                                arr[index1, index2] = 1;
                                index2--;
                                arr[index1, index2] = 0;
                            }
                            break;
                        }
                    case 'd':
                        {
                            int iter = index2+1;
                            if ((index1>=0 && index1 <= size - 1) && (iter>=0 && iter <= size2 - 1))
                            {
                                arr[index1, index2] = 1;
                                index2++;
                                arr[index1, index2] = 0;
                            }
                            break;
                        }
                    case 'q':
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Try more");
                            break;
                        }
                }
                Writer(arr, size, size2);
                ArrayGamer(arr, size, size2, sets, index1, index2);
            }
            catch (Exception) { ArrayGamer(arr, size, size2, sets, index1, index2); }
            
        }

        private static void Writer(int[,] arr, int size, int size2)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    if (j == size2 - 1) { Console.WriteLine(arr[i, j] + " "); }
                    else { Console.Write(arr[i, j] + " "); }
                }
            }
        }

        private static void ArrCreator(int[,] arr, int size, int size2)
        {
            
            for (int i = 0; i<size; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    arr[i, j] = 1;
                }
            }
            arr[1,1]=0;
        }
    }
}
