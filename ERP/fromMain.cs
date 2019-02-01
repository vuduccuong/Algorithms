using System;
using System.Windows.Forms;

namespace ERP
{
    public partial class fromMain : Form
    {
        public fromMain()
        {
            InitializeComponent();
        }

        private void fromMain_Load(object sender, EventArgs e)
        {
            advTree1.Nodes.Clear();
            DevComponents.AdvTree.Node node = new DevComponents.AdvTree.Node() {Text = "Cuongvd" };
            advTree1.Nodes.Add(node);

            this.ControlBox = false;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            string query = "SELECT 4*4 from dual";
            try
            {
                int i = DataProvider.Instance.ExecuteNonQuery(query);
                if (i > 0)
                {
                    MessageBox.Show("OKE");
                }
                MessageBox.Show("Không thực hiện được!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối " + ex);
            }
        }

        private void node90_NodeClick(object sender, EventArgs e)
        {
            MessageBox.Show("This is : Set of Books");
        }

        private void node91_NodeClick(object sender, EventArgs e)
        {
            MessageBox.Show("This is : Organization");
        }

        private void node92_NodeClick(object sender, EventArgs e)
        {
            ShowMess(this.node92.Text);
        }

        private void node93_NodeClick(object sender, EventArgs e)
        {
            ShowMess(this.node93.Text);
        }

        public DialogResult ShowMess(string nodeText)
        {
            return MessageBox.Show("This is : " + nodeText);
        }

        private void node94_NodeClick(object sender, EventArgs e)
        {
            ShowMess(this.node94.Text);
        }

        private void node95_NodeClick(object sender, EventArgs e)
        {
            ShowMess(this.node95.Text);
        }

        private void node96_NodeClick(object sender, EventArgs e)
        {
            ShowMess(this.node96.Text);
        }

        private void node97_NodeClick(object sender, EventArgs e)
        {
            ShowMess(this.node97.Text);
        }

        private void node98_NodeClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ShowMess(e.Node.Text);
        }

        private void node98_NodeClick(object sender, EventArgs e)
        {

        }

        private void advTree1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void advTree1_NodeClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            MessageBox.Show("This is "+ e.Node.Text);
        }
    }
}