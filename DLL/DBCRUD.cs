namespace DBMethods
{
    internal class DBCRUD
    {
        #region Customers CRUD Queries

        public string AddCustomer = @"INSERT INTO Customers (CustomerName, Budget, CustomerType, TotalSpent) 
                                        VALUES (@CustomerName, @Budget, @CustomerType, @TotalSpent)";

        public string UpdateCustomer = @"UPDATE Customers 
                                         SET CustomerName = @CustomerName, Budget = @Budget, CustomerType = @CustomerType, TotalSpent = @TotalSpent 
                                         WHERE CustomerID = @CustomerID";

        public string UpdateCustomerTotalSpent = @"UPDATE Customers 
                                           SET TotalSpent = @TotalSpent 
                                           WHERE CustomerID = @CustomerID";

        public string UpdateCustomerBudget = @"UPDATE Customers 
                                       SET Budget = @Budget 
                                       WHERE CustomerID = @CustomerID";

        public string DeleteCustomer = @"DELETE FROM Customers WHERE CustomerID = @CustomerID";

        public string GetCustomerById = @"SELECT * FROM Customers WHERE CustomerID = @CustomerID";

        public string GetAllCustomers = @"SELECT * FROM Customers";

        public string GetCustomerOrders = @"SELECT * FROM ORDERS WHERE CustomerID = @CustomerID";

        #endregion

        #region Products CRUD Queries

        public string AddProduct = @"INSERT INTO Products (ProductName, Stock, Price) 
                                      VALUES (@ProductName, @Stock, @Price)";

        public string UpdateProduct = @" 
                                      UPDATE Products 
                                      SET ProductName = @ProductName, Stock = @Stock, Price = @Price 
                                      WHERE ProductID = @ProductID";

        public string UpdateProductStock = @"UPDATE Products 
                                     SET Stock = @Stock 
                                     WHERE ProductID = @ProductID";

        public string DeleteProduct = @"DELETE FROM Products WHERE ProductID = @ProductID";

        public string GetProductById = @"SELECT * FROM Products WHERE ProductID = @ProductID";

        public string GetProductByOrderID = @"
                                            SELECT p.ProductID, p.ProductName, p.Stock, p.Price
                                            FROM Products p
                                            INNER JOIN Orders o ON p.ProductID = o.ProductID
                                            WHERE o.OrderID = @OrderID";

        public string GetAllProducts = @"SELECT * FROM Products";

        #endregion

        #region Orders CRUD Queries

        public string AddOrder = @"INSERT INTO Orders (CustomerID, ProductID, Quantity, TotalPrice, OrderDate, OrderStatus) 
                                    VALUES (@CustomerID, @ProductID, @Quantity, @TotalPrice, @OrderDate, @OrderStatus)";

        public string UpdateOrder = @"UPDATE Orders 
                                       SET CustomerID = @CustomerID, ProductID = @ProductID, Quantity = @Quantity, 
                                           TotalPrice = @TotalPrice, OrderDate = @OrderDate, OrderStatus = @OrderStatus 
                                       WHERE OrderID = @OrderID";

        public string UpdateOrderStatus = @"UPDATE Orders 
                                     SET OrderStatus = @OrderStatus 
                                     WHERE OrderID = @OrderID";

        public string DeleteOrder = @"DELETE FROM Orders WHERE OrderID = @OrderID";

        public string GetOrderById = @"SELECT * FROM Orders WHERE OrderID = @OrderID";

        public string GetAllOrders = @"SELECT * FROM Orders";

        public string GetPendingOrders = @"
                                        SELECT * 
                                        FROM Orders 
                                        WHERE OrderStatus = 'Pending'";
        #endregion

        #region Logs CRUD Queries

        public string AddLog = @"INSERT INTO Logs (CustomerID, OrderID, ProductID, LogDate, LogType, LogDetails) 
                          VALUES (@CustomerID, @OrderID, @ProductID, @LogDate, @LogType, @LogDetails)";

        public string UpdateLog = @"UPDATE Logs 
                             SET CustomerID = @CustomerID, OrderID = @OrderID, ProductID = @ProductID, 
                                 LogDate = @LogDate, LogType = @LogType, LogDetails = @LogDetails 
                             WHERE LogID = @LogID";

        public string DeleteLog = @"DELETE FROM Logs WHERE LogID = @LogID";

        public string GetLogById = @"SELECT * FROM Logs WHERE LogID = @LogID";

        public string GetAllLogs = @"SELECT * FROM Logs";

        public string GetLogsByCustomerId = @"SELECT * FROM Logs WHERE CustomerID = @CustomerID";

        public string GetLogsByOrderId = @"SELECT * FROM Logs WHERE OrderID = @OrderID";

        public string GetLogsByProductId = @"SELECT * FROM Logs WHERE ProductID = @ProductID";

        #endregion

    }
}