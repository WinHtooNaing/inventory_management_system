using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inventory_management_system.Model;
using Microsoft.Data.SqlClient;

namespace inventory_management_system.Controller
{
    public class SellItemController
    {
        private readonly DatabaseConnection databaseConnection;
        public SellItemController() {
            databaseConnection = new DatabaseConnection();
        }
        public bool SellItem(SellItem item)
        {
            string query = "INSERT SellItem (Type, Price, Quantity, TotalPrice,SellerName) " +
                           "VALUES (@Type, @Price, @Quantity, @TotalPrice,@SellerName)";

            try
            {
                databaseConnection.OpenConnection();
                SqlConnection connection = databaseConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Type", item.Type);
                cmd.Parameters.AddWithValue("@Price", item.Price);
                cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                cmd.Parameters.AddWithValue("@TotalPrice", item.TotalPrice);
                cmd.Parameters.AddWithValue("@SellerName", item.SellerName);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while adding item: " + ex.Message);
                return false;
            }
            finally
            {
                databaseConnection.CloseConnection();
            }
        }
    }
}
