using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Maximal_Adjacent_Difference
{
    class Program
    {
        /*
         * Tìm giá trị chênh lệch lớn nhất của 2 phần tử cạnh nhau trong mảng
         * Input: [1,2,5,4,20]
         * Output:16 (20-4)
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr = new[] {1, 2, 3, 5, 4, 20};
            Console.WriteLine("mảng đầu vào: ");
            foreach (var VARIABLE in arr)
            {
                Console.Write(VARIABLE);
            }

            Console.WriteLine("\nĐộ chênh lệch giá trị lớn nhất là : {0}", ArrayMaximalAdjacentDifference(arr));
            Console.ReadLine();
        }
        static int ArrayMaximalAdjacentDifference(int[] inputArray)
        {
            int countDiffenren = 0;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {

                countDiffenren = Math.Max(Math.Abs(inputArray[i] - inputArray[i + 1]), countDiffenren);
            }
            return countDiffenren;
        }

    }
}
