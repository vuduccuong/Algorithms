using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 20, 30, 45, 89, 105 };
            Linear_Search(arr, 45);

            Console.ReadLine();
        }

        private static void Linear_Search(int[] arr, int num)
        {
            int i = 1;
            if (i > arr.Length)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                for (i = 1; i < arr.Length; i++)
                {
                    if (arr[i] == num)
                    {
                        Console.WriteLine("A[{0}] = {1}",i,arr[i]);
                    }
                }
            }
        }
    }
}
