using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_IPv4_Address
{
    class Program
    {
        /*
         * Kiểm tra một chuỗi nhập vào có phải là 1 địa chỉ IP v4 hay không
         */
        static void Main(string[] args)
        {Console.WriteLine(isIPv4Address("1.1.1.1a"));
            Console.ReadLine();
        }
        private static bool isIPv4Address(string inputString)
        {
            var arr = inputString.Split('.');
            if (arr.Length != 4)
                return false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (String.IsNullOrEmpty(arr[i]))
                    return false;
                if (!arr[i].All(char.IsDigit)) return false;
                if (arr[i].Length > 3) return false;
                if (int.Parse(arr[i]) < 0 || int.Parse(arr[i]) > 255)
                    return false;
            }
            return true;
        }

    }
}
