using System;
using System.Windows.Forms;
namespace demo_form_connect_oracle
{
    public partial class frm_Fake : Form
    {
        public frm_Fake()
        {
            InitializeComponent();
        }

        private void frm_Fake_Load(object sender, EventArgs e)
        {
            txtPw.UseSystemPasswordChar = true;
            label6.Text = null;
            txtUname.Focus();
            label1.Text = "Kết nối công ty BHFlex Vina";
            label2.Text = "Yêu cầu nhập đúng tên và mã số bí mật";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _uname = "admin";
            string _pword = "1q2w3e4r";
            if (txtUname.Text == _uname && txtPw.Text == _pword)
            {
                MessageBox.Show("Login Success");
                frm_management a = new frm_management();
                this.Hide();
                a.ShowDialog();
            }
            else if (txtUname.Text == _uname && txtPw.Text != _pword)
            {
                label6.Text = "*Password is correct";
                txtPw.Focus();
            }
            else if (txtPw.Text == _pword && txtUname.Text != _uname)
            {
                label6.Text = "*Username is correct";
                txtUname.Focus();
            }
            else
            {
                label6.Text = "*Username and password is correct";
                txtUname.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dal = MessageBox.Show("Do you want Exit?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dal == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}