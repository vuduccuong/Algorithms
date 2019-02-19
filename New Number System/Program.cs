using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Number_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập ký tự A => Z : ");
            string cInput = Console.ReadLine();

            var arr = newNumeralSystem(Char.Parse(cInput));

            foreach (var item in arr)
            {
                Console.WriteLine(item + "\t");
            }
            //newNumeralSystem(char.Parse(cInput.ToUpper()));
            Console.ReadLine();
        }
        private static string[] newNumeralSystem(char number)
        {
            char[] strInput = { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z' };
            
            List<string> lstOut = new List<string>();
            for (int i = 0; i < strInput.Length; i++)
            {
                if (strInput[i] == number)
                {
                    for (int j = 0; j < i/2 +1; j++)
                    {
                        if(true)
                        {
                            lstOut.Add(strInput[j].ToString() + " + " + strInput[i - j].ToString());
                        }
                    }
                    break;
                }
            }

            return lstOut.ToArray();
        }

    }
}
