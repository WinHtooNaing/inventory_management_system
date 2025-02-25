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
            string query = "INSERT SellItem (Type, Price, Quantity, TotalPrice,SellerName,Category) " +
                           "VALUES (@Type, @Price, @Quantity, @TotalPrice,@SellerName,@Category)";

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
                cmd.Parameters.AddWithValue("@Category",item.Category);

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

        public List<SellItem> GetAllSellItems()
        {
            List<SellItem> items = new List<SellItem>();
            string query = "select * from SellItem";
            try
            {

                databaseConnection.OpenConnection();
                SqlConnection connection = databaseConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader=cmd.ExecuteReader();
                while (reader.Read())
                {
                    SellItem item = new SellItem
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Type = reader["Type"].ToString(),
                        Category = reader["Category"].ToString(),
                        Price = Convert.ToDecimal(reader["Price"]),
                        Quantity = Convert.ToInt32(reader["Quantity"]),
                        TotalPrice = Convert.ToDecimal(reader["TotalPrice"]),
                        SellerName = reader["SellerName"].ToString()

                    };
                    items.Add(item);

                }
                reader.Close();
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                databaseConnection.CloseConnection();
            }
            return items;   
        }
    }
}
