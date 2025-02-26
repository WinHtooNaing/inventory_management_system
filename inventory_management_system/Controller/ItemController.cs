using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inventory_management_system.Model;
using Microsoft.Data.SqlClient;

namespace inventory_management_system.Controller
{
    public class ItemController
    {
        private readonly DatabaseConnection dbConnection;
        public ItemController() { 
            dbConnection = new DatabaseConnection();
        }
        // CREATE (Add a new Item)
        public bool AddProduct(Item item)
        {
            string query = "INSERT INTO Item (Category,Types, Quantity, PurchasePrice, SellingPrice) VALUES (@Category,@Types, @Quantity, @PurchasePrice, @SellingPrice)";

            try
            {
                dbConnection.OpenConnection();
                SqlConnection connection = dbConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Types", item.Types);
                cmd.Parameters.AddWithValue("@Quantity",item.Quantity);
                cmd.Parameters.AddWithValue("@PurchasePrice", item.PurchasePrice);
                cmd.Parameters.AddWithValue("@SellingPrice", item.SellingPrice);
                cmd.Parameters.AddWithValue("@Category",item.Category);
               int rowAffected =  cmd.ExecuteNonQuery();
                return rowAffected > 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while adding product: " + ex.Message);
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }
        // READ (Get all Items)
        public List<Item> GetAllItems(string searchItem="")
        {
            List<Item> items = new List<Item>();
            string query = "SELECT * FROM Item";
            if (!string.IsNullOrEmpty(searchItem))
            {
                query += " WHERE Category LIKE @SearchItem";
            }
            try
            {
                dbConnection.OpenConnection();
                SqlConnection connection = dbConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Item item = new Item
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Types = reader["Types"].ToString(),
                        Category = reader["Category"].ToString(),
                        Quantity = Convert.ToInt32(reader["Quantity"]),
                        PurchasePrice = Convert.ToDecimal(reader["PurchasePrice"]),
                        SellingPrice = Convert.ToDecimal(reader["SellingPrice"]),
                        CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                    };
                    items.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while retrieving products: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }

            return items;
        }
        // DELETE (Remove an item by Id)
        public bool DeleteItem(int id)
        {
            string query = "DELETE FROM Item WHERE Id=@Id";

            try
            {
                dbConnection.OpenConnection();
                SqlConnection connection = dbConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);

                int rowAffected = cmd.ExecuteNonQuery();
                return rowAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while deleting product: " + ex.Message);
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        // READ (Get a single Item by Id)
        public Item GetItemById(int id)
        {
            Item item = null;
            string query = "SELECT * FROM Item WHERE Id = @Id";

            try
            {
                dbConnection.OpenConnection();
                SqlConnection connection = dbConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    item = new Item
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Types = reader["Types"].ToString(),
                        Category = reader["Category"].ToString(),

                        Quantity = Convert.ToInt32(reader["Quantity"]),
                        PurchasePrice = Convert.ToDecimal(reader["PurchasePrice"]),
                        SellingPrice = Convert.ToDecimal(reader["SellingPrice"]),
                        CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while retrieving product by Id: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }

            return item;
        }
        // UPDATE (Modify an existing item)
        public bool UpdateItem(Item item)
        {
            string query = "UPDATE Item SET  Category=@Category,Types=@Types, Quantity=@Quantity, PurchasePrice=@PurchasePrice, SellingPrice=@SellingPrice  WHERE Id=@Id";

            try
            {
                dbConnection.OpenConnection();
                SqlConnection connection = dbConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", item.Id);
                cmd.Parameters.AddWithValue("@Types", item.Types);
                cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                cmd.Parameters.AddWithValue("@PurchasePrice", item.PurchasePrice);
                cmd.Parameters.AddWithValue("@SellingPrice", item.SellingPrice);
                cmd.Parameters.AddWithValue("@Category", item.Category);

                int rowAffected = cmd.ExecuteNonQuery();
                return rowAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while updating product: " + ex.Message);
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

    }
}
