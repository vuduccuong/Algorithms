using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Linq;

namespace ERP
{
    public class DataProvider
    {
        private static DataProvider instance; // Ctrl + R + E

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider()
        {
        }

        #region Connection String

        private string connStr = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
    + "localhost" + ")(PORT = " + "1521" + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
    + "db12c" + ")));Password=" + "D0ilaipass" + ";User ID=" + "C##uongvd";

        #endregion Connection String

        #region Query to TableData

        /// <summary>
        /// Truy vấn với OracleDB trả về 1 bảng
        /// </summary>
        /// <param name="query">query Oracle</param>
        /// <param name="parameter"></param>
        /// <returns>table data</returns>
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (OracleConnection connection = new OracleConnection(connStr))
            {
                connection.Open();

                OracleCommand command = new OracleCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.Add(item, parameter[i]);
                            i++;
                        }
                    }
                }

                OracleDataAdapter adapter = new OracleDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }

        #endregion Query to TableData

        #region Query to Int

        /// <summary>
        /// Trả về số tự nhiên dựa vào kết quả truy vấn thực hiện được
        /// </summary>
        /// <param name="query">Query OracleDB</param>
        /// <param name="parameter"></param>
        /// <returns>int i</returns>
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (OracleConnection connection = new OracleConnection(connStr))
            {
                connection.Open();

                OracleCommand command = new OracleCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.Add(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        #endregion Query to Int
    }
}