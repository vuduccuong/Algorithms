using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        /*
         * Kiểm tra một chuỗi nhập vào có sắp xếp được thành chuỗi đối xứng hay không
         *
         * Input: "aabbc
         * Output: true ("abcba")
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập chuỗi cần kiểm tra: ");
            string s = Console.ReadLine();
            bool check = PalindromeRearranging(s);
            Console.WriteLine("is Palindrom? : {0}", check);
            Console.ReadLine();
        }

        private static bool PalindromeRearranging(string s)
        {
            s = String.Concat(s.OrderBy(c => c));
            if (s.Length == 1) return true;
            for (int i = s.Length; i >0; i--)
            {
                if (s[0] == s[1])
                {
                    s = s.Remove(0, 2);
                    
                    if (s.Length < 1)
                    {
                        return true;
                    }

                    Console.WriteLine(s);
                    Console.WriteLine(s.Length);
                }
            }

            return false;

        }
    }
}
