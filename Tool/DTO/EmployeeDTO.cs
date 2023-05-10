using System;
using Tools.VO;

namespace Tools.DTO
{
    public class EmployeeDTO
    {
        #region Atributos
        private int employeeId;
        private string lastName;
        private string firstName;
        private string title;
        private Byte[] photo;
        private int numSales;
        #endregion

        #region Constructor
        public EmployeeDTO()
        {

        }

        public EmployeeDTO(EmployeeVO emp)
        {
            this.employeeId = emp.getEmployeeId();
            this.lastName = emp.getLastName();
            this.firstName = emp.getFirstName();
            this.title = emp.getTitle();
            this.photo = emp.getPhoto();
        }

        #endregion
        #region Propiedades
        public int getEmployeeId() { return this.employeeId; }
        public string getLastName() { return this.lastName; }
        public string getFirstName() { return this.firstName; }
        public string getTitle() { return this.title; }
        public Byte[] getPhoto() { return this.photo; }
        public int getNumSales() { return this.numSales; }


        public void setEmployeeId(int employeeId) { this.employeeId = employeeId; }
        public void setLastName(string lastName) { this.lastName = lastName; }
        public void setFirstName(string firstName) { this.firstName = firstName; }
        public void setTitle(string title) { this.title = title; }
        public void setPhoto(Byte[] photo) { this.photo = photo; }
        public void setNumSales(int num) { this.numSales = num; }
        #endregion
    }

}
