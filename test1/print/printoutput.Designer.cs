namespace test1.print
{
    partial class printoutput
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.outputxsd = new test1.outputxsd();
            this.outputxsdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outputxsdBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.outputxsdBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new test1.outputxsdTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.outputxsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputxsdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputxsdBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputxsdBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable1BindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "test1.print.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1462, 637);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // outputxsd
            // 
            this.outputxsd.DataSetName = "outputxsd";
            this.outputxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // outputxsdBindingSource
            // 
            this.outputxsdBindingSource.DataSource = this.outputxsd;
            this.outputxsdBindingSource.Position = 0;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.outputxsd;
            // 
            // outputxsdBindingSource1
            // 
            this.outputxsdBindingSource1.DataSource = this.outputxsd;
            this.outputxsdBindingSource1.Position = 0;
            // 
            // outputxsdBindingSource2
            // 
            this.outputxsdBindingSource2.DataSource = this.outputxsd;
            this.outputxsdBindingSource2.Position = 0;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.outputxsd;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // printoutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 637);
            this.Controls.Add(this.reportViewer1);
            this.Name = "printoutput";
            this.Text = "printoutput";
            this.Load += new System.EventHandler(this.printoutput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputxsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputxsdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputxsdBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputxsdBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource outputxsdBindingSource;
        private outputxsd outputxsd;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private System.Windows.Forms.BindingSource outputxsdBindingSource1;
        private System.Windows.Forms.BindingSource outputxsdBindingSource2;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private outputxsdTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    }
}