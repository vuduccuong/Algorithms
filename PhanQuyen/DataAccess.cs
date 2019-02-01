using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanQuyen
{
    public class DataAccess
    {
        private static DBUnit _db = new DBUnit();
        private static OracleConnection _conn = new OracleConnection();
        

        #region Insert
        public int InsertData(string query)
        {
            _conn = _db.GetConnect();
            _conn.Open();

            try
            {
                OracleCommand cmd = new OracleCommand(query, _conn);
                int checkSuccs = cmd.ExecuteNonQuery();
                _conn.Clone();
                if (checkSuccs >= 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Error!" + ex);
            }
            return 0;
        }
        #endregion

        #region GetDataToDataSet
        public DataSet Getdata(string query)
        {
            _conn = _db.GetConnect();
            _conn.Open();

            OracleCommand cmd = new OracleCommand(query, _conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        #endregion

        #region Update
        public int UpdateData(string query)
        {
            _conn = _db.GetConnect();
            _conn.Open();

            try
            {
                OracleCommand cmd = new OracleCommand(query, _conn);
                var checkSuccs = cmd.ExecuteNonQuery();
                _conn.Clone();
                if (checkSuccs > 1)
                {
                    return 1;
                }
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Error!" + ex);
            }
            return 0;
        }
        #endregion

        #region Delete
        public int DeleteData(string query)
        {
            _conn = _db.GetConnect();
            _conn.Open();

            try
            {
                OracleCommand cmd = new OracleCommand(query);
                var checkSuccs = cmd.ExecuteNonQuery();
                _conn.Close();
                if (checkSuccs > 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Error!" + ex);
            }
            return 0;
        }
        #endregion

        #region Get Per
        public List<string> GetLogin(string uName, string pWord)
        {
            _conn = _db.GetConnect();
            _conn.Open();
            string query = "select u.FULLNAME as FullName, u.USERNAME UserName, pd.CODE_ACTION as CODE from TBL_USER u inner join TBL_USER_PER up on u.ID = up.ID_USER";
            query += " inner join TBL_PERMISION p on up.ID_PER = p.ID";
            query += " inner join TBL_PER_DETAIL pd on p.ID = pd.ID_PER";
            query += " WHERE u.USERNAME = '" + uName + "' AND u.PASSWORD = '" + pWord + "'";

            OracleCommand cmd = new OracleCommand(query, _conn);
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            _conn.Close();
            List<string> lst_per = new List<string>();

            foreach (DataRow dr in dt.Rows)
            {
                lst_per.Add(dr["CODE"].ToString());
            }
            return lst_per;
        }
        #endregion
    }
}
