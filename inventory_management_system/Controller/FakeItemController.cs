using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inventory_management_system.Model;
using Microsoft.Data.SqlClient;

namespace inventory_management_system.Controller
{
    public class FakeItemController
    {
        private readonly DatabaseConnection databaseConnection;
        public FakeItemController() { 
            databaseConnection = new DatabaseConnection();
        }
        public bool IsItemExists(int itemId)
        {
            string query = "SELECT COUNT(*) FROM FakeItem WHERE TypeId = @TypeId";
            try
            {
                databaseConnection.OpenConnection();
                SqlConnection connection = databaseConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TypeId", itemId);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while checking product existence: " + ex.Message);
                return false;
            }
            finally
            {
                databaseConnection.CloseConnection();
            }
        }

        // add
        public bool AddItem(FakeItem fakeItem)
        {
            if (IsItemExists(fakeItem.TypeId))
            {
                Console.WriteLine("Type with the same ID already exists.");
                return false;
            }
            string query = "INSERT FakeItem (TypeId,Type,Price,Category,PurchasePrice)" +
                " VALUES (@TypeId,@Type,@Price,@Category,@PurchasePrice);";
            try
            {
                databaseConnection.OpenConnection();
                SqlConnection connection = databaseConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@TypeId", fakeItem.TypeId);
                cmd.Parameters.AddWithValue("@Type", fakeItem.Type);
                cmd.Parameters.AddWithValue("@Price", fakeItem.Price);
                cmd.Parameters.AddWithValue("@Category",fakeItem.Category);
                cmd.Parameters.AddWithValue("@PurchasePrice",fakeItem.PurchasePrice);

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
        public List<FakeItem> GetAllItems()
        {
            List<FakeItem> items = new List<FakeItem>();
            string query = "SELECT * FROM FakeItem;";
            try
            {
                databaseConnection.OpenConnection();
                SqlConnection connection = databaseConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);


                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    items.Add(new FakeItem
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        TypeId = Convert.ToInt32(reader["TypeId"]),
                        Type = reader["Type"].ToString(),
                        Category = reader["Category"].ToString(),
                        Price = Convert.ToDecimal(reader["Price"]),
                        PurchasePrice = Convert.ToDecimal(reader["PurchasePrice"])
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while fetching items: " + ex.Message);
            }
            finally
            {
                databaseConnection.CloseConnection();
            }

            return items;
        }
        // Delete all 
        public bool DeleteAllItems()
        {
            string query = "DELETE FROM FakeItem";
            try
            {
                databaseConnection.OpenConnection();
                SqlConnection connection = databaseConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while deleting item: " + ex.Message);
                return false;
            }
            finally
            {
                databaseConnection.CloseConnection();
            }
            
        }
        // Delete
        public bool DeleteItem(int id)
        {
            string query = "DELETE FROM FakeItem WHERE id = @Id";

            try
            {
                databaseConnection.OpenConnection();
                SqlConnection connection = databaseConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while deleting item: " + ex.Message);
                return false;
            }
            finally
            {
                databaseConnection.CloseConnection();
            }
        }
    }
}
