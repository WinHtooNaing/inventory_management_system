using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace inventory_management_system.Model
{
    internal class DatabaseConnection
    {
        private SqlConnection _connection;
        public  DatabaseConnection()
        {
            string ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Inventory.mdf;Integrated Security=True;Connect Timeout=30");
            _connection = new SqlConnection(ConnectionString);
        }
        public void OpenConnection()
        {
            try
            {
                if (_connection.State == System.Data.ConnectionState.Closed)
                {
                    _connection.Open();
                }

            }
            catch (Exception ex) { 
            Console.WriteLine(ex.ToString());
                throw;
            }
        }
        public void CloseConnection()
        {
            try
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                {
                    _connection.Close();
                }
            } catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
        public SqlConnection GetConnection()
        {
            return _connection;
        }
    }
}
