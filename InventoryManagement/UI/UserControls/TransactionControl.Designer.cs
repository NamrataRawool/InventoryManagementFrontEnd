namespace InventoryManagement.UI.UserControls
{
    partial class TransactionControl
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
            this.transactionTabControl = new System.Windows.Forms.TabControl();
            this.tab_newTransaction = new System.Windows.Forms.TabPage();
            this.btn_deleteBillRecord = new System.Windows.Forms.Button();
            this.gb_billDetails = new System.Windows.Forms.GroupBox();
            this.btn_saveTransaction = new System.Windows.Forms.Button();
            this.tb_subtotal = new System.Windows.Forms.TextBox();
            this.tb_amountDue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_totalTax = new System.Windows.Forms.TextBox();
            this.tb_totalDiscount = new System.Windows.Forms.TextBox();
            this.gb_customerDeails = new System.Windows.Forms.GroupBox();
            this.tb_mobileNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_addCustomer = new System.Windows.Forms.Button();
            this.tb_customerName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_pendingAmount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_errorText = new System.Windows.Forms.Label();
            this.tb_barCode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_productName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_discount = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_addProductToBill = new System.Windows.Forms.Button();
            this.table_Products = new System.Windows.Forms.DataGridView();
            this.BillTable_ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTable_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTable_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTable_Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTable_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTable_TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.table_TransactionHistory = new System.Windows.Forms.DataGridView();
            this.Transaction_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaction_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaction_CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaction_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaction_TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionTabControl.SuspendLayout();
            this.tab_newTransaction.SuspendLayout();
            this.gb_billDetails.SuspendLayout();
            this.gb_customerDeails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Products)).BeginInit();
            this.tab_transactionHistory.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_TransactionHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionTabControl
            // 
            this.transactionTabControl.Controls.Add(this.tab_newTransaction);
            this.transactionTabControl.Controls.Add(this.tab_transactionHistory);
            this.transactionTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionTabControl.ItemSize = new System.Drawing.Size(100, 50);
            this.transactionTabControl.Location = new System.Drawing.Point(0, 0);
            this.transactionTabControl.Name = "transactionTabControl";
            this.transactionTabControl.Padding = new System.Drawing.Point(190, 3);
            this.transactionTabControl.SelectedIndex = 0;
            this.transactionTabControl.Size = new System.Drawing.Size(1303, 782);
            this.transactionTabControl.TabIndex = 0;
            // 
            // tab_newTransaction
            // 
            this.tab_newTransaction.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab_newTransaction.Controls.Add(this.btn_deleteBillRecord);
            this.tab_newTransaction.Controls.Add(this.gb_billDetails);
            this.tab_newTransaction.Controls.Add(this.gb_customerDeails);
            this.tab_newTransaction.Controls.Add(this.groupBox1);
            this.tab_newTransaction.Controls.Add(this.table_Products);
            this.tab_newTransaction.Location = new System.Drawing.Point(4, 54);
            this.tab_newTransaction.Margin = new System.Windows.Forms.Padding(0);
            this.tab_newTransaction.Name = "tab_newTransaction";
            this.tab_newTransaction.Padding = new System.Windows.Forms.Padding(3);
            this.tab_newTransaction.Size = new System.Drawing.Size(1295, 724);
            this.tab_newTransaction.TabIndex = 0;
            this.tab_newTransaction.Text = "New Transaction";
            // 
            // btn_deleteBillRecord
            // 
            this.btn_deleteBillRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteBillRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteBillRecord.Location = new System.Drawing.Point(1184, 110);
            this.btn_deleteBillRecord.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deleteBillRecord.Name = "btn_deleteBillRecord";
            this.btn_deleteBillRecord.Size = new System.Drawing.Size(77, 33);
            this.btn_deleteBillRecord.TabIndex = 36;
            this.btn_deleteBillRecord.Text = "Delete";
            this.btn_deleteBillRecord.UseVisualStyleBackColor = true;
            this.btn_deleteBillRecord.Click += new System.EventHandler(this.btn_deleteBillRecord_Click);
            // 
            // gb_billDetails
            // 
            this.gb_billDetails.Controls.Add(this.btn_saveTransaction);
            this.gb_billDetails.Controls.Add(this.tb_subtotal);
            this.gb_billDetails.Controls.Add(this.tb_amountDue);
            this.gb_billDetails.Controls.Add(this.label12);
            this.gb_billDetails.Controls.Add(this.label11);
            this.gb_billDetails.Controls.Add(this.label10);
            this.gb_billDetails.Controls.Add(this.label7);
            this.gb_billDetails.Controls.Add(this.tb_totalTax);
            this.gb_billDetails.Controls.Add(this.tb_totalDiscount);
            this.gb_billDetails.Location = new System.Drawing.Point(783, 443);
            this.gb_billDetails.Margin = new System.Windows.Forms.Padding(2);
            this.gb_billDetails.Name = "gb_billDetails";
            this.gb_billDetails.Padding = new System.Windows.Forms.Padding(2);
            this.gb_billDetails.Size = new System.Drawing.Size(378, 273);
            this.gb_billDetails.TabIndex = 31;
            this.gb_billDetails.TabStop = false;
            this.gb_billDetails.Text = "Bill Details";
            // 
            // btn_saveTransaction
            // 
            this.btn_saveTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveTransaction.Location = new System.Drawing.Point(275, 226);
            this.btn_saveTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.btn_saveTransaction.Name = "btn_saveTransaction";
            this.btn_saveTransaction.Size = new System.Drawing.Size(77, 33);
            this.btn_saveTransaction.TabIndex = 27;
            this.btn_saveTransaction.Text = "Save";
            this.btn_saveTransaction.UseVisualStyleBackColor = true;
            this.btn_saveTransaction.Click += new System.EventHandler(this.btn_saveTransaction_Click);
            // 
            // tb_subtotal
            // 
            this.tb_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_subtotal.Location = new System.Drawing.Point(168, 37);
            this.tb_subtotal.Margin = new System.Windows.Forms.Padding(2);
            this.tb_subtotal.Name = "tb_subtotal";
            this.tb_subtotal.Size = new System.Drawing.Size(184, 21);
            this.tb_subtotal.TabIndex = 23;
            // 
            // tb_amountDue
            // 
            this.tb_amountDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_amountDue.Location = new System.Drawing.Point(168, 179);
            this.tb_amountDue.Margin = new System.Windows.Forms.Padding(2);
            this.tb_amountDue.Name = "tb_amountDue";
            this.tb_amountDue.Size = new System.Drawing.Size(184, 21);
            this.tb_amountDue.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 179);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 18);
            this.label12.TabIndex = 26;
            this.label12.Text = "Amount Due";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 132);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 18);
            this.label11.TabIndex = 17;
            this.label11.Text = "Total Tax";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Subtotal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total Discount";
            // 
            // tb_totalTax
            // 
            this.tb_totalTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_totalTax.Location = new System.Drawing.Point(168, 132);
            this.tb_totalTax.Margin = new System.Windows.Forms.Padding(2);
            this.tb_totalTax.Name = "tb_totalTax";
            this.tb_totalTax.Size = new System.Drawing.Size(184, 21);
            this.tb_totalTax.TabIndex = 25;
            // 
            // tb_totalDiscount
            // 
            this.tb_totalDiscount.AutoCompleteCustomSource.AddRange(new string[] {
            "hh",
            "h"});
            this.tb_totalDiscount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_totalDiscount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_totalDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_totalDiscount.Location = new System.Drawing.Point(168, 84);
            this.tb_totalDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.tb_totalDiscount.Name = "tb_totalDiscount";
            this.tb_totalDiscount.Size = new System.Drawing.Size(184, 21);
            this.tb_totalDiscount.TabIndex = 24;
            // 
            // gb_customerDeails
            // 
            this.gb_customerDeails.Controls.Add(this.tb_mobileNumber);
            this.gb_customerDeails.Controls.Add(this.label8);
            this.gb_customerDeails.Controls.Add(this.label6);
            this.gb_customerDeails.Controls.Add(this.btn_addCustomer);
            this.gb_customerDeails.Controls.Add(this.tb_customerName);
            this.gb_customerDeails.Controls.Add(this.label9);
            this.gb_customerDeails.Controls.Add(this.tb_pendingAmount);
            this.gb_customerDeails.Location = new System.Drawing.Point(45, 427);
            this.gb_customerDeails.Margin = new System.Windows.Forms.Padding(2);
            this.gb_customerDeails.Name = "gb_customerDeails";
            this.gb_customerDeails.Padding = new System.Windows.Forms.Padding(2);
            this.gb_customerDeails.Size = new System.Drawing.Size(453, 243);
            this.gb_customerDeails.TabIndex = 30;
            this.gb_customerDeails.TabStop = false;
            this.gb_customerDeails.Text = "Customer Details";
            // 
            // tb_mobileNumber
            // 
            this.tb_mobileNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mobileNumber.Location = new System.Drawing.Point(207, 45);
            this.tb_mobileNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tb_mobileNumber.Name = "tb_mobileNumber";
            this.tb_mobileNumber.Size = new System.Drawing.Size(184, 21);
            this.tb_mobileNumber.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 45);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Mobile No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Customer Name";
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCustomer.Location = new System.Drawing.Point(192, 198);
            this.btn_addCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(199, 33);
            this.btn_addCustomer.TabIndex = 26;
            this.btn_addCustomer.Text = "Add New Customer";
            this.btn_addCustomer.UseVisualStyleBackColor = true;
            this.btn_addCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // tb_customerName
            // 
            this.tb_customerName.AutoCompleteCustomSource.AddRange(new string[] {
            "hh",
            "h"});
            this.tb_customerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_customerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customerName.Location = new System.Drawing.Point(207, 90);
            this.tb_customerName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_customerName.Name = "tb_customerName";
            this.tb_customerName.Size = new System.Drawing.Size(184, 21);
            this.tb_customerName.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 141);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Pending Amount";
            // 
            // tb_pendingAmount
            // 
            this.tb_pendingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pendingAmount.Location = new System.Drawing.Point(207, 141);
            this.tb_pendingAmount.Margin = new System.Windows.Forms.Padding(2);
            this.tb_pendingAmount.Name = "tb_pendingAmount";
            this.tb_pendingAmount.Size = new System.Drawing.Size(184, 21);
            this.tb_pendingAmount.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.lbl_errorText);
            this.groupBox1.Controls.Add(this.tb_barCode);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tb_productName);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tb_quantity);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.tb_discount);
            this.groupBox1.Controls.Add(this.tb_price);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.btn_addProductToBill);
            this.groupBox1.Location = new System.Drawing.Point(45, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(453, 353);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            // 
            // lbl_errorText
            // 
            this.lbl_errorText.AutoSize = true;
            this.lbl_errorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorText.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorText.Location = new System.Drawing.Point(146, 35);
            this.lbl_errorText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_errorText.Name = "lbl_errorText";
            this.lbl_errorText.Size = new System.Drawing.Size(0, 17);
            this.lbl_errorText.TabIndex = 36;
            // 
            // tb_barCode
            // 
            this.tb_barCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_barCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_barCode.Location = new System.Drawing.Point(207, 67);
            this.tb_barCode.Margin = new System.Windows.Forms.Padding(2);
            this.tb_barCode.Name = "tb_barCode";
            this.tb_barCode.Size = new System.Drawing.Size(184, 21);
            this.tb_barCode.TabIndex = 1;
            this.tb_barCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_barCode_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(68, 112);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 18);
            this.label13.TabIndex = 26;
            this.label13.Text = "Product Name";
            // 
            // tb_productName
            // 
            this.tb_productName.AutoCompleteCustomSource.AddRange(new string[] {
            "hh",
            "h"});
            this.tb_productName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_productName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_productName.Location = new System.Drawing.Point(207, 112);
            this.tb_productName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.Size = new System.Drawing.Size(184, 21);
            this.tb_productName.TabIndex = 35;
            this.tb_productName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_productName_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(68, 157);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 18);
            this.label14.TabIndex = 25;
            this.label14.Text = "Price";
            // 
            // tb_quantity
            // 
            this.tb_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_quantity.Location = new System.Drawing.Point(207, 245);
            this.tb_quantity.Margin = new System.Windows.Forms.Padding(2);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(184, 21);
            this.tb_quantity.TabIndex = 2;
            this.tb_quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_quantity_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(68, 67);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 18);
            this.label15.TabIndex = 33;
            this.label15.Text = "Bar Code";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(68, 245);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 18);
            this.label16.TabIndex = 28;
            this.label16.Text = "Quantity";
            // 
            // tb_discount
            // 
            this.tb_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_discount.Location = new System.Drawing.Point(207, 201);
            this.tb_discount.Margin = new System.Windows.Forms.Padding(2);
            this.tb_discount.Name = "tb_discount";
            this.tb_discount.ReadOnly = true;
            this.tb_discount.Size = new System.Drawing.Size(184, 21);
            this.tb_discount.TabIndex = 32;
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(207, 157);
            this.tb_price.Margin = new System.Windows.Forms.Padding(2);
            this.tb_price.Name = "tb_price";
            this.tb_price.ReadOnly = true;
            this.tb_price.Size = new System.Drawing.Size(184, 21);
            this.tb_price.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(68, 201);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 18);
            this.label17.TabIndex = 31;
            this.label17.Text = "Discount";
            // 
            // btn_addProductToBill
            // 
            this.btn_addProductToBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addProductToBill.Location = new System.Drawing.Point(314, 288);
            this.btn_addProductToBill.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addProductToBill.Name = "btn_addProductToBill";
            this.btn_addProductToBill.Size = new System.Drawing.Size(77, 33);
            this.btn_addProductToBill.TabIndex = 3;
            this.btn_addProductToBill.Text = "Add";
            this.btn_addProductToBill.UseVisualStyleBackColor = true;
            this.btn_addProductToBill.Click += new System.EventHandler(this.btn_addProductToBill_Click);
            // 
            // table_Products
            // 
            this.table_Products.AllowUserToAddRows = false;
            this.table_Products.AllowUserToOrderColumns = true;
            this.table_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_Products.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.table_Products.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.table_Products.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.table_Products.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.table_Products.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table_Products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillTable_ProductId,
            this.BillTable_Name,
            this.BillTable_Price,
            this.BillTable_Discount,
            this.BillTable_Quantity,
            this.BillTable_TotalPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table_Products.DefaultCellStyle = dataGridViewCellStyle2;
            this.table_Products.GridColor = System.Drawing.Color.Black;
            this.table_Products.Location = new System.Drawing.Point(523, 21);
            this.table_Products.MultiSelect = false;
            this.table_Products.Name = "table_Products";
            this.table_Products.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_Products.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.table_Products.RowHeadersVisible = false;
            this.table_Products.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.table_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_Products.Size = new System.Drawing.Size(638, 402);
            this.table_Products.TabIndex = 25;
            this.table_Products.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Bill_ProductsDataView_CellBeginEdit);
            this.table_Products.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Bill_ProductsDataView_CellEndEdit);
            // 
            // BillTable_ProductId
            // 
            this.BillTable_ProductId.HeaderText = "Product Id";
            this.BillTable_ProductId.Name = "BillTable_ProductId";
            this.BillTable_ProductId.ReadOnly = true;
            // 
            // BillTable_Name
            // 
            this.BillTable_Name.HeaderText = "Name";
            this.BillTable_Name.Name = "BillTable_Name";
            this.BillTable_Name.ReadOnly = true;
            // 
            // BillTable_Price
            // 
            this.BillTable_Price.HeaderText = "Price (in Rs)";
            this.BillTable_Price.Name = "BillTable_Price";
            this.BillTable_Price.ReadOnly = true;
            // 
            // BillTable_Discount
            // 
            this.BillTable_Discount.HeaderText = "Discount (in Rs)";
            this.BillTable_Discount.Name = "BillTable_Discount";
            this.BillTable_Discount.ReadOnly = true;
            // 
            // BillTable_Quantity
            // 
            this.BillTable_Quantity.HeaderText = "Quantity";
            this.BillTable_Quantity.Name = "BillTable_Quantity";
            // 
            // BillTable_TotalPrice
            // 
            this.BillTable_TotalPrice.HeaderText = "Total Price (in Rs)";
            this.BillTable_TotalPrice.Name = "BillTable_TotalPrice";
            this.BillTable_TotalPrice.ReadOnly = true;
            // 
            // tab_transactionHistory
            // 
            this.tab_transactionHistory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab_transactionHistory.Controls.Add(this.lbl_transactionError);
            this.tab_transactionHistory.Controls.Add(this.btn_exportToExcel);
            this.tab_transactionHistory.Controls.Add(this.groupBox3);
            this.tab_transactionHistory.Controls.Add(this.groupBox2);
            this.tab_transactionHistory.Controls.Add(this.table_TransactionHistory);
            this.tab_transactionHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_transactionHistory.Location = new System.Drawing.Point(4, 54);
            this.tab_transactionHistory.Name = "tab_transactionHistory";
            this.tab_transactionHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tab_transactionHistory.Size = new System.Drawing.Size(1295, 724);
            this.tab_transactionHistory.TabIndex = 1;
            this.tab_transactionHistory.Text = "Transaction History";
            // 
            // lbl_transactionError
            // 
            this.lbl_transactionError.AutoSize = true;
            this.lbl_transactionError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transactionError.ForeColor = System.Drawing.Color.Red;
            this.lbl_transactionError.Location = new System.Drawing.Point(491, 265);
            this.lbl_transactionError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_transactionError.Name = "lbl_transactionError";
            this.lbl_transactionError.Size = new System.Drawing.Size(0, 16);
            this.lbl_transactionError.TabIndex = 30;
            // 
            // btn_exportToExcel
            // 
            this.btn_exportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportToExcel.Location = new System.Drawing.Point(1064, 391);
            this.btn_exportToExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exportToExcel.Name = "btn_exportToExcel";
            this.btn_exportToExcel.Size = new System.Drawing.Size(175, 33);
            this.btn_exportToExcel.TabIndex = 29;
            this.btn_exportToExcel.Text = "Export To Excel";
            this.btn_exportToExcel.UseVisualStyleBackColor = true;
            this.btn_exportToExcel.Click += new System.EventHandler(this.btn_exportToExcel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_searchByCustomerName);
            this.groupBox3.Controls.Add(this.cb_customerName);
            this.groupBox3.Location = new System.Drawing.Point(278, 165);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(703, 88);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Name";
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
            this.btn_searchByCustomerName.Click += new System.EventHandler(this.btn_searchByCustomerName_Click);
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
            this.cb_customerName.Text = "Select Customer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_searchByDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.DateTime_toDate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DateTime_fromDate);
            this.groupBox2.Location = new System.Drawing.Point(76, 32);
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
            this.btn_searchByDate.Click += new System.EventHandler(this.btn_searchByDate_Click);
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
            // table_TransactionHistory
            // 
            this.table_TransactionHistory.AllowUserToOrderColumns = true;
            this.table_TransactionHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_TransactionHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.table_TransactionHistory.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.table_TransactionHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.table_TransactionHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.table_TransactionHistory.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table_TransactionHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.table_TransactionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_TransactionHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Transaction_Date,
            this.Transaction_ID,
            this.Transaction_CustomerName,
            this.Transaction_Quantity,
            this.Transaction_TotalPrice});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table_TransactionHistory.DefaultCellStyle = dataGridViewCellStyle5;
            this.table_TransactionHistory.GridColor = System.Drawing.Color.Black;
            this.table_TransactionHistory.Location = new System.Drawing.Point(129, 297);
            this.table_TransactionHistory.MultiSelect = false;
            this.table_TransactionHistory.Name = "table_TransactionHistory";
            this.table_TransactionHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_TransactionHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.table_TransactionHistory.RowHeadersVisible = false;
            this.table_TransactionHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.table_TransactionHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_TransactionHistory.Size = new System.Drawing.Size(903, 407);
            this.table_TransactionHistory.TabIndex = 26;
            // 
            // Transaction_Date
            // 
            this.Transaction_Date.HeaderText = "Date";
            this.Transaction_Date.Name = "Transaction_Date";
            this.Transaction_Date.ReadOnly = true;
            // 
            // Transaction_ID
            // 
            this.Transaction_ID.HeaderText = "Transaction ID";
            this.Transaction_ID.Name = "Transaction_ID";
            this.Transaction_ID.ReadOnly = true;
            // 
            // Transaction_CustomerName
            // 
            this.Transaction_CustomerName.HeaderText = "Customer Name";
            this.Transaction_CustomerName.Name = "Transaction_CustomerName";
            this.Transaction_CustomerName.ReadOnly = true;
            // 
            // Transaction_Quantity
            // 
            this.Transaction_Quantity.HeaderText = "Quantity";
            this.Transaction_Quantity.Name = "Transaction_Quantity";
            this.Transaction_Quantity.ReadOnly = true;
            // 
            // Transaction_TotalPrice
            // 
            this.Transaction_TotalPrice.HeaderText = "Total Price (in Rs)";
            this.Transaction_TotalPrice.Name = "Transaction_TotalPrice";
            this.Transaction_TotalPrice.ReadOnly = true;
            // 
            // TransactionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.transactionTabControl);
            this.Name = "TransactionControl";
            this.Size = new System.Drawing.Size(1303, 782);
            this.Load += new System.EventHandler(this.TransactionControl_Load);
            this.transactionTabControl.ResumeLayout(false);
            this.tab_newTransaction.ResumeLayout(false);
            this.gb_billDetails.ResumeLayout(false);
            this.gb_billDetails.PerformLayout();
            this.gb_customerDeails.ResumeLayout(false);
            this.gb_customerDeails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Products)).EndInit();
            this.tab_transactionHistory.ResumeLayout(false);
            this.tab_transactionHistory.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_TransactionHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl transactionTabControl;
        private System.Windows.Forms.TabPage tab_newTransaction;
        private System.Windows.Forms.TabPage tab_transactionHistory;
        public System.Windows.Forms.DataGridView table_Products;
        private System.Windows.Forms.TextBox tb_mobileNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_customerName;
        private System.Windows.Forms.TextBox tb_pendingAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_addCustomer;
        private System.Windows.Forms.Button btn_saveTransaction;
        private System.Windows.Forms.TextBox tb_amountDue;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox tb_subtotal;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tb_totalDiscount;
        private System.Windows.Forms.TextBox tb_totalTax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_barCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_productName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_discount;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_addProductToBill;
        private System.Windows.Forms.GroupBox gb_billDetails;
        private System.Windows.Forms.GroupBox gb_customerDeails;
        public System.Windows.Forms.DataGridView table_TransactionHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_TotalPrice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker DateTime_fromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateTime_toDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_customerName;
        private System.Windows.Forms.Button btn_exportToExcel;
        private System.Windows.Forms.Button btn_searchByCustomerName;
        private System.Windows.Forms.Button btn_searchByDate;
        private System.Windows.Forms.Button btn_deleteBillRecord;
        private System.Windows.Forms.Label lbl_errorText;
        public System.Windows.Forms.Label lbl_transactionError;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTable_ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTable_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTable_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTable_Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTable_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTable_TotalPrice;
    }
}
