namespace PhanQuyen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.lable1 = new DevComponents.DotNetBar.LabelX();
            this.lable2 = new DevComponents.DotNetBar.LabelX();
            this.lable3 = new DevComponents.DotNetBar.LabelX();
            this.lable4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCity = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCustType = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtFedId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPostalCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtState = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(12, 125);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.RowTemplate.Height = 24;
            this.dataGridViewX1.Size = new System.Drawing.Size(1011, 186);
            this.dataGridViewX1.TabIndex = 0;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(12, 317);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(155, 45);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 1;
            this.buttonX1.Text = "GetData";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(173, 317);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(155, 45);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 1;
            this.buttonX2.Text = "InsertData";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            this.buttonX2.MouseHover += new System.EventHandler(this.buttonX2_MouseHover);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(334, 317);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(155, 45);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 1;
            this.buttonX3.Text = "UpdateData";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Location = new System.Drawing.Point(495, 317);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(155, 45);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.TabIndex = 1;
            this.buttonX4.Text = "DeleteData";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(2, 96);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(1031, 23);
            this.line1.TabIndex = 2;
            this.line1.Text = "line1";
            // 
            // lable1
            // 
            // 
            // 
            // 
            this.lable1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lable1.Location = new System.Drawing.Point(20, 10);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(75, 23);
            this.lable1.TabIndex = 3;
            this.lable1.Text = "ID";
            // 
            // lable2
            // 
            // 
            // 
            // 
            this.lable2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lable2.Location = new System.Drawing.Point(20, 39);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(75, 23);
            this.lable2.TabIndex = 3;
            this.lable2.Text = "Address";
            // 
            // lable3
            // 
            // 
            // 
            // 
            this.lable3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lable3.Location = new System.Drawing.Point(20, 68);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(75, 23);
            this.lable3.TabIndex = 3;
            this.lable3.Text = "City";
            // 
            // lable4
            // 
            // 
            // 
            // 
            this.lable4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lable4.Location = new System.Drawing.Point(343, 12);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(109, 23);
            this.lable4.TabIndex = 3;
            this.lable4.Text = "Cust_type_cd";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(343, 39);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(91, 23);
            this.labelX5.TabIndex = 3;
            this.labelX5.Text = "Fed_id";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(343, 68);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(91, 23);
            this.labelX6.TabIndex = 3;
            this.labelX6.Text = "Postal_code";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(735, 12);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 3;
            this.labelX7.Text = "State";
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.Border.Class = "TextBoxBorder";
            this.txtID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtID.Location = new System.Drawing.Point(91, 11);
            this.txtID.Name = "txtID";
            this.txtID.PreventEnterBeep = true;
            this.txtID.Size = new System.Drawing.Size(196, 22);
            this.txtID.TabIndex = 4;
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.Border.Class = "TextBoxBorder";
            this.txtAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAddress.Location = new System.Drawing.Point(91, 40);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PreventEnterBeep = true;
            this.txtAddress.Size = new System.Drawing.Size(196, 22);
            this.txtAddress.TabIndex = 4;
            // 
            // txtCity
            // 
            // 
            // 
            // 
            this.txtCity.Border.Class = "TextBoxBorder";
            this.txtCity.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCity.Location = new System.Drawing.Point(91, 69);
            this.txtCity.Name = "txtCity";
            this.txtCity.PreventEnterBeep = true;
            this.txtCity.Size = new System.Drawing.Size(196, 22);
            this.txtCity.TabIndex = 4;
            // 
            // txtCustType
            // 
            // 
            // 
            // 
            this.txtCustType.Border.Class = "TextBoxBorder";
            this.txtCustType.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCustType.Location = new System.Drawing.Point(459, 13);
            this.txtCustType.Name = "txtCustType";
            this.txtCustType.PreventEnterBeep = true;
            this.txtCustType.Size = new System.Drawing.Size(212, 22);
            this.txtCustType.TabIndex = 4;
            // 
            // txtFedId
            // 
            // 
            // 
            // 
            this.txtFedId.Border.Class = "TextBoxBorder";
            this.txtFedId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFedId.Location = new System.Drawing.Point(459, 41);
            this.txtFedId.Name = "txtFedId";
            this.txtFedId.PreventEnterBeep = true;
            this.txtFedId.Size = new System.Drawing.Size(212, 22);
            this.txtFedId.TabIndex = 4;
            // 
            // txtPostalCode
            // 
            // 
            // 
            // 
            this.txtPostalCode.Border.Class = "TextBoxBorder";
            this.txtPostalCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPostalCode.Location = new System.Drawing.Point(459, 70);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.PreventEnterBeep = true;
            this.txtPostalCode.Size = new System.Drawing.Size(212, 22);
            this.txtPostalCode.TabIndex = 4;
            // 
            // txtState
            // 
            // 
            // 
            // 
            this.txtState.Border.Class = "TextBoxBorder";
            this.txtState.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtState.Location = new System.Drawing.Point(782, 12);
            this.txtState.Name = "txtState";
            this.txtState.PreventEnterBeep = true;
            this.txtState.Size = new System.Drawing.Size(196, 22);
            this.txtState.TabIndex = 4;
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX5.Location = new System.Drawing.Point(875, 317);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(133, 45);
            this.buttonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX5.TabIndex = 1;
            this.buttonX5.Text = "Insert";
            this.buttonX5.Click += new System.EventHandler(this.buttonX5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 374);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtFedId);
            this.Controls.Add(this.txtCustType);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.lable4);
            this.Controls.Add(this.lable3);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.buttonX5);
            this.Controls.Add(this.buttonX4);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.lable1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.LabelX lable1;
        private DevComponents.DotNetBar.LabelX lable2;
        private DevComponents.DotNetBar.LabelX lable3;
        private DevComponents.DotNetBar.LabelX lable4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCity;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCustType;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFedId;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPostalCode;
        private DevComponents.DotNetBar.Controls.TextBoxX txtState;
        private DevComponents.DotNetBar.ButtonX buttonX5;
    }
}

