namespace Cafeeeeeeeeeeeeeeeeeeeeeeee
{
    partial class OrderViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderViewForm));
            this.label1 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.billBillDataSet1 = new Cafeeeeeeeeeeeeeeeeeeeeeeee.BillBillDataSet1();
            this.viewUserOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_UserOrderTableAdapter = new Cafeeeeeeeeeeeeeeeeeeeeeeee.BillBillDataSet1TableAdapters.View_UserOrderTableAdapter();
            this.billBillDataSet2 = new Cafeeeeeeeeeeeeeeeeeeeeeeee.BillBillDataSet2();
            this.viewUserOrderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.view_UserOrderTableAdapter1 = new Cafeeeeeeeeeeeeeeeeeeeeeeee.BillBillDataSet2TableAdapters.View_UserOrderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBillDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUserOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBillDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUserOrderBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order List";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "FOOD",
            "BEVARAGES"});
            this.categoryComboBox.Location = new System.Drawing.Point(134, 82);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(440, 24);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.Text = "Category";
            this.categoryComboBox.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // orderGridView
            // 
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Location = new System.Drawing.Point(40, 112);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.RowTemplate.Height = 24;
            this.orderGridView.Size = new System.Drawing.Size(597, 382);
            this.orderGridView.TabIndex = 2;
            this.orderGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderGridView_CellDoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnClose.Location = new System.Drawing.Point(264, 512);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // billBillDataSet1
            // 
            this.billBillDataSet1.DataSetName = "BillBillDataSet1";
            this.billBillDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewUserOrderBindingSource
            // 
            this.viewUserOrderBindingSource.DataMember = "View_UserOrder";
            this.viewUserOrderBindingSource.DataSource = this.billBillDataSet1;
            // 
            // view_UserOrderTableAdapter
            // 
            this.view_UserOrderTableAdapter.ClearBeforeFill = true;
            // 
            // billBillDataSet2
            // 
            this.billBillDataSet2.DataSetName = "BillBillDataSet2";
            this.billBillDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewUserOrderBindingSource1
            // 
            this.viewUserOrderBindingSource1.DataMember = "View_UserOrder";
            this.viewUserOrderBindingSource1.DataSource = this.billBillDataSet2;
            // 
            // view_UserOrderTableAdapter1
            // 
            this.view_UserOrderTableAdapter1.ClearBeforeFill = true;
            // 
            // OrderViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(673, 582);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.orderGridView);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderViewForm";
            this.Load += new System.EventHandler(this.OrderViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBillDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUserOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBillDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUserOrderBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private BillBillDataSet1 billBillDataSet1;
        private System.Windows.Forms.BindingSource viewUserOrderBindingSource;
        private BillBillDataSet1TableAdapters.View_UserOrderTableAdapter view_UserOrderTableAdapter;
        private BillBillDataSet2 billBillDataSet2;
        private System.Windows.Forms.BindingSource viewUserOrderBindingSource1;
        private BillBillDataSet2TableAdapters.View_UserOrderTableAdapter view_UserOrderTableAdapter1;
    }
}