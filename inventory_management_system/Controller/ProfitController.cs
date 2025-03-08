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

        public decimal MonthlyGeneralPrice()
        {
            decimal totalPrice = 0;

            string query = "SELECT SUM(Price) FROM General WHERE MONTH(CreatedAt) = MONTH(GETDATE()) AND YEAR(CreatedAt) = YEAR(GETDATE())";

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

        public decimal MonthlyTotalSalary()
        {
            decimal totalSalary = 0;

            string query = @"
        SELECT SUM(Salary) 
        FROM Employee
        WHERE 
            (StartDate <= GETDATE() AND (EndDate IS NULL OR EndDate >= GETDATE()))";

            try
            {
                dbConnection.OpenConnection();
                SqlConnection connection = dbConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalSalary = Convert.ToDecimal(result);
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
            return totalSalary;
        }

        public decimal MonthlyProfit()
        {
            decimal totalProfit = 0;
            decimal totalExpense = MonthlyTotalSalary() + MonthlyGeneralPrice() + MonthlyPurchasePrice();
            totalProfit = MonthlySellingPrice() - totalExpense;
            return totalProfit;
        }

    }
}
