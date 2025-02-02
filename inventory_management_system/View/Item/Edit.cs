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
    public partial class Edit : Form
    {
        private readonly int editId;
        private readonly ItemController itemController;
        public Edit(int id)
        {
            InitializeComponent();
            editId = id;
            itemController = new ItemController();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            LoadItemDetails();
        }
        private void LoadItemDetails()
        {
            try
            {



                // Fetch product by ID
                var item = itemController.GetItemById(editId);

                if (item != null)
                {
                    // Populate form fields with product details
                    typeTxt.Text = item.Types;
                    qtyTxt.Text = item.Quantity.ToString();
                    purchaseTxt.Text = item.PurchasePrice.ToString();
                    sellingTxt.Text = item.SellingPrice.ToString();
                }
                else
                {
                    MessageBox.Show("Item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading item details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string type = typeTxt.Text;
            int qty = int.Parse(qtyTxt.Text);
            decimal purchase = decimal.Parse(purchaseTxt.Text);
            decimal selling = decimal.Parse(sellingTxt.Text);
            if (string.IsNullOrEmpty(type) || string.IsNullOrEmpty(qtyTxt.Text) || string.IsNullOrEmpty(purchaseTxt.Text) || string.IsNullOrEmpty(sellingTxt.Text))
            {
                MessageBox.Show("Data Empty", "Create Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Model.Item newItem = new Model.Item
            {
                Id = editId,
                Types = type,
                Quantity = qty,
                PurchasePrice = purchase,
                SellingPrice = selling,

            };
            bool isAdded = itemController.UpdateItem(newItem);

            if (isAdded)
            {
                MessageBox.Show("Item updated successfully", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Index index = new Index();
                index.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Failed to update", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
