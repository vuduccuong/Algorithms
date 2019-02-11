using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Regular_Expression
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập văn bản: ");
            string strinput;
            strinput =  Console.ReadLine();
            Console.WriteLine("Nhập chương trình: ");
            Console.WriteLine("1. chỉ lấy chữ số");
            Console.WriteLine("2. không lấy chữ số");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Regex reg = new Regex(@"\d");
                    foreach (Match item in reg.Matches(strinput))
                    {
                        Console.WriteLine(item.ToString());
                    }
                    break;
                case 2:
                    Regex a = new Regex(@"\D");
                    foreach (var item in a.Matches(strinput))
                    {
                        Console.WriteLine(item.ToString());
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}