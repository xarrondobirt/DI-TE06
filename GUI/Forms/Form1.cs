using Controller;
using GUI.Forms;
using GUI.Report;
using GUI.UC;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        private GeneralUC generalUC;
        private EmployeeUC employeeUC;

        // flag para saber en qué vista estamos
        private bool bIsGeneralView = true;
        public Form1()
        {
            InitializeComponent();
            LoadComboBoxes();
            LoadGeneralUC();
            this.toolTip.SetToolTip(this.cbHeaderL, "Selecciona un producto");
            this.toolTip.SetToolTip(this.cbHeaderR, "Selecciona un país");
            this.toolTip.SetToolTip(this.pb, "Ver información");
        }

        /// <summary>
        /// Carga de ComboBoxes
        /// </summary>
        private void LoadComboBoxes()
        {
            cbHeaderL.Items.Clear();
            cbHeaderR.Items.Clear();

            BindingSource bsCountry = new BindingSource();
            bsCountry.DataSource = DashboardControl.LoadCountries();
            cbHeaderR.DataSource = bsCountry;

            BindingSource bsProduct = new BindingSource();
            bsProduct.DataSource = DashboardControl.LoadProducts();
            cbHeaderL.DataSource = bsProduct;

        }

        /// <summary>
        /// Cargar Control de Usuario de la vista General
        /// </summary>
        private void LoadGeneralUC()
        {
            this.btnSideTop.Enabled = false;
            this.btnSideBot.Enabled = true;
            this.btnSideTop.BackColor = SystemColors.Highlight;
            this.btnSideBot.BackColor = Color.Transparent;

            tlpBase.Controls.Remove(employeeUC);
            tlpBase.Controls.Remove(generalUC);
            generalUC = new GeneralUC();


            string selectedProd = cbHeaderL.SelectedValue.ToString();
            string selectedCountry = cbHeaderR.SelectedValue.ToString();

            // Dependiendo de si hay algún filtro activo llamará a un método u otro
            if (selectedProd == "" && selectedCountry == "")
            {
                generalUC.MainView();
            }
            else if (selectedProd != "" && selectedCountry == "")
            {
                generalUC.ProductView(selectedProd);
            }
            else if (selectedProd == "" && selectedCountry != "")
            {
                generalUC.CountryView(selectedCountry);
            }
            else
            {
                generalUC.ProductAndCountryView(selectedProd, selectedCountry);
            }

            tlpBase.Controls.Add(generalUC, 1, 1);
        }

        /// <summary>
        /// Cargar vista empleados
        /// </summary>
        private void LoadEmployeeUC()
        {
            this.btnSideTop.Enabled = true;
            this.btnSideBot.Enabled = false;
            this.btnSideTop.BackColor = Color.Transparent;
            this.btnSideBot.BackColor = SystemColors.Highlight;

            tlpBase.Controls.Remove(employeeUC);
            tlpBase.Controls.Remove(generalUC);
            employeeUC = new EmployeeUC();


            string selectedProd = cbHeaderL.SelectedValue.ToString();
            string selectedCountry = cbHeaderR.SelectedValue.ToString();

            if (selectedProd == "" && selectedCountry == "")
            {
                employeeUC.MainView();
            }
            else if (selectedProd != "" && selectedCountry == "")
            {
                employeeUC.ProductView(selectedProd);
            }
            else if (selectedProd == "" && selectedCountry != "")
            {
                employeeUC.CountryView(selectedCountry);
            }
            else
            {
                employeeUC.ProductAndCountryView(selectedProd, selectedCountry);
            }

            tlpBase.Controls.Add(employeeUC, 1, 1);
        }

        /// <summary>
        /// Cargar Control de Usuario de la vista General
        /// </summary>
        private void btnSideTop_Click(object sender, EventArgs e)
        {
            this.bIsGeneralView = true;
            this.LoadGeneralUC();

        }

        /// <summary>
        /// Cargar Control de Usuario de la vista Empleados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSideBot_Click(object sender, EventArgs e)
        {
            this.bIsGeneralView = false;
            this.LoadEmployeeUC();
        }

        /// <summary>
        /// Rellenar datos filtrados por producto según en la vista en la que estamos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbHeaderL_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (bIsGeneralView)
            {
                LoadGeneralUC();
            }
            else
            {
                LoadEmployeeUC();
            }

        }

        /// <summary>
        /// Rellenar datos filtrados por país según en la vista en la que estamos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbHeaderR_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (bIsGeneralView)
            {
                LoadGeneralUC();
            }
            else
            {
                LoadEmployeeUC();
            }
        }

        /// <summary>
        /// Evento del botón que abre el form de Crystal Report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReport_Click(object sender, EventArgs e)
        {
            CrystalForm crystalRpt = new CrystalForm();
            crystalRpt.Show();
        }

        private void tlpSide_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Evento del botón que abre el form de Report Viewer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReportViewer_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm();
            report.Show();
        }

        private void pb_Click(object sender, EventArgs e)
        {
            Popup popup = new Popup();
            popup.Show();

        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help/help.chm");
        }
    }
}
