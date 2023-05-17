﻿using Cafeeeeeeeeeeeeeeeeeeeeeeee.Common;
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
    public partial class OrderViewForm : Form
    {
        SqlConnection sqlCon = new SqlConnection(DBCommon.ConString);
        int orderId = 0;
        public OrderViewForm()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            sqlCon = CmnMethods.OpenConnectionString(sqlCon);
            string query = string.Format(@"SELECT * FROM View_UserOrder WHERE AddedBy = {0}", Global.UserInfo.UserId);
            if (Global.UserInfo.Username == "Admin")
            {
                query = string.Format(@"SELECT * FROM View_UserOrder");

            }
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
            orderGridView.DataSource = dataSet.Tables[0];
            sqlCon.Close();

            orderGridView.Columns[0].Visible = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void orderGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            orderId = Convert.ToInt32(this.orderGridView.Rows[e.RowIndex].Cells["UserOrderId"].Value);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            UserOrder userOrder = new UserOrder();
            List<UserOrderDetail> userOrderDetails = new List<UserOrderDetail>();

            if (orderId > 0)
            {
                sqlCon = CmnMethods.OpenConnectionString(sqlCon);
                string query = string.Format(@"SELECT * FROM View_UserOrder WHERE UserOrderId='{0}'", orderId);
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                sqlCon.Close();

                userOrder = this.GetOrder(dataTable);

                sqlCon = CmnMethods.OpenConnectionString(sqlCon);
                query = string.Format(@"SELECT * FROM View_UserOrderDetail WHERE UserOrderId='{0}'", orderId);
                sda = new SqlDataAdapter(query, sqlCon);
                dataTable = new DataTable();
                sda.Fill(dataTable);
                sqlCon.Close();

                userOrderDetails = this.GetOrderDetail(dataTable);

            }
            e.Graphics.DrawString("==Order Summary==", new Font("Century", 22, FontStyle.Bold), Brushes.Red, new Point(200, 40));
            e.Graphics.DrawString("Basic Information", new Font("Century", 18, FontStyle.Bold), Brushes.Red, new Point(200, 80));

            e.Graphics.DrawString("Order No : " + userOrder.OrderNo, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, 105));
            e.Graphics.DrawString("Seller :" + userOrder.SellerName, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, 125));
            e.Graphics.DrawString("Order Date :" + userOrder.OrderDate, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, 145));
            e.Graphics.DrawString("Order Time :" + userOrder.OrderTime, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, 165));
            e.Graphics.DrawString("Order By : " + userOrder.OrderBy, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, 185));
            e.Graphics.DrawString("Contact :" + userOrder.Contact, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, 205));

            e.Graphics.DrawString("Order Detail", new Font("Century", 18, FontStyle.Bold), Brushes.Red, new Point(200, 235));

            int rowGap = 20,
                lastPoint = 235;
            foreach (var userOrderDetail in userOrderDetails)
            {
                lastPoint += rowGap + 10;
                e.Graphics.DrawString("Code : " + userOrderDetail.ItemCode, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, lastPoint));
                lastPoint += rowGap;
                e.Graphics.DrawString("Item : " + userOrderDetail.ItemName, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, lastPoint));
                lastPoint += rowGap;
                e.Graphics.DrawString("Category :" + userOrderDetail.Category, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, lastPoint));
                lastPoint += rowGap;
                e.Graphics.DrawString("Unit Price :" + userOrderDetail.UnitPrice, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, lastPoint));
                lastPoint += rowGap;
                e.Graphics.DrawString("Qty :" + userOrderDetail.Qty, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, lastPoint));
                lastPoint += rowGap;
                e.Graphics.DrawString("Amount :" + userOrderDetail.UnitPrice * userOrderDetail.Qty, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(120, lastPoint));
            }
        }

        public UserOrder GetOrder(DataTable dt)
        {
            UserOrder userOrder = (from rw in dt.AsEnumerable()
                                   select new UserOrder()
                                   {
                                       UserOrderId = Convert.ToInt32(rw["UserOrderId"]),
                                       OrderNo = Convert.ToString(rw["OrderNo"]),
                                       SellerName = Convert.ToString(rw["SellerName"]),
                                       OrderDate = Convert.ToString(rw["OrderDate"]),
                                       OrderTime = Convert.ToString(rw["OrderTime"]),
                                       OrderBy = Convert.ToString(rw["OrderBy"]),
                                       Contact = Convert.ToString(rw["Contact"])
                                   }).ToList().FirstOrDefault();
            return userOrder;
        }
        public List<UserOrderDetail> GetOrderDetail(DataTable dt)
        {
            List<UserOrderDetail> userOrderDetails = (from rw in dt.AsEnumerable()
                                                      select new UserOrderDetail()
                                                      {
                                                          UserOrderDetailId = Convert.ToInt32(rw["UserOrderDetailId"]),
                                                          UserOrderId = Convert.ToInt32(rw["UserOrderId"]),
                                                          ItemId = Convert.ToInt32(rw["ItemId"]),
                                                          ItemCode = Convert.ToString(rw["ItemCode"]),
                                                          ItemName = Convert.ToString(rw["ItemName"]),
                                                          Category = Convert.ToString(rw["Category"]),
                                                          UnitPrice = Convert.ToDecimal(rw["UnitPrice"]),
                                                          Qty = Convert.ToInt32(rw["Qty"])
                                                      }).ToList();
            return userOrderDetails;

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByCategory();
        }
        private void FilterByCategory()
        {
            sqlCon = CmnMethods.OpenConnectionString(sqlCon);
            string query = string.Format(@"SELECT * FROM Item WHERE UPPER (Category)= UPPER('{0}')", categoryComboBox.SelectedItem.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder scb = new SqlCommandBuilder (sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
            orderGridView.DataSource = dataSet.Tables[0];
            sqlCon.Close();

        }

        private void OrderViewForm_Load(object sender, EventArgs e)
        {
            

        }
    } }

