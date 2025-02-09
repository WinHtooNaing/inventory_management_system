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
            dashboard.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SellingItem.Index index = new SellingItem.Index();
            index.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee.Index index = new Employee.Index();
            index.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            General.Index index = new General.Index();
            index.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked cell is a button
            if (e.RowIndex >= 0 && (e.ColumnIndex == itemGridView.Columns["Edit"].Index || e.ColumnIndex == itemGridView.Columns["Delete"].Index))
            {
                // Get the selected product's ID
                int itemId = Convert.ToInt32(itemGridView.Rows[e.RowIndex].Cells["Id"].Value);

                if (e.ColumnIndex == itemGridView.Columns["Edit"].Index)
                {
                    // Edit button clicked
                    EditItem(itemId);
                }
                else if (e.ColumnIndex == itemGridView.Columns["Delete"].Index)
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
            this.Hide();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            LoadItemsIntoGrid("");
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
                        item => item.Types.Contains(searchItem, StringComparison.OrdinalIgnoreCase)
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

                // Add Edit button
                if (!itemGridView.Columns.Contains("Edit"))
                {
                    DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn
                    {
                        Name = "Edit",
                        HeaderText = "",
                        Text = "Edit",
                        UseColumnTextForButtonValue = true
                    };
                    itemGridView.Columns.Add(editColumn);
                    editColumn.DefaultCellStyle.BackColor = Color.Orange;
                    editColumn.DefaultCellStyle.ForeColor = Color.White;
                }

                // Add Delete button
                if (!itemGridView.Columns.Contains("Delete"))
                {
                    DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
                    {
                        Name = "Delete",
                        HeaderText = "",
                        Text = "Delete",
                        UseColumnTextForButtonValue = true
                    };
                    itemGridView.Columns.Add(deleteColumn);
                    deleteColumn.DefaultCellStyle.BackColor = Color.Red;
                    deleteColumn.DefaultCellStyle.ForeColor = Color.White;
                }

                // Populate "No" column with sequential numbers
                for (int i = 0; i < itemGridView.Rows.Count; i++)
                {
                    itemGridView.Rows[i].Cells["No"].Value = i + 1;
                }

                // Customize the DataGridView
                itemGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Hide the "Id" column
                if (itemGridView.Columns.Contains("Id"))
                {
                    itemGridView.Columns["Id"].Visible = false; // Hide the ID column
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EditItem(int itemId)
        {
            Edit edit = new Edit(itemId);
            edit.Show();
            this.Hide();
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
    }
}
