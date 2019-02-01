using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanQuyen
{
    public partial class frmLogin : Form
    {
        private DataAccess dataHelp = new DataAccess();
        private DataSet ds = new DataSet();
        public frmLogin()
        {
            InitializeComponent();
        }

        #region Select User

        #endregion
        private void buttonX2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            if (dataHelp.GetLogin(txtUser.Text, txtpWord.Text) != null)
            {
                foreach (var item in dataHelp.GetLogin(txtUser.Text, txtpWord.Text))
                {
                    frm.lst.Add(item);
                }
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Opz... can't get permision for user "+ txtUser.Text);
            }
            
        }
    }
}
