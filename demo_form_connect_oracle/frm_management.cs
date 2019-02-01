using System;
using System.Windows.Forms;

namespace demo_form_connect_oracle
{
    public partial class frm_management : Form
    {
        public frm_management()
        {
            InitializeComponent();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmData _frmData = new frmData();
            _frmData.ShowDialog();
        }

        private void yourHeigntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHeight _frmHeight = new frmHeight();
            _frmHeight.ShowDialog();
        }

        private void yourWeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWeight _frmWeight = new frmWeight();
            _frmWeight.ShowDialog();
        }

        private void insertDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInsert _frmInsert = new frmInsert();
            _frmInsert.ShowDialog();
        }
    }
}