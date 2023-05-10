using System;

namespace Tools.VO
{
    public class ProductVO
    {
        #region Atributos
        private int productId;
        private string productName;
        private string quantityPerUnit;
        private decimal unitPrice;
        private int unitsInStock;
        private int unitsOnOrder;
        #endregion

        #region Constructor
        public ProductVO()
        {

        }
        #endregion

        #region Propiedades
        public int getProductId() { return this.productId; }
        public string getProductName() { return this.productName; }
        public string getQuantityPerUnit() { return this.quantityPerUnit; } 
        public int getUnitsInStock() { return this.unitsInStock; }
        public int getUnitsOnOrder() { return this.unitsOnOrder; }
        public decimal getUnitPrice() { return this.unitPrice; }

        public void setProductId(int id) { this.productId = id; }
        public void setProductName(string name) { this.productName = name; }
        public void setQuantityPerUnit(string quantity) { this.quantityPerUnit = quantity; }
        public void setUnitsInStock(int stock) { this.unitsInStock = stock; }
        public void setUnitsOnOrder(int order) { this.unitsOnOrder = order; }
        public void setUnitPrice(decimal price) { this.unitPrice = price; }
        #endregion
    }
}
