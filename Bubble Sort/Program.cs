using System;
using System.Text;

namespace Bubble_Sort
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] arr = { 30, 50, 13, 4, 26, 24 };
            Console.Write("Mảng trước sắp xếp : ");
            foreach (var item in arr)
            {
                Console.Write(item + "; ");
            }

            BubbleSortUp(arr);
            BubbleSortDown(arr);

            Console.ReadLine();
        }

        private static void BubbleSortDown(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);

                        //var temp = arr[j + 1];
                        //arr[j + 1] = arr[j];
                        //arr[j] = temp;
                    }
                }
            }
            Console.Write("\nMảng sắp xếp giảm :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "; ");
            }
        }

        private static void BubbleSortUp(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);

                        //var temp = arr[j + 1];
                        //arr[j + 1] = arr[j];
                        //arr[j] = temp;

                        //arr[j] = arr[j] + arr[j + 1];
                        //arr[j + 1] = arr[j] - arr[j + 1];
                        //arr[j] = arr[j] - arr[j + 1];
                    }
                }
            }
            Console.Write("\nMảng sắp xếp tăng :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "; ");
            }
        }

        /// <summary>
        /// Hoán đổi vị trí 2 số
        /// </summary>
        /// <param name="v1">số thứ nhất</param>
        /// <param name="v2">số thứ 2</param>
        private static void Swap(ref int v1, ref int v2)
        {
            v1 = v1 + v2;
            v2 = v1 - v2;
            v1 = v1 - v2;
            Console.Write("\n"+v1 + " - " + v2);
        }
    }
}