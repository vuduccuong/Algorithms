using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Tripple
{
    class Program
    {
        /*Cho một mảng số nguyên
         * đếm số lần thoả mãn sao cho: Lấy ra 3 phần tử ngẫu nhiên a,b,c sao cho
         * a+b>c
         * b+c>a
         * a+c>b
         *
         * Input: [1, 2, 10, 5, 12, 8, 2]
         * Output: 5
         *  1-2-2
            10-5-12
            10-5-8
            10-12-8
            5-12-8
         */
        static void Main(string[] args)
        {
            int[] arr = {1, 2, 10, 5, 12, 8, 2 };
            int a = arrayTriplets(arr);
            Console.WriteLine(a);

            Console.ReadLine();
        }
        private static int arrayTriplets(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    for (int k = j+1; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] > arr[k] && arr[i] + arr[k] > arr[j] && arr[j] + arr[k] > arr[i])
                        {
                            Console.WriteLine(arr[i]+"-"+arr[j]+"-"+arr[k]);
                            count++;
                        }
                    }
                }
            }
            return count;
        }

    }
}
