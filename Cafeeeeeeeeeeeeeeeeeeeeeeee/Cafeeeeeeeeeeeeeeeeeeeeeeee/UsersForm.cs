using Cafeeeeeeeeeeeeeeeeeeeeeeee.Common;
using Cafeeeeeeeeeeeeeeeeeeeeeeee.DB;
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
    public partial class UsersForm : Form
    {
        SqlConnection sqlCon = new SqlConnection(DBCommon.ConString);
        public UsersForm()
        {
            InitializeComponent();
            usernameLabel.Text = Global.UserInfo.Username;
            LoadUsers();
        }

        private void LoadUsers()
        {
            sqlCon = CmnMethods.OpenConnectionString(sqlCon);
            string query = "SELECT * FROM UserInfo";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
            userGridView.DataSource = dataSet.Tables[0];
            sqlCon.Close();


            userGridView.Columns[0].Visible = false;
            userGridView.Columns[4].Visible = false;
            userGridView.Columns[5].Visible = false;
            userGridView.Columns[6].Visible = false;
            userGridView.Columns[7].Visible = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrderForm userOrderForm = new UserOrderForm();
            userOrderForm.Show();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm itemsForm = new ItemsForm();
            itemsForm.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtContact.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Fill all Fields");
            }
            else
            {
                sqlCon = CmnMethods.OpenConnectionString(sqlCon);
                string query = @"INSERT INTO Item (Username,Contact,UserPassword,AddedDate,AddedBy) VALUES (@Username,@Contact,@UserPassword,@AddedDate,@AddedBy)";
                SqlCommand command = new SqlCommand(query, sqlCon);
                command.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                command.Parameters.AddWithValue("@Contact", txtContact.Text.Trim());
                command.Parameters.AddWithValue("@UserPassword", txtPassword.Text.Trim());
                command.Parameters.AddWithValue("@AddedDate", DateTime.Now);
                command.Parameters.AddWithValue("@AddedBy", 1);
                command.ExecuteNonQuery();
                MessageBox.Show("User Created Succesfully");
                sqlCon.Close();
                LoadUsers();
                Reset();


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ( userIdTextBox.Text.Trim() == "" || Convert.ToInt32(userIdTextBox) == 0)
            {
                MessageBox.Show("Select an User");
            }
            else if (txtUsername.Text.Trim() == "" || txtContact.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Fill all Fields");
            }
            else
            {
                sqlCon = CmnMethods.OpenConnectionString(sqlCon);
                string query = @"UPDATE UserInfo SET Username = @Username, Contact = @Contact,UserPassword=@UserPassword WHERE UserId = @UserId";
                SqlCommand command = new SqlCommand(query, sqlCon);
                command.Parameters.AddWithValue("@UserId", userIdTextBox.Text.Trim());
                command.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                command.Parameters.AddWithValue("@Contact", txtContact.Text.Trim());
                command.Parameters.AddWithValue("@UserPassword", txtPassword.Text.Trim());
                command.Parameters.AddWithValue("@UpdatedDate", DateTime.Now);
                command.Parameters.AddWithValue("@UpdatedBy", 1);
                command.ExecuteNonQuery();
                MessageBox.Show("User Updated Succesfully");
                sqlCon.Close();
                LoadUsers();
                Reset();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (userIdTextBox.Text.Trim() == "" || Convert.ToInt32(userIdTextBox.Text) == 0)
            {
                MessageBox.Show("Select an User");

            }
            else
            {
                sqlCon = CmnMethods.OpenConnectionString(sqlCon);
                string query = string.Format(@"DELETE FROM userInfo WHERE UserId={0}", Convert.ToInt32(userIdTextBox.Text));
                SqlCommand command = new SqlCommand(query, sqlCon);
                command.ExecuteNonQuery();
                MessageBox.Show("User Deleted Succesfully");
                sqlCon.Close();
                LoadUsers();
                Reset();
            }
        }
        private void Reset()
        {
            userIdTextBox.Text = 0.ToString();
            txtUsername.Text = "";
            txtContact.Text = "";
            txtPassword.Text = "";
        }

        private void userGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            userIdTextBox.Text = userGridView.Rows[e.RowIndex].Cells["UserId"].Value.ToString();
            txtUsername.Text = userGridView.Rows[e.RowIndex].Cells["Username"].Value.ToString();
            txtContact.Text = userGridView.Rows[e.RowIndex].Cells["Contact"].Value.ToString();
            txtPassword.Text = userGridView.Rows[e.RowIndex].Cells["UserPassword"].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'billBillDataSet.UserInfo' table. You can move, or remove it, as needed.
            this.userInfoTableAdapter.Fill(this.billBillDataSet.UserInfo);

        }

        private void Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
            CmnMethods.ResetGlobal();
        }

        private void userGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
