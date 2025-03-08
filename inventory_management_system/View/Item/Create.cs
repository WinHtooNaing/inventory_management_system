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
using inventory_management_system.Model;

namespace inventory_management_system.View.Item
{
    public partial class Create : Form
    {
        private readonly ItemController itemcontroller;
        private readonly CategoryController categorycontroller;
        public Create()
        {
            InitializeComponent();
            itemcontroller = new ItemController();
            categorycontroller = new CategoryController();
            this.MaximizeBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string formattedDate = DateTime.Now.ToString("dd-MM-yyyy");
            string category = categoryTxt.SelectedItem.ToString() + "(" + formattedDate + ")";
            string type = typeTxt.SelectedItem.ToString();
            int qty = int.Parse(qtyTxt.Text);
            decimal purchase = decimal.Parse(purchaseTxt.Text);
            decimal selling = decimal.Parse(sellingTxt.Text);
            if (string.IsNullOrEmpty(type) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(qtyTxt.Text) || string.IsNullOrEmpty(purchaseTxt.Text) || string.IsNullOrEmpty(sellingTxt.Text))
            {
                MessageBox.Show("Data Empty", "Create Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Model.Item newItem = new Model.Item
            {
                Types = type,
                Category = category,
                Quantity = qty,
                PurchasePrice = purchase,
                SellingPrice = selling,

            };
            bool isAdded = itemcontroller.AddProduct(newItem);

            if (isAdded)
            {
                MessageBox.Show("Item added successfully", "Create Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Index index = new Index();
                index.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Failed to add", "Create Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Create_Load(object sender, EventArgs e)
        {
            Load_combobox();
        }
        private void Load_combobox()
        {
            try
            {
                var categories = categorycontroller.GetAllCategories();
                categoryTxt.Items.Add("Select A Category");
                foreach (var category in categories)
                {
                    categoryTxt.Items.Add(category.Name.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            this.Hide();
        }
    }
}
