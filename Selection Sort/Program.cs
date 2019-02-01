using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr = { 30, 50, 13, 4, 26, 24 };
            Console.Write("Mảng trước sắp xếp : ");
            foreach (var item in arr)
            {
                Console.Write(item + "; ");
            }

            SelectionSort(arr);
            Console.ReadLine();
        }

        private static void SelectionSort(int[] arr)
        {
            
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var indexmin = 1;
                for (int j =i+1; j < arr.Length; j++)
                {
                    if (arr[indexmin] > arr[j])
                    {
                        indexmin = j;
                    }
                }
                Swap(ref arr[indexmin], ref arr[i]);
            }
            Console.Write("\nMảng sắp xếp giảm :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "; ");
            }
        }

        /// <summary>
        /// Hóa đổi vị trí 2 số
        /// </summary>
        /// <param name="min">số thứ nhất</param>
        /// <param name="v">số thứ 2</param>
        private static void Swap(ref int min, ref int v)
        {
            min = min + v;
            v = min - v;
            min = min - v;
        }
    }
}
