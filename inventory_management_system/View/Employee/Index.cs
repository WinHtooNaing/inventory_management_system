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
            dashboard.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Item.Index index = new Item.Index();
            index.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserManagement.Index userManagement = new UserManagement.Index();
            userManagement.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            General.Index index = new General.Index();
            index.Show();
            this.Hide();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            LoadEmployeeIntoGrid();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.Show();
            this.Hide();
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

                // Add Edit button
                if (!EmployeeGridView.Columns.Contains("Edit"))
                {
                    DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn
                    {
                        Name = "Edit",
                        HeaderText = "",
                        Text = "Edit",
                        UseColumnTextForButtonValue = true
                    };
                    EmployeeGridView.Columns.Add(editColumn);
                    editColumn.DefaultCellStyle.BackColor = Color.Orange;
                    editColumn.DefaultCellStyle.ForeColor = Color.White;
                }

                // Add Delete button
                if (!EmployeeGridView.Columns.Contains("Delete"))
                {
                    DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
                    {
                        Name = "Delete",
                        HeaderText = "",
                        Text = "Delete",
                        UseColumnTextForButtonValue = true
                    };
                    EmployeeGridView.Columns.Add(deleteColumn);
                    deleteColumn.DefaultCellStyle.BackColor = Color.Red;
                    deleteColumn.DefaultCellStyle.ForeColor = Color.White;
                }

                // Populate "No" column with sequential numbers
                for (int i = 0; i < EmployeeGridView.Rows.Count; i++)
                {
                    EmployeeGridView.Rows[i].Cells["No"].Value = i + 1;
                }

                // Customize the DataGridView
                EmployeeGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Hide the "Id" column
                if (EmployeeGridView.Columns.Contains("Id"))
                {
                    EmployeeGridView.Columns["Id"].Visible = false; // Hide the ID column
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EditEmoloyee(int employeeId)
        {
            Edit edit = new Edit(employeeId);
            edit.Show();
            this.Hide();
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

                if (e.ColumnIndex == EmployeeGridView.Columns["Edit"].Index)
                {
                    // Edit button clicked
                    EditEmoloyee(employeeId);
                }
                else if (e.ColumnIndex == EmployeeGridView.Columns["Delete"].Index)
                {
                    // Delete button clicked
                    DeleteEmployee(employeeId);
                }
            }
        }
    }
}
