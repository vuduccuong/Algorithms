using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Silentttt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _source = "Software.exe";
            InstallerFile(_source);
        }

        private void InstallerFile(string fName)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Setup\" + fName);
            Process.Start(path);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Show();
            richTextBox1.AppendText("***Các phần mềm sau được cài đặt silent\n\n");
            richTextBox1.AppendText("1. AOMEI_Bkcup_Recovery_Onekey\n");
            richTextBox1.AppendText("2. Bhflex-EPPAgentSetup\n");
            richTextBox1.AppendText("3. FLEX_ERP_BHV_20181120\n");
            richTextBox1.AppendText("4. FoxitReader614.0217_enu_Setup\n");
            richTextBox1.AppendText("5. HanbiroTalk_Installer_gwv.bhe.kr");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}