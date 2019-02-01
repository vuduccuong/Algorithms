using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_form_connect_oracle
{
    public class DBUnit
    {
        public OracleConnection GetConnect()
        {
            OracleConnection conn = new OracleConnection();
             string strconn = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
     + "localhost" + ")(PORT = " + "1521" + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
     + "db12c" + ")));Password=" + "D0ilaipass" + ";User ID=" + "C##uongvd";

            conn.ConnectionString = strconn;

            return conn;
        }
    }
}
