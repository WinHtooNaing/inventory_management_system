﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using inventory_management_system.Controller;

namespace inventory_management_system.View.General
{
    public partial class Create : Form
    {
        private readonly GeneralController generalController;
        public Create()
        {
            InitializeComponent();
            generalController = new GeneralController();
        }

        private void Create_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            decimal price = decimal.Parse(priceTxt.Text);
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(priceTxt.Text) )
            {
                MessageBox.Show("invalid input", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            Model.General general = new Model.General
            {
                Name = name,
                Price = price,
            };
            bool AddGeneral = generalController.AddGeneral(general);
            if (AddGeneral)
            {
                MessageBox.Show("Add Successful", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Index index = new Index();
                index.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Add Fail", "Added", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
