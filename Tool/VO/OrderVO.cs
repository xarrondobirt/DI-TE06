using System;

namespace Tools.VO
{
    public class OrderVO
    {
        #region Atributos
        private int orderId;
        private int employeeId;
        private DateTime orderDate;
        private string shipCountry;
        #endregion

        #region Propiedades
        public int getOrderId() { return this.orderId; }
        public int getEmployeeId() { return this.employeeId; }
        public DateTime getOrderDate() { return this.orderDate; }
        public string getShipCountry() { return this.shipCountry; }

        public void setOrderId(int id) { this.orderId = id; }
        public void setEmployeeId(int id) { this.employeeId = id; }
        public void setOrderDate(DateTime date) { this.orderDate = date; }
        public void setShipCountry(string country) { this.shipCountry = country; }
        #endregion
    }
}
