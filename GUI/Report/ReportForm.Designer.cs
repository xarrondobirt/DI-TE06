using GUI.Report;
namespace GUI.Report
{
    partial class ReportForm
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
            this.rvDateFrom = new System.Windows.Forms.DateTimePicker();
            this.rvLabelFrom = new System.Windows.Forms.Label();
            this.rvLabelTo = new System.Windows.Forms.Label();
            this.rvDateTo = new System.Windows.Forms.DateTimePicker();
            this.empDataSet = new GUI.Report.EmpDataSet();
            this.employeeSalesByCountryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_Sales_by_CountryTableAdapter = new GUI.Report.EmpDataSetTableAdapters.Employee_Sales_by_CountryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalesByCountryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.employeeSalesByCountryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 56);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1116, 507);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // rvDateFrom
            // 
            this.rvDateFrom.Location = new System.Drawing.Point(573, 29);
            this.rvDateFrom.Name = "rvDateFrom";
            this.rvDateFrom.Size = new System.Drawing.Size(200, 20);
            this.rvDateFrom.TabIndex = 3;
            this.rvDateFrom.Value = new System.DateTime(1994, 1, 1, 0, 0, 0, 0);
            // 
            // rvLabelFrom
            // 
            this.rvLabelFrom.AutoSize = true;
            this.rvLabelFrom.Location = new System.Drawing.Point(519, 35);
            this.rvLabelFrom.Name = "rvLabelFrom";
            this.rvLabelFrom.Size = new System.Drawing.Size(38, 13);
            this.rvLabelFrom.TabIndex = 4;
            this.rvLabelFrom.Text = "Desde";
            // 
            // rvLabelTo
            // 
            this.rvLabelTo.AutoSize = true;
            this.rvLabelTo.Location = new System.Drawing.Point(819, 36);
            this.rvLabelTo.Name = "rvLabelTo";
            this.rvLabelTo.Size = new System.Drawing.Size(35, 13);
            this.rvLabelTo.TabIndex = 5;
            this.rvLabelTo.Text = "Hasta";
            // 
            // rvDateTo
            // 
            this.rvDateTo.Location = new System.Drawing.Point(876, 30);
            this.rvDateTo.Name = "rvDateTo";
            this.rvDateTo.Size = new System.Drawing.Size(200, 20);
            this.rvDateTo.TabIndex = 6;
            this.rvDateTo.Value = new System.DateTime(2023, 5, 1, 0, 0, 0, 0);
            // 
            // empDataSet
            // 
            this.empDataSet.DataSetName = "EmpDataSet";
            this.empDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeSalesByCountryBindingSource
            // 
            this.employeeSalesByCountryBindingSource.DataMember = "Employee Sales by Country";
            this.employeeSalesByCountryBindingSource.DataSource = this.empDataSet;
            // 
            // employee_Sales_by_CountryTableAdapter
            // 
            this.employee_Sales_by_CountryTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 563);
            this.Controls.Add(this.rvDateTo);
            this.Controls.Add(this.rvLabelTo);
            this.Controls.Add(this.rvLabelFrom);
            this.Controls.Add(this.rvDateFrom);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalesByCountryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker rvDateFrom;
        private System.Windows.Forms.Label rvLabelFrom;
        private System.Windows.Forms.Label rvLabelTo;
        private System.Windows.Forms.DateTimePicker rvDateTo;
        private System.Windows.Forms.BindingSource employeeSalesByCountryBindingSource;
        private EmpDataSet empDataSet;
        private EmpDataSetTableAdapters.Employee_Sales_by_CountryTableAdapter employee_Sales_by_CountryTableAdapter;
    }
}