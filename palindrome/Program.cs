using System;
using System.Linq;
using System.Text;

namespace palindrome
{
    internal class Program
    {
        /*
         * Kiểm tra một chuỗi nhập vào có sắp xếp được thành chuỗi đối xứng hay không
         *
         * Input: "aabbc
         * Output: true ("abcba")
         */

        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập chuỗi cần kiểm tra: ");
            string s = Console.ReadLine();
            bool check = PalindromeRearranging(s);
            Console.WriteLine("is Palindrom? : {0}", check);
            Console.ReadLine();
        }
        static int NO_OF_CHARS = 256;
        private static bool PalindromeRearranging(string str)
        {
            //s = String.Concat(s.OrderBy(c => c));
            //if (s.Length == 1) return true;
            //for (int i = s.Length; i > 0; i--)
            //{
            //    if (s[0] == s[1])
            //    {
            //        s = s.Remove(0, 2);

            //        if (s.Length < 1)
            //        {
            //            return true;
            //        }

            //        Console.WriteLine(s);
            //        Console.WriteLine(s.Length);
            //    }
            //}

            //return false;

            
            int[] count = new int[NO_OF_CHARS];
            count = count.Select(i => 0).ToArray();

            // For each character in input strings, 
            // increment count in the corresponding 
            // count array 
            for (int i = 0; i < str.Length; i++)
                count[(int)(str[i])]++;

            // Count odd occurring characters 
            int odd = 0;
            for (int i = 0; i < NO_OF_CHARS; i++)
            {
                if ((count[i] & 1) == 1)
                    odd++;

                if (odd > 1)
                    return false;
            }

            // Return true if odd count is 0 or 1, 
            return true;
        }
    }
}