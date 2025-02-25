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
        public Create()
        {
            InitializeComponent();
            itemcontroller = new ItemController();
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
            string type = typeTxt.Text;
            string category = categoryTxt.SelectedItem.ToString();
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

        }
    }
}
