using System;
using System.Text;

namespace Prime
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Kiểm tra một số nhập vào có là số nguyên tố không");
            Console.WriteLine("-------------------------------------------------\n");
        continiu:
            Console.WriteLine("Nhập số tự nhiên");
            int a;
            int.TryParse(Console.ReadLine(), out a);

            if (CheckPrime(a) == 1)
            {
                Console.WriteLine("a là số nguyên tố");
            }
            else
                Console.WriteLine("a không là số nguyên tố");
            Console.Write("Bạn có muốn tiếp tục không?(Y/N): ");
            string awr = Console.ReadLine();
            if (awr == "Y" || awr == "y")
            {
                goto continiu;
            }
            else

                Console.ReadLine();
        }

        private static int CheckPrime(int a)
        {
            if (a < 2)
            {
                return 0;
            }
            else if (a > 2)
            {
                if (a % 2 == 0)
                {
                    return 0;
                }
                for (int i = 3; i < Math.Sqrt(a); i += 2)
                {
                    if (a % i == 0)
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }
    }
}