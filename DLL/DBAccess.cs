using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace DBMethods
{
    public class DBAccess
    {
        private string connectionString;

        public DBAccess()
        {
            connectionString = "Server=Eren\\SQLEXPRESS;Database=YazLabDB1.3;User Id=sa;Password=sa123;";
        }

        public SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                throw(ex);
            }
            return connection;
        }

        public void CloseConnection(SqlConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    connection.Close();
                    Console.WriteLine("Connection closed successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error closing connection: " + ex.Message);
                }
            }
        }
    }
}

