using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Tools.DTO;
using Tools.VO;

namespace Controller
{
    public class DashboardControl
    {
        #region Métodos
        /// <summary>
        /// Coger los productos de la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<string> LoadProducts()
        {
            List<string> listProdNames = new List<string>();

            // primer elemento vacío
            listProdNames.Add("");
            List<ProductVO> products = DBAccess.ProductQuery();

            // mapeo VO -> DTO
            List<ProductDTO> listProducts = new List<ProductDTO>();
            foreach (ProductVO productVO in products)
            {
                listProducts.Add(new ProductDTO(productVO));
            }

            foreach (ProductDTO product in listProducts)
            {
                listProdNames.Add(product.getProductName());
            }
            listProdNames.Sort();
            return listProdNames;
        }

        /// <summary>
        /// Cargar la lista de países
        /// </summary>
        /// <returns></returns>
        public static List<string> LoadCountries()
        {
            List<OrderVO> orders = DBAccess.OrderQuery();
            List<string> listCountries = new List<string>();

            // primer elemento vacío
            listCountries.Add("");

            // mapeo VO -> DTO
            List<OrderDTO> listOrder = new List<OrderDTO>();
            foreach (OrderVO ordersVO in orders)
            {
                listOrder.Add(new OrderDTO(ordersVO));
            }

            foreach (OrderDTO order in listOrder)
            {
                bool bExists = false;
                int index = 0;

                // recorremos la lista de países mientras no encontremos el país actual
                while (index < listCountries.Count && !bExists)
                {
                    if (listCountries[index] == order.getShipCountry())
                    {
                        bExists = true;
                    }
                    index++;
                }

                // si al terminar la iteración no lo hemos encontrado lo añadimos a la lista
                if (!bExists)
                {
                    listCountries.Add(order.getShipCountry());
                }
            }
            listCountries.Sort();
            return listCountries;
        }

        /// <summary>
        /// Ingresos por cada año
        /// </summary>
        /// <returns></returns>
        public static double[] RevenueByYear()
        {
            List<OrderDetailVO> orderDetails = DBAccess.OrderDetailQuery();
            List<OrderVO> orders = DBAccess.OrderQuery();

            double subtotal = 0;

            // en la BD solo hay datos de ventas entre el 96-98
            double[] aYearSum = new double[3];

            // mapeo VO -> DTO
            List<OrderDTO> listOrder = new List<OrderDTO>();
            foreach (OrderVO ordersVO in orders)
            {
                listOrder.Add(new OrderDTO(ordersVO));
            }

            List<OrderDetailDTO> listOrderDetail = new List<OrderDetailDTO>();
            foreach (OrderDetailVO orderDetailsVO in orderDetails)
            {
                listOrderDetail.Add(new OrderDetailDTO(orderDetailsVO));
            }

            foreach (OrderDTO order in listOrder)
            {
                DateTime orderDate = order.getOrderDate();
                int orderYear = orderDate.Year;

                int orderId = order.getOrderId();
                foreach (OrderDetailDTO orderDetail in listOrderDetail)
                {
                    if (orderDetail.getOrderId() == order.getOrderId())
                    {
                        // precio de la orden aplicando el descuento
                        subtotal = OrderDetailDTO.CalcSubtotal(orderDetail.getUnitPrice(), orderDetail.getQuantity(), orderDetail.getDiscount());
                        subtotal = Math.Round(subtotal, 2);
                        switch (orderYear)
                        {
                            case 1996:
                                aYearSum[0] += subtotal;
                                break;
                            case 1997:
                                aYearSum[1] += subtotal;
                                break;
                            case 1998:
                                aYearSum[2] += subtotal;
                                break;
                        }
                    }

                }
            }
            return aYearSum;
        }

        /// <summary>
        /// Ingresos por año de un producto dado
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public static double[] RevenueByYearProduct(string product)
        {
            List<OrderDetailVO> orderDetails = DBAccess.OrderDetailQuery();
            List<OrderVO> orders = DBAccess.OrderQuery();
            List<ProductVO> products = DBAccess.ProductQuery();

            double subtotal = 0;
            int productId = 0;

            // mapeo VO -> DTO
            List<OrderDTO> listOrder = new List<OrderDTO>();
            foreach (OrderVO ordersVO in orders)
            {
                listOrder.Add(new OrderDTO(ordersVO));
            }

            List<OrderDetailDTO> listOrderDetail = new List<OrderDetailDTO>();
            foreach (OrderDetailVO orderDetailsVO in orderDetails)
            {
                listOrderDetail.Add(new OrderDetailDTO(orderDetailsVO));
            }

            List<ProductDTO> listProduct = new List<ProductDTO>();
            foreach (ProductVO productVO in products)
            {
                listProduct.Add(new ProductDTO(productVO));
            }

            // conseguir el ProductId a partir del nombre
            foreach (ProductDTO prod in listProduct)
            {
                if (product == prod.getProductName())
                {
                    productId = prod.getProductId();
                }
            }

            // en la BD solo hay datos de ventas entre el 96-98
            double[] aYearSum = new double[3];

            foreach (OrderDTO order in listOrder)
            {
                DateTime orderDate = order.getOrderDate();
                int orderYear = orderDate.Year;

                int orderId = order.getOrderId();
                foreach (OrderDetailDTO orderDetail in listOrderDetail)
                {
                    if (orderDetail.getOrderId() == order.getOrderId() && orderDetail.getProductId() == productId)
                    {
                        // precio de la orden aplicando el descuento
                        subtotal = OrderDetailDTO.CalcSubtotal(orderDetail.getUnitPrice(), orderDetail.getQuantity(), orderDetail.getDiscount());
                        subtotal = Math.Round(subtotal, 2);
                        switch (orderYear)
                        {
                            case 1996:
                                aYearSum[0] += subtotal;
                                break;
                            case 1997:
                                aYearSum[1] += subtotal;
                                break;
                            case 1998:
                                aYearSum[2] += subtotal;
                                break;
                        }
                    }
                }
            }
            return aYearSum;
        }

        /// <summary>
        /// Ingresos por año en un país dado
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static double[] RevenueByYearCountry(string country)
        {
            List<OrderDetailVO> orderDetails = DBAccess.OrderDetailQuery();
            List<OrderVO> orders = DBAccess.OrderQuery();

            double subtotal = 0;

            // en la BD solo hay datos de ventas entre el 96-98
            double[] aYearSum = new double[3];


            // mapeo VO -> DTO
            List<OrderDTO> listOrder = new List<OrderDTO>();
            foreach (OrderVO ordersVO in orders)
            {
                listOrder.Add(new OrderDTO(ordersVO));
            }

            List<OrderDetailDTO> listOrderDetail = new List<OrderDetailDTO>();
            foreach (OrderDetailVO orderDetailsVO in orderDetails)
            {
                listOrderDetail.Add(new OrderDetailDTO(orderDetailsVO));
            }


            foreach (OrderDTO order in listOrder)
            {
                DateTime orderDate = order.getOrderDate();
                int orderYear = orderDate.Year;
                int orderId = order.getOrderId();

                if (order.getShipCountry() == country)
                {
                    foreach (OrderDetailDTO orderDetail in listOrderDetail)
                    {
                        if (orderDetail.getOrderId() == order.getOrderId())
                        {
                            // precio de la orden aplicando el descuento
                            subtotal = OrderDetailDTO.CalcSubtotal(orderDetail.getUnitPrice(), orderDetail.getQuantity(), orderDetail.getDiscount());
                            subtotal = Math.Round(subtotal, 2);
                            switch (orderYear)
                            {
                                case 1996:
                                    aYearSum[0] += subtotal;
                                    break;
                                case 1997:
                                    aYearSum[1] += subtotal;
                                    break;
                                case 1998:
                                    aYearSum[2] += subtotal;
                                    break;
                            }
                        }
                    }
                }
            }
            return aYearSum;
        }

        /// <summary>
        /// Ingresos por año de un producto en un país
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public static double[] RevenueByYearProductAndCountry(string product, string country)
        {
            List<OrderDetailVO> orderDetails = DBAccess.OrderDetailQuery();
            List<OrderVO> orders = DBAccess.OrderQuery();
            List<ProductVO> products = DBAccess.ProductQuery();

            double subtotal = 0;
            int productId = 0;

            // mapeo VO -> DTO
            List<OrderDTO> listOrder = new List<OrderDTO>();
            foreach (OrderVO ordersVO in orders)
            {
                listOrder.Add(new OrderDTO(ordersVO));
            }

            List<OrderDetailDTO> listOrderDetail = new List<OrderDetailDTO>();
            foreach (OrderDetailVO orderDetailsVO in orderDetails)
            {
                listOrderDetail.Add(new OrderDetailDTO(orderDetailsVO));
            }

            List<ProductDTO> listProduct = new List<ProductDTO>();
            foreach (ProductVO productVO in products)
            {
                listProduct.Add(new ProductDTO(productVO));
            }

            // conseguir el ProductId a partir del nombre
            foreach (ProductDTO prod in listProduct)
            {
                if (product == prod.getProductName())
                {
                    productId = prod.getProductId();
                }
            }

            // en la BD solo hay datos de ventas entre el 96-98
            double[] aYearSum = new double[3];

            foreach (OrderDTO order in listOrder)
            {
                DateTime orderDate = order.getOrderDate();
                int orderYear = orderDate.Year;

                int orderId = order.getOrderId();
                if (order.getShipCountry() == country)
                {
                    foreach (OrderDetailDTO orderDetail in listOrderDetail)
                    {
                        if (orderDetail.getOrderId() == order.getOrderId() && orderDetail.getProductId() == productId)
                        {
                            // precio de la orden aplicando el descuento
                            subtotal = OrderDetailDTO.CalcSubtotal(orderDetail.getUnitPrice(), orderDetail.getQuantity(), orderDetail.getDiscount());
                            subtotal = Math.Round(subtotal, 2);
                            switch (orderYear)
                            {
                                case 1996:
                                    aYearSum[0] += subtotal;
                                    break;
                                case 1997:
                                    aYearSum[1] += subtotal;
                                    break;
                                case 1998:
                                    aYearSum[2] += subtotal;
                                    break;
                            }
                        }
                    }
                }
            }
            return aYearSum;
        }

        /// <summary>
        /// Devuelve la lista de empleados ordenados por mayor número de ventas
        /// </summary>
        /// <returns></returns>
        public static List<EmployeeDTO> BestEmployees()
        {
            List<EmployeeVO> employees = DBAccess.EmployeeQuery();
            List<OrderVO> orders = DBAccess.OrderQuery();

            // mapeo VO -> DTO
            List<OrderDTO> listOrder = new List<OrderDTO>();
            foreach (OrderVO ordersVO in orders)
            {
                listOrder.Add(new OrderDTO(ordersVO));
            }

            List<EmployeeDTO> listEmployee = new List<EmployeeDTO>();
            foreach (EmployeeVO employeeVO in employees)
            {
                listEmployee.Add(new EmployeeDTO(employeeVO));
            }

            foreach (OrderDTO order in listOrder)
            {
                foreach (EmployeeDTO employee in listEmployee)
                {
                    int currentSales = employee.getNumSales();
                    if (employee.getEmployeeId() == order.getEmployeeId())
                    {
                        employee.setNumSales(++currentSales);
                    }
                }
            }
            List<EmployeeDTO> sortedList = listEmployee.OrderByDescending(x => x.getNumSales()).ToList();
            return sortedList;
        }

        /// <summary>
        /// Devuelve la lista de empleados ordenados por mayor número de ventas sobre un producto
        /// </summary>
        /// <returns></returns>
        public static List<EmployeeDTO> BestEmployeesByProduct(string product)
        {
            List<EmployeeVO> employees = DBAccess.EmployeeQuery();
            List<OrderVO> orders = DBAccess.OrderQuery();
            List<OrderDetailVO> orderDetails = DBAccess.OrderDetailQuery();
            List<ProductVO> products = DBAccess.ProductQuery();

            // mapeo VO -> DTO
            List<OrderDTO> listOrder = new List<OrderDTO>();
            foreach (OrderVO ordersVO in orders)
            {
                listOrder.Add(new OrderDTO(ordersVO));
            }

            List<OrderDetailDTO> listOrderDetail = new List<OrderDetailDTO>();
            foreach (OrderDetailVO orderDetailsVO in orderDetails)
            {
                listOrderDetail.Add(new OrderDetailDTO(orderDetailsVO));
            }

            List<ProductDTO> listProduct = new List<ProductDTO>();
            foreach (ProductVO productVO in products)
            {
                listProduct.Add(new ProductDTO(productVO));
            }

            List<EmployeeDTO> listEmployee = new List<EmployeeDTO>();
            foreach (EmployeeVO employeeVO in employees)
            {
                listEmployee.Add(new EmployeeDTO(employeeVO));
            }

            int productId = 0;

            // conseguir el ProductId a partir del nombre
            foreach (ProductDTO prod in listProduct)
            {
                if (product == prod.getProductName())
                {
                    productId = prod.getProductId();
                }
            }

            foreach (OrderDetailDTO orderDetail in listOrderDetail)
            {
                if (orderDetail.getProductId() == productId)
                {
                    int currentOrderId = orderDetail.getOrderId();
                    foreach (OrderDTO order in listOrder)
                    {
                        if (currentOrderId == order.getOrderId())
                        {
                            foreach (EmployeeDTO employee in listEmployee)
                            {
                                int currentSales = employee.getNumSales();
                                if (employee.getEmployeeId() == order.getEmployeeId())
                                {
                                    employee.setNumSales(++currentSales);
                                }
                            }
                        }
                    }
                }
            }
            List<EmployeeDTO> sortedList = listEmployee.OrderByDescending(x => x.getNumSales()).ToList();
            return sortedList;
        }

        /// <summary>
        /// Devuelve la lista de empleados ordenados por mayor número de ventas en un país
        /// </summary>
        /// <returns></returns>
        public static List<EmployeeDTO> BestEmployeesByCountry(string country)
        {
            List<EmployeeVO> employees = DBAccess.EmployeeQuery();
            List<OrderVO> orders = DBAccess.OrderQuery();

            // mapeo VO -> DTO
            List<OrderDTO> listOrder = new List<OrderDTO>();
            foreach (OrderVO ordersVO in orders)
            {
                listOrder.Add(new OrderDTO(ordersVO));
            }

            List<EmployeeDTO> listEmployee = new List<EmployeeDTO>();
            foreach (EmployeeVO employeeVO in employees)
            {
                listEmployee.Add(new EmployeeDTO(employeeVO));
            }

            foreach (OrderDTO order in listOrder)
            {

                if (order.getShipCountry() == country)
                {
                    foreach (EmployeeDTO employee in listEmployee)
                    {
                        int currentSales = employee.getNumSales();
                        if (employee.getEmployeeId() == order.getEmployeeId())
                        {
                            employee.setNumSales(++currentSales);
                        }
                    }
                }

            }
            List<EmployeeDTO> sortedList = listEmployee.OrderByDescending(x => x.getNumSales()).ToList();
            return sortedList;
        }

        /// <summary>
        /// Devuelve la lista de empleados ordenados por mayor número de ventas en un país
        /// </summary>
        /// <returns></returns>
        public static List<EmployeeDTO> BestEmployeesByCountryAndProduct(string product, string country)
        {
            List<EmployeeVO> employees = DBAccess.EmployeeQuery();
            List<OrderVO> orders = DBAccess.OrderQuery();
            List<OrderDetailVO> orderDetails = DBAccess.OrderDetailQuery();
            List<ProductVO> products = DBAccess.ProductQuery();

            int productId = 0;

            // mapeo VO -> DTO
            List<OrderDTO> listOrder = new List<OrderDTO>();
            foreach (OrderVO ordersVO in orders)
            {
                listOrder.Add(new OrderDTO(ordersVO));
            }

            List<OrderDetailDTO> listOrderDetail = new List<OrderDetailDTO>();
            foreach (OrderDetailVO orderDetailsVO in orderDetails)
            {
                listOrderDetail.Add(new OrderDetailDTO(orderDetailsVO));
            }

            List<ProductDTO> listProduct = new List<ProductDTO>();
            foreach (ProductVO productVO in products)
            {
                listProduct.Add(new ProductDTO(productVO));
            }

            List<EmployeeDTO> listEmployee = new List<EmployeeDTO>();
            foreach (EmployeeVO employeeVO in employees)
            {
                listEmployee.Add(new EmployeeDTO(employeeVO));
            }

            // conseguir el ProductId a partir del nombre
            foreach (ProductDTO prod in listProduct)
            {
                if (product == prod.getProductName())
                {
                    productId = prod.getProductId();
                }
            }

            foreach (OrderDetailDTO orderDetail in listOrderDetail)
            {
                if (orderDetail.getProductId() == productId)
                {
                    int currentOrderId = orderDetail.getOrderId();
                    foreach (OrderDTO order in listOrder)
                    {
                        if (currentOrderId == order.getOrderId() && order.getShipCountry() == country)
                        {
                            foreach (EmployeeDTO employee in listEmployee)
                            {
                                int currentSales = employee.getNumSales();
                                if (employee.getEmployeeId() == order.getEmployeeId())
                                {
                                    employee.setNumSales(++currentSales);
                                }
                            }
                        }
                    }
                }
            }

            List<EmployeeDTO> sortedList = listEmployee.OrderByDescending(x => x.getNumSales()).ToList();
            return sortedList;
        }
        #endregion
    }

}