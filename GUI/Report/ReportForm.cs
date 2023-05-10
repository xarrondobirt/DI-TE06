using System;
using System.Windows.Forms;

namespace GUI.Report
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, System.EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, System.EventArgs e)
        {
            DateTime from = rvDateFrom.Value;
            DateTime to = rvDateTo.Value;
            var adapter = new EmpDataSetTableAdapters.Employee_Sales_by_CountryTableAdapter();

            adapter.Fill(this.empDataSet.Employee_Sales_by_Country, from, to);


            this.reportViewer1.RefreshReport();
        }

        private void empDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
