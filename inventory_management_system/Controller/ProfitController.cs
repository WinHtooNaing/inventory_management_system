using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inventory_management_system.Model;
using Microsoft.Data.SqlClient;

namespace inventory_management_system.Controller
{
    public class ProfitController
    {
        private readonly DatabaseConnection dbConnection;
        public ProfitController() { 
            dbConnection = new DatabaseConnection();
        }
        public decimal TotalPrice(string query)
        {
            decimal totalPrice = 0;
            try
            {
                dbConnection.OpenConnection();
                SqlConnection connection = dbConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalPrice = Convert.ToDecimal(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
            return totalPrice;
        }
        public decimal TotalCost()
        {
            decimal totalCost = 0;
            decimal purchasePrice = TotalPrice("SELECT SUM(Quantity * PurchasePrice) AS TotalPrice FROM Items;");
            decimal generalPrice = TotalPrice("SELECT SUM(Price) AS TotalPrice FROM General;");
            decimal employeeSalary = TotalPrice("SELECT SUM(Number * Salary) AS totalPrice FROM Employee;");
            totalCost = purchasePrice + generalPrice + employeeSalary;
            return totalCost;
        }
        
        public decimal Profit()
        {
            decimal cost=TotalCost();
            
            decimal totalSale = TotalPrice("SELECT SUM(Quantity * SellingPrice) AS TotalPrice FROM Items;");

            return totalSale - cost;
        }

        public decimal DailySale()
        {
            decimal totalPrice = 0;
            //string query = "SELECT SUM(TotalPrice) AS TotalPrice FROM SellItem where DATE(timestamp) = CURDATE();"; 
            string query = "SELECT SUM(TotalPrice) AS DailyTotal FROM SellItem WHERE CAST(CreatedAt AS DATE) = CAST(GETDATE() AS DATE)";
            try
            {
                dbConnection.OpenConnection();
                SqlConnection connection = dbConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalPrice = Convert.ToDecimal(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
            return totalPrice;
        }
        
    }
}
