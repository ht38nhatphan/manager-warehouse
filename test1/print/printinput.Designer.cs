namespace test1.print
{
    partial class printinput
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
            this.inputdateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_KHO_HANGDataSet = new test1.QL_KHO_HANGDataSet();
            this.input_dateTableAdapter = new test1.QL_KHO_HANGDataSetTableAdapters.input_dateTableAdapter();
            this.qLKHOHANGDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.input_dateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inputdateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_KHO_HANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKHOHANGDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_dateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.input_dateBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "test1.print.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1037, 519);
            this.reportViewer1.TabIndex = 0;
            // 
            // inputdateBindingSource
            // 
            this.inputdateBindingSource.DataMember = "input_date";
            this.inputdateBindingSource.DataSource = this.qL_KHO_HANGDataSet;
            // 
            // qL_KHO_HANGDataSet
            // 
            this.qL_KHO_HANGDataSet.DataSetName = "QL_KHO_HANGDataSet";
            this.qL_KHO_HANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // input_dateTableAdapter
            // 
            this.input_dateTableAdapter.ClearBeforeFill = true;
            // 
            // qLKHOHANGDataSetBindingSource
            // 
            this.qLKHOHANGDataSetBindingSource.DataSource = this.qL_KHO_HANGDataSet;
            this.qLKHOHANGDataSetBindingSource.Position = 0;
            // 
            // input_dateBindingSource
            // 
            this.input_dateBindingSource.DataMember = "input_date";
            this.input_dateBindingSource.DataSource = this.qL_KHO_HANGDataSet;
            // 
            // printinput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 519);
            this.Controls.Add(this.reportViewer1);
            this.Name = "printinput";
            this.Text = "printinput";
            this.Load += new System.EventHandler(this.printinput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputdateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_KHO_HANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKHOHANGDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_dateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource inputdateBindingSource;
        private QL_KHO_HANGDataSet qL_KHO_HANGDataSet;
        private QL_KHO_HANGDataSetTableAdapters.input_dateTableAdapter input_dateTableAdapter;
        private System.Windows.Forms.BindingSource input_dateBindingSource;
        private System.Windows.Forms.BindingSource qLKHOHANGDataSetBindingSource;
    }
}