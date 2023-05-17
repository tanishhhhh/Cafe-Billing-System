namespace Cafeeeeeeeeeeeeeeeeeeeeeeee
{
    partial class UserOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.sellerTextBox = new System.Windows.Forms.TextBox();
            this.orderNoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelAmount = new System.Windows.Forms.Label();
            this.btnPlaceThisOrder = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.txtamount);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnAddToCart);
            this.panel1.Controls.Add(this.qtyTextBox);
            this.panel1.Controls.Add(this.sellerTextBox);
            this.panel1.Controls.Add(this.orderNoTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LabelAmount);
            this.panel1.Controls.Add(this.btnPlaceThisOrder);
            this.panel1.Controls.Add(this.btnViewOrders);
            this.panel1.Controls.Add(this.categoryComboBox);
            this.panel1.Controls.Add(this.itemGridView);
            this.panel1.Controls.Add(this.orderGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(147, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 574);
            this.panel1.TabIndex = 0;
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(648, 514);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(152, 22);
            this.txtamount.TabIndex = 17;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(661, 515);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(46, 17);
            this.usernameLabel.TabIndex = 16;
            this.usernameLabel.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumPurple;
            this.label7.Location = new System.Drawing.Point(892, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnAddToCart.Location = new System.Drawing.Point(620, 201);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(185, 33);
            this.btnAddToCart.TabIndex = 14;
            this.btnAddToCart.Text = "Add to cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.button3_Click);
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Location = new System.Drawing.Point(462, 206);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(152, 22);
            this.qtyTextBox.TabIndex = 13;
            this.qtyTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.qtyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qtyTextBox_KeyPress);
            // 
            // sellerTextBox
            // 
            this.sellerTextBox.Location = new System.Drawing.Point(535, 161);
            this.sellerTextBox.Name = "sellerTextBox";
            this.sellerTextBox.Size = new System.Drawing.Size(243, 22);
            this.sellerTextBox.TabIndex = 12;
            // 
            // orderNoTextBox
            // 
            this.orderNoTextBox.Location = new System.Drawing.Point(535, 120);
            this.orderNoTextBox.Name = "orderNoTextBox";
            this.orderNoTextBox.Size = new System.Drawing.Size(243, 22);
            this.orderNoTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumPurple;
            this.label6.Location = new System.Drawing.Point(617, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Place to order";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumPurple;
            this.label5.Location = new System.Drawing.Point(400, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Qty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumPurple;
            this.label4.Location = new System.Drawing.Point(400, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Seller";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(400, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Order No";
            // 
            // LabelAmount
            // 
            this.LabelAmount.AutoSize = true;
            this.LabelAmount.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAmount.ForeColor = System.Drawing.Color.MediumPurple;
            this.LabelAmount.Location = new System.Drawing.Point(448, 507);
            this.LabelAmount.Name = "LabelAmount";
            this.LabelAmount.Size = new System.Drawing.Size(194, 29);
            this.LabelAmount.TabIndex = 6;
            this.LabelAmount.Text = "Order Amount";
            // 
            // btnPlaceThisOrder
            // 
            this.btnPlaceThisOrder.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceThisOrder.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnPlaceThisOrder.Location = new System.Drawing.Point(227, 507);
            this.btnPlaceThisOrder.Name = "btnPlaceThisOrder";
            this.btnPlaceThisOrder.Size = new System.Drawing.Size(172, 40);
            this.btnPlaceThisOrder.TabIndex = 5;
            this.btnPlaceThisOrder.Text = "Place Order";
            this.btnPlaceThisOrder.UseVisualStyleBackColor = true;
            this.btnPlaceThisOrder.Click += new System.EventHandler(this.btnPlaceThisOrder_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnViewOrders.Location = new System.Drawing.Point(15, 507);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(188, 40);
            this.btnViewOrders.TabIndex = 4;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.button1_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "FOOD",
            "BEVARAGES"});
            this.categoryComboBox.Location = new System.Drawing.Point(24, 82);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(334, 35);
            this.categoryComboBox.TabIndex = 3;
            this.categoryComboBox.Text = "Category";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            this.categoryComboBox.SelectionChangeCommitted += new System.EventHandler(this.categoryComboBox_SelectionChangeCommitted);
            // 
            // itemGridView
            // 
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Location = new System.Drawing.Point(368, 253);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.RowTemplate.Height = 24;
            this.itemGridView.Size = new System.Drawing.Size(538, 223);
            this.itemGridView.TabIndex = 2;
            // 
            // orderGridView
            // 
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Location = new System.Drawing.Point(15, 141);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.RowTemplate.Height = 24;
            this.orderGridView.Size = new System.Drawing.Size(334, 335);
            this.orderGridView.TabIndex = 1;
            this.orderGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Order";
            // 
            // btnUsers
            // 
            this.btnUsers.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnUsers.Location = new System.Drawing.Point(12, 113);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(129, 40);
            this.btnUsers.TabIndex = 6;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnItems
            // 
            this.btnItems.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnItems.Location = new System.Drawing.Point(12, 53);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(129, 40);
            this.btnItems.TabIndex = 7;
            this.btnItems.Text = "Items";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(21, 534);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 29);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // UserOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1065, 573);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserOrderForm";
            this.Load += new System.EventHandler(this.UserOrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.TextBox sellerTextBox;
        private System.Windows.Forms.TextBox orderNoTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelAmount;
        private System.Windows.Forms.Button btnPlaceThisOrder;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.DataGridView itemGridView;
        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox txtamount;
    }
}