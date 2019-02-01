using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            int[] arr = { 30, 50, 13, 4, 26, 24 };
            Console.Write("Mảng trước sắp xếp : ");
            foreach (var item in arr)
            {
                Console.Write(item + "; ");
            }

            Insertion_Sort(arr);
            Console.ReadLine();
        }

        /// <summary>
        /// Sắp xếp dãy tăng dần sử dụng thuật toán Insertion Sort
        /// </summary>
        /// <param name="arr">Mảng đầu vào</param>
        private static void Insertion_Sort(int[] arr)
        {
            int holePostion;
            int valueInsert;
            for (int i = 1; i < arr.Length; i++)
            {
                valueInsert = arr[i];
                holePostion = i;
                do
                {
                    arr[holePostion] = arr[holePostion - 1];
                    holePostion --;
                } while (holePostion>0 && arr[holePostion -1] > valueInsert);

                arr[holePostion] = valueInsert;
            }

            Console.Write("\nMảng sau khi sắp xếp");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "; ");
            }
        }
    }
}
