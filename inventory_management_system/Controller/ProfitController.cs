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
        public decimal DailySellingPrice()
        {
            decimal totalPrice = 0;
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
        public decimal DailyPurchasePrice()
        {
            decimal totalPrice = 0;
            string query = "SELECT SUM(PurchasePrice * Quantity) AS DailyTotal FROM SellItem WHERE CAST(CreatedAt AS DATE) = CAST(GETDATE() AS DATE)";
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
        public decimal MonthlySellingPrice()
        {
            decimal totalPrice = 0;

            string query = "SELECT SUM(TotalPrice) FROM SellItem WHERE MONTH(CreatedAt) = MONTH(GETDATE()) AND YEAR(CreatedAt) = YEAR(GETDATE())";

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

        public decimal MonthlyPurchasePrice()
        {
            decimal totalPrice = 0;

            string query = "SELECT SUM(PurchasePrice * Quantity) FROM SellItem WHERE MONTH(CreatedAt) = MONTH(GETDATE()) AND YEAR(CreatedAt) = YEAR(GETDATE())";

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

        

        public decimal DailyProfit()
        {
            return DailySellingPrice() - DailyPurchasePrice();
        }
        public decimal MonthlyProfit()
        {
            return MonthlySellingPrice() - MonthlyPurchasePrice();    
        }




    }
}
