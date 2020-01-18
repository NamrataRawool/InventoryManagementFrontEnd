﻿namespace InventoryManagement.UI.UserControls
{
    partial class PurchaseControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Purchase_ProductsDataView = new System.Windows.Forms.DataGridView();
            this.PurchaseTable_ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTable_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTable_PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTable_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTable_Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_transactionHistory = new System.Windows.Forms.TabPage();
            this.lbl_transactionError = new System.Windows.Forms.Label();
            this.btn_exportToExcel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_searchByCustomerName = new System.Windows.Forms.Button();
            this.cb_customerName = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_searchByDate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTime_toDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTime_fromDate = new System.Windows.Forms.DateTimePicker();
            this.TransactionHistoryDataView = new System.Windows.Forms.DataGridView();
            this.Purchase_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase_VendorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase_TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseTabControl = new System.Windows.Forms.TabControl();
            this.tab_newPurchase = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.purchase_dateTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_vendorName = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.gb_billDetails = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_errorAmountPaid = new System.Windows.Forms.Label();
            this.btn_ViewPuchaseBill = new System.Windows.Forms.Button();
            this.tb_subtotal = new System.Windows.Forms.TextBox();
            this.tb_AmountPaid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_amountDue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_totalTax = new System.Windows.Forms.TextBox();
            this.tb_totalDiscount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_availableStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_discount = new System.Windows.Forms.TextBox();
            this.lbl_errorText = new System.Windows.Forms.Label();
            this.cb_productName = new System.Windows.Forms.ComboBox();
            this.tb_purchasePrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_barCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Purchase_ProductsDataView)).BeginInit();
            this.tab_transactionHistory.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionHistoryDataView)).BeginInit();
            this.purchaseTabControl.SuspendLayout();
            this.tab_newPurchase.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gb_billDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Purchase_ProductsDataView
            // 
            this.Purchase_ProductsDataView.AllowUserToAddRows = false;
            this.Purchase_ProductsDataView.AllowUserToDeleteRows = false;
            this.Purchase_ProductsDataView.AllowUserToOrderColumns = true;
            this.Purchase_ProductsDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Purchase_ProductsDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Purchase_ProductsDataView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Purchase_ProductsDataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Purchase_ProductsDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Purchase_ProductsDataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Purchase_ProductsDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Purchase_ProductsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Purchase_ProductsDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchaseTable_ProductId,
            this.PurchaseTable_Name,
            this.PurchaseTable_PurchasePrice,
            this.PurchaseTable_Quantity,
            this.PurchaseTable_Discount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Purchase_ProductsDataView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Purchase_ProductsDataView.GridColor = System.Drawing.Color.Black;
            this.Purchase_ProductsDataView.Location = new System.Drawing.Point(25, 319);
            this.Purchase_ProductsDataView.MultiSelect = false;
            this.Purchase_ProductsDataView.Name = "Purchase_ProductsDataView";
            this.Purchase_ProductsDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Purchase_ProductsDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Purchase_ProductsDataView.RowHeadersVisible = false;
            this.Purchase_ProductsDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.Purchase_ProductsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Purchase_ProductsDataView.Size = new System.Drawing.Size(716, 349);
            this.Purchase_ProductsDataView.TabIndex = 25;
            this.Purchase_ProductsDataView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Purchase_ProductsDataView_KeyDown);
            // 
            // PurchaseTable_ProductId
            // 
            this.PurchaseTable_ProductId.HeaderText = "ID";
            this.PurchaseTable_ProductId.Name = "PurchaseTable_ProductId";
            this.PurchaseTable_ProductId.ReadOnly = true;
            // 
            // PurchaseTable_Name
            // 
            this.PurchaseTable_Name.HeaderText = "Product Name";
            this.PurchaseTable_Name.Name = "PurchaseTable_Name";
            this.PurchaseTable_Name.ReadOnly = true;
            // 
            // PurchaseTable_PurchasePrice
            // 
            this.PurchaseTable_PurchasePrice.HeaderText = "Purchase Price";
            this.PurchaseTable_PurchasePrice.Name = "PurchaseTable_PurchasePrice";
            this.PurchaseTable_PurchasePrice.ReadOnly = true;
            // 
            // PurchaseTable_Quantity
            // 
            this.PurchaseTable_Quantity.HeaderText = "Quantity";
            this.PurchaseTable_Quantity.Name = "PurchaseTable_Quantity";
            // 
            // PurchaseTable_Discount
            // 
            this.PurchaseTable_Discount.HeaderText = "Discount";
            this.PurchaseTable_Discount.Name = "PurchaseTable_Discount";
            this.PurchaseTable_Discount.ReadOnly = true;
            // 
            // tab_transactionHistory
            // 
            this.tab_transactionHistory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab_transactionHistory.Controls.Add(this.lbl_transactionError);
            this.tab_transactionHistory.Controls.Add(this.btn_exportToExcel);
            this.tab_transactionHistory.Controls.Add(this.groupBox3);
            this.tab_transactionHistory.Controls.Add(this.groupBox2);
            this.tab_transactionHistory.Controls.Add(this.TransactionHistoryDataView);
            this.tab_transactionHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_transactionHistory.Location = new System.Drawing.Point(4, 54);
            this.tab_transactionHistory.Name = "tab_transactionHistory";
            this.tab_transactionHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tab_transactionHistory.Size = new System.Drawing.Size(1295, 724);
            this.tab_transactionHistory.TabIndex = 1;
            this.tab_transactionHistory.Text = "Purchase History";
            // 
            // lbl_transactionError
            // 
            this.lbl_transactionError.AutoSize = true;
            this.lbl_transactionError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transactionError.ForeColor = System.Drawing.Color.Red;
            this.lbl_transactionError.Location = new System.Drawing.Point(490, 253);
            this.lbl_transactionError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_transactionError.Name = "lbl_transactionError";
            this.lbl_transactionError.Size = new System.Drawing.Size(0, 16);
            this.lbl_transactionError.TabIndex = 30;
            // 
            // btn_exportToExcel
            // 
            this.btn_exportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportToExcel.Location = new System.Drawing.Point(1063, 379);
            this.btn_exportToExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exportToExcel.Name = "btn_exportToExcel";
            this.btn_exportToExcel.Size = new System.Drawing.Size(175, 33);
            this.btn_exportToExcel.TabIndex = 29;
            this.btn_exportToExcel.Text = "Export To Excel";
            this.btn_exportToExcel.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_searchByCustomerName);
            this.groupBox3.Controls.Add(this.cb_customerName);
            this.groupBox3.Location = new System.Drawing.Point(277, 153);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(703, 88);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vendor Name";
            // 
            // btn_searchByCustomerName
            // 
            this.btn_searchByCustomerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchByCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchByCustomerName.Location = new System.Drawing.Point(469, 37);
            this.btn_searchByCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.btn_searchByCustomerName.Name = "btn_searchByCustomerName";
            this.btn_searchByCustomerName.Size = new System.Drawing.Size(175, 33);
            this.btn_searchByCustomerName.TabIndex = 31;
            this.btn_searchByCustomerName.Text = "Search";
            this.btn_searchByCustomerName.UseVisualStyleBackColor = true;
            // 
            // cb_customerName
            // 
            this.cb_customerName.DropDownHeight = 80;
            this.cb_customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_customerName.FormattingEnabled = true;
            this.cb_customerName.IntegralHeight = false;
            this.cb_customerName.Location = new System.Drawing.Point(136, 37);
            this.cb_customerName.Margin = new System.Windows.Forms.Padding(2);
            this.cb_customerName.Name = "cb_customerName";
            this.cb_customerName.Size = new System.Drawing.Size(278, 25);
            this.cb_customerName.TabIndex = 0;
            this.cb_customerName.Text = "Select Vendor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_searchByDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.DateTime_toDate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DateTime_fromDate);
            this.groupBox2.Location = new System.Drawing.Point(75, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1055, 97);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Date";
            // 
            // btn_searchByDate
            // 
            this.btn_searchByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchByDate.Location = new System.Drawing.Point(830, 37);
            this.btn_searchByDate.Margin = new System.Windows.Forms.Padding(2);
            this.btn_searchByDate.Name = "btn_searchByDate";
            this.btn_searchByDate.Size = new System.Drawing.Size(175, 33);
            this.btn_searchByDate.TabIndex = 30;
            this.btn_searchByDate.Text = "Search";
            this.btn_searchByDate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // DateTime_toDate
            // 
            this.DateTime_toDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime_toDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime_toDate.Location = new System.Drawing.Point(550, 43);
            this.DateTime_toDate.Margin = new System.Windows.Forms.Padding(2);
            this.DateTime_toDate.Name = "DateTime_toDate";
            this.DateTime_toDate.Size = new System.Drawing.Size(233, 23);
            this.DateTime_toDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // DateTime_fromDate
            // 
            this.DateTime_fromDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime_fromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime_fromDate.Location = new System.Drawing.Point(129, 43);
            this.DateTime_fromDate.Margin = new System.Windows.Forms.Padding(2);
            this.DateTime_fromDate.Name = "DateTime_fromDate";
            this.DateTime_fromDate.Size = new System.Drawing.Size(233, 23);
            this.DateTime_fromDate.TabIndex = 0;
            // 
            // TransactionHistoryDataView
            // 
            this.TransactionHistoryDataView.AllowUserToAddRows = false;
            this.TransactionHistoryDataView.AllowUserToOrderColumns = true;
            this.TransactionHistoryDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TransactionHistoryDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TransactionHistoryDataView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.TransactionHistoryDataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TransactionHistoryDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.TransactionHistoryDataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TransactionHistoryDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TransactionHistoryDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionHistoryDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Purchase_Date,
            this.Purchase_ID,
            this.Purchase_VendorName,
            this.Purchase_TotalPrice});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TransactionHistoryDataView.DefaultCellStyle = dataGridViewCellStyle5;
            this.TransactionHistoryDataView.GridColor = System.Drawing.Color.Black;
            this.TransactionHistoryDataView.Location = new System.Drawing.Point(128, 285);
            this.TransactionHistoryDataView.MultiSelect = false;
            this.TransactionHistoryDataView.Name = "TransactionHistoryDataView";
            this.TransactionHistoryDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransactionHistoryDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TransactionHistoryDataView.RowHeadersVisible = false;
            this.TransactionHistoryDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.TransactionHistoryDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TransactionHistoryDataView.Size = new System.Drawing.Size(903, 407);
            this.TransactionHistoryDataView.TabIndex = 26;
            // 
            // Purchase_Date
            // 
            this.Purchase_Date.HeaderText = "Date";
            this.Purchase_Date.Name = "Purchase_Date";
            this.Purchase_Date.ReadOnly = true;
            // 
            // Purchase_ID
            // 
            this.Purchase_ID.HeaderText = "Purchase ID";
            this.Purchase_ID.Name = "Purchase_ID";
            this.Purchase_ID.ReadOnly = true;
            // 
            // Purchase_VendorName
            // 
            this.Purchase_VendorName.HeaderText = "Vendor Name";
            this.Purchase_VendorName.Name = "Purchase_VendorName";
            this.Purchase_VendorName.ReadOnly = true;
            // 
            // Purchase_TotalPrice
            // 
            this.Purchase_TotalPrice.HeaderText = "Total Price";
            this.Purchase_TotalPrice.Name = "Purchase_TotalPrice";
            this.Purchase_TotalPrice.ReadOnly = true;
            // 
            // purchaseTabControl
            // 
            this.purchaseTabControl.Controls.Add(this.tab_newPurchase);
            this.purchaseTabControl.Controls.Add(this.tab_transactionHistory);
            this.purchaseTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseTabControl.ItemSize = new System.Drawing.Size(100, 50);
            this.purchaseTabControl.Location = new System.Drawing.Point(0, 0);
            this.purchaseTabControl.Name = "purchaseTabControl";
            this.purchaseTabControl.Padding = new System.Drawing.Point(260, 3);
            this.purchaseTabControl.SelectedIndex = 0;
            this.purchaseTabControl.Size = new System.Drawing.Size(1303, 782);
            this.purchaseTabControl.TabIndex = 1;
            // 
            // tab_newPurchase
            // 
            this.tab_newPurchase.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab_newPurchase.Controls.Add(this.groupBox4);
            this.tab_newPurchase.Controls.Add(this.btn_reset);
            this.tab_newPurchase.Controls.Add(this.gb_billDetails);
            this.tab_newPurchase.Controls.Add(this.groupBox1);
            this.tab_newPurchase.Controls.Add(this.Purchase_ProductsDataView);
            this.tab_newPurchase.Location = new System.Drawing.Point(4, 54);
            this.tab_newPurchase.Margin = new System.Windows.Forms.Padding(0);
            this.tab_newPurchase.Name = "tab_newPurchase";
            this.tab_newPurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tab_newPurchase.Size = new System.Drawing.Size(1295, 724);
            this.tab_newPurchase.TabIndex = 0;
            this.tab_newPurchase.Text = "New Purchase";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.purchase_dateTime);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cb_vendorName);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Location = new System.Drawing.Point(25, 21);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(816, 95);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            // 
            // purchase_dateTime
            // 
            this.purchase_dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_dateTime.Location = new System.Drawing.Point(490, 45);
            this.purchase_dateTime.Name = "purchase_dateTime";
            this.purchase_dateTime.Size = new System.Drawing.Size(216, 22);
            this.purchase_dateTime.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(434, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Date :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_vendorName
            // 
            this.cb_vendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cb_vendorName.FormattingEnabled = true;
            this.cb_vendorName.Location = new System.Drawing.Point(83, 44);
            this.cb_vendorName.Name = "cb_vendorName";
            this.cb_vendorName.Size = new System.Drawing.Size(216, 26);
            this.cb_vendorName.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(15, 48);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 18);
            this.label17.TabIndex = 33;
            this.label17.Text = "Vendor :";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_reset
            // 
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_reset.ForeColor = System.Drawing.Color.Red;
            this.btn_reset.Location = new System.Drawing.Point(996, 65);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(142, 36);
            this.btn_reset.TabIndex = 37;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // gb_billDetails
            // 
            this.gb_billDetails.Controls.Add(this.label13);
            this.gb_billDetails.Controls.Add(this.lbl_errorAmountPaid);
            this.gb_billDetails.Controls.Add(this.btn_ViewPuchaseBill);
            this.gb_billDetails.Controls.Add(this.tb_subtotal);
            this.gb_billDetails.Controls.Add(this.tb_AmountPaid);
            this.gb_billDetails.Controls.Add(this.label5);
            this.gb_billDetails.Controls.Add(this.tb_amountDue);
            this.gb_billDetails.Controls.Add(this.label12);
            this.gb_billDetails.Controls.Add(this.label11);
            this.gb_billDetails.Controls.Add(this.label10);
            this.gb_billDetails.Controls.Add(this.label7);
            this.gb_billDetails.Controls.Add(this.tb_totalTax);
            this.gb_billDetails.Controls.Add(this.tb_totalDiscount);
            this.gb_billDetails.Location = new System.Drawing.Point(777, 331);
            this.gb_billDetails.Margin = new System.Windows.Forms.Padding(2);
            this.gb_billDetails.Name = "gb_billDetails";
            this.gb_billDetails.Padding = new System.Windows.Forms.Padding(2);
            this.gb_billDetails.Size = new System.Drawing.Size(453, 337);
            this.gb_billDetails.TabIndex = 31;
            this.gb_billDetails.TabStop = false;
            this.gb_billDetails.Text = "Bill Details";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(163, 220);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 18);
            this.label13.TabIndex = 29;
            this.label13.Text = "*";
            // 
            // lbl_errorAmountPaid
            // 
            this.lbl_errorAmountPaid.AutoSize = true;
            this.lbl_errorAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorAmountPaid.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorAmountPaid.Location = new System.Drawing.Point(64, 278);
            this.lbl_errorAmountPaid.Name = "lbl_errorAmountPaid";
            this.lbl_errorAmountPaid.Size = new System.Drawing.Size(0, 18);
            this.lbl_errorAmountPaid.TabIndex = 28;
            // 
            // btn_ViewPuchaseBill
            // 
            this.btn_ViewPuchaseBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewPuchaseBill.Location = new System.Drawing.Point(311, 271);
            this.btn_ViewPuchaseBill.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ViewPuchaseBill.Name = "btn_ViewPuchaseBill";
            this.btn_ViewPuchaseBill.Size = new System.Drawing.Size(77, 33);
            this.btn_ViewPuchaseBill.TabIndex = 28;
            this.btn_ViewPuchaseBill.Text = "View Bill";
            this.btn_ViewPuchaseBill.UseVisualStyleBackColor = true;
            // 
            // tb_subtotal
            // 
            this.tb_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_subtotal.Location = new System.Drawing.Point(204, 36);
            this.tb_subtotal.Margin = new System.Windows.Forms.Padding(2);
            this.tb_subtotal.Name = "tb_subtotal";
            this.tb_subtotal.ReadOnly = true;
            this.tb_subtotal.Size = new System.Drawing.Size(184, 21);
            this.tb_subtotal.TabIndex = 23;
            // 
            // tb_AmountPaid
            // 
            this.tb_AmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AmountPaid.Location = new System.Drawing.Point(204, 220);
            this.tb_AmountPaid.Margin = new System.Windows.Forms.Padding(2);
            this.tb_AmountPaid.Name = "tb_AmountPaid";
            this.tb_AmountPaid.Size = new System.Drawing.Size(184, 21);
            this.tb_AmountPaid.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Amount Paid :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_amountDue
            // 
            this.tb_amountDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_amountDue.Location = new System.Drawing.Point(204, 174);
            this.tb_amountDue.Margin = new System.Windows.Forms.Padding(2);
            this.tb_amountDue.Name = "tb_amountDue";
            this.tb_amountDue.ReadOnly = true;
            this.tb_amountDue.Size = new System.Drawing.Size(184, 21);
            this.tb_amountDue.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(42, 174);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 18);
            this.label12.TabIndex = 26;
            this.label12.Text = "Amount Due :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(64, 128);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 18);
            this.label11.TabIndex = 17;
            this.label11.Text = "Total Tax :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(54, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Subtotal :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total Discount :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_totalTax
            // 
            this.tb_totalTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_totalTax.Location = new System.Drawing.Point(204, 128);
            this.tb_totalTax.Margin = new System.Windows.Forms.Padding(2);
            this.tb_totalTax.Name = "tb_totalTax";
            this.tb_totalTax.ReadOnly = true;
            this.tb_totalTax.Size = new System.Drawing.Size(184, 21);
            this.tb_totalTax.TabIndex = 25;
            // 
            // tb_totalDiscount
            // 
            this.tb_totalDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_totalDiscount.Location = new System.Drawing.Point(204, 82);
            this.tb_totalDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.tb_totalDiscount.Name = "tb_totalDiscount";
            this.tb_totalDiscount.ReadOnly = true;
            this.tb_totalDiscount.Size = new System.Drawing.Size(184, 21);
            this.tb_totalDiscount.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.tb_availableStock);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_discount);
            this.groupBox1.Controls.Add(this.lbl_errorText);
            this.groupBox1.Controls.Add(this.cb_productName);
            this.groupBox1.Controls.Add(this.tb_purchasePrice);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tb_quantity);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.tb_barCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(25, 144);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1161, 146);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(1049, 90);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(64, 30);
            this.btn_add.TabIndex = 30;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_availableStock
            // 
            this.tb_availableStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_availableStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_availableStock.Location = new System.Drawing.Point(521, 55);
            this.tb_availableStock.Margin = new System.Windows.Forms.Padding(2);
            this.tb_availableStock.Name = "tb_availableStock";
            this.tb_availableStock.ReadOnly = true;
            this.tb_availableStock.Size = new System.Drawing.Size(142, 21);
            this.tb_availableStock.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(394, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Available Stock :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_discount
            // 
            this.tb_discount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_discount.Location = new System.Drawing.Point(521, 102);
            this.tb_discount.Margin = new System.Windows.Forms.Padding(2);
            this.tb_discount.Name = "tb_discount";
            this.tb_discount.Size = new System.Drawing.Size(142, 21);
            this.tb_discount.TabIndex = 1;
            // 
            // lbl_errorText
            // 
            this.lbl_errorText.AutoSize = true;
            this.lbl_errorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorText.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorText.Location = new System.Drawing.Point(28, 25);
            this.lbl_errorText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_errorText.Name = "lbl_errorText";
            this.lbl_errorText.Size = new System.Drawing.Size(0, 17);
            this.lbl_errorText.TabIndex = 36;
            // 
            // cb_productName
            // 
            this.cb_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cb_productName.FormattingEnabled = true;
            this.cb_productName.Location = new System.Drawing.Point(150, 101);
            this.cb_productName.Name = "cb_productName";
            this.cb_productName.Size = new System.Drawing.Size(184, 24);
            this.cb_productName.TabIndex = 37;
            this.cb_productName.Text = "Select Product";
            this.cb_productName.SelectedValueChanged += new System.EventHandler(this.cb_productName_SelectedValueChanged);
            // 
            // tb_purchasePrice
            // 
            this.tb_purchasePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_purchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_purchasePrice.Location = new System.Drawing.Point(852, 55);
            this.tb_purchasePrice.Margin = new System.Windows.Forms.Padding(2);
            this.tb_purchasePrice.Name = "tb_purchasePrice";
            this.tb_purchasePrice.Size = new System.Drawing.Size(143, 21);
            this.tb_purchasePrice.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(442, 102);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 18);
            this.label14.TabIndex = 33;
            this.label14.Text = "Discount :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_quantity
            // 
            this.tb_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_quantity.Location = new System.Drawing.Point(852, 99);
            this.tb_quantity.Margin = new System.Windows.Forms.Padding(2);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(142, 21);
            this.tb_quantity.TabIndex = 35;
            this.tb_quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_quantity_KeyDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(731, 55);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 18);
            this.label16.TabIndex = 33;
            this.label16.Text = "Purchase Price :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(768, 100);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 18);
            this.label19.TabIndex = 36;
            this.label19.Text = "Quantity :";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_barCode
            // 
            this.tb_barCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_barCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_barCode.Location = new System.Drawing.Point(150, 55);
            this.tb_barCode.Margin = new System.Windows.Forms.Padding(2);
            this.tb_barCode.Name = "tb_barCode";
            this.tb_barCode.Size = new System.Drawing.Size(184, 21);
            this.tb_barCode.TabIndex = 1;
            this.tb_barCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_barCode_KeyDown);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Product Name :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 55);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 18);
            this.label15.TabIndex = 33;
            this.label15.Text = "Bar Code :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PurchaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.purchaseTabControl);
            this.Name = "PurchaseControl";
            this.Size = new System.Drawing.Size(1303, 782);
            this.Load += new System.EventHandler(this.PurchaseControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Purchase_ProductsDataView)).EndInit();
            this.tab_transactionHistory.ResumeLayout(false);
            this.tab_transactionHistory.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionHistoryDataView)).EndInit();
            this.purchaseTabControl.ResumeLayout(false);
            this.tab_newPurchase.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gb_billDetails.ResumeLayout(false);
            this.gb_billDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView Purchase_ProductsDataView;
        private System.Windows.Forms.TabPage tab_transactionHistory;
        public System.Windows.Forms.Label lbl_transactionError;
        private System.Windows.Forms.Button btn_exportToExcel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_searchByCustomerName;
        public System.Windows.Forms.ComboBox cb_customerName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_searchByDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateTime_toDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateTime_fromDate;
        public System.Windows.Forms.DataGridView TransactionHistoryDataView;
        private System.Windows.Forms.TabControl purchaseTabControl;
        private System.Windows.Forms.TabPage tab_newPurchase;
        private System.Windows.Forms.GroupBox gb_billDetails;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label lbl_errorAmountPaid;
        public System.Windows.Forms.Button btn_ViewPuchaseBill;
        public System.Windows.Forms.TextBox tb_subtotal;
        public System.Windows.Forms.TextBox tb_AmountPaid;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tb_amountDue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tb_totalTax;
        public System.Windows.Forms.TextBox tb_totalDiscount;
        public System.Windows.Forms.Label lbl_errorText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tb_discount;
        public System.Windows.Forms.TextBox tb_purchasePrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox tb_barCode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_availableStock;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btn_reset;
        public System.Windows.Forms.ComboBox cb_vendorName;
        public System.Windows.Forms.ComboBox cb_productName;
        public System.Windows.Forms.DateTimePicker purchase_dateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_VendorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTable_ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTable_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTable_PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTable_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTable_Discount;
        public System.Windows.Forms.Button btn_add;
    }
}
