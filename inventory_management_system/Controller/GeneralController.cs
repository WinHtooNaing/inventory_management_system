using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inventory_management_system.Model;
using Microsoft.Data.SqlClient;

namespace inventory_management_system.Controller
{
    public class GeneralController
    {
        private readonly DatabaseConnection dbConnection;
        public GeneralController() { 
            dbConnection = new DatabaseConnection();

        }
        // Add
        public bool AddGeneral(General general) {
            string query = "insert into General(Name,Price,CreatedAt) values(@Name,@Price,@CreatedAt)";
            try
            {
                dbConnection.OpenConnection();
                SqlConnection connection = dbConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Name",general.Name);
                cmd.Parameters.AddWithValue("@Price", general.Price);
                cmd.Parameters.AddWithValue("@CreatedAt",general.CreatedAt);
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
        // READ 
        public List<General> GetAllGenerals()
        {
            List<General> generals = new List<General>();
            string query = "SELECT * FROM General";

            try
            {
                dbConnection.OpenConnection();
                SqlConnection connection = dbConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                   
                    General general = new General
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Price = Convert.ToDecimal(reader["Price"]),
                        CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                    };
                    generals.Add(general);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while retrieving general: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }

            return generals;
        }

        // Read by Id
        public General GetGeneralById(int id)
        {
            General general = null;
            string query = "select * from General where Id=@Id";
            try
            {
                dbConnection.OpenConnection();
                SqlConnection connection = dbConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    general = new General
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Price = Convert.ToDecimal(reader["Price"]),
                        CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                    };
                    reader.Close();
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while retrieving employee by Id: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }

            return general;
        }    

        // update
        public bool UpdateGeneral(General general)
        {
            string query = "UPDATE General SET Name=@Name, Price=@Price  , CreatedAt=@CreatedAt WHERE Id=@Id";

            try
            {
                dbConnection.OpenConnection();
                SqlConnection connection = dbConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", general.Id);
                cmd.Parameters.AddWithValue("@Name", general.Name);
                cmd.Parameters.AddWithValue("@Price", general.Price);
                cmd.Parameters.AddWithValue("@CreatedAt",general.CreatedAt);

                int rowAffected = cmd.ExecuteNonQuery();
                return rowAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while updating general: " + ex.Message);
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        // delete
        public bool DeleteGeneral(int id)
        {
            string query = "DELETE FROM General WHERE Id=@Id";
            try
            {
                dbConnection.OpenConnection();
                SqlConnection connection = dbConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);

                int rowAffected = cmd.ExecuteNonQuery();
                return rowAffected > 0;
            }
            catch (Exception ex) { 
                Console.WriteLine($"{ex.Message}");
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

    }

}
