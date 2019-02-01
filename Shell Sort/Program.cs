using System;
using System.Text;

namespace Shell_Sort
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            int[] arr = { 10, 289, 38, 29, 30, 5 };
            Console.Write("Mảng trước khi sắp xếp : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "; ");
            }

            ShellSort(arr);

            Console.ReadLine();
        }

        private static void ShellSort(int[] arr)
        {
            int inner, outer;
            int valueToInsert;
            int interval = 1;
            int elements = arr.Length;
            int i = 0;

            while (interval <= elements / 3)
            {
                interval = interval * 3 + 1;
            }

            while (interval > 0)
            {
                for (outer = interval; outer < elements; outer++)
                {
                    valueToInsert = arr[outer];
                    inner = outer;

                    while (inner > interval - 1 && arr[inner - interval] >= valueToInsert)
                    {
                        arr[inner] = arr[inner - interval];
                        inner -= interval;
                        Console.WriteLine("Di chuyển phần tử : {0}", arr[inner]);
                    }

                    arr[inner] = valueToInsert;
                    Console.WriteLine("Chèn phần tử {0} tại vị trí {1}", valueToInsert, inner);
                }

                interval = (interval - 1) / 3;
                i++;
            }
            Console.Write("\nMảng sau khi sắp xếp: ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "; ");
            }
        }
    }
}