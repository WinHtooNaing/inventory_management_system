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

namespace inventory_management_system.View.Seller
{
    public partial class DailyRecord : Form
    {
        private readonly SellItemController sellItemController;
        private readonly string sellerName;
        public DailyRecord()
        {
            InitializeComponent();
            sellItemController = new SellItemController();
            sellerName = SessionStorage.Session.UserName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DailyRecord_Load(object sender, EventArgs e)
        {
            LoadDailyRecord();
        }
        private void LoadDailyRecord()
        {

            try
            {
                var items = sellItemController.DailyRecord(sellerName);

               

                dailyRecordGridView.DataSource = items;
                // Add a "No" column for numbering
                if (!dailyRecordGridView.Columns.Contains("No"))
                {
                    DataGridViewTextBoxColumn noColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "No",
                        HeaderText = "No",
                        ReadOnly = true
                    };
                    dailyRecordGridView.Columns.Insert(0, noColumn);
                }

                

                // Populate "No" column with sequential numbers
                for (int i = 0; i < dailyRecordGridView.Rows.Count; i++)
                {
                    dailyRecordGridView.Rows[i].Cells["No"].Value = i + 1;
                }

                // Customize the DataGridView
                dailyRecordGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Hide the "Id" column
                if (dailyRecordGridView.Columns.Contains("Id"))
                {
                    dailyRecordGridView.Columns["Id"].Visible = false; // Hide the ID column
                }
                if (dailyRecordGridView.Columns.Contains("CreatedAt"))
                {
                    dailyRecordGridView.Columns["CreatedAt"].Visible = false; // Hide the ID column
                }
                if (dailyRecordGridView.Columns.Contains("PurchasePrice"))
                {
                    dailyRecordGridView.Columns["PurchasePrice"].Visible = false; // Hide the ID column
                }
                if (dailyRecordGridView.Columns.Contains("SellerName"))
                {
                    dailyRecordGridView.Columns["SellerName"].Visible = false; // Hide the ID column
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
