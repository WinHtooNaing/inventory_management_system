using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using inventory_management_system.Model;
using inventory_management_system.View;
using Microsoft.Data.SqlClient;

namespace inventory_management_system
{
    public partial class Login : Form
    {
        private DatabaseConnection dbConnection;
        public Login()
        {

            InitializeComponent();
            dbConnection = new DatabaseConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = idTxt.Text;
            string pwd = pwdTxt.Text;
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Something Went Wrong!", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }
            try
            {
                dbConnection.OpenConnection();
                SqlConnection connection = dbConnection.GetConnection();
                string query = "select * from users where UserId=@UserId and Password=@Password";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserId", id);
                cmd.Parameters.AddWithValue("@Password", pwd);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string userName = reader["Name"].ToString();
                    string userId = reader["UserId"].ToString();
                    int role = int.Parse(reader["Role"].ToString());
                    reader.Close();
                    dbConnection.CloseConnection();
                    idTxt.Text = "";
                    pwdTxt.Text = "";
                    SessionStorage.Session.UserName = userName;
                    SessionStorage.Session.UserId = userId;
                    if (role == 1) {
                        MessageBox.Show("Login Successfully", "Login ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dashboard dashbaord = new Dashboard();
                        dashbaord.Show();
                        this.Hide();
                    }
                    if (role == 0)
                    {
                        MessageBox.Show("Login Successfully", "Login ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Seller.Dashboard dashboard = new Seller.Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }



                }
                else
                {
                    MessageBox.Show("Something Went Wrong!", "Login ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pwdTxt.PasswordChar = '\0';
            }
            else
            {
                pwdTxt.PasswordChar = '*';
            }
        }
    }
}
