namespace test1.usercontrol
{
    partial class add_categories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_categories));
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.txtname = new Guna.UI.WinForms.GunaTextBox();
            this.btsearch = new Guna.UI.WinForms.GunaButton();
            this.btdelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.btedit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btadd = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_all = new Guna.UI.WinForms.GunaMediumCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loại Hàng Hoá";
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryID,
            this.CategoryName,
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
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(30, 31);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 24;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(1511, 536);
            this.bunifuCustomDataGrid1.TabIndex = 40;
            this.bunifuCustomDataGrid1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_RowEnter);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 0;
            this.gunaElipse1.TargetControl = this;
            // 
            // txtname
            // 
            this.txtname.BaseColor = System.Drawing.Color.White;
            this.txtname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.FocusedBaseColor = System.Drawing.Color.White;
            this.txtname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtname.Location = new System.Drawing.Point(1194, 111);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.SelectedText = "";
            this.txtname.Size = new System.Drawing.Size(267, 36);
            this.txtname.TabIndex = 64;
            this.txtname.Tag = "";
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
            this.btsearch.Location = new System.Drawing.Point(1477, 106);
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
            this.btdelete.Location = new System.Drawing.Point(187, 100);
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
            this.btedit.Location = new System.Drawing.Point(128, 101);
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
            this.btadd.Location = new System.Drawing.Point(72, 100);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(40, 40);
            this.btadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btadd.TabIndex = 67;
            this.btadd.TabStop = false;
            this.btadd.Zoom = 10;
            this.btadd.Click += new System.EventHandler(this.btadd_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuCustomDataGrid1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(72, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1579, 600);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Loại Hàng Hoá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1123, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 77;
            this.label2.Text = "Tất Cả";
            // 
            // cb_all
            // 
            this.cb_all.BaseColor = System.Drawing.Color.White;
            this.cb_all.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.cb_all.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.cb_all.FillColor = System.Drawing.Color.White;
            this.cb_all.Location = new System.Drawing.Point(1097, 117);
            this.cb_all.Name = "cb_all";
            this.cb_all.Size = new System.Drawing.Size(20, 20);
            this.cb_all.TabIndex = 76;
            this.cb_all.CheckedChanged += new System.EventHandler(this.cb_all_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1190, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 78;
            this.label3.Text = "Nhập Tên ";
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.HeaderText = "Mã Loại Hàng Hoá";
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.Width = 200;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "Tên Loại hàng Hoá";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Width = 600;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Ghi Chú";
            this.Description.Name = "Description";
            this.Description.Width = 700;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(244, 101);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 65;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // add_categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_all);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.label1);
            this.Name = "add_categories";
            this.Size = new System.Drawing.Size(1705, 1014);
            this.Load += new System.EventHandler(this.add_categories_Load);
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
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaTextBox txtname;
        private Guna.UI.WinForms.GunaButton btsearch;
        private Bunifu.Framework.UI.BunifuImageButton btdelete;
        private Bunifu.Framework.UI.BunifuImageButton btedit;
        private Bunifu.Framework.UI.BunifuImageButton btadd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaMediumCheckBox cb_all;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}
