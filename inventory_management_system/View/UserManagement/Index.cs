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
    public partial class Index : Form
    {
        private readonly UserController userController;
        public Index()
        {
            InitializeComponent();
            userController = new UserController();
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

        private void button3_Click(object sender, EventArgs e)
        {
            Employee.Index index = new Employee.Index();
            //index.Show();
            //this.Hide();
            index.Visible = true;
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.Show();
            this.Hide();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            LoadUsersIntoGrid();
            userGridView.CellEndEdit += userGridView_CellEndEdit;
        }
        private void userGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                if (rowIndex >= 0)
                {
                    // Retrieve the employee ID
                    int id = Convert.ToInt32(userGridView.Rows[rowIndex].Cells["Id"].Value);

                    // Get updated values from the grid
                    string name = userGridView.Rows[rowIndex].Cells["Name"].Value.ToString();
                    string userId = userGridView.Rows[rowIndex].Cells["UserId"].Value.ToString();
                    string password = userGridView.Rows[rowIndex].Cells["Password"].Value.ToString();



                    Model.User user = new Model.User
                    {
                        Id = id,
                        Name = name,
                        UserId = userId,
                        Password = password
                    };
                    bool updateUser = userController.UpdateUser(user);
                    if (updateUser)
                    {
                        MessageBox.Show("Edit Successful", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Edit Fail", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUsersIntoGrid()
        {
            try
            {
                var users = userController.GetAllUsers();
                userGridView.DataSource = users;

                // Add a "No" column for numbering
                if (!userGridView.Columns.Contains("No"))
                {
                    DataGridViewTextBoxColumn noColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "No",
                        HeaderText = "No",
                        ReadOnly = true
                    };
                    userGridView.Columns.Insert(0, noColumn);
                }

                // Hide the "Active" column
                if (userGridView.Columns.Contains("Active"))
                {
                    userGridView.Columns["Active"].Visible = false;
                }

                // Add a "Status" column
                if (!userGridView.Columns.Contains("Status"))
                {
                    DataGridViewTextBoxColumn statusColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "Status",
                        HeaderText = "Status",
                        ReadOnly = true
                    };
                    userGridView.Columns.Add(statusColumn);
                }

                // Add a "Change Status" button
                if (!userGridView.Columns.Contains("ToggleStatus"))
                {
                    DataGridViewButtonColumn toggleStatusColumn = new DataGridViewButtonColumn
                    {
                        Name = "ToggleStatus",
                        HeaderText = "",
                        Text = "Change Status",
                        UseColumnTextForButtonValue = true
                    };
                    userGridView.Columns.Add(toggleStatusColumn);
                    toggleStatusColumn.DefaultCellStyle.BackColor = Color.Blue;
                    toggleStatusColumn.DefaultCellStyle.ForeColor = Color.White;
                }



                // Add "Delete" button
                if (!userGridView.Columns.Contains("Delete"))
                {
                    DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
                    {
                        Name = "Delete",
                        HeaderText = "",
                        Text = "🗑", // Unicode trash icon
                        UseColumnTextForButtonValue = true
                    };
                    userGridView.Columns.Add(deleteColumn);

                    // Optional: Style the button
                    deleteColumn.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 12); // Use an emoji-supporting font
                    deleteColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    deleteColumn.DefaultCellStyle.BackColor = Color.Red;
                    deleteColumn.DefaultCellStyle.ForeColor = Color.White;
                }

                // Populate "No" column and update "Status" column
                for (int i = 0; i < userGridView.Rows.Count; i++)
                {
                    userGridView.Rows[i].Cells["No"].Value = i + 1;
                    int activeStatus = Convert.ToInt32(userGridView.Rows[i].Cells["Active"].Value);

                    // Set "Status" column
                    userGridView.Rows[i].Cells["Status"].Value = activeStatus == 0 ? "Active" : "Banned";

                    // Hide "Edit" and "Delete" buttons if the user is banned (Active = 1)
                    if (activeStatus == 1)
                    {


                        userGridView.Rows[i].Cells["Delete"].Style.BackColor = Color.White;  // Hide text
                    }
                    else
                    {

                        userGridView.Rows[i].Cells["Delete"].Style.ForeColor = Color.White;
                    }
                }

                // Hide the "Id" and "Password" columns
                if (userGridView.Columns.Contains("Id"))
                    userGridView.Columns["Id"].Visible = false;
                if (userGridView.Columns.Contains("Role"))
                    userGridView.Columns["Role"].Visible = false;

                userGridView.Columns["Name"].ReadOnly = false;
                userGridView.Columns["UserId"].ReadOnly = false;
                userGridView.Columns["Password"].ReadOnly = false;

                // Auto-size columns
                userGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void DeleteUser(int userId)
        {



            bool deleteUser = userController.DeleteUser(userId);
            if (deleteUser)
            {
                MessageBox.Show("User Deleted successfully", "User delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsersIntoGrid();
            }
            else
            {
                MessageBox.Show("User not found or already deleted.", "User delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void userGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int userId = Convert.ToInt32(userGridView.Rows[e.RowIndex].Cells["Id"].Value);
                int currentStatus = Convert.ToInt32(userGridView.Rows[e.RowIndex].Cells["Active"].Value);

                if (e.ColumnIndex == userGridView.Columns["Delete"].Index && currentStatus == 0)
                {
                    DeleteUser(userId);
                }
                else if (e.ColumnIndex == userGridView.Columns["ToggleStatus"].Index)
                {
                    // Toggle the user's status
                    int newStatus = currentStatus == 0 ? 1 : 0;

                    bool updated = userController.UpdateUserStatus(userId, newStatus);

                    if (updated)
                    {
                        MessageBox.Show("User status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsersIntoGrid(); // Refresh the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Failed to update user status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void button7_Click(object sender, EventArgs e)
        {
            SellItem.Index index = new SellItem.Index();
            //index.Show();
            //this.Hide();
            index.Visible = true;
            this.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Report.Index index = new Report.Index();    
            index.Show();
            this.Hide();
        }
    }
}

