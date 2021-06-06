namespace test1.Add
{
    partial class add_supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_supplier));
            this.btsave = new Guna.UI.WinForms.GunaButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemail = new Guna.UI.WinForms.GunaTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcompany = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtaddress = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnamecopany = new Guna.UI.WinForms.GunaTextBox();
            this.txtphone = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btsave.Location = new System.Drawing.Point(474, 471);
            this.btsave.Name = "btsave";
            this.btsave.OnHoverBaseColor = System.Drawing.Color.CadetBlue;
            this.btsave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btsave.OnHoverForeColor = System.Drawing.Color.White;
            this.btsave.OnHoverImage = null;
            this.btsave.OnPressedColor = System.Drawing.Color.Black;
            this.btsave.Radius = 8;
            this.btsave.Size = new System.Drawing.Size(177, 40);
            this.btsave.TabIndex = 6;
            this.btsave.Text = "Lưu";
            this.btsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(627, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 29);
            this.label4.TabIndex = 75;
            this.label4.Text = "x";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtemail
            // 
            this.txtemail.BaseColor = System.Drawing.Color.White;
            this.txtemail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtemail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtemail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtemail.Location = new System.Drawing.Point(26, 391);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(267, 36);
            this.txtemail.TabIndex = 5;
            this.txtemail.Tag = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 74);
            this.panel1.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(215, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhà Cung Cấp";
            // 
            // txtcompany
            // 
            this.txtcompany.BaseColor = System.Drawing.Color.White;
            this.txtcompany.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtcompany.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcompany.FocusedBaseColor = System.Drawing.Color.White;
            this.txtcompany.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtcompany.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcompany.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompany.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtcompany.Location = new System.Drawing.Point(25, 161);
            this.txtcompany.Name = "txtcompany";
            this.txtcompany.PasswordChar = '\0';
            this.txtcompany.SelectedText = "";
            this.txtcompany.Size = new System.Drawing.Size(267, 36);
            this.txtcompany.TabIndex = 0;
            this.txtcompany.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 24);
            this.label6.TabIndex = 78;
            this.label6.Text = "Tên Công Ty(*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 78;
            this.label2.Text = "Địa Chỉ(*)";
            // 
            // txtaddress
            // 
            this.txtaddress.BaseColor = System.Drawing.Color.White;
            this.txtaddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtaddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtaddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtaddress.Location = new System.Drawing.Point(25, 276);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '\0';
            this.txtaddress.SelectedText = "";
            this.txtaddress.Size = new System.Drawing.Size(267, 36);
            this.txtaddress.TabIndex = 2;
            this.txtaddress.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(380, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 24);
            this.label7.TabIndex = 86;
            this.label7.Text = "Tên Người Đại diện(*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(380, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 24);
            this.label5.TabIndex = 86;
            this.label5.Text = "Số Điện Thoại(*)";
            // 
            // txtnamecopany
            // 
            this.txtnamecopany.BaseColor = System.Drawing.Color.White;
            this.txtnamecopany.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtnamecopany.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnamecopany.FocusedBaseColor = System.Drawing.Color.White;
            this.txtnamecopany.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtnamecopany.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtnamecopany.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamecopany.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtnamecopany.Location = new System.Drawing.Point(384, 161);
            this.txtnamecopany.Name = "txtnamecopany";
            this.txtnamecopany.PasswordChar = '\0';
            this.txtnamecopany.SelectedText = "";
            this.txtnamecopany.Size = new System.Drawing.Size(267, 36);
            this.txtnamecopany.TabIndex = 1;
            this.txtnamecopany.Tag = "";
            // 
            // txtphone
            // 
            this.txtphone.BaseColor = System.Drawing.Color.White;
            this.txtphone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtphone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtphone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtphone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtphone.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtphone.Location = new System.Drawing.Point(384, 276);
            this.txtphone.Name = "txtphone";
            this.txtphone.PasswordChar = '\0';
            this.txtphone.SelectedText = "";
            this.txtphone.Size = new System.Drawing.Size(267, 36);
            this.txtphone.TabIndex = 3;
            this.txtphone.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 24);
            this.label8.TabIndex = 87;
            this.label8.Text = "Email(*)";
            // 
            // add_supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 523);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtnamecopany);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtcompany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_supplier";
            this.Load += new System.EventHandler(this.add_supplier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btsave;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtemail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtcompany;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtaddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtnamecopany;
        private Guna.UI.WinForms.GunaTextBox txtphone;
        private System.Windows.Forms.Label label8;
    }
}