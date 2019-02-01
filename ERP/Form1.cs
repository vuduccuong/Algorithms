using System;
using System.Windows.Forms;

namespace ERP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroTileItem1_Click(object sender, EventArgs e)
        {
        }

        private void metroTileItem4_Click(object sender, EventArgs e)
        {
        }

        private void overADToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void formCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void applicationExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fromMain _frmMain = new fromMain();
            _frmMain.TopLevel = false;
            _frmMain.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(_frmMain);
            _frmMain.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Anchor = AnchorStyles.Left | AnchorStyles.Top;
        }
    }
}