using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inventory_management_system.Model;
using Microsoft.Data.SqlClient;

namespace inventory_management_system.Controller
{
    public class CategoryController
    {
        private readonly DatabaseConnection dbConnection;
        public CategoryController() {
            dbConnection = new DatabaseConnection();
        }
        public bool AddCategory(Category category) {
            string query = "insert into Category(Name) values(@Name)";
            try
            {
                dbConnection.OpenConnection();
                SqlConnection connection = dbConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Name", category.Name);
                int rowEffected = cmd.ExecuteNonQuery();
                return rowEffected > 0;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }
        public List<Category> GetAllCategories() {
            List<Category> categories = new List<Category>();
            string query = "SELECT * FROM Category";

            try
            {
                dbConnection.OpenConnection();
                SqlConnection connection = dbConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Category category = new Category
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),

                    };
                    categories.Add(category);
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

            return categories;
        }

    }
}
