using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Luy thua = {0}",Mu(3,3));
            Console.ReadLine();
        }

        /// <summary>
        /// Tính lũy thừa của 1 số
        /// </summary>
        /// <param name="a">Lũy thừa</param>
        /// <param name="b">Số mũ</param>
        /// <returns>a^b</returns>
        private static long Mu(int a, int b)
        {
            long sum = 1;
            for (int i = 0; i < b; i++)
            {
                sum =sum * a;
            }
            return sum;
        }
    }
}
