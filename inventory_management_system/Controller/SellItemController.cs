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
            string query = "INSERT SellItem (Type, Price, Quantity, TotalPrice,SellerName,Category,PurchasePrice) " +
                           "VALUES (@Type, @Price, @Quantity, @TotalPrice,@SellerName,@Category,@PurchasePrice)";

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
                cmd.Parameters.AddWithValue("@PurchasePrice",item.PurchasePrice);

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

        public List<SellItem> GetAllSellItems(string searchItem="")
        {
            List<SellItem> items = new List<SellItem>();
            string query = "select * from SellItem WHERE CAST(CreatedAt AS DATE) = CAST(GETDATE() AS DATE)";
            if (!string.IsNullOrEmpty(searchItem))
            {
                query += " AND Category LIKE @SearchItem";
            }
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
                        Category = reader["Category"].ToString(),

                        Type = reader["Type"].ToString(),
                        Price = Convert.ToDecimal(reader["Price"]),
                        Quantity = Convert.ToInt32(reader["Quantity"]),
                        TotalPrice = Convert.ToDecimal(reader["TotalPrice"]),
                        SellerName = reader["SellerName"].ToString(),

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
        public List<SellItem> DailyRecord(string sellerName)
        {
            List<SellItem> items = new List<SellItem>();
            string query = "SELECT * FROM SellItem WHERE SellerName = @SellerName AND CAST(CreatedAt AS DATE) = CAST(GETDATE() AS DATE)";

            try
            {
                databaseConnection.OpenConnection();
                SqlConnection connection = databaseConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@SellerName", sellerName);
                SqlDataReader reader = cmd.ExecuteReader();

                // Dictionary to group items by Category
                Dictionary<string, SellItem> categoryMap = new Dictionary<string, SellItem>();

                while (reader.Read())
                {
                    string category = reader["Category"].ToString();
                    int quantity = Convert.ToInt32(reader["Quantity"]);
                    decimal totalPrice = Convert.ToDecimal(reader["TotalPrice"]);

                    if (categoryMap.ContainsKey(category))
                    {
                        // If the category already exists, update the quantity and total price
                        categoryMap[category].Quantity += quantity;
                        categoryMap[category].TotalPrice += totalPrice;
                    }
                    else
                    {
                        // If the category does not exist, add a new entry
                        SellItem item = new SellItem
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Category = category,
                            Type = reader["Type"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"]),
                            Quantity = quantity,
                            TotalPrice = totalPrice,
                            SellerName = reader["SellerName"].ToString()
                        };
                        categoryMap.Add(category, item);
                    }
                }
                reader.Close();

                // Convert the dictionary values to a list
                items = categoryMap.Values.ToList();
            }
            catch (Exception ex)
            {
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
