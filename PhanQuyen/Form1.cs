using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PhanQuyen
{
    public partial class Form1 : Form
    {
        private DataAccess dataHelp = new DataAccess();
        private DataSet ds = new DataSet();
        public List<string> lst = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            buttonX5.Hide();
            buttonX1.Image = (Image)(new Bitmap(PhanQuyen.Properties.Resources.k_get_list_icon, new Size(32, 32)));
            buttonX2.Image = (Image)(new Bitmap(PhanQuyen.Properties.Resources.system_database_add_icon, new Size(32, 32)));
            buttonX3.Image = (Image)(new Bitmap(PhanQuyen.Properties.Resources.data_edit_icon, new Size(32, 32)));
            buttonX4.Image = (Image)(new Bitmap(PhanQuyen.Properties.Resources.database_delete_icon, new Size(32, 32)));
            buttonX5.Image = (Image)(new Bitmap(PhanQuyen.Properties.Resources.Ok_icon, new Size(32, 32)));
            ds.Clear();
            buttonX1.Hide();
            buttonX2.Hide();
            buttonX3.Hide();
            buttonX4.Hide();

            foreach (var item in lst)
            {
                if (item == "READ")
                {
                    buttonX1.Show();
                }
                if (item == "ADD")
                {
                    buttonX2.Show();
                }
                if (item == "UPDATE")
                {
                    buttonX3.Show();
                }
                if (item == "DELETE")
                {
                    buttonX4.Show();
                }
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            ClearText();
            txtID.Enabled = true;
            buttonX2.Enabled = false;
            buttonX5.Show();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            buttonX5.Hide();
            buttonX2.Enabled = true;
            InsertData();
        }

        private void AddToGrid()
        {
            var ID = int.Parse(txtID.Text);
            var Address = txtAddress.Text;
            var City = txtCity.Text;
            var Cust_Type = txtCustType.Text;
            var Fed_ID = txtFedId.Text;
            var Postal_code = txtPostalCode.Text;
            var State = txtState.Text;

            string[] row = { Address, City, Cust_Type, Fed_ID, Postal_code, State };
            dataGridViewX1.Rows.Add(ID, row);
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        #region Getdata

        private void GetData()
        {
            string query = "SELECT * FROM CUSTOMER";
            ds = dataHelp.Getdata(query);
            dataGridViewX1.DataSource = ds.Tables[0];

            //Data Bindding
            this.txtID.DataBindings.Clear();
            this.txtID.DataBindings.Add(new Binding("Text", ds.Tables[0], "cust_id", true));

            this.txtAddress.DataBindings.Clear();
            this.txtAddress.DataBindings.Add(new Binding("Text", ds.Tables[0], "address", true));

            this.txtCity.DataBindings.Clear();
            this.txtCity.DataBindings.Add(new Binding("Text", ds.Tables[0], "city", true));

            this.txtCustType.DataBindings.Clear();
            this.txtCustType.DataBindings.Add(new Binding("Text", ds.Tables[0], "cust_type_cd", true));

            this.txtFedId.DataBindings.Clear();
            this.txtFedId.DataBindings.Add(new Binding("Text", ds.Tables[0], "fed_id", true));

            this.txtPostalCode.DataBindings.Clear();
            this.txtPostalCode.DataBindings.Add(new Binding("Text", ds.Tables[0], "postal_code", true));

            this.txtState.DataBindings.Clear();
            this.txtState.DataBindings.Add(new Binding("Text", ds.Tables[0], "state", true));
        }

        #endregion Getdata

        #region Update

        private void UpdateData()
        {
            StringBuilder query = new StringBuilder();
            query.Append("Update customer set ");
            query.Append("address = '" + txtAddress.Text);
            query.Append("', city = '" + txtCity.Text);
            query.Append("', cust_type_cd = '" + txtCustType.Text);
            query.Append("', fed_id = '" + txtFedId.Text);
            query.Append("', postal_code = '" + txtPostalCode.Text);
            query.Append("', state = '" + txtState.Text);
            query.Append("' where cust_id = " + txtID.Text);

            int checkSuccs = dataHelp.UpdateData(query.ToString());
            if (checkSuccs >= 0)
            {
                MessageBox.Show("Success!");
            }
        }

        #endregion Update

        #region Insert Data

        private void InsertData()
        {
            StringBuilder query = new StringBuilder();
            query.Append("Insert into Customer(cust_id, address, city, cust_type_cd, fed_id, postal_code, state) values (");
            query.Append("'" + txtID.Text + "',");
            query.Append("'" + txtAddress.Text + "',");
            query.Append("'" + txtCity.Text + "',");
            query.Append("'" + txtCustType.Text + "',");
            query.Append("'" + txtFedId.Text + "',");
            query.Append("'" + txtPostalCode.Text + "',");
            query.Append("'" + txtState.Text + "')");

            if (txtID.Text.Length != 0 || query.Length != 0)
            {
                var checkSuccs = dataHelp.InsertData(query.ToString());
                if (checkSuccs >= 1)
                {
                    MessageBox.Show("Success!");
                    GetData();
                }
                //AddToGrid();
            }
        }

        #endregion Insert Data

        #region Delete Data

        private void DeleteData()
        {
            string query = "Delete Customer where Cust_id = " + txtID.Text;

            var CheckSuccs = dataHelp.DeleteData(query);
            if (CheckSuccs >= 1)
            {
                MessageBox.Show("Success!");
            }
        }

        #endregion Delete Data

        #region Clear All Textbox

        private void ClearText()
        {
            txtID.Text = null;
            txtAddress.Text = null;
            txtCity.Text = null;
            txtCustType.Text = null;
            txtFedId.Text = null;
            txtPostalCode.Text = null;
            txtState.Text = null;
        }

        #endregion Clear All Textbox

        private void buttonX2_MouseHover(object sender, EventArgs e)
        {
            this.buttonX2.Tooltip = "Không có quyền";
        }
    }
}