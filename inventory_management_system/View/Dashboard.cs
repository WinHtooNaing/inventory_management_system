using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_management_system.View
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Item.Index index = new Item.Index();
            index.Show();
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
    }
}
