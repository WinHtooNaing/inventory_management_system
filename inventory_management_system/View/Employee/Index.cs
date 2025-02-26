using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using inventory_management_system.Controller;
using inventory_management_system.View.Item;

namespace inventory_management_system.View.Employee
{
    public partial class Index : Form
    {
        private readonly EmployeeController employeeController;
        public Index()
        {
            InitializeComponent();
            employeeController = new EmployeeController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            //dashboard.Show();
            //this.Hide();
            dashboard.Visible = true;
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Item.Index index = new Item.Index();
            //index.Show();
            //this.Hide();
            index.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserManagement.Index userManagement = new UserManagement.Index();
            //userManagement.Show();
            //this.Hide();
            userManagement.Visible = true;
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            General.Index index = new General.Index();
            //index.Show();
            //this.Hide();
            index.Visible = true;
            this.Visible = false;
        }

        private void Index_Load(object sender, EventArgs e)
        {
            LoadEmployeeIntoGrid();
            EmployeeGridView.CellEndEdit += EmployeeGridView_CellEndEdit;
        }
        private void EmployeeGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                if (rowIndex >= 0)
                {
                    // Retrieve the employee ID
                    int employeeId = Convert.ToInt32(EmployeeGridView.Rows[rowIndex].Cells["Id"].Value);

                    // Get updated values from the grid
                    string updatedRole = EmployeeGridView.Rows[rowIndex].Cells["EmployeeRole"].Value.ToString();
                    int updatedNumber = Convert.ToInt32(EmployeeGridView.Rows[rowIndex].Cells["Number"].Value); // Ensure proper conversion
                    decimal updatedSalary = Convert.ToDecimal(EmployeeGridView.Rows[rowIndex].Cells["Salary"].Value);

                    // Create an Employee object with the updated values
                    Model.Employee updatedEmployee = new Model.Employee
                    {
                        Id = employeeId,
                        EmployeeRole = updatedRole,
                        Number = updatedNumber,
                        Salary = updatedSalary
                    };

                    // Call the update function
                    bool updated = employeeController.UpdateEmployee(updatedEmployee);

                    if (updated)
                    {
                        MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.Show();
        }
        private void LoadEmployeeIntoGrid()
        {
            try
            {
                // Fetch all employees from the repository
                var employees = employeeController.GetAllEmployees();



                // Bind the employees list to the DataGridView
                EmployeeGridView.DataSource = employees;


                // Add a "No" column for numbering
                if (!EmployeeGridView.Columns.Contains("No"))
                {
                    DataGridViewTextBoxColumn noColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "No",
                        HeaderText = "No",
                        ReadOnly = true
                    };
                    EmployeeGridView.Columns.Insert(0, noColumn);
                }

               

                // Add Delete button
                if (!EmployeeGridView.Columns.Contains("Delete"))
                {
                    DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
                    {
                        Name = "Delete",
                        HeaderText = "",
                        Text = "🗑", // Unicode trash icon
                        UseColumnTextForButtonValue = true
                    };
                    EmployeeGridView.Columns.Add(deleteColumn);

                    // Optional: Style the button
                    deleteColumn.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 12); // Use an emoji-supporting font
                    deleteColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    deleteColumn.DefaultCellStyle.BackColor = Color.Red;
                    deleteColumn.DefaultCellStyle.ForeColor = Color.White;
                }

                // Populate "No" column with sequential numbers
                for (int i = 0; i < EmployeeGridView.Rows.Count; i++)
                {
                    EmployeeGridView.Rows[i].Cells["No"].Value = i + 1;
                }


                EmployeeGridView.Columns["EmployeeRole"].ReadOnly = false;
                EmployeeGridView.Columns["Number"].ReadOnly = false;
                EmployeeGridView.Columns["Salary"].ReadOnly = false;

                // Customize the DataGridView
                EmployeeGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Hide the "Id" column
                if (EmployeeGridView.Columns.Contains("Id"))
                {
                    EmployeeGridView.Columns["Id"].Visible = false; // Hide the ID column
                }
                if (EmployeeGridView.Columns.Contains("CreatedAt"))
                {
                    EmployeeGridView.Columns["CreatedAt"].Visible = false; // Hide the ID column


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void DeleteEmployee(int employeeId)
        {



            bool deleteItem = employeeController.DeleteEmployee(employeeId);
            if (deleteItem)
            {
                MessageBox.Show("Employee Deleted successfully", "Employee delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployeeIntoGrid();
            }
            else
            {
                MessageBox.Show("Employee not found or already deleted.", "Employee delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void EmployeeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked cell is a button
            if (e.RowIndex >= 0 && (e.ColumnIndex == EmployeeGridView.Columns["Edit"].Index || e.ColumnIndex == EmployeeGridView.Columns["Delete"].Index))
            {
                // Get the selected employee's ID
                int employeeId = Convert.ToInt32(EmployeeGridView.Rows[e.RowIndex].Cells["Id"].Value);

                
                if (e.ColumnIndex == EmployeeGridView.Columns["Delete"].Index)
                {
                    // Delete button clicked
                    DeleteEmployee(employeeId);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SessionStorage.Session.UserName = "";
            SessionStorage.Session.UserId = "";
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            SellItem.Index index = new SellItem.Index();
            //index.Show();
            //this.Hide();
            index.Visible = true;
            this.Visible = false;
        }
    }
}
