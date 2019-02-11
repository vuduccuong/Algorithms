using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex(@"\d");
            foreach (Match item in reg.Matches("-vuduccuong-18061996"))
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
