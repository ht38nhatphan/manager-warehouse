namespace test1.usercontrol
{
    partial class us_output
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(us_output));
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usoutput = new Guna.UI.WinForms.GunaElipse(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_total_amount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btprint = new Guna.UI.WinForms.GunaButton();
            this.txtdate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txtcategory = new Guna.UI.WinForms.GunaComboBox();
            this.txtinput = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.btdelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.btedit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btadd = new Bunifu.Framework.UI.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btdelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btedit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 40);
            this.label1.TabIndex = 19;
            this.label1.Text = "Phiếu Xuất";
            // 
            // bunifuCustomDataGrid2
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.ProductName,
            this.CategoryName,
            this.NameUnit,
            this.Quantity,
            this.OutputDate,
            this.Note});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid2.DefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(31, 39);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid2.RowTemplate.Height = 24;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(1571, 476);
            this.bunifuCustomDataGrid2.TabIndex = 39;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Tên Khách Hàng";
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 250;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Tên Sản Phẩm";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 300;
            // 
            // CategoryName
            // 
            this.CategoryName.HeaderText = "Tên Loại Sản Phẩm";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Width = 300;
            // 
            // NameUnit
            // 
            this.NameUnit.HeaderText = "Tên Loại Đơn Vị Tính";
            this.NameUnit.Name = "NameUnit";
            this.NameUnit.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Số Lượng Xuất";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 250;
            // 
            // OutputDate
            // 
            this.OutputDate.HeaderText = "Ngày Xuất ";
            this.OutputDate.Name = "OutputDate";
            this.OutputDate.Width = 200;
            // 
            // Note
            // 
            this.Note.HeaderText = "Ghi Chú";
            this.Note.Name = "Note";
            this.Note.Width = 300;
            // 
            // usoutput
            // 
            this.usoutput.Radius = 0;
            this.usoutput.TargetControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_total_amount);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btprint);
            this.groupBox1.Controls.Add(this.bunifuCustomDataGrid2);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1629, 617);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phiếu Nhập";
            // 
            // txt_total_amount
            // 
            this.txt_total_amount.AutoSize = true;
            this.txt_total_amount.Location = new System.Drawing.Point(175, 560);
            this.txt_total_amount.Name = "txt_total_amount";
            this.txt_total_amount.Size = new System.Drawing.Size(0, 24);
            this.txt_total_amount.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 560);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 24);
            this.label9.TabIndex = 43;
            this.label9.Text = "Tổng tiền :";
            // 
            // btprint
            // 
            this.btprint.AnimationHoverSpeed = 0.07F;
            this.btprint.AnimationSpeed = 0.03F;
            this.btprint.BackColor = System.Drawing.Color.Transparent;
            this.btprint.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.btprint.BorderColor = System.Drawing.Color.Black;
            this.btprint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btprint.FocusedColor = System.Drawing.Color.Empty;
            this.btprint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btprint.ForeColor = System.Drawing.Color.White;
            this.btprint.Image = global::test1.Properties.Resources.print2_300px;
            this.btprint.ImageSize = new System.Drawing.Size(30, 30);
            this.btprint.Location = new System.Drawing.Point(1446, 544);
            this.btprint.Name = "btprint";
            this.btprint.OnHoverBaseColor = System.Drawing.Color.CadetBlue;
            this.btprint.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btprint.OnHoverForeColor = System.Drawing.Color.White;
            this.btprint.OnHoverImage = null;
            this.btprint.OnPressedColor = System.Drawing.Color.Black;
            this.btprint.Radius = 8;
            this.btprint.Size = new System.Drawing.Size(177, 40);
            this.btprint.TabIndex = 42;
            this.btprint.Text = "In";
            this.btprint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdate
            // 
            this.txtdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtdate.CustomFormat = null;
            this.txtdate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtdate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.ForeColor = System.Drawing.Color.White;
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdate.Location = new System.Drawing.Point(632, 107);
            this.txtdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdate.Name = "txtdate";
            this.txtdate.OnHoverBaseColor = System.Drawing.Color.White;
            this.txtdate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtdate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtdate.OnPressedColor = System.Drawing.Color.Black;
            this.txtdate.Size = new System.Drawing.Size(267, 36);
            this.txtdate.TabIndex = 69;
            this.txtdate.Text = "5/15/2021";
            this.txtdate.Value = new System.DateTime(2021, 5, 15, 17, 42, 21, 782);
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
            this.txtcategory.Location = new System.Drawing.Point(905, 107);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtcategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.txtcategory.Size = new System.Drawing.Size(267, 29);
            this.txtcategory.TabIndex = 68;
            this.txtcategory.Tag = "Chọn theo loại";
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
            this.txtinput.Location = new System.Drawing.Point(1189, 107);
            this.txtinput.Name = "txtinput";
            this.txtinput.PasswordChar = '\0';
            this.txtinput.SelectedText = "";
            this.txtinput.Size = new System.Drawing.Size(267, 36);
            this.txtinput.TabIndex = 64;
            this.txtinput.Tag = "";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton1.Location = new System.Drawing.Point(1501, 102);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.CadetBlue;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 8;
            this.gunaButton1.Size = new System.Drawing.Size(177, 41);
            this.gunaButton1.TabIndex = 63;
            this.gunaButton1.Text = "Lọc";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // btdelete
            // 
            this.btdelete.BackColor = System.Drawing.Color.White;
            this.btdelete.Image = ((System.Drawing.Image)(resources.GetObject("btdelete.Image")));
            this.btdelete.ImageActive = null;
            this.btdelete.Location = new System.Drawing.Point(163, 96);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(40, 40);
            this.btdelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btdelete.TabIndex = 65;
            this.btdelete.TabStop = false;
            this.btdelete.Zoom = 10;
            // 
            // btedit
            // 
            this.btedit.BackColor = System.Drawing.Color.White;
            this.btedit.Image = ((System.Drawing.Image)(resources.GetObject("btedit.Image")));
            this.btedit.ImageActive = null;
            this.btedit.Location = new System.Drawing.Point(104, 97);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(40, 40);
            this.btedit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btedit.TabIndex = 66;
            this.btedit.TabStop = false;
            this.btedit.Zoom = 10;
            // 
            // btadd
            // 
            this.btadd.BackColor = System.Drawing.Color.White;
            this.btadd.Image = ((System.Drawing.Image)(resources.GetObject("btadd.Image")));
            this.btadd.ImageActive = null;
            this.btadd.Location = new System.Drawing.Point(48, 96);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(40, 40);
            this.btadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btadd.TabIndex = 67;
            this.btadd.TabStop = false;
            this.btadd.Zoom = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1185, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 24);
            this.label3.TabIndex = 78;
            this.label3.Text = "Nhập Tên Cần tìm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(628, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 79;
            this.label5.Text = "Chọn Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(901, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 80;
            this.label4.Text = "Chọn Theo Loại";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(226, 97);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 81;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // us_output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtcategory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btadd);
            this.Name = "us_output";
            this.Size = new System.Drawing.Size(1705, 1014);
            this.Load += new System.EventHandler(this.us_output_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btdelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btedit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private Guna.UI.WinForms.GunaElipse usoutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaDateTimePicker txtdate;
        private Guna.UI.WinForms.GunaComboBox txtcategory;
        private Guna.UI.WinForms.GunaTextBox txtinput;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Bunifu.Framework.UI.BunifuImageButton btdelete;
        private Bunifu.Framework.UI.BunifuImageButton btedit;
        private Bunifu.Framework.UI.BunifuImageButton btadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.Label txt_total_amount;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaButton btprint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}
