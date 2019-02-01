using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanQuyen
{
    public class DBUnit
    {
        public OracleConnection GetConnect()
        {
            var connStr = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
     + "localhost" + ")(PORT = " + "1521" + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
     + "db12c" + ")));Password=" + "D0ilaipass" + ";User ID=" + "C##uongvd";

            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = connStr;

            return conn;
        }
    }
}
