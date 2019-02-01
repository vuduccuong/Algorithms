using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWithOracle
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Set tiếng việt trong console
            Console.OutputEncoding = Encoding.UTF8;

            //string dirPath = "D:/Vũ Đức Cường";
            //PrintDirectory(dirPath);
            //int[] a = {1,6,16,67,344,34,23,99,9,10 };

            //int x = int.Parse(Console.ReadLine());

            //int test = Search(a, a.Length, x);

            //Console.WriteLine(test);
            //Fibonaci();
            //int res = Sum(100);
            //Console.WriteLine("Tổng = {0}", res);

            //long gt = GiaiThua(20);
            //Console.WriteLine("50! = {0}", gt);

            //ThapHaNoi(3, 'A', 'B', 'C');
            ThapHaNoi(3, "Cột 1", "Cột 2", "Cột 3");

            Console.ReadLine();
        }

        /// <summary>
        /// Bài toán tháp hà nội
        /// </summary>
        /// <param name="v1">Số đĩa</param>
        /// <param name="v2">cột thứ nhất</param>
        /// <param name="v3">cột thứ 2</param>
        /// <param name="v4">cột thứ 3</param>
        private static void ThapHaNoi(int v1, string v2, string v3, string v4)
        {
            if (v1 > 0)
            {
                ThapHaNoi(v1 - 1, v2, v4, v3);
                Console.Write("{0} -> {1}\n", v2, v4);
                ThapHaNoi(v1 - 1, v3, v2, v4);
            }
        }

        /// <summary>
        /// Bài toán tính giai thừa của một số
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        private static long GiaiThua(int v)
        {
            long res;
            if (v ==1)
            {
                return 1;
            }
            else
            {
                res = v * GiaiThua(v - 1);
            }
            return res;
        }

        /// <summary>
        /// In tất cả các file con trong 1 folder
        /// </summary>
        /// <param name="dirPath"></param>
        public static void PrintDirectory(string dirPath)
        {
            try
            {
                IEnumerable<string> enums = Directory.EnumerateDirectories(dirPath);

                List<string> dirs = new List<string>(enums);

                foreach (var dir in dirs)
                {
                    Console.WriteLine(dir);

                    PrintDirectory(dir);
                }
            }
            catch (UnauthorizedAccessException uax)
            {
                throw uax;
                throw;
            }
        }


        /// <summary>
        /// TÌm kiếm nhị phân
        /// </summary>
        /// <param name="a">Mảng a</param>
        /// <param name="n">Số phần tử trong mảng</param>
        /// <param name="x">Giá trị cần tìm kiếm</param>
        /// <returns></returns>
        public static int Search(int[] a, int n, int x)
        {
            int i;
            for ( i = 0; i < n; i++)
                if (a[i] == x)
                    return i;
            return -1;
        }

        /// <summary>
        /// Dãy số fibonaci
        /// </summary>
        /// <param name="f0">Số hạng đầu tiên</param>
        /// <param name="f1">Số hạng thứ 2</param>
        public static void Fibonaci(int f0 =0, int f1=1)
        {
            for (int i = 1; i < 30; i++)
            {
                int fb = f0 + f1;
                f0 = f1;
                f1 = fb;
                Console.Write(fb+"; ");
            }

        }

        /// <summary>
        /// Tính tổng các số tự nhiên từ 1 đến 1
        /// </summary>
        /// <param name="num">số tự nhiên</param>
        /// <returns></returns>
        public static int Sum(int num)
        {
            int res;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                res = num + Sum(num - 1);
                //Console.WriteLine(res);
            }
            return res;
        }
    }
}
