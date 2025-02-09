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
    public partial class Edit : Form
    {
        private readonly int employeeId;
        private readonly EmployeeController employeeController;
        public Edit(int id)
        {
            InitializeComponent();
            employeeId = id;
            employeeController = new EmployeeController();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            LoadEmployeeDetails();

        }
        private void LoadEmployeeDetails()
        {
            try
            {



                // Fetch employee by ID
                var employee = employeeController.GetEmployeeById(employeeId);

                if (employee != null)
                {
                    // Populate form fields with product details
                    roleTxt.Text = employee.EmployeeRole;
                    numberTxt.Text = employee.Number.ToString();
                    salaryTxt.Text = employee.Salary.ToString();
                }
                else
                {
                    MessageBox.Show("Item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading item details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string EmpRole = roleTxt.Text;
            int Number = int.Parse(numberTxt.Text);
            decimal Salary = decimal.Parse(salaryTxt.Text);
            if (string.IsNullOrEmpty(EmpRole) || string.IsNullOrEmpty(numberTxt.Text) || string.IsNullOrEmpty(salaryTxt.Text))
            {
                MessageBox.Show("invalid input", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            Model.Employee employee = new Model.Employee
            {
                Id = employeeId,
                EmployeeRole = EmpRole,
                Number = Number,
                Salary = Salary

            };
            bool isEdited = employeeController.UpdateEmployee(employee);
            if (isEdited) {
                
                
                    MessageBox.Show("Employee updated successfully", "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Index index = new Index();
                    index.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Failed to update", "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
    }
}
