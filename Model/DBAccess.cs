using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using Tools.VO;
using Tools.DTO;

namespace Model
{
    public static class DBAccess
    {
        /// <summary>
        /// Query tabla Order Details
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static List<OrderDetailVO> OrderDetailQuery()
        {
            // cadena de conexión
            SqlConnection conn = new SqlConnection(@"Data Source=localhost; Initial Catalog=Northwind; User ID=di; Password=1234; TrustServerCertificate=True");
            SqlCommand command;
            string sqlQuery = "select * from \"order details\"";

            // objeto lectura de datos
            SqlDataReader dataReader;

            try
            {
                conn.Open();
                command = new SqlCommand(sqlQuery, conn);
                dataReader = command.ExecuteReader();

                List<OrderDetailVO> list = new List<OrderDetailVO>();

                while (dataReader.Read())
                {
                    OrderDetailVO orderDetail = new OrderDetailVO();

                    orderDetail.setOrderId((int)Int64.Parse(dataReader.GetValue(0).ToString()));
                    orderDetail.setProductId((int)Int64.Parse(dataReader.GetValue(1).ToString()));
                    orderDetail.setUnitPrice((double)Double.Parse(dataReader.GetValue(2).ToString()));
                    orderDetail.setQuantity((int)Int64.Parse(dataReader.GetValue(3).ToString()));
                    orderDetail.setDiscount((double)Double.Parse(dataReader.GetValue(4).ToString()));

                    list.Add(orderDetail);
                }
                dataReader.Close();
                command.Dispose();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Query tabla Orders
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static List<OrderVO> OrderQuery()
        {
            // cadena de conexión
            SqlConnection conn = new SqlConnection(@"Data Source=localhost; Initial Catalog=Northwind; User ID=di; Password=1234; TrustServerCertificate=True");
            SqlCommand command;
            string sqlQuery = "select * from orders";

            // objeto lectura de datos
            SqlDataReader dataReader;

            try
            {
                conn.Open();
                command = new SqlCommand(sqlQuery, conn);
                dataReader = command.ExecuteReader();

                List<OrderVO> list = new List<OrderVO>();

                while (dataReader.Read())
                {
                    OrderVO order = new OrderVO();

                    order.setOrderId((int)Int64.Parse(dataReader.GetValue(0).ToString()));
                    order.setEmployeeId((int)Int64.Parse(dataReader.GetValue(2).ToString()));
                    order.setOrderDate(DateTime.Parse(dataReader.GetValue(3).ToString()));
                    order.setShipCountry(dataReader.GetValue(13).ToString());

                    list.Add(order);
                }
                dataReader.Close();
                command.Dispose();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Query tabla Employees
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static List<EmployeeVO> EmployeeQuery()
        {
            // cadena de conexión
            SqlConnection conn = new SqlConnection(@"Data Source=localhost; Initial Catalog=Northwind; User ID=di; Password=1234; TrustServerCertificate=True");
            SqlCommand command;
            string sqlQuery = "select * from employees";

            // objeto lectura de datos
            SqlDataReader dataReader;

            try
            {
                conn.Open();
                command = new SqlCommand(sqlQuery, conn);
                dataReader = command.ExecuteReader();

                List<EmployeeVO> list = new List<EmployeeVO>();

                while (dataReader.Read())
                {
                    EmployeeVO employee = new EmployeeVO();

                    employee.setEmployeeId((int)Int64.Parse(dataReader.GetValue(0).ToString()));
                    employee.setLastName(dataReader.GetValue(1).ToString());
                    employee.setFirstName(dataReader.GetValue(2).ToString());
                    employee.setTitle(dataReader.GetValue(3).ToString());
                    employee.setPhoto((Byte[])dataReader.GetValue(14));

                    list.Add(employee);
                }
                dataReader.Close();
                command.Dispose();
               // List<EmployeeDTO> empList = new List<EmployeeDTO>(list);
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Query tabla Products
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static List<ProductVO> ProductQuery()
        {
            // cadena de conexión
            SqlConnection conn = new SqlConnection(@"Data Source=localhost; Initial Catalog=Northwind; User ID=di; Password=1234; TrustServerCertificate=True");
            SqlCommand command;
            string sqlQuery = "select * from products";

            // objeto lectura de datos
            SqlDataReader dataReader;

            try
            {
                conn.Open();
                command = new SqlCommand(sqlQuery, conn);
                dataReader = command.ExecuteReader();

                List<ProductVO> list = new List<ProductVO>();

                while (dataReader.Read())
                {
                    ProductVO product = new ProductVO();

                    product.setProductId((int)Int64.Parse(dataReader.GetValue(0).ToString()));
                    product.setProductName(dataReader.GetValue(1).ToString());                   
                    product.setQuantityPerUnit(dataReader.GetValue(4).ToString());
                    product.setUnitPrice((decimal)Decimal.Parse(dataReader.GetValue(5).ToString()));
                    product.setUnitsInStock((int)Int64.Parse(dataReader.GetValue(6).ToString()));
                    product.setUnitsOnOrder((int)Int64.Parse(dataReader.GetValue(7).ToString()));

                    list.Add(product);
                }
                dataReader.Close();
                command.Dispose();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}