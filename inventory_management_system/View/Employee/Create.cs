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
using Microsoft.Identity.Client;

namespace inventory_management_system.View.Employee
{
    public partial class Create : Form
    {
        private readonly EmployeeController employeeController;
        public Create()
        {
            InitializeComponent();
            employeeController = new EmployeeController();
            this.MaximizeBox = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string EmpRole = roleTxt.Text;
            int Number = int.Parse(numberTxt.Text);
            decimal Salary = decimal.Parse(salaryTxt.Text);
            if (string.IsNullOrEmpty(EmpRole) || string.IsNullOrEmpty(numberTxt.Text) || string.IsNullOrEmpty(salaryTxt.Text))
            {
                MessageBox.Show("invalid input", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            Model.Employee employee = new Model.Employee
            {
                EmployeeRole = EmpRole,
                Number = Number,
                Salary = Salary

            };
            bool AddEmp = employeeController.AddEmployee(employee);
            if (AddEmp)
            {
                MessageBox.Show("Add Successful", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Index index = new Index();
                index.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Add Fail", "Added", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            this.Hide();
        }

        private void Create_Load(object sender, EventArgs e)
        {

        }
    }
}
