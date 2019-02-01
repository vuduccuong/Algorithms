using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_To_Oracle
{
     class DBUnit
    {
        public static OracleConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 1521;
            string sid = "db12c";
            string user = "C##uongvd";
            string password = "D0ilaipass";
            return DBOracleUtils.GetDBConnection(host,port,sid,user,password);
        }
    }
}
