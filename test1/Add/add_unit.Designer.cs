namespace test1.Add
{
    partial class add_unit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_unit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtunit = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btsave = new Guna.UI.WinForms.GunaButton();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btdelete = new Guna.UI.WinForms.GunaButton();
            this.btedit = new Guna.UI.WinForms.GunaButton();
            this.btadd = new Guna.UI.WinForms.GunaButton();
            this.NameUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 74);
            this.panel1.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(808, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 29);
            this.label4.TabIndex = 75;
            this.label4.Text = "x";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn Vị Tính";
            // 
            // txtunit
            // 
            this.txtunit.BaseColor = System.Drawing.Color.White;
            this.txtunit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtunit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtunit.FocusedBaseColor = System.Drawing.Color.White;
            this.txtunit.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtunit.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtunit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtunit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtunit.Location = new System.Drawing.Point(35, 134);
            this.txtunit.Name = "txtunit";
            this.txtunit.PasswordChar = '\0';
            this.txtunit.SelectedText = "";
            this.txtunit.Size = new System.Drawing.Size(285, 36);
            this.txtunit.TabIndex = 85;
            this.txtunit.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 84;
            this.label2.Text = "Tên Đơn Vị";
            // 
            // btsave
            // 
            this.btsave.AnimationHoverSpeed = 0.07F;
            this.btsave.AnimationSpeed = 0.03F;
            this.btsave.BackColor = System.Drawing.Color.Transparent;
            this.btsave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.btsave.BorderColor = System.Drawing.Color.Black;
            this.btsave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btsave.FocusedColor = System.Drawing.Color.Empty;
            this.btsave.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsave.ForeColor = System.Drawing.Color.White;
            this.btsave.Image = ((System.Drawing.Image)(resources.GetObject("btsave.Image")));
            this.btsave.ImageSize = new System.Drawing.Size(30, 30);
            this.btsave.Location = new System.Drawing.Point(650, 385);
            this.btsave.Name = "btsave";
            this.btsave.OnHoverBaseColor = System.Drawing.Color.CadetBlue;
            this.btsave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btsave.OnHoverForeColor = System.Drawing.Color.White;
            this.btsave.OnHoverImage = null;
            this.btsave.OnPressedColor = System.Drawing.Color.Black;
            this.btsave.Radius = 8;
            this.btsave.Size = new System.Drawing.Size(177, 40);
            this.btsave.TabIndex = 90;
            this.btsave.Text = "Lưu";
            this.btsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // bunifuCustomDataGrid2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameUnit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid2.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(387, 95);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid2.RowTemplate.Height = 24;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(440, 250);
            this.bunifuCustomDataGrid2.TabIndex = 91;
            this.bunifuCustomDataGrid2.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid2_RowEnter);
            // 
            // btdelete
            // 
            this.btdelete.AnimationHoverSpeed = 0.07F;
            this.btdelete.AnimationSpeed = 0.03F;
            this.btdelete.BackColor = System.Drawing.Color.Transparent;
            this.btdelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.btdelete.BorderColor = System.Drawing.Color.Black;
            this.btdelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btdelete.FocusedColor = System.Drawing.Color.Empty;
            this.btdelete.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdelete.ForeColor = System.Drawing.Color.White;
            this.btdelete.Image = global::test1.Properties.Resources.delete_300px;
            this.btdelete.ImageSize = new System.Drawing.Size(30, 30);
            this.btdelete.Location = new System.Drawing.Point(441, 385);
            this.btdelete.Name = "btdelete";
            this.btdelete.OnHoverBaseColor = System.Drawing.Color.CadetBlue;
            this.btdelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btdelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btdelete.OnHoverImage = null;
            this.btdelete.OnPressedColor = System.Drawing.Color.Black;
            this.btdelete.Radius = 8;
            this.btdelete.Size = new System.Drawing.Size(177, 40);
            this.btdelete.TabIndex = 92;
            this.btdelete.Text = "Xoá";
            this.btdelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btedit
            // 
            this.btedit.AnimationHoverSpeed = 0.07F;
            this.btedit.AnimationSpeed = 0.03F;
            this.btedit.BackColor = System.Drawing.Color.Transparent;
            this.btedit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.btedit.BorderColor = System.Drawing.Color.Black;
            this.btedit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btedit.FocusedColor = System.Drawing.Color.Empty;
            this.btedit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btedit.ForeColor = System.Drawing.Color.White;
            this.btedit.Image = global::test1.Properties.Resources.edit_property1_300px;
            this.btedit.ImageSize = new System.Drawing.Size(30, 30);
            this.btedit.Location = new System.Drawing.Point(222, 385);
            this.btedit.Name = "btedit";
            this.btedit.OnHoverBaseColor = System.Drawing.Color.CadetBlue;
            this.btedit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btedit.OnHoverForeColor = System.Drawing.Color.White;
            this.btedit.OnHoverImage = null;
            this.btedit.OnPressedColor = System.Drawing.Color.Black;
            this.btedit.Radius = 8;
            this.btedit.Size = new System.Drawing.Size(177, 40);
            this.btedit.TabIndex = 93;
            this.btedit.Text = "Sửa";
            this.btedit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // btadd
            // 
            this.btadd.AnimationHoverSpeed = 0.07F;
            this.btadd.AnimationSpeed = 0.03F;
            this.btadd.BackColor = System.Drawing.Color.Transparent;
            this.btadd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.btadd.BorderColor = System.Drawing.Color.Black;
            this.btadd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btadd.FocusedColor = System.Drawing.Color.Empty;
            this.btadd.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.ForeColor = System.Drawing.Color.White;
            this.btadd.Image = ((System.Drawing.Image)(resources.GetObject("btadd.Image")));
            this.btadd.ImageSize = new System.Drawing.Size(35, 35);
            this.btadd.Location = new System.Drawing.Point(12, 385);
            this.btadd.Name = "btadd";
            this.btadd.OnHoverBaseColor = System.Drawing.Color.CadetBlue;
            this.btadd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btadd.OnHoverForeColor = System.Drawing.Color.White;
            this.btadd.OnHoverImage = null;
            this.btadd.OnPressedColor = System.Drawing.Color.Black;
            this.btadd.Radius = 8;
            this.btadd.Size = new System.Drawing.Size(177, 40);
            this.btadd.TabIndex = 94;
            this.btadd.Text = "Thêm";
            this.btadd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btadd.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // NameUnit
            // 
            this.NameUnit.DataPropertyName = "NameUnit";
            this.NameUnit.HeaderText = "Tên đơn vị";
            this.NameUnit.Name = "NameUnit";
            this.NameUnit.Width = 400;
            // 
            // add_unit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 459);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.bunifuCustomDataGrid2);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.txtunit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_unit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_unit";
            this.Load += new System.EventHandler(this.add_unit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtunit;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btsave;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private Guna.UI.WinForms.GunaButton btdelete;
        private Guna.UI.WinForms.GunaButton btedit;
        private Guna.UI.WinForms.GunaButton btadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUnit;
    }
}