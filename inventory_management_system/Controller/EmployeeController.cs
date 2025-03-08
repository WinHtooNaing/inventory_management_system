using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inventory_management_system.Model;
using Microsoft.Data.SqlClient;

namespace inventory_management_system.Controller
{
    public class EmployeeController
    {
        private readonly DatabaseConnection dbConnection;
        public EmployeeController() { 
        dbConnection=new DatabaseConnection();
        }
        public bool AddEmployee(Employee employee)
        {
            string query = "insert into Employee(Name,EmployeeRole,Salary) values(@Name,@EmployeeRole,@Salary)";
            try
            {
                dbConnection.OpenConnection();
                SqlConnection connection=dbConnection.GetConnection();
                SqlCommand cmd=new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@EmployeeRole", employee.EmployeeRole);
                cmd.Parameters.AddWithValue("@Name", employee.Name);
                cmd.Parameters.AddWithValue("@Salary", employee.Salary);
               int rowEffected= cmd.ExecuteNonQuery();
                return rowEffected > 0;
                

            }
            catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }
        // READ (Get all Employee)
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            string query = "SELECT * FROM Employee WHERE EndDate IS NULL";
            
            try
            {
                dbConnection.OpenConnection();
                SqlConnection connection = dbConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = new Employee
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        EmployeeRole = reader["EmployeeRole"].ToString(),
                        Salary = Convert.ToDecimal(reader["Salary"]),
                        StartDate = Convert.ToDateTime(reader["StartDate"]),
                        EndDate = reader["EndDate"] != DBNull.Value ? Convert.ToDateTime(reader["EndDate"]) : (DateTime?)null


                    };
                    employees.Add(employee);
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

            return employees;
        }
        // DELETE (Remove an employee by Id)
        public bool DeleteEmployee(int id)
        {
            string query = "DELETE FROM Employee WHERE Id=@Id";

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
                Console.WriteLine("Error while deleting employee: " + ex.Message);
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }
        // READ (Get a single employee by Id)
        public Employee GetEmployeeById(int id)
        {
            Employee employee = null;
            string query = "SELECT * FROM Employee WHERE Id = @Id";

            try
            {
                dbConnection.OpenConnection();
                SqlConnection connection = dbConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    employee = new Employee
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        EmployeeRole = reader["EmployeeRole"].ToString(),
                        Name = Convert.ToInt32(reader["Name"]).ToString(),
                        Salary = Convert.ToDecimal(reader["Salary"]),
                        
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
                dbConnection.CloseConnection();
            }

            return employee;
        }
        // UPDATE (Modify an existing employee)
        public bool UpdateEmployee(Employee employee)
        {
            string query = "UPDATE Employee SET Name=@Name,EmployeeRole=@EmployeeRole,  Salary=@Salary WHERE Id=@Id";

            try
            {
                dbConnection.OpenConnection();
                SqlConnection connection = dbConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", employee.Id);
                cmd.Parameters.AddWithValue("@EmployeeRole", employee.EmployeeRole);
                cmd.Parameters.AddWithValue("@Name", employee.Name);
                cmd.Parameters.AddWithValue("@Salary", employee.Salary);

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
                dbConnection.CloseConnection();
            }
        }
        public bool MarkEmployeeAsLeft(int employeeId)
        {
            string query = "UPDATE Employee SET EndDate = @EndDate WHERE Id = @Id";

            try
            {
                dbConnection.OpenConnection();
                SqlConnection connection = dbConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", employeeId);
                cmd.Parameters.AddWithValue("@EndDate", DateTime.Now); // Set current date

                int rowAffected = cmd.ExecuteNonQuery();
                return rowAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while marking employee as left: " + ex.Message);
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

    }
}
