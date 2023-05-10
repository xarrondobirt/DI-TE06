using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using Tools.DTO;
using Tools.VO;

namespace GUI.UC
{
    public partial class EmployeeUC : UserControl
    {
        public EmployeeUC()
        {
            InitializeComponent();
        }

        private void tlpEmployeeRUC_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Rellenar los datos de empleados sin filtros
        /// </summary>
        public void MainView()
        {
            List<EmployeeDTO> list = DashboardControl.BestEmployees();
            
            List<string> listNames = new List<string>();
            List<int> listSales = new List<int>();

            foreach(EmployeeDTO emp in list)
            {
                listNames.Add(emp.getFirstName() + " " + emp.getLastName());
                listSales.Add(emp.getNumSales());
            }
            showEmployeeData(list.First());
            chartEmployeeUC.Series["Mejores vendedores"].Points.DataBindXY(listNames.ToArray(), listSales.ToArray());
        }

        /// <summary>
        /// Rellenar los datos de empleado filtrando por producto
        /// </summary>
        /// <param name="prod"></param>
        public void ProductView(string prod)
        {

            List<EmployeeDTO> list = DashboardControl.BestEmployeesByProduct(prod);

            List<string> listNames = new List<string>();
            List<int> listSales = new List<int>();

            foreach (EmployeeDTO emp in list)
            {
                listNames.Add(emp.getFirstName() + " " + emp.getLastName());
                listSales.Add(emp.getNumSales());
            }
            showEmployeeData(list.First());
            chartEmployeeUC.Series["Mejores vendedores"].Points.DataBindXY(listNames.ToArray(), listSales.ToArray());
        }

        /// <summary>
        /// Rellenar los datos de empleado filtrando por país
        /// </summary>
        /// <param name="country"></param>
        public void CountryView(string country)
        {

            List<EmployeeDTO> list = DashboardControl.BestEmployeesByCountry(country);

            List<string> listNames = new List<string>();
            List<int> listSales = new List<int>();

            foreach (EmployeeDTO emp in list)
            {
                listNames.Add(emp.getFirstName() + " " + emp.getLastName());
                listSales.Add(emp.getNumSales());
            }
            showEmployeeData(list.First());
            chartEmployeeUC.Series["Mejores vendedores"].Points.DataBindXY(listNames.ToArray(), listSales.ToArray());
        }

        /// <summary>
        /// Rellenar los datos de empleado filtrando por producto y país
        /// </summary>
        /// <param name="prod"></param>
        /// <param name="country"></param>
        public void ProductAndCountryView(string prod, string country)
        {

            List<EmployeeDTO> list = DashboardControl.BestEmployeesByCountryAndProduct(prod, country);

            List<string> listNames = new List<string>();
            List<int> listSales = new List<int>();

            foreach (EmployeeDTO emp in list)
            {
                listNames.Add(emp.getFirstName() + " " + emp.getLastName());
                listSales.Add(emp.getNumSales());
            }
            showEmployeeData(list.First());
            chartEmployeeUC.Series["Mejores vendedores"].Points.DataBindXY(listNames.ToArray(), listSales.ToArray());
        }

        /// <summary>
        /// Mostrar detalles del mejor empleado
        /// </summary>
        /// <param name="emp"></param>
        private void showEmployeeData(EmployeeDTO emp)
        {

            employeeImg.Image = convertPhoto(emp.getPhoto());
            employeeImg.SizeMode = PictureBoxSizeMode.StretchImage;
            labelEmployeeUCMiddle.Text = emp.getFirstName() + " " + emp.getLastName();
            labelEmployeeUCBot.Text = emp.getTitle();
        }

        /// <summary>
        /// Convertir el Byte[] que recogemos de la BD a Bitmap para mostrar la imagen (baja calidad)
        /// </summary>
        /// <param name="aByte"></param>
        /// <returns></returns>
        private Bitmap convertPhoto(Byte[] aByte)
        {
            Bitmap img;
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(aByte, 78, aByte.Length - 78);
                ms.Position = 0;
                img = new Bitmap(ms);
                return img;
            }
        }
    }
}
