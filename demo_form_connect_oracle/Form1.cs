using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace demo_form_connect_oracle
{
    public partial class frmLogin : Form
    {
        public static OracleConnection conn = new OracleConnection();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void keyboardControl1_Click(object sender, EventArgs e)
        {
            
        }
    }
}