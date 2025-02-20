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

namespace inventory_management_system.View.General
{
    public partial class Edit : Form
    {
        private readonly int generalId;
        private readonly GeneralController generalController;
        public Edit(int id)
        {
            InitializeComponent();
            generalId = id;
            generalController = new GeneralController();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            LoadGeneralDetails();
        }
        private void LoadGeneralDetails()
        {
            try
            {




                var general = generalController.GetGeneralById(generalId);

                if (general != null)
                {
                    // Populate form fields with product details
                    nameTxt.Text = general.Name;
                    priceTxt.Text = general.Price.ToString();
                }
                else
                {
                    MessageBox.Show("General not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading General details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            decimal price = decimal.Parse(priceTxt.Text);
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(priceTxt.Text))
            {
                MessageBox.Show("invalid input", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            Model.General general = new Model.General
            {
                Id = generalId,
                Name = name,
                Price = price,
            };
            bool updateGeneral = generalController.UpdateGeneral(general);
            if (updateGeneral)
            {
                MessageBox.Show("Edit Successful", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Index index = new Index();
                index.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Edit Fail", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
