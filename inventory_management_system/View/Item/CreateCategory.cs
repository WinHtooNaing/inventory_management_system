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

namespace inventory_management_system.View.Item
{
    public partial class CreateCategory : Form
    {
        private readonly CategoryController categoryController;
        public CreateCategory()
        {
            InitializeComponent();
            categoryController = new CategoryController();
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Data Empty", "Create Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Model.Category category = new Model.Category
            {
                Name = name,
            };
            bool isAdded = categoryController.AddCategory(category);

            if (isAdded)
            {
                MessageBox.Show("Category added successfully", "Create Category", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

            }
            else
            {
                MessageBox.Show("Failed to add", "Create category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Index index = new Index();  
            index.Show();
            this.Hide();
        }
    }
}
