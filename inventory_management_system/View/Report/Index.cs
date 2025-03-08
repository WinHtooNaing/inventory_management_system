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

namespace inventory_management_system.View.Report
{
    public partial class Index : Form
    {
        private readonly ProfitController profitController;
        public Index()
        {
            InitializeComponent();
            profitController = new ProfitController();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SessionStorage.Session.UserName = "";
            SessionStorage.Session.UserId = "";
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Item.Index index = new Item.Index();
            index.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            UserManagement.Index index = new UserManagement.Index();
            index.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Employee.Index index = new Employee.Index();
            index.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            General.Index index = new General.Index();
            index.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SellItem.Index index = new SellItem.Index();
            index.Show();

            this.Hide();
        }

        private void ရောင်းရငွေ_Click(object sender, EventArgs e)
        {

        }

        private void Index_Load(object sender, EventArgs e)
        {
            sellingTxt.Text = profitController.MonthlySellingPrice().ToString() + " ကျပ်";
            purchaseTxt.Text = profitController.MonthlyPurchasePrice().ToString() + " ကျပ်";
            generalTxt.Text = profitController.MonthlyGeneralPrice().ToString() + " ကျပ်";
            salaryTxt.Text = profitController.MonthlyTotalSalary().ToString() + " ကျပ်";
            profitTxt.Text = profitController.MonthlyProfit().ToString() + " ကျပ်";
        }
    }
}
