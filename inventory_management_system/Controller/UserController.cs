using System;
using System.Collections;
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
    public class UserController
    {
        private readonly DatabaseConnection databaseConnection;
        public UserController() {
            databaseConnection = new DatabaseConnection();  
        }

        // add
        public bool AddUser(User user)
        {
            string query = "insert into users(Name,UserId,Password) values(@Name,@UserId,@Password);";
            try
            {
                databaseConnection.OpenConnection();
                SqlConnection connection = databaseConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Name",user.Name);
                cmd.Parameters.AddWithValue("@UserId",user.UserId);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                int rowAffected =  cmd.ExecuteNonQuery();
                return rowAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                databaseConnection.CloseConnection();
            }
        }

        // read 
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            string query = "select * from users where Role=0";
            try
            {
                databaseConnection.OpenConnection();
                SqlConnection connection = databaseConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        UserId = reader["UserId"].ToString(),
                        Active = Convert.ToInt32(reader["Active"]),
                        Password = reader["Password"].ToString(),


                    };
                    users.Add(user);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while retrieving products: " + ex.Message);
            }
            finally
            {
                databaseConnection.CloseConnection();
            }

            return users;
        }

        // get by id
        public User GetUserById(int id)
        {
            User user = null;
            string query = "SELECT * FROM users WHERE Id = @Id";

            try
            {
                databaseConnection.OpenConnection();
                SqlConnection connection = databaseConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                     user = new User
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        UserId = reader["UserId"].ToString(),
                        Password = reader["Password"].ToString(),
                        Role = int.Parse(reader["Role"].ToString())


                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while retrieving employee by Id: " + ex.Message);
            }
            finally
            {
                databaseConnection.CloseConnection();
            }

            return user;
        }
        // update 
        public bool UpdateUser(User user)
        {
            string query = "UPDATE users SET Name=@Name, UserId=@UserId, Password=@Password WHERE Id=@Id";

            try
            {
                databaseConnection.OpenConnection();
                SqlConnection connection = databaseConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", user.Id);
                cmd.Parameters.AddWithValue("@Name",user.Name);
                cmd.Parameters.AddWithValue("@UserId", user.UserId);
                cmd.Parameters.AddWithValue("@Password", user.Password);

                int rowAffected = cmd.ExecuteNonQuery();
                return rowAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while updating employee: " + ex.Message);
                return false;
            }
            finally
            {
                databaseConnection.CloseConnection();
            }
        }

        public bool DeleteUser(int id)
        {
            string query = "DELETE FROM users WHERE Id=@Id";

            try
            {
                databaseConnection.OpenConnection();
                SqlConnection connection = databaseConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);

                int rowAffected = cmd.ExecuteNonQuery();
                return rowAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while deleting users: " + ex.Message);
                return false;
            }
            finally
            {
                databaseConnection.CloseConnection();
            }
        }
        public bool UpdateUserStatus(int userId, int newStatus)
        {
            string query = "UPDATE users SET Active = @Active WHERE Id = @Id";

            try
            {
                databaseConnection.OpenConnection();
                SqlConnection connection = databaseConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Active", newStatus);
                cmd.Parameters.AddWithValue("@Id", userId);

                int rowAffected = cmd.ExecuteNonQuery();
                return rowAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating user status: " + ex.Message);
                return false;
            }
            finally
            {
                databaseConnection.CloseConnection();
            }
        }

    }
}
