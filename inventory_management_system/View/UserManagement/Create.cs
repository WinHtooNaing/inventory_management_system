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

namespace inventory_management_system.View.UserManagement
{
    public partial class Create : Form
    {
        private readonly UserController userController;
        public Create()
        {
            InitializeComponent();
            userController = new UserController();
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string userId = userIdTxt.Text;
            string password = passwordTxt.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Data Empty", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Model.User newUser = new Model.User
            {
                Name = name,
                UserId = userId,
                Password = password,

            };
            bool isAdded = userController.AddUser(newUser);

            if (isAdded)
            {
                MessageBox.Show("Item added successfully", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to add", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Create_Load(object sender, EventArgs e)
        {

        }
    }
}
