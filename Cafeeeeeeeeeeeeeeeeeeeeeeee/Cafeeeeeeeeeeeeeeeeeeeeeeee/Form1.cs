using Cafeeeeeeeeeeeeeeeeeeeeeeee.Common;
using Cafeeeeeeeeeeeeeeeeeeeeeeee.DB;
using Cafeeeeeeeeeeeeeeeeeeeeeeee.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeeeeeeeeeeeeeeeeeeeeeeee
{
    public partial class Form1 : Form
    {
        SqlConnection sqlCon = new SqlConnection(DBCommon.ConString);
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Enter Username and Password");
            }
            else
            {
                sqlCon = CmnMethods.OpenConnectionString(sqlCon);
                string query = string.Format(@"SELECT * FROM UserInfo WHERE username='{0}' AND UserPassword='{1}'", txtUsername.Text.Trim(), txtPassword.Text.Trim());
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    UserOrderForm userOrderForm = new UserOrderForm();
                    userOrderForm.Show();
                    this.Hide();

                    CmnMethods.GetUserInfo(dataTable);

                    UserOrderForm userOrder = new UserOrderForm();
                    userOrder.Show();

                }
                else
                {
                    MessageBox.Show("Invalid Username and Password");

                }

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Fill Username ans Password");

            }
            else
            {
                sqlCon = CmnMethods.OpenConnectionString(sqlCon);
                string query = @"INSERT INTO UserInfo (Username,UserPassword,Contact,AddedDate,AddedBy) VALUES (@Username,@UserPassword,@Contact,@AddedDate,@AddedBy)";
                SqlCommand command = new SqlCommand(query, sqlCon);
                command.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                command.Parameters.AddWithValue("@UserPassword", txtPassword.Text.Trim());
                command.Parameters.AddWithValue("@Contact", "");
                command.Parameters.AddWithValue("@AddedDate", DateTime.Now);
                command.Parameters.AddWithValue("@AddedBy", Global.UserInfo.UserId);   
                command.ExecuteNonQuery();
                MessageBox.Show("Signup Succesfull. Now login.");
                sqlCon.Close();

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Global.UserInfo = new UserInfo();
            Global.UserInfo.Username = "Guest";

            UserOrderForm userOrderForm = new UserOrderForm();
            userOrderForm.Show();
            this.Hide();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
