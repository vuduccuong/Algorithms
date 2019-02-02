using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silent_Install
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Process.Start(@"C:\Users\Admin\Desktop\setup\FoxitReader614.0217_enu_Setup_sib.exe");
            }
            catch (Exception)
            {

                Console.WriteLine("Lỗi");
            }
            Console.ReadLine();
            
        }
        public static bool RunInstallMSI(string sMSIPath)
        {
            try
            {
                Console.WriteLine("Starting to install application");
                Process process = new Process();
                process.StartInfo.FileName = "FoxitReader614.0217_enu_Setup.exe";
                process.StartInfo.Arguments = string.Format(" /qb /i \"{0}\" ALLUSERS=1", sMSIPath);
                process.Start();
                process.WaitForExit();
                Console.WriteLine("Application installed successfully!");
                return true; //Return True if process ended successfully
            }
            catch
            {
                Console.WriteLine("There was a problem installing the application!");
                return false;  //Return False if process ended unsuccessfully
            }
        }
    }
}
