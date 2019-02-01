using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace demo_form_connect_oracle
{
    public partial class frmData : Form
    {
        private double firstNumb;
        private string operation;

        public frmData()
        {
            InitializeComponent();
        }

        private void frmData_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";

            Get_Event_Use();
        }

        private void Get_Event_Use()
        {
           // MessageBox.Show("Chào mừng đến vơi chương trình", "CALCULATOR", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            OracleConnection conn = frmLogin.conn;
            conn.Open();

            string query = "Select 2+2 , 4*4, 4*4, 4*4, 4*4  from Dual";
            OracleCommand cmd = new OracleCommand(query, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Test");
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Setvalue(button5.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Setvalue(button8.Text);
        }

        private void Setvalue(string b)
        {
            if (textBox1.Text == "0" || textBox1.Text != null)
            {
                textBox1.Text = b;
            }
        }
        
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Setvalue(button6.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Setvalue(button9.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Setvalue(button10.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Setvalue(button7.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Setvalue(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Setvalue(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Setvalue(button4.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            firstNumb = double.Parse(textBox1.Text);
            //textBox1.Text = "0";
            operation = "chia";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double secondNumb = double.Parse(textBox1.Text);
            double result = 0;
            if (operation == "cong")
            {
                result = firstNumb + secondNumb;
                textBox1.Text = result.ToString();
            }
            if (operation == "tru")
            {
                result = firstNumb - secondNumb;
                textBox1.Text = result.ToString();
            }
            if (operation == "nhan")
            {
                result = firstNumb * secondNumb;
                textBox1.Text = result.ToString();
            }
            if (operation == "chia")
            {
                result = firstNumb / secondNumb;
                textBox1.Text = result.ToString();
            }
        }

        private double testMath(string[] a)
        {
            var stn = double.Parse(a[1]);
            var sth = double.Parse(a[3]);

            return 1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button14_Click(object sender, EventArgs e)
        {
            firstNumb = double.Parse(textBox1.Text);
            operation = "nhan";
            //textBox1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            firstNumb = double.Parse(textBox1.Text);
            operation = "tru";
            //textBox1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            firstNumb = double.Parse(textBox1.Text);
            operation = "cong";
            //textBox1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Setvalue(button11.Text);
        }
    }
}