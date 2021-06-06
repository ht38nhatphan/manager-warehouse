namespace test1.Add
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_product));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtproduct = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btsave = new Guna.UI.WinForms.GunaButton();
            this.bntsupplier = new Bunifu.Framework.UI.BunifuImageButton();
            this.bntunit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bntcategory = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtnote = new System.Windows.Forms.RichTextBox();
            this.cmsupplier = new System.Windows.Forms.ComboBox();
            this.cmcategory = new System.Windows.Forms.ComboBox();
            this.cmunit = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntsupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntunit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntcategory)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 88;
            this.label3.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1249, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 29);
            this.label4.TabIndex = 75;
            this.label4.Text = "x";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 74);
            this.panel1.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(563, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sản Phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(488, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 24);
            this.label5.TabIndex = 77;
            this.label5.Text = "Tên Loại Hàng Hoá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 78;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // txtproduct
            // 
            this.txtproduct.BaseColor = System.Drawing.Color.White;
            this.txtproduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtproduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtproduct.FocusedBaseColor = System.Drawing.Color.White;
            this.txtproduct.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(138)))), ((int)(((byte)(252)))));
            this.txtproduct.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtproduct.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtproduct.Location = new System.Drawing.Point(31, 180);
            this.txtproduct.Name = "txtproduct";
            this.txtproduct.PasswordChar = '\0';
            this.txtproduct.SelectedText = "";
            this.txtproduct.Size = new System.Drawing.Size(267, 36);
            this.txtproduct.TabIndex = 83;
            this.txtproduct.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(957, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 77;
            this.label6.Text = "Tên Đơn Vị";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 24);
            this.label7.TabIndex = 77;
            this.label7.Text = "Tên Nhà Cung Cấp";
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
            this.btsave.Location = new System.Drawing.Point(1066, 540);
            this.btsave.Name = "btsave";
            this.btsave.OnHoverBaseColor = System.Drawing.Color.CadetBlue;
            this.btsave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btsave.OnHoverForeColor = System.Drawing.Color.White;
            this.btsave.OnHoverImage = null;
            this.btsave.OnPressedColor = System.Drawing.Color.Black;
            this.btsave.Radius = 8;
            this.btsave.Size = new System.Drawing.Size(177, 40);
            this.btsave.TabIndex = 89;
            this.btsave.Text = "Lưu";
            this.btsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // bntsupplier
            // 
            this.bntsupplier.BackColor = System.Drawing.Color.White;
            this.bntsupplier.Image = ((System.Drawing.Image)(resources.GetObject("bntsupplier.Image")));
            this.bntsupplier.ImageActive = null;
            this.bntsupplier.Location = new System.Drawing.Point(320, 284);
            this.bntsupplier.Name = "bntsupplier";
            this.bntsupplier.Size = new System.Drawing.Size(40, 29);
            this.bntsupplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bntsupplier.TabIndex = 79;
            this.bntsupplier.TabStop = false;
            this.bntsupplier.Zoom = 10;
            this.bntsupplier.Click += new System.EventHandler(this.bntsupplier_Click);
            // 
            // bntunit
            // 
            this.bntunit.BackColor = System.Drawing.Color.White;
            this.bntunit.Image = ((System.Drawing.Image)(resources.GetObject("bntunit.Image")));
            this.bntunit.ImageActive = null;
            this.bntunit.Location = new System.Drawing.Point(1254, 180);
            this.bntunit.Name = "bntunit";
            this.bntunit.Size = new System.Drawing.Size(40, 29);
            this.bntunit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bntunit.TabIndex = 79;
            this.bntunit.TabStop = false;
            this.bntunit.Zoom = 10;
            this.bntunit.Click += new System.EventHandler(this.bntunit_Click);
            // 
            // bntcategory
            // 
            this.bntcategory.BackColor = System.Drawing.Color.White;
            this.bntcategory.Image = ((System.Drawing.Image)(resources.GetObject("bntcategory.Image")));
            this.bntcategory.ImageActive = null;
            this.bntcategory.Location = new System.Drawing.Point(780, 180);
            this.bntcategory.Name = "bntcategory";
            this.bntcategory.Size = new System.Drawing.Size(40, 29);
            this.bntcategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bntcategory.TabIndex = 79;
            this.bntcategory.TabStop = false;
            this.bntcategory.Zoom = 10;
            this.bntcategory.Click += new System.EventHandler(this.bntcategory_Click);
            // 
            // txtnote
            // 
            this.txtnote.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtnote.Location = new System.Drawing.Point(36, 392);
            this.txtnote.Name = "txtnote";
            this.txtnote.Size = new System.Drawing.Size(1192, 100);
            this.txtnote.TabIndex = 91;
            this.txtnote.Text = "";
            // 
            // cmsupplier
            // 
            this.cmsupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmsupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmsupplier.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsupplier.FormattingEnabled = true;
            this.cmsupplier.Location = new System.Drawing.Point(31, 284);
            this.cmsupplier.Name = "cmsupplier";
            this.cmsupplier.Size = new System.Drawing.Size(267, 31);
            this.cmsupplier.TabIndex = 92;
            // 
            // cmcategory
            // 
            this.cmcategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmcategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmcategory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmcategory.FormattingEnabled = true;
            this.cmcategory.Location = new System.Drawing.Point(492, 185);
            this.cmcategory.Name = "cmcategory";
            this.cmcategory.Size = new System.Drawing.Size(267, 31);
            this.cmcategory.TabIndex = 92;
            // 
            // cmunit
            // 
            this.cmunit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmunit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmunit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmunit.FormattingEnabled = true;
            this.cmunit.Location = new System.Drawing.Point(961, 180);
            this.cmunit.Name = "cmunit";
            this.cmunit.Size = new System.Drawing.Size(267, 31);
            this.cmunit.TabIndex = 92;
            // 
            // add_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1309, 626);
            this.Controls.Add(this.cmunit);
            this.Controls.Add(this.cmcategory);
            this.Controls.Add(this.cmsupplier);
            this.Controls.Add(this.txtnote);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtproduct);
            this.Controls.Add(this.bntsupplier);
            this.Controls.Add(this.bntunit);
            this.Controls.Add(this.bntcategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_product";
            this.Load += new System.EventHandler(this.add_product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntsupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntunit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntcategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btsave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bntcategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtproduct;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuImageButton bntunit;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuImageButton bntsupplier;
        private System.Windows.Forms.RichTextBox txtnote;
        private System.Windows.Forms.ComboBox cmsupplier;
        private System.Windows.Forms.ComboBox cmcategory;
        private System.Windows.Forms.ComboBox cmunit;
    }
}