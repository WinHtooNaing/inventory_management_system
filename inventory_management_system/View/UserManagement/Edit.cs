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
    public partial class Edit : Form
    {
        private readonly int userId;
        private readonly UserController userController;
        public Edit(int id)
        {
            InitializeComponent();
            userId = id;
            userController = new UserController();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            LoadUserDetails();
        }
        private void LoadUserDetails()
        {
            try
            {



                // Fetch user by ID
                var user = userController.GetUserById(userId);

                if (user != null)
                {
                    // Populate form fields with user details
                    nameTxt.Text = user.Name;
                    userIdTxt.Text = user.UserId;
                    passwordTxt.Text = user.Password;
                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string password = passwordTxt.Text;
            string user_Id = userIdTxt.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(user_Id) )
            {
                MessageBox.Show("Data Empty", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Model.User user = new Model.User
            {
                Id = userId,
                Name = name,
                UserId = user_Id,
                Password = password,

            };
            bool isAdded = userController.UpdateUser(user);

            if (isAdded)
            {
                MessageBox.Show("User updated successfully", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Index index = new Index();
                index.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Failed to update", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
