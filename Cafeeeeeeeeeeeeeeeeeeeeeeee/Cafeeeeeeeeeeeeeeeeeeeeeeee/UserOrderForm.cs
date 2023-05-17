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
    public partial class UserOrderForm : Form
    {
        SqlConnection sqlCon = new SqlConnection(DBCommon.ConString);
        public UserOrderForm()
        {
            InitializeComponent();
            usernameLabel.Text = Global.UserInfo.Username;
            LoadItems();

        }
        private void LoadItems()
        {
            sqlCon = CmnMethods.OpenConnectionString(sqlCon);
            string query = "SELECT * FROM Item";
            SqlDataAdapter  sda = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder  scb = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
            itemGridView.DataSource = dataset.Tables[0];
            sqlCon.Close();


            // Hide Coloumns
            itemGridView.Columns[0].Visible = false;
            itemGridView.Columns[5].Visible = false;
            itemGridView.Columns[6].Visible = false;
            itemGridView.Columns[7].Visible = false;
            itemGridView.Columns[8].Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
            CmnMethods.ResetGlobal();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm itemsForm = new ItemsForm();
            itemsForm.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
        }

        private void qtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '_'))
            {
                e.Handled = true;

            }
            // Only one decimal point
            if ((e.KeyChar == '_') && ((sender as TextBox).Text.IndexOf('_') > -1))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddToCart();
        }
        private void AddToCart()
        {
            if (qtyTextBox.Text.Trim() == "" || Convert.ToInt32(qtyTextBox.Text) == 0)
            {
                MessageBox.Show("Give Quantity");
                qtyTextBox.Focus();

            }
            else if (itemGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select Item");

            }
            else
            {
                DataGridViewRow  row = this.itemGridView.SelectedRows[0];

                int itemId = Convert.ToInt32(row.Cells["ItemId"].Value);
                string itemCode = row.Cells["ItemCode"].Value.ToString();
                string itemName = row.Cells["ItemName"].Value.ToString();
                string category = row.Cells["Category"].Value.ToString();
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                int rowIndex = -1;

                var orderTotalRows = orderGridView.Rows.Count;

                if (orderTotalRows > 1)
                {
                    //var orderRow = orderGridView.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["ItemId"].Value.ToString());
                    
                    for (int i = 0; i < orderGridView.Rows.Count - 1; i++)
                    {
                        if (orderGridView.Rows[i].Cells["ItemId"].Value.ToString() == itemId.ToString())
                        {
                            rowIndex = orderGridView.Rows[i].Index;
                            break;

                        }
                    }



                }
                int qty = Convert.ToInt32(qtyTextBox.Text);
                decimal amount = 0;
                if (rowIndex < 0)
                {
                    rowIndex = orderGridView.Rows.Add();

                }
                else
                {
                    int previousQty = (int)orderGridView.Rows[rowIndex].Cells["Qty"].Value;
                    qty += previousQty;
                }
                amount = qty * price;

                orderGridView.Rows[rowIndex].Cells["ItemId"].Value = itemId;
                orderGridView.Rows[rowIndex].Cells["ItemCode"].Value = itemCode;
                orderGridView.Rows[rowIndex].Cells["ItemId"].Value = itemId.ToString();
                orderGridView.Rows[rowIndex].Cells["ItemName"].Value = itemName;
                orderGridView.Rows[rowIndex].Cells["Category"].Value = category;
                orderGridView.Rows[rowIndex].Cells["UnitPrice"].Value = price;
                orderGridView.Rows[rowIndex].Cells["Qty"].Value = qty;
                orderGridView.Rows[rowIndex].Cells["Amount"].Value = amount;
                orderGridView.Rows[rowIndex]. Selected = true; 
                CalculateTotal();
            }

        }
        private void CalculateTotal()
        {
            decimal totalAmount = 0;
            for (int i = 0; i < orderGridView.Rows.Count - 1; i++)
            {
                totalAmount += Convert.ToDecimal(orderGridView.Rows[i].Cells["Amount "].Value);

            }
            LabelAmount.Text = totalAmount.ToString();

        }

        private void btnPlaceThisOrder_Click(object sender, EventArgs e)
        {
            if (Global.UserInfo.UserId == 0)

            {
                MessageBox.Show("Please login");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }

            else if (orderNoTextBox.Text.Trim() == "")

            {
                MessageBox.Show("Give order no.");
                orderNoTextBox.Focus();

            }

            else if (sellerTextBox.Text.Trim() == "")
            {

                MessageBox.Show("Give seller name.");
                sellerTextBox.Focus();

            }
            else
            {
                using (SqlConnection conn = new SqlConnection(DBCommon.ConString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();
                    try
                    {
                        string query = @"INSERT INTO UserOrder(OrderNo,SellerName,AddedDate,AddedBy) VALUES (@OrderNo,@SellerName,@AddedDate,@AddedBy);
                            SELECT SCOPE_IDENTITY();";

                        SqlCommand command = new SqlCommand(query, conn, transaction);

                        command.Parameters.AddWithValue("@OrderNo", orderNoTextBox.Text.Trim());
                        command.Parameters.AddWithValue("@SellerName", sellerTextBox.Text.Trim());
                        command.Parameters.AddWithValue("@AddedDate", DateTime.Now);
                        command.Parameters.AddWithValue("@AddedBy", Global.UserInfo.UserId);
                        int orderId = Convert.ToInt32(command.ExecuteScalar());

                        if (orderId > 0)
                        {
                            List<UserOrderDetail> userOrderDetails = new List<UserOrderDetail>();
                            for (int i = 0; i < orderGridView.Rows.Count - 1; i++)
                            {
                                var orderDetail = new UserOrderDetail()
                                {
                                    UserOrderId = 0,
                                    ItemId = Convert.ToInt32(orderGridView.Rows[i].Cells["ItemId"].Value),
                                    UnitPrice = Convert.ToDecimal(orderGridView.Rows[i].Cells["UnitPrice"].Value),
                                    Qty = Convert.ToInt32(orderGridView.Rows[i].Cells["Qty"].Value)

                                };


                                query = @"INSERT INTO UserOrderDetail (UserOrderId, ItemId, UnitPrice, Qty) VALUES (@UserOrderId, @ItemId, @UnitPrice,@Qty);";
                                command = new SqlCommand(query, conn, transaction);
                                command.Parameters.AddWithValue("@UserOrderId", orderId);
                                command.Parameters.AddWithValue("@ItemId", orderDetail.ItemId);
                                command.Parameters.AddWithValue("@UnitPrice", orderDetail.UnitPrice);
                                command.Parameters.AddWithValue("@Qty", orderDetail.Qty);
                                command.ExecuteNonQuery();















                            }
                        }
                        transaction.Commit();
                        MessageBox.Show("Order Placed.");







                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        transaction.Rollback();
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            } }

        private void categoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByCategory();
        }
        private void FilterByCategory()
        {
            sqlCon=CmnMethods.OpenConnectionString(sqlCon);
            string query=string.Format(@"SELECT*FROM Item WHERE UPPER (Category)=UPPER('{0})", categoryComboBox.SelectedItem.ToString());
            SqlDataAdapter sda=new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
            itemGridView.DataSource = dataSet.Tables[0];
            sqlCon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderViewForm orderViewForm = new OrderViewForm();
            orderViewForm.Show();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void orderGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

