using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCLN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Ước chung lớn nhất của 2 số");
            Console.WriteLine("---------------------------");
            int a, b;
            Console.WriteLine("Nhập số thứ nhất: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Nhập số thứ hai: ");
            int.TryParse(Console.ReadLine(), out b);
                Console.WriteLine("Ước chung lớn nhất của {0} và {1} là :{2}",a,b, UCLN(a, b));
                Console.ReadLine();
        }

        private static int UCLN(int firstNumber, int secondNumber)
        {
            if (secondNumber==0)
            {
                return firstNumber;
            }
            else
            {
                return UCLN(secondNumber, firstNumber % secondNumber);
            }
        }
    }
}
