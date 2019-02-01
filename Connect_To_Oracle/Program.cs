using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Connect_To_Oracle.Model;
using Oracle.ManagedDataAccess.Client;

namespace Connect_To_Oracle
{
    class Program
    {
        #region GetData
         static void GetData(OracleConnection conn)
        {
            try
            {
                conn.Open();
                Console.WriteLine("Kết nối thành công!");
                Console.WriteLine("-------------------");
                Console.WriteLine("Thực hiện truy vấn");
                Console.WriteLine("******************");
                Console.WriteLine("Kết quả truy vấn");
                Console.WriteLine("+-+-+-+-+-+-+-+-");

                string query = "SELECT 4+5 FROM Dual";
                OracleCommand cmd = new OracleCommand(query, conn);

                DbDataReader readers = cmd.ExecuteReader();

                if (readers.Read())
                {
                    Console.WriteLine(readers.GetValue(0));
                    conn.Close();
                }
                else
                {
                    Console.WriteLine("Có lỗi!!!!!!!!!!!");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi " + ex);
                conn.Close();
            }
        }
        #endregion

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            OracleConnection conn = DBUnit.GetDBConnection();
            Console.WriteLine("Tạo kết nối ...");
            GetData(conn);
            Data dta= new Data();
            dta.a = 4;
            dta.b = 2;
            Insert(conn, dta);
            
            Console.ReadLine();
        }

        static void Insert(OracleConnection conn, Data dt)
        {
            Console.WriteLine("\nInsert data\n-----------");
            try
            {
                conn.Open();
                var query = "Select " + dt.a * dt.b + " from Dual";
                OracleCommand cmd = new OracleCommand(query, conn);
                DbDataReader readers = cmd.ExecuteReader();
                if (readers.Read())
                {
                    Console.WriteLine(readers.GetValue(0));
                    conn.Close();
                }
                else
                {
                    Console.WriteLine("Có lỗi!!!!!!!!!!!");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }  
    }
}
