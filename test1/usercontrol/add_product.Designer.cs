namespace test1.usercontrol
{
    partial class add_product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_product));
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addproduct = new Guna.UI.WinForms.GunaElipse(this.components);
            this.txtcategoryproduct = new Guna.UI.WinForms.GunaComboBox();
            this.txtinput = new Guna.UI.WinForms.GunaTextBox();
            this.btsearch = new Guna.UI.WinForms.GunaButton();
            this.btdelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.btedit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btadd = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaMediumCheckBox1 = new Guna.UI.WinForms.GunaMediumCheckBox();
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
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 40);
            this.label1.TabIndex = 22;
            this.label1.Text = "Sản Phẩm";
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.CategoryName,
            this.CompanyName,
            this.UnitID,
            this.Description});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle9;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(32, 41);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 24;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(1589, 522);
            this.bunifuCustomDataGrid1.TabIndex = 42;
            this.bunifuCustomDataGrid1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_RowEnter);
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Tên Sản Phẩm";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 400;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "Tên Loại Sản Phẩm";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Width = 350;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.CompanyName.DefaultCellStyle = dataGridViewCellStyle8;
            this.CompanyName.HeaderText = "Tên Nhà Cung Cấp";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Width = 300;
            // 
            // UnitID
            // 
            this.UnitID.DataPropertyName = "NameUnit";
            this.UnitID.HeaderText = "Tên Đơn Vị Tính";
            this.UnitID.Name = "UnitID";
            this.UnitID.Width = 150;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Ghi Chú";
            this.Description.Name = "Description";
            this.Description.Width = 380;
            // 
            // addproduct
            // 
            this.addproduct.Radius = 0;
            this.addproduct.TargetControl = this;
            // 
            // txtcategoryproduct
            // 
            this.txtcategoryproduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtcategoryproduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtcategoryproduct.BackColor = System.Drawing.Color.Transparent;
            this.txtcategoryproduct.BaseColor = System.Drawing.Color.White;
            this.txtcategoryproduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtcategoryproduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtcategoryproduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcategoryproduct.FocusedColor = System.Drawing.Color.Empty;
            this.txtcategoryproduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtcategoryproduct.ForeColor = System.Drawing.Color.Black;
            this.txtcategoryproduct.FormattingEnabled = true;
            this.txtcategoryproduct.ItemHeight = 23;
            this.txtcategoryproduct.Location = new System.Drawing.Point(911, 109);
            this.txtcategoryproduct.Name = "txtcategoryproduct";
            this.txtcategoryproduct.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtcategoryproduct.OnHoverItemForeColor = System.Drawing.Color.White;
            this.txtcategoryproduct.Size = new System.Drawing.Size(267, 29);
            this.txtcategoryproduct.TabIndex = 68;
            this.txtcategoryproduct.Tag = "Chọn theo loại";
            this.txtcategoryproduct.SelectedIndexChanged += new System.EventHandler(this.txtcategoryproduct_SelectedIndexChanged);
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
            this.txtinput.Location = new System.Drawing.Point(1184, 109);
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
            this.btsearch.Location = new System.Drawing.Point(1501, 104);
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
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click_1);
            // 
            // btdelete
            // 
            this.btdelete.BackColor = System.Drawing.Color.White;
            this.btdelete.Image = ((System.Drawing.Image)(resources.GetObject("btdelete.Image")));
            this.btdelete.ImageActive = null;
            this.btdelete.Location = new System.Drawing.Point(172, 98);
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
            this.btedit.Location = new System.Drawing.Point(113, 99);
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
            this.btadd.Location = new System.Drawing.Point(57, 98);
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
            this.groupBox1.Location = new System.Drawing.Point(57, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1645, 610);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(916, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 70;
            this.label2.Text = "Chọn Theo Loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1180, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 24);
            this.label3.TabIndex = 70;
            this.label3.Text = "Nhập Tên Cần tìm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(840, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 77;
            this.label4.Text = "Tất Cả";
            // 
            // gunaMediumCheckBox1
            // 
            this.gunaMediumCheckBox1.BaseColor = System.Drawing.Color.White;
            this.gunaMediumCheckBox1.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.gunaMediumCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.gunaMediumCheckBox1.FillColor = System.Drawing.Color.White;
            this.gunaMediumCheckBox1.Location = new System.Drawing.Point(814, 114);
            this.gunaMediumCheckBox1.Name = "gunaMediumCheckBox1";
            this.gunaMediumCheckBox1.Size = new System.Drawing.Size(20, 20);
            this.gunaMediumCheckBox1.TabIndex = 76;
            this.gunaMediumCheckBox1.CheckedChanged += new System.EventHandler(this.gunaMediumCheckBox1_CheckedChanged);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(235, 99);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 78;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // add_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gunaMediumCheckBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtcategoryproduct);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.label1);
            this.Name = "add_product";
            this.Size = new System.Drawing.Size(1705, 1014);
            this.Load += new System.EventHandler(this.add_product_Load);
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
        private Guna.UI.WinForms.GunaElipse addproduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaComboBox txtcategoryproduct;
        private Guna.UI.WinForms.GunaTextBox txtinput;
        private Guna.UI.WinForms.GunaButton btsearch;
        private Bunifu.Framework.UI.BunifuImageButton btdelete;
        private Bunifu.Framework.UI.BunifuImageButton btedit;
        private Bunifu.Framework.UI.BunifuImageButton btadd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaMediumCheckBox gunaMediumCheckBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}
