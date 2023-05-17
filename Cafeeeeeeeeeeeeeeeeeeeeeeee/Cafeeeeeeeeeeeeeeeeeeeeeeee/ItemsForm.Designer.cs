namespace Cafeeeeeeeeeeeeeeeeeeeeeeee
{
    partial class ItemsForm
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
            this.itemIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemCodeTextBox = new System.Windows.Forms.TextBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.itemPriceTextBox = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.itemCode = new System.Windows.Forms.Label();
            this.btnPlaceOrders = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.LinkLabel();
            this.lblX = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.itemIdTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.categoryComboBox);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.itemNameTextBox);
            this.panel1.Controls.Add(this.itemCodeTextBox);
            this.panel1.Controls.Add(this.btnDeleteItem);
            this.panel1.Controls.Add(this.btnEditItem);
            this.panel1.Controls.Add(this.btnAddItem);
            this.panel1.Controls.Add(this.itemGridView);
            this.panel1.Controls.Add(this.itemPriceTextBox);
            this.panel1.Controls.Add(this.itemName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.itemCode);
            this.panel1.Location = new System.Drawing.Point(136, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 539);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // itemIdTextBox
            // 
            this.itemIdTextBox.Location = new System.Drawing.Point(191, 131);
            this.itemIdTextBox.Name = "itemIdTextBox";
            this.itemIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.itemIdTextBox.TabIndex = 13;
            this.itemIdTextBox.Visible = false;
            this.itemIdTextBox.TextChanged += new System.EventHandler(this.itemIdTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(23, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Item Id :";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Food",
            "Beverages",
            "C1"});
            this.categoryComboBox.Location = new System.Drawing.Point(28, 251);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(284, 24);
            this.categoryComboBox.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(171, 291);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 10;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(191, 214);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.itemNameTextBox.TabIndex = 9;
            // 
            // itemCodeTextBox
            // 
            this.itemCodeTextBox.Location = new System.Drawing.Point(191, 173);
            this.itemCodeTextBox.Name = "itemCodeTextBox";
            this.itemCodeTextBox.Size = new System.Drawing.Size(100, 22);
            this.itemCodeTextBox.TabIndex = 8;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnDeleteItem.Location = new System.Drawing.Point(250, 380);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(75, 50);
            this.btnDeleteItem.TabIndex = 7;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditItem.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnEditItem.Location = new System.Drawing.Point(139, 380);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(75, 50);
            this.btnEditItem.TabIndex = 6;
            this.btnEditItem.Text = "Edit Item";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.EditItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnAddItem.Location = new System.Drawing.Point(28, 380);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(77, 50);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // itemGridView
            // 
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Location = new System.Drawing.Point(368, 63);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.RowTemplate.Height = 24;
            this.itemGridView.Size = new System.Drawing.Size(723, 450);
            this.itemGridView.TabIndex = 4;
            this.itemGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemGridView_CellContentClick);
            this.itemGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemGridView_CellDoubleClick);
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.AutoSize = true;
            this.itemPriceTextBox.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPriceTextBox.ForeColor = System.Drawing.Color.MediumPurple;
            this.itemPriceTextBox.Location = new System.Drawing.Point(3, 286);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(157, 29);
            this.itemPriceTextBox.TabIndex = 2;
            this.itemPriceTextBox.Text = "Item Price :";
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.ForeColor = System.Drawing.Color.MediumPurple;
            this.itemName.Location = new System.Drawing.Point(20, 214);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(165, 29);
            this.itemName.TabIndex = 1;
            this.itemName.Text = "Item Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumPurple;
            this.label4.Location = new System.Drawing.Point(669, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "ItemList";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // itemCode
            // 
            this.itemCode.AutoSize = true;
            this.itemCode.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCode.ForeColor = System.Drawing.Color.MediumPurple;
            this.itemCode.Location = new System.Drawing.Point(23, 173);
            this.itemCode.Name = "itemCode";
            this.itemCode.Size = new System.Drawing.Size(155, 29);
            this.itemCode.TabIndex = 0;
            this.itemCode.Text = "Item Code :";
            // 
            // btnPlaceOrders
            // 
            this.btnPlaceOrders.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrders.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnPlaceOrders.Location = new System.Drawing.Point(12, 97);
            this.btnPlaceOrders.Name = "btnPlaceOrders";
            this.btnPlaceOrders.Size = new System.Drawing.Size(101, 67);
            this.btnPlaceOrders.TabIndex = 1;
            this.btnPlaceOrders.Text = "Place Orders";
            this.btnPlaceOrders.UseVisualStyleBackColor = true;
            this.btnPlaceOrders.Click += new System.EventHandler(this.btnPlaceOrders_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnUsers.Location = new System.Drawing.Point(12, 188);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(101, 61);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(442, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 49);
            this.label5.TabIndex = 4;
            this.label5.Text = "Manage Items";
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.LinkColor = System.Drawing.Color.White;
            this.Logout.Location = new System.Drawing.Point(12, 538);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(93, 29);
            this.Logout.TabIndex = 5;
            this.Logout.TabStop = true;
            this.Logout.Text = "Logout";
            this.Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout_LinkClicked);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.ForeColor = System.Drawing.Color.White;
            this.lblX.Location = new System.Drawing.Point(1264, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 17);
            this.lblX.TabIndex = 6;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(1029, 34);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(12, 17);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = ".";
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1302, 632);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnPlaceOrders);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemsForm";
            this.Load += new System.EventHandler(this.ItemsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox itemCodeTextBox;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView itemGridView;
        private System.Windows.Forms.Label itemPriceTextBox;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label itemCode;
        private System.Windows.Forms.Button btnPlaceOrders;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel Logout;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox itemIdTextBox;
        private System.Windows.Forms.Label label1;
    }
}