using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace demo_form_connect_oracle
{
    public partial class frmInsert : Form
    {
        private DBUnit db = new DBUnit();

        public frmInsert()
        {
            InitializeComponent();
        }

        private void frmInsert_Load(object sender, EventArgs e)
        {
            LoadListTest();
        }

        private void LoadListTest()
        {
            OracleConnection conn = db.GetConnect();
            conn.Open();
            var query = "select * from customer";
            OracleCommand cmd = new OracleCommand(query, conn);

            OracleDataAdapter dad = new OracleDataAdapter(cmd);
            DataSet dsd = new DataSet();
            dsd.Clear();
            if (dsd != null)
            {
                dad.Fill(dsd);

                dataGridView1.DataSource = dsd.Tables[0];
                this.textBox1.DataBindings.Clear();
                this.textBox1.DataBindings.Add(new Binding("Text", dsd.Tables[0], "address", true));

                this.txtID.DataBindings.Clear();
                this.txtID.DataBindings.Add(new Binding("Text", dsd.Tables[0], "cust_id", true));

                this.txtCity.DataBindings.Clear();
                this.txtCity.DataBindings.Add(new Binding("Text", dsd.Tables[0], "city", true));

                this.txtCustType.DataBindings.Clear();
                this.txtCustType.DataBindings.Add(new Binding("Text", dsd.Tables[0], "cust_type_cd", true));

                this.txtFed.DataBindings.Clear();
                this.txtFed.DataBindings.Add(new Binding("Text", dsd.Tables[0], "fed_id", true));

                this.txtPostal.DataBindings.Clear();
                this.txtPostal.DataBindings.Add(new Binding("Text", dsd.Tables[0], "postal_code", true));

                this.txtState.DataBindings.Clear();
                this.txtState.DataBindings.Add(new Binding("Text", dsd.Tables[0], "state", true));
            }
            else
            {
                MessageBox.Show("Không có dữ liệu");
            }

            cmd.Dispose();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = db.GetConnect();
            conn.Open();
            var query = "INSERT INTO TEST(name) values ('" + textBox1.Text + "')";
            OracleCommand cmd = new OracleCommand(query, conn);
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                MessageBox.Show("Thêm thành công");
                textBox1.Text = null;
            }
            else
            {
                MessageBox.Show("Có lỗi");
                textBox1.Focus();
            }
            LoadListTest();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = db.GetConnect())
            {
                conn.Open();
                var query = "update CUSTOMER set ADDRESS = '" + textBox1.Text + "', city = '" + txtCity.Text + "', cust_type_cd = '" + txtCustType.Text + "', fed_id = '" + txtFed.Text + "', postal_code = '" + txtPostal.Text + "', state = '" + txtState.Text + "' where cust_id = '" + txtID.Text+"'";
                using (OracleCommand cmd = new OracleCommand(query,conn))
                {
                    int kt = cmd.ExecuteNonQuery();
                    if (kt>0)
                    {
                        MessageBox.Show("Update Success!");
                        LoadListTest();
                    }
                    else
                    {
                        MessageBox.Show("False");
                    }
                } 
            }
        }
    }
}