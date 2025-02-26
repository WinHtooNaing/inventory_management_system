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
            string total_purchase_price = profitController.TotalCost().ToString();
            totalPurchasePriceTxt.Text = total_purchase_price + " (Kyats)";

            string total_income = profitController.TotalPrice("SELECT SUM(Quantity * SellingPrice) AS TotalPrice FROM Items;").ToString();
            totalIncomeTxt.Text = total_income + " (Kyats)";

            string total_income_for_now = profitController.TotalPrice("SELECT SUM(TotalPrice) AS TotalPrice FROM SellItem").ToString();
            totalIncomeforNTxt.Text = total_income_for_now + " (Kyats)";

            string profit = profitController.Profit().ToString();
            profitTxt.Text = profit + " (Kyats)";

            string daily_income = profitController.DailySale().ToString();  
            dailyIncomeTxt.Text = daily_income+" (Kyats)";



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
