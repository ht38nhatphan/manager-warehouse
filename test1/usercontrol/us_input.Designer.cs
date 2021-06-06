namespace test1.usercontrol
{
    partial class us_input
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(us_input));
            this.usinput = new Guna.UI.WinForms.GunaElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtinput = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_total_amount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btprint = new Guna.UI.WinForms.GunaButton();
            this.txtcategory = new Guna.UI.WinForms.GunaComboBox();
            this.txtdate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btsearch = new Guna.UI.WinForms.GunaButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btdelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.btedit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btadd = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btdelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btedit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btadd)).BeginInit();
            this.SuspendLayout();
            // 
            // usinput
            // 
            this.usinput.Radius = 0;
            this.usinput.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "Phiếu Nhập";
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
            this.txtinput.Location = new System.Drawing.Point(1204, 125);
            this.txtinput.Name = "txtinput";
            this.txtinput.PasswordChar = '\0';
            this.txtinput.SelectedText = "";
            this.txtinput.Size = new System.Drawing.Size(267, 36);
            this.txtinput.TabIndex = 19;
            this.txtinput.Tag = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 680);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 24);
            this.label9.TabIndex = 40;
            this.label9.Text = "Tổng tiền :";
            // 
            // txt_total_amount
            // 
            this.txt_total_amount.AutoSize = true;
            this.txt_total_amount.Location = new System.Drawing.Point(176, 680);
            this.txt_total_amount.Name = "txt_total_amount";
            this.txt_total_amount.Size = new System.Drawing.Size(0, 24);
            this.txt_total_amount.TabIndex = 41;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bunifuCustomDataGrid2);
            this.groupBox2.Controls.Add(this.txt_total_amount);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btprint);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(60, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1622, 722);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Phiếu Nhập";
            // 
            // bunifuCustomDataGrid2
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.CategoryName,
            this.CompanyName,
            this.InputDate,
            this.Column1,
            this.column2,
            this.Column3,
            this.column4,
            this.Column5});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid2.DefaultCellStyle = dataGridViewCellStyle7;
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(19, 47);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.bunifuCustomDataGrid2.RowTemplate.Height = 24;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(1592, 585);
            this.bunifuCustomDataGrid2.TabIndex = 39;
            this.bunifuCustomDataGrid2.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid2_RowEnter);
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Tên Sản Phẩm";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 350;
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
            this.CompanyName.HeaderText = "Tên Nhà Cung Cấp";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Width = 350;
            // 
            // InputDate
            // 
            this.InputDate.DataPropertyName = "InputDate";
            this.InputDate.HeaderText = "Ngày Nhập";
            this.InputDate.Name = "InputDate";
            this.InputDate.Width = 200;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Quantity";
            this.Column1.HeaderText = "Số Lượng";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // column2
            // 
            this.column2.DataPropertyName = "InputPrice";
            this.column2.HeaderText = "Giá Nhập";
            this.column2.Name = "column2";
            this.column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "OutputPrice";
            this.Column3.HeaderText = "Giá Xuất";
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // column4
            // 
            this.column4.DataPropertyName = "Note";
            this.column4.HeaderText = "Ghi Chú";
            this.column4.Name = "column4";
            this.column4.Width = 300;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NameUnit";
            this.Column5.HeaderText = "Đơn Vị Tính";
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
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
            this.btprint.Location = new System.Drawing.Point(1415, 664);
            this.btprint.Name = "btprint";
            this.btprint.OnHoverBaseColor = System.Drawing.Color.CadetBlue;
            this.btprint.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btprint.OnHoverForeColor = System.Drawing.Color.White;
            this.btprint.OnHoverImage = null;
            this.btprint.OnPressedColor = System.Drawing.Color.Black;
            this.btprint.Radius = 8;
            this.btprint.Size = new System.Drawing.Size(177, 40);
            this.btprint.TabIndex = 20;
            this.btprint.Text = "In";
            this.btprint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btprint.Click += new System.EventHandler(this.btprint_Click);
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
            this.txtcategory.Location = new System.Drawing.Point(931, 125);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtcategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.txtcategory.Size = new System.Drawing.Size(267, 29);
            this.txtcategory.TabIndex = 61;
            this.txtcategory.Tag = "Chọn theo loại";
            this.txtcategory.SelectedIndexChanged += new System.EventHandler(this.txtcategory_SelectedIndexChanged);
            this.txtcategory.Click += new System.EventHandler(this.txtcategory_Click);
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
            this.txtdate.Location = new System.Drawing.Point(658, 125);
            this.txtdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdate.Name = "txtdate";
            this.txtdate.OnHoverBaseColor = System.Drawing.Color.White;
            this.txtdate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtdate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtdate.OnPressedColor = System.Drawing.Color.Black;
            this.txtdate.Size = new System.Drawing.Size(267, 36);
            this.txtdate.TabIndex = 62;
            this.txtdate.Text = "5/15/2021";
            this.txtdate.Value = new System.DateTime(2021, 5, 15, 17, 42, 21, 782);
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
            this.btsearch.Location = new System.Drawing.Point(1494, 120);
            this.btsearch.Name = "btsearch";
            this.btsearch.OnHoverBaseColor = System.Drawing.Color.CadetBlue;
            this.btsearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btsearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btsearch.OnHoverImage = null;
            this.btsearch.OnPressedColor = System.Drawing.Color.Black;
            this.btsearch.Radius = 8;
            this.btsearch.Size = new System.Drawing.Size(177, 41);
            this.btsearch.TabIndex = 73;
            this.btsearch.Text = "Lọc";
            this.btsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1211, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 24);
            this.label3.TabIndex = 76;
            this.label3.Text = "Nhập Tên Cần tìm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(927, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 77;
            this.label4.Text = "Chọn Theo Loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(654, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 77;
            this.label5.Text = "Chọn Ngày";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(240, 117);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 80;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btdelete
            // 
            this.btdelete.BackColor = System.Drawing.Color.White;
            this.btdelete.Image = ((System.Drawing.Image)(resources.GetObject("btdelete.Image")));
            this.btdelete.ImageActive = null;
            this.btdelete.Location = new System.Drawing.Point(181, 120);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(40, 40);
            this.btdelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btdelete.TabIndex = 60;
            this.btdelete.TabStop = false;
            this.btdelete.Zoom = 10;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btedit
            // 
            this.btedit.BackColor = System.Drawing.Color.White;
            this.btedit.Image = ((System.Drawing.Image)(resources.GetObject("btedit.Image")));
            this.btedit.ImageActive = null;
            this.btedit.Location = new System.Drawing.Point(122, 121);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(40, 40);
            this.btedit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btedit.TabIndex = 60;
            this.btedit.TabStop = false;
            this.btedit.Zoom = 10;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // btadd
            // 
            this.btadd.BackColor = System.Drawing.Color.White;
            this.btadd.Image = ((System.Drawing.Image)(resources.GetObject("btadd.Image")));
            this.btadd.ImageActive = null;
            this.btadd.Location = new System.Drawing.Point(66, 120);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(40, 40);
            this.btadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btadd.TabIndex = 60;
            this.btadd.TabStop = false;
            this.btadd.Zoom = 10;
            this.btadd.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // us_input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtcategory);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "us_input";
            this.Size = new System.Drawing.Size(1705, 1014);
            this.Load += new System.EventHandler(this.us_input_Load_1);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btdelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btedit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btadd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse usinput;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtinput;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private System.Windows.Forms.Label txt_total_amount;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaButton btprint;
        private Bunifu.Framework.UI.BunifuImageButton btdelete;
        private Bunifu.Framework.UI.BunifuImageButton btedit;
        private Bunifu.Framework.UI.BunifuImageButton btadd;
        private Guna.UI.WinForms.GunaComboBox txtcategory;
        private Guna.UI.WinForms.GunaDateTimePicker txtdate;
        private Guna.UI.WinForms.GunaButton btsearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
