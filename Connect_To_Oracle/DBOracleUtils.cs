using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace Connect_To_Oracle
{
    class DBOracleUtils
    {
        public static OracleConnection GetDBConnection(string host, int port, string sid, string user, string password)
        {
            Console.OutputEncoding = Encoding.UTF8;
            OracleConnection conn = null;


            string connString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + user+ ";DBA Privilege=SYSDBA";
            try
            {
                conn = new OracleConnection();
                conn.ConnectionString = connString;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi " + ex);
            }
            return conn;
        }
    }
}
