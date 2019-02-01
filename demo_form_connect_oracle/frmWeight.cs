using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace demo_form_connect_oracle
{
    public partial class frmWeight : Form
    {
        private DBUnit db = new DBUnit();

        public frmWeight()
        {
            InitializeComponent();
        }

        private void frmWeight_Load(object sender, EventArgs e)
        {
            LoadData();
            label1.Text = "Nhập cân nặng của bạn :";
        }

        private void LoadData()
        {
            OracleConnection conn = db.GetConnect();
            var query = "SELECT * FROM CUSTOMER";
            OracleCommand cmd = new OracleCommand(query, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "TEST");

            dataGridView1.DataSource = ds.Tables["TEST"];
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cân nặng của bạn là " + textBox1.Text);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }
    }
}