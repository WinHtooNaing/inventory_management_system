using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using inventory_management_system.Controller;

namespace inventory_management_system.View.General
{
    public partial class Index : Form
    {
        private readonly GeneralController generalController;
        public Index()
        {
            InitializeComponent();
            generalController = new GeneralController();
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
            UserManagement.Index index = new UserManagement.Index();
            index.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee.Index index = new Employee.Index();
            index.Show();
            this.Hide();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            LoadGeneralIntoGrid();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.Show();
            this.Hide();
        }
        private void LoadGeneralIntoGrid()
        {
            try
            {
                // Fetch all generals from the repository
                var generals = generalController.GetAllGenerals();



                // Bind the generals list to the DataGridView
                GeneralGridView.DataSource = generals;


                // Add a "No" column for numbering
                if (!GeneralGridView.Columns.Contains("No"))
                {
                    DataGridViewTextBoxColumn noColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "No",
                        HeaderText = "No",
                        ReadOnly = true
                    };
                    GeneralGridView.Columns.Insert(0, noColumn);
                }

                // Add Edit button
                if (!GeneralGridView.Columns.Contains("Edit"))
                {
                    DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn
                    {
                        Name = "Edit",
                        HeaderText = "",
                        Text = "Edit",
                        UseColumnTextForButtonValue = true
                    };
                    GeneralGridView.Columns.Add(editColumn);
                    editColumn.DefaultCellStyle.BackColor = Color.Orange;
                    editColumn.DefaultCellStyle.ForeColor = Color.White;
                }

                // Add Delete button
                if (!GeneralGridView.Columns.Contains("Delete"))
                {
                    DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
                    {
                        Name = "Delete",
                        HeaderText = "",
                        Text = "Delete",
                        UseColumnTextForButtonValue = true
                    };
                    GeneralGridView.Columns.Add(deleteColumn);
                    deleteColumn.DefaultCellStyle.BackColor = Color.Red;
                    deleteColumn.DefaultCellStyle.ForeColor = Color.White;
                }

                // Populate "No" column with sequential numbers
                for (int i = 0; i < GeneralGridView.Rows.Count; i++)
                {
                    GeneralGridView.Rows[i].Cells["No"].Value = i + 1;
                }

                // Customize the DataGridView
                GeneralGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Hide the "Id" column
                if (GeneralGridView.Columns.Contains("Id"))
                {
                    GeneralGridView.Columns["Id"].Visible = false; // Hide the ID column
                }
                if (GeneralGridView.Columns.Contains("CreatedAt"))
                {
                    GeneralGridView.Columns["CreatedAt"].Visible = false; // Hide the ID column
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading general: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EditGeneral(int generalId)
        {
            Edit edit = new Edit(generalId);
            edit.Show();
            this.Hide();
        }
        public void DeleteGeneral(int generalId)
        {



            bool deleteGeneral = generalController.DeleteGeneral(generalId);
            if (deleteGeneral)
            {
                MessageBox.Show("General Deleted successfully", "General delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGeneralIntoGrid();
            }
            else
            {
                MessageBox.Show("General not found or already deleted.", "General delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void GeneralGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked cell is a button
            if (e.RowIndex >= 0 && (e.ColumnIndex == GeneralGridView.Columns["Edit"].Index || e.ColumnIndex == GeneralGridView.Columns["Delete"].Index))
            {
                // Get the selected employee's ID
                int generalId = Convert.ToInt32(GeneralGridView.Rows[e.RowIndex].Cells["Id"].Value);

                if (e.ColumnIndex == GeneralGridView.Columns["Edit"].Index)
                {
                    // Edit button clicked
                    EditGeneral(generalId);
                }
                else if (e.ColumnIndex == GeneralGridView.Columns["Delete"].Index)
                {
                    // Delete button clicked
                    DeleteGeneral(generalId);
                }
            }
        }
    }
}
