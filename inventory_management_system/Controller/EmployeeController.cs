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
            string query = "insert into Employee(EmployeeRole,Number,Salary) values(@EmployeeRole,@Number,@Salary)";
            try
            {
                dbConnection.OpenConnection();
                SqlConnection connection=dbConnection.GetConnection();
                SqlCommand cmd=new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@EmployeeRole", employee.EmployeeRole);
                cmd.Parameters.AddWithValue("@Number", employee.Number);
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
            string query = "SELECT * FROM Employee";
            
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
                        EmployeeRole = reader["EmployeeRole"].ToString(),
                        Number = Convert.ToInt32(reader["Number"]),
                        Salary = Convert.ToDecimal(reader["Salary"]),
                        CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),

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
                        Number = Convert.ToInt32(reader["Number"]),
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
            string query = "UPDATE Employee SET EmployeeRole=@EmployeeRole, Number=@Number, Salary=@Salary WHERE Id=@Id";

            try
            {
                dbConnection.OpenConnection();
                SqlConnection connection = dbConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", employee.Id);
                cmd.Parameters.AddWithValue("@EmployeeRole", employee.EmployeeRole);
                cmd.Parameters.AddWithValue("@Number", employee.Number);
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
    }
}
