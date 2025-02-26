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

namespace inventory_management_system.View
{
    public partial class Dashboard : Form
    {
        private readonly ProfitController profitController;
        public Dashboard()
        {
            InitializeComponent();
            profitController = new ProfitController();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Item.Index index = new Item.Index();
            //index.Show();
            //this.Hide();
            index.Visible = true;
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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dailySellingPriceTxt.Text = profitController.DailySellingPrice().ToString() + "(ကျပ်)";
            dailyProfitTxt.Text = profitController.DailyProfit().ToString() + "(ကျပ်)";
            monthlySellingPriceTxt.Text = profitController.MonthlySellingPrice().ToString() + "(ကျပ်)";
            monthlyProfitTxt.Text = profitController.MonthlyProfit().ToString() + "(ကျပ်)";




        }

        private void button6_Click(object sender, EventArgs e)
        {
            SessionStorage.Session.UserName = "";
            SessionStorage.Session.UserId = "";
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SellItem.Index index = new SellItem.Index();
            //index.Show();
            //this.Hide();
            index.Visible = true;
            this.Visible = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
