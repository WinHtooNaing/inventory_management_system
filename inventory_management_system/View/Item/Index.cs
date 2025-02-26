using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using inventory_management_system.Controller;
using inventory_management_system.View.UserManagement;
using Microsoft.Data.SqlClient;

namespace inventory_management_system.View.Item
{
    public partial class Index : Form
    {
        private readonly ItemController itemController;

        public Index()
        {
            InitializeComponent();
            itemController = new ItemController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            //dashboard.Show();
            //this.Hide();
            dashboard.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserManagement.Index index = new UserManagement.Index();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked cell is a button
            if (e.RowIndex >= 0 && ( e.ColumnIndex == itemGridView.Columns["Delete"].Index))
            {
                // Get the selected product's ID
                int itemId = Convert.ToInt32(itemGridView.Rows[e.RowIndex].Cells["Id"].Value);

                if (e.ColumnIndex == itemGridView.Columns["Delete"].Index)
                {
                    // Delete button clicked
                    DeleteItem(itemId);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.Show();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            LoadItemsIntoGrid("");
            itemGridView.CellEndEdit += ItemGridView_CellEndEdit;
        }
        private void ItemGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                if (rowIndex >= 0)
                {
                    // Retrieve the employee ID
                    int itemId = Convert.ToInt32(itemGridView.Rows[rowIndex].Cells["Id"].Value);

                    // Get updated values from the grid
                    string type = itemGridView.Rows[rowIndex].Cells["Types"].Value.ToString();
                    string category = itemGridView.Rows[rowIndex].Cells["Category"].Value.ToString();
                    int qty = Convert.ToInt32(itemGridView.Rows[rowIndex].Cells["Quantity"].Value);
                    decimal purchase = Convert.ToDecimal(itemGridView.Rows[rowIndex].Cells["PurchasePrice"].Value);
                    decimal selling = Convert.ToDecimal(itemGridView.Rows[rowIndex].Cells["SellingPrice"].Value);


                    Model.Item newItem = new Model.Item
                    {
                        Id = itemId,
                        Types = type,
                        Category = category,
                        Quantity = qty,
                        PurchasePrice = purchase,
                        SellingPrice = selling,

                    };
                    bool isAdded = itemController.UpdateItem(newItem);

                    if (isAdded)
                    {
                        MessageBox.Show("Item updated successfully", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Failed to update", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadItemsIntoGrid(string searchItem = "")
        {
            try
            {
                // Fetch all products from the repository
                var items = itemController.GetAllItems();

                if (!string.IsNullOrEmpty(searchItem))
                {
                    items = items.Where(
                        item => item.Category.Contains(searchItem, StringComparison.OrdinalIgnoreCase)
                        ).ToList();
                }

                // Bind the products list to the DataGridView
                itemGridView.DataSource = items;


                // Add a "No" column for numbering
                if (!itemGridView.Columns.Contains("No"))
                {
                    DataGridViewTextBoxColumn noColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "No",
                        HeaderText = "No",
                        ReadOnly = true
                    };
                    itemGridView.Columns.Insert(0, noColumn);
                }

                

                // Add Delete button
                if (!itemGridView.Columns.Contains("Delete"))
                {
                    DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
                    {
                        Name = "Delete",
                        HeaderText = "",
                        Text = "🗑", // Unicode trash icon
                        UseColumnTextForButtonValue = true
                    };
                    itemGridView.Columns.Add(deleteColumn);
                    // Optional: Style the button
                    deleteColumn.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 12); // Use an emoji-supporting font
                    deleteColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    deleteColumn.DefaultCellStyle.BackColor = Color.Red;
                    deleteColumn.DefaultCellStyle.ForeColor = Color.White;
                }

                // Populate "No" column with sequential numbers
                for (int i = 0; i < itemGridView.Rows.Count; i++)
                {
                    itemGridView.Rows[i].Cells["No"].Value = i + 1;
                }

                itemGridView.Columns["Types"].ReadOnly = true;
                itemGridView.Columns["PurchasePrice"].ReadOnly = false;
                itemGridView.Columns["SellingPrice"].ReadOnly = false;
                itemGridView.Columns["Quantity"].ReadOnly = false;
                itemGridView.Columns["Category"].ReadOnly = false;


                // Customize the DataGridView
                itemGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Hide the "Id" column
                if (itemGridView.Columns.Contains("Id"))
                {
                    itemGridView.Columns["Id"].Visible = false; // Hide the ID column
                }
                if (itemGridView.Columns.Contains("CreatedAt"))
                {
                    itemGridView.Columns["CreatedAt"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void DeleteItem(int itemId)
        {



            bool deleteItem = itemController.DeleteItem(itemId);
            if (deleteItem)
            {
                MessageBox.Show("Item Deleted successfully", "Item delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadItemsIntoGrid();
            }
            else
            {
                MessageBox.Show("Item not found or already deleted.", "Item delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchItem = searchTxt.Text;
            LoadItemsIntoGrid(searchItem);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            searchTxt.Text = "";
            LoadItemsIntoGrid("");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SessionStorage.Session.UserName = "";
            SessionStorage.Session.UserId = "";
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SellItem.Index index = new SellItem.Index();
            //index.Show();
            //this.Hide();
            index.Visible = true;
            this.Visible = false;
        }
    }
}
