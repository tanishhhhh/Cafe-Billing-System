namespace Cafeeeeeeeeeeeeeeeeeeeeeeee
{
    partial class UsersForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblX = new System.Windows.Forms.Label();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billBillDataSet = new Cafeeeeeeeeeeeeeeeeeeeeeeee.BillBillDataSet();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.LinkLabel();
            this.userInfoTableAdapter = new Cafeeeeeeeeeeeeeeeeeeeeeeee.BillBillDataSetTableAdapters.UserInfoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBillDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.lblX);
            this.panel1.Controls.Add(this.userIdTextBox);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.userGridView);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Location = new System.Drawing.Point(136, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 575);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblX.Location = new System.Drawing.Point(900, 10);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 17);
            this.lblX.TabIndex = 14;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Location = new System.Drawing.Point(176, 89);
            this.userIdTextBox.Multiline = true;
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.ReadOnly = true;
            this.userIdTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userIdTextBox.Size = new System.Drawing.Size(144, 22);
            this.userIdTextBox.TabIndex = 13;
            this.userIdTextBox.Visible = false;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(167, 178);
            this.txtContact.Multiline = true;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(144, 22);
            this.txtContact.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(167, 220);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(144, 22);
            this.txtPassword.TabIndex = 11;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(167, 130);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(144, 22);
            this.txtUsername.TabIndex = 10;
            // 
            // userGridView
            // 
            this.userGridView.AutoGenerateColumns = false;
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.userPasswordDataGridViewTextBoxColumn,
            this.addedDateDataGridViewTextBoxColumn,
            this.addedByDataGridViewTextBoxColumn,
            this.updatedDateDataGridViewTextBoxColumn,
            this.updatedByDataGridViewTextBoxColumn});
            this.userGridView.DataSource = this.userInfoBindingSource;
            this.userGridView.Location = new System.Drawing.Point(396, 89);
            this.userGridView.Name = "userGridView";
            this.userGridView.RowTemplate.Height = 24;
            this.userGridView.Size = new System.Drawing.Size(521, 457);
            this.userGridView.TabIndex = 9;
            this.userGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userGridView_CellContentClick);
            this.userGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userGridView_CellDoubleClick);
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // userPasswordDataGridViewTextBoxColumn
            // 
            this.userPasswordDataGridViewTextBoxColumn.DataPropertyName = "UserPassword";
            this.userPasswordDataGridViewTextBoxColumn.HeaderText = "UserPassword";
            this.userPasswordDataGridViewTextBoxColumn.Name = "userPasswordDataGridViewTextBoxColumn";
            // 
            // addedDateDataGridViewTextBoxColumn
            // 
            this.addedDateDataGridViewTextBoxColumn.DataPropertyName = "AddedDate";
            this.addedDateDataGridViewTextBoxColumn.HeaderText = "AddedDate";
            this.addedDateDataGridViewTextBoxColumn.Name = "addedDateDataGridViewTextBoxColumn";
            // 
            // addedByDataGridViewTextBoxColumn
            // 
            this.addedByDataGridViewTextBoxColumn.DataPropertyName = "AddedBy";
            this.addedByDataGridViewTextBoxColumn.HeaderText = "AddedBy";
            this.addedByDataGridViewTextBoxColumn.Name = "addedByDataGridViewTextBoxColumn";
            // 
            // updatedDateDataGridViewTextBoxColumn
            // 
            this.updatedDateDataGridViewTextBoxColumn.DataPropertyName = "UpdatedDate";
            this.updatedDateDataGridViewTextBoxColumn.HeaderText = "UpdatedDate";
            this.updatedDateDataGridViewTextBoxColumn.Name = "updatedDateDataGridViewTextBoxColumn";
            // 
            // updatedByDataGridViewTextBoxColumn
            // 
            this.updatedByDataGridViewTextBoxColumn.DataPropertyName = "UpdatedBy";
            this.updatedByDataGridViewTextBoxColumn.HeaderText = "UpdatedBy";
            this.updatedByDataGridViewTextBoxColumn.Name = "updatedByDataGridViewTextBoxColumn";
            // 
            // userInfoBindingSource
            // 
            this.userInfoBindingSource.DataMember = "UserInfo";
            this.userInfoBindingSource.DataSource = this.billBillDataSet;
            // 
            // billBillDataSet
            // 
            this.billBillDataSet.DataSetName = "BillBillDataSet";
            this.billBillDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnDelete.Location = new System.Drawing.Point(262, 280);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 33);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnUpdate.Location = new System.Drawing.Point(134, 280);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 33);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnAddUser.Location = new System.Drawing.Point(13, 280);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(102, 33);
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumPurple;
            this.label5.Location = new System.Drawing.Point(341, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumPurple;
            this.label4.Location = new System.Drawing.Point(529, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Users List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(21, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(21, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.usernameLabel.Location = new System.Drawing.Point(21, 130);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(140, 29);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnOrder.Location = new System.Drawing.Point(12, 121);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(102, 33);
            this.btnOrder.TabIndex = 9;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnItems
            // 
            this.btnItems.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnItems.Location = new System.Drawing.Point(12, 173);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(102, 33);
            this.btnItems.TabIndex = 10;
            this.btnItems.Text = "Items";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.LinkColor = System.Drawing.Color.White;
            this.Logout.Location = new System.Drawing.Point(13, 516);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(100, 29);
            this.Logout.TabIndex = 11;
            this.Logout.TabStop = true;
            this.Logout.Text = "Logout";
            this.Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout_LinkClicked);
            // 
            // userInfoTableAdapter
            // 
            this.userInfoTableAdapter.ClearBeforeFill = true;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1065, 573);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBillDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.LinkLabel Logout;
        private BillBillDataSet billBillDataSet;
        private System.Windows.Forms.BindingSource userInfoBindingSource;
        private BillBillDataSetTableAdapters.UserInfoTableAdapter userInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedByDataGridViewTextBoxColumn;
    }
}