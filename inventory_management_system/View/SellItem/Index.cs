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

namespace inventory_management_system.View.SellItem
{
    public partial class Index : Form
    {
        private readonly SellItemController sellItemController;
        public Index()
        {
            InitializeComponent();
            sellItemController = new SellItemController();

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
            Item.Index item = new Item.Index();
            //item.Show();
            //this.Hide();
            item.Visible = true;
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

        private void button6_Click(object sender, EventArgs e)
        {
            SessionStorage.Session.UserName = "";
            Login index = new Login();
            //index.Show();
            //this.Hide();
            index.Visible = true;
            this.Visible = false;
        }

        private void Index_Load(object sender, EventArgs e)
        {
            LoadSellItem();
        }
        private void LoadSellItem()
        {

            try
            {
                var items = sellItemController.GetAllSellItems();
                sellItemGridView.DataSource = items;
                // Add a "No" column for numbering
                if (!sellItemGridView.Columns.Contains("No"))
                {
                    DataGridViewTextBoxColumn noColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "No",
                        HeaderText = "No",
                        ReadOnly = true
                    };
                    sellItemGridView.Columns.Insert(0, noColumn);
                }

                //// Add Edit button
                //if (!sellItemGridView.Columns.Contains("Edit"))
                //{
                //    DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn
                //    {
                //        Name = "Edit",
                //        HeaderText = "",
                //        Text = "Edit",
                //        UseColumnTextForButtonValue = true
                //    };
                //    sellItemGridView.Columns.Add(editColumn);
                //    editColumn.DefaultCellStyle.BackColor = Color.Orange;
                //    editColumn.DefaultCellStyle.ForeColor = Color.White;
                //}

                //// Add Delete button
                //if (!sellItemGridView.Columns.Contains("Delete"))
                //{
                //    DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
                //    {
                //        Name = "Delete",
                //        HeaderText = "",
                //        Text = "Delete",
                //        UseColumnTextForButtonValue = true
                //    };
                //    sellItemGridView.Columns.Add(deleteColumn);
                //    deleteColumn.DefaultCellStyle.BackColor = Color.Red;
                //    deleteColumn.DefaultCellStyle.ForeColor = Color.White;
                //}

                // Populate "No" column with sequential numbers
                for (int i = 0; i < sellItemGridView.Rows.Count; i++)
                {
                    sellItemGridView.Rows[i].Cells["No"].Value = i + 1;
                }

                // Customize the DataGridView
                sellItemGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Hide the "Id" column
                if (sellItemGridView.Columns.Contains("Id"))
                {
                    sellItemGridView.Columns["Id"].Visible = false; // Hide the ID column
                }
                if (sellItemGridView.Columns.Contains("CreatedAt"))
                {
                    sellItemGridView.Columns["CreatedAt"].Visible = false; // Hide the ID column
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void sellItemGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //// Ensure the clicked cell is a button
            //if (e.RowIndex >= 0 && (e.ColumnIndex == sellItemGridView.Columns["Edit"].Index || e.ColumnIndex == sellItemGridView.Columns["Delete"].Index))
            //{
            //    // Get the selected employee's ID
            //    int generalId = Convert.ToInt32(sellItemGridView.Rows[e.RowIndex].Cells["Id"].Value);

            //    if (e.ColumnIndex == sellItemGridView.Columns["Edit"].Index)
            //    {
            //        // Edit button clicked
            //       // EditGeneral(generalId);
            //    }
            //    else if (e.ColumnIndex == sellItemGridView.Columns["Delete"].Index)
            //    {
            //        // Delete button clicked
            //      //  DeleteGeneral(generalId);
            //    }
            //}
        }
    }
}
