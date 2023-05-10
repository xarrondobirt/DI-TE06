namespace Tools.VO
{
    public class OrderDetailVO
    {
        #region Atributos
        private int orderId;
        private int productId;
        private double unitPrice;
        private int quantity;
        private double discount;
        #endregion

        #region Propiedades
        public int getOrderId() { return this.orderId; }
        public int getProductId() { return this.productId;}
        public double getUnitPrice() { return this.unitPrice; }
        public int getQuantity() { return this.quantity; }
        public double getDiscount() { return this.discount;}

        public void setOrderId(int id) { this.orderId = id; }
        public void setProductId(int id) { this.productId = id;}
        public void setUnitPrice(double price) { this.unitPrice = price; }
        public void setQuantity(int quantity) { this.quantity = quantity;}
        public void setDiscount(double discount) { this.discount = discount;}

        #endregion

        #region Métodos
        public static double CalcSubtotal(double price, double quantity, double discount)
        {
            return price * quantity * (1 - discount);
        }
        #endregion
    }
}