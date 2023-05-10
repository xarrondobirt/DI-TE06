using System;

namespace Tools.VO
{
    public class EmployeeVO
    {
        #region Atributos
        private int employeeId;
        private string lastName;
        private string firstName;
        private string title;
        private Byte[] photo;
        #endregion

        #region Constructor
        public EmployeeVO()
        {

        }
        #endregion
        #region Propiedades
        public int getEmployeeId() { return this.employeeId; }
        public string getLastName() { return this.lastName; }
        public string getFirstName() { return this.firstName; }
        public string getTitle() { return this.title; }
        public Byte[] getPhoto() { return this.photo; }
        //public int getNumSales() { return this.numSales; }


        public void setEmployeeId(int employeeId) { this.employeeId = employeeId; }
        public void setLastName(string lastName) { this.lastName = lastName; }
        public void setFirstName(string firstName) { this.firstName = firstName; }
        public void setTitle(string title) { this.title = title; }
        public void setPhoto(Byte[] photo) { this.photo = photo; }
        //public void setNumSales(int num) { this.numSales = num; }
        #endregion
    }

}
