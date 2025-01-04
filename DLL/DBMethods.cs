using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMethods
{
    public class DBMethods
    {
        DBAccess dbAccess;
        DBCRUD dbCRUD;

        public DBMethods()
        {
            dbAccess = new DBAccess();
            dbCRUD = new DBCRUD();
        }

        #region Customers CRUD Methods

        public bool AddCustomer(string name, decimal budget, string type, decimal totalSpent)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.AddCustomer, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerName", name);
                    cmd.Parameters.AddWithValue("@Budget", budget);
                    cmd.Parameters.AddWithValue("@CustomerType", type);
                    cmd.Parameters.AddWithValue("@TotalSpent", totalSpent);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateCustomer(int id, string name, decimal budget, string type, decimal totalSpent)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.UpdateCustomer, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", id);
                    cmd.Parameters.AddWithValue("@CustomerName", name);
                    cmd.Parameters.AddWithValue("@Budget", budget);
                    cmd.Parameters.AddWithValue("@CustomerType", type);
                    cmd.Parameters.AddWithValue("@TotalSpent", totalSpent);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateCustomerTotalSpent(int customerId, decimal totalSpent)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.UpdateCustomerTotalSpent, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    cmd.Parameters.AddWithValue("@TotalSpent", totalSpent);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateCustomerBudget(int customerId, decimal newBudget)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.UpdateCustomerBudget, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    cmd.Parameters.AddWithValue("@Budget", newBudget);

                    return cmd.ExecuteNonQuery() > 0; // Güncelleme başarılıysa true döner
                }
            }
        }

        public bool DeleteCustomer(int id)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.DeleteCustomer, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable GetCustomerById(int id)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.GetCustomerById, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", id);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetAllCustomers()
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.GetAllCustomers, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetCustomerOrders(int customerId)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.GetCustomerOrders, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        #endregion

        #region Products CRUD Methods

        public bool AddProduct(string name, int stock, decimal price)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.AddProduct, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductName", name);
                    cmd.Parameters.AddWithValue("@Stock", stock);
                    cmd.Parameters.AddWithValue("@Price", price);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateProduct(int id, string name, int stock, decimal price)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.UpdateProduct, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", id);
                    cmd.Parameters.AddWithValue("@ProductName", name);
                    cmd.Parameters.AddWithValue("@Stock", stock);
                    cmd.Parameters.AddWithValue("@Price", price);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateProductStock(int productId, int newStock)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.UpdateProductStock, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    cmd.Parameters.AddWithValue("@Stock", newStock);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteProduct(int id)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.DeleteProduct, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable GetProductById(int id)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.GetProductById, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", id);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetProductByOrderID(int orderId)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.GetProductByOrderID, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetAllProducts()
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.GetAllProducts, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        #endregion

        #region Orders CRUD Methods

        public bool AddOrder(int customerId, int productId, int quantity, decimal totalPrice, DateTime orderDate, string orderStatus)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.AddOrder, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                    cmd.Parameters.AddWithValue("@OrderDate", orderDate);
                    cmd.Parameters.AddWithValue("@OrderStatus", orderStatus);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateOrder(int id, int customerId, int productId, int quantity, decimal totalPrice, DateTime orderDate, string orderStatus)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.UpdateOrder, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", id);
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                    cmd.Parameters.AddWithValue("@OrderDate", orderDate);
                    cmd.Parameters.AddWithValue("@OrderStatus", orderStatus);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateOrderStatus(int orderId, string status)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.UpdateOrderStatus, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    cmd.Parameters.AddWithValue("@OrderStatus", status);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteOrder(int id)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.DeleteOrder, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable GetOrderById(int id)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.GetOrderById, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", id);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetAllOrders()
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.GetAllOrders, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetPendingOrders()
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.GetPendingOrders, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        #endregion

        #region Logs CRUD Methods

        public bool AddLog(int? customerId, int? orderId, int? productId, DateTime logDate, string logType, string logDetails)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.AddLog, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId.HasValue ? (object)customerId.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@OrderID", orderId.HasValue ? (object)orderId.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@ProductID", productId.HasValue ? (object)productId.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@LogDate", logDate);
                    cmd.Parameters.AddWithValue("@LogType", logType);
                    cmd.Parameters.AddWithValue("@LogDetails", logDetails);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateLog(int id, int? customerId, int? orderId, int? productId, DateTime logDate, string logType, string logDetails)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.UpdateLog, conn))
                {
                    cmd.Parameters.AddWithValue("@LogID", id);
                    cmd.Parameters.AddWithValue("@CustomerID", customerId.HasValue ? (object)customerId.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@OrderID", orderId.HasValue ? (object)orderId.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@ProductID", productId.HasValue ? (object)productId.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@LogDate", logDate);
                    cmd.Parameters.AddWithValue("@LogType", logType);
                    cmd.Parameters.AddWithValue("@LogDetails", logDetails);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteLog(int id)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.DeleteLog, conn))
                {
                    cmd.Parameters.AddWithValue("@LogID", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable GetLogById(int id)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.GetLogById, conn))
                {
                    cmd.Parameters.AddWithValue("@LogID", id);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetAllLogs()
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.GetAllLogs, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetLogsByCustomerId(int customerId)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.GetLogsByCustomerId, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetLogsByOrderId(int orderId)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.GetLogsByOrderId, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetLogsByProductId(int productId)
        {
            using (SqlConnection conn = dbAccess.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(dbCRUD.GetLogsByProductId, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        #endregion

    }
}