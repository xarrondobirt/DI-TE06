using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UC
{
    public partial class GeneralUC : UserControl
    {
        public GeneralUC()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cargar datos sin filtros
        /// </summary>
        public void MainView()
        {
            double[] y = DashboardControl.RevenueByYear();
            int[] x = { 1996, 1997, 1998 };
            double sales = 0;

            // Suma de los ingresos totales
            for(int i = 0; i < y.Length; i++)
            {
                sales += y[i];
            }

            chartGeneralUC.Series["Ingresos"].Points.DataBindXY(x, y);

            labelGeneralLTopUC.Text = "Ingresos totales";
            labelGeneralLBotUC.Text = sales.ToString() + "€";
        }

        /// <summary>
        /// Cargar datos filtrando por producto
        /// </summary>
        /// <param name="prod"></param>
        public void ProductView(string prod)
        {
            double[] y = DashboardControl.RevenueByYearProduct(prod);
            int[] x = { 1996, 1997, 1998 };
            double sales = 0;

            // Suma de los ingresos totales
            for (int i = 0; i < y.Length; i++)
            {
                sales += y[i];
            }

            chartGeneralUC.Series["Ingresos"].Points.DataBindXY(x, y);

            labelGeneralLTopUC.Text = "Ingresos por " + prod;
            labelGeneralLBotUC.Text = sales.ToString() + "€";
        }

        /// <summary>
        /// Cargar datos filtrando por país
        /// </summary>
        /// <param name="country"></param>
        public void CountryView(string country)
        {
            double[] y = DashboardControl.RevenueByYearCountry(country);
            int[] x = { 1996, 1997, 1998 };
            double sales = 0;

            // Suma de los ingresos totales
            for (int i = 0; i < y.Length; i++)
            {
                sales += y[i];
            }

            chartGeneralUC.Series["Ingresos"].Points.DataBindXY(x, y);

            labelGeneralLTopUC.Text = "Ingresos en " + country;
            labelGeneralLBotUC.Text = sales.ToString() + "€";
        }

        /// <summary>
        /// Cargar datos filtrando por producto y país
        /// </summary>
        /// <param name="prod"></param>
        /// <param name="country"></param>
        public void ProductAndCountryView(string prod, string country)
        {
            double[] y = DashboardControl.RevenueByYearProductAndCountry(prod, country);
            int[] x = { 1996, 1997, 1998 };
            double sales = 0;

            // Suma de los ingresos totales
            for (int i = 0; i < y.Length; i++)
            {
                sales += y[i];
            }

            chartGeneralUC.Series["Ingresos"].Points.DataBindXY(x, y);

            labelGeneralLTopUC.Text = "Ingresos por " + prod + " en " + country;
            labelGeneralLBotUC.Text = sales.ToString() + "€";
        }
    }
}
