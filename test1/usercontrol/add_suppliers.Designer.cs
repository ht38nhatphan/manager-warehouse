namespace test1.usercontrol
{
    partial class add_suppliers
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

       
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_suppliers));
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addsuppliers = new Guna.UI.WinForms.GunaElipse(this.components);
            this.txtcategory = new Guna.UI.WinForms.GunaComboBox();
            this.txtinput = new Guna.UI.WinForms.GunaTextBox();
            this.btsearch = new Guna.UI.WinForms.GunaButton();
            this.btdelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.btedit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btadd = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaMediumCheckBox1 = new Guna.UI.WinForms.GunaMediumCheckBox();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btdelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btedit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btadd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhà Cung Cấp";
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(25, 40);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 24;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(1584, 560);
            this.bunifuCustomDataGrid1.TabIndex = 43;
            this.bunifuCustomDataGrid1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CompanyName";
            this.Column1.HeaderText = "Tên Nhà Cung Cấp";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 350;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ContactName";
            this.Column2.HeaderText = "Tên Người Đại Diện";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 350;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Address";
            this.Column3.HeaderText = "Địa Chỉ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 350;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Phone";
            this.Column4.HeaderText = "Số Điện Thoại";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Email";
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 250;
            // 
            // addsuppliers
            // 
            this.addsuppliers.Radius = 0;
            this.addsuppliers.TargetControl = this;
            // 
            // txtcategory
            // 
            this.txtcategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtcategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtcategory.BackColor = System.Drawing.Color.Transparent;
            this.txtcategory.BaseColor = System.Drawing.Color.White;
            this.txtcategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtcategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcategory.FocusedColor = System.Drawing.Color.Empty;
            this.txtcategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtcategory.ForeColor = System.Drawing.Color.Black;
            this.txtcategory.FormattingEnabled = true;
            this.txtcategory.ItemHeight = 23;
            this.txtcategory.Location = new System.Drawing.Point(898, 97);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtcategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.txtcategory.Size = new System.Drawing.Size(267, 29);
            this.txtcategory.TabIndex = 68;
            this.txtcategory.Tag = "";
            this.txtcategory.SelectedIndexChanged += new System.EventHandler(this.txtcategory_SelectedIndexChanged);
            // 
            // txtinput
            // 
            this.txtinput.BaseColor = System.Drawing.Color.White;
            this.txtinput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtinput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtinput.FocusedBaseColor = System.Drawing.Color.White;
            this.txtinput.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtinput.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtinput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtinput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtinput.Location = new System.Drawing.Point(1183, 97);
            this.txtinput.Name = "txtinput";
            this.txtinput.PasswordChar = '\0';
            this.txtinput.SelectedText = "";
            this.txtinput.Size = new System.Drawing.Size(267, 36);
            this.txtinput.TabIndex = 64;
            this.txtinput.Tag = "";
            // 
            // btsearch
            // 
            this.btsearch.AnimationHoverSpeed = 0.07F;
            this.btsearch.AnimationSpeed = 0.03F;
            this.btsearch.BackColor = System.Drawing.Color.Transparent;
            this.btsearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.btsearch.BorderColor = System.Drawing.Color.Black;
            this.btsearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btsearch.FocusedColor = System.Drawing.Color.Empty;
            this.btsearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsearch.ForeColor = System.Drawing.Color.White;
            this.btsearch.Image = null;
            this.btsearch.ImageSize = new System.Drawing.Size(30, 30);
            this.btsearch.Location = new System.Drawing.Point(1505, 92);
            this.btsearch.Name = "btsearch";
            this.btsearch.OnHoverBaseColor = System.Drawing.Color.CadetBlue;
            this.btsearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btsearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btsearch.OnHoverImage = null;
            this.btsearch.OnPressedColor = System.Drawing.Color.Black;
            this.btsearch.Radius = 8;
            this.btsearch.Size = new System.Drawing.Size(177, 41);
            this.btsearch.TabIndex = 63;
            this.btsearch.Text = "Lọc";
            this.btsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // btdelete
            // 
            this.btdelete.BackColor = System.Drawing.Color.White;
            this.btdelete.Image = ((System.Drawing.Image)(resources.GetObject("btdelete.Image")));
            this.btdelete.ImageActive = null;
            this.btdelete.Location = new System.Drawing.Point(165, 85);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(40, 40);
            this.btdelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btdelete.TabIndex = 65;
            this.btdelete.TabStop = false;
            this.btdelete.Zoom = 10;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btedit
            // 
            this.btedit.BackColor = System.Drawing.Color.White;
            this.btedit.Image = ((System.Drawing.Image)(resources.GetObject("btedit.Image")));
            this.btedit.ImageActive = null;
            this.btedit.Location = new System.Drawing.Point(106, 86);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(40, 40);
            this.btedit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btedit.TabIndex = 66;
            this.btedit.TabStop = false;
            this.btedit.Zoom = 10;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // btadd
            // 
            this.btadd.BackColor = System.Drawing.Color.White;
            this.btadd.Image = ((System.Drawing.Image)(resources.GetObject("btadd.Image")));
            this.btadd.ImageActive = null;
            this.btadd.Location = new System.Drawing.Point(50, 85);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(40, 40);
            this.btadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btadd.TabIndex = 67;
            this.btadd.TabStop = false;
            this.btadd.Zoom = 10;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuCustomDataGrid1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1630, 649);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(827, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 77;
            this.label2.Text = "Tất Cả";
            // 
            // gunaMediumCheckBox1
            // 
            this.gunaMediumCheckBox1.BaseColor = System.Drawing.Color.White;
            this.gunaMediumCheckBox1.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.gunaMediumCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.gunaMediumCheckBox1.FillColor = System.Drawing.Color.White;
            this.gunaMediumCheckBox1.Location = new System.Drawing.Point(801, 97);
            this.gunaMediumCheckBox1.Name = "gunaMediumCheckBox1";
            this.gunaMediumCheckBox1.Size = new System.Drawing.Size(20, 20);
            this.gunaMediumCheckBox1.TabIndex = 76;
            this.gunaMediumCheckBox1.CheckedChanged += new System.EventHandler(this.gunaMediumCheckBox1_CheckedChanged);
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "Tên Nhà Cung Cấp";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Width = 400;
            // 
            // ContactName
            // 
            this.ContactName.DataPropertyName = "ContactName";
            this.ContactName.HeaderText = "Tên Người Đại Diện";
            this.ContactName.Name = "ContactName";
            this.ContactName.Width = 300;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(224, 86);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 79;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // add_suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gunaMediumCheckBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtcategory);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.label1);
            this.Name = "add_suppliers";
            this.Size = new System.Drawing.Size(1705, 1014);
            this.Load += new System.EventHandler(this.add_suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btdelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btedit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btadd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Guna.UI.WinForms.GunaElipse addsuppliers;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaComboBox txtcategory;
        private Guna.UI.WinForms.GunaTextBox txtinput;
        private Guna.UI.WinForms.GunaButton btsearch;
        private Bunifu.Framework.UI.BunifuImageButton btdelete;
        private Bunifu.Framework.UI.BunifuImageButton btedit;
        private Bunifu.Framework.UI.BunifuImageButton btadd;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaMediumCheckBox gunaMediumCheckBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactName;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}
