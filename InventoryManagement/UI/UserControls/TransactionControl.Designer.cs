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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.transactionTabControl = new System.Windows.Forms.TabControl();
            this.tab_newTransaction = new System.Windows.Forms.TabPage();
            this.btn_deleteBillRecord = new System.Windows.Forms.Button();
            this.gb_billDetails = new System.Windows.Forms.GroupBox();
            this.btn_saveTransaction = new System.Windows.Forms.Button();
            this.tb_subtotal = new System.Windows.Forms.TextBox();
            this.tb_amountDue = new System.Windows.Forms.TextBox();
            this.btn_printBill = new System.Windows.Forms.Button();
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
            this.Bill_ProductsDataView = new System.Windows.Forms.DataGridView();
            this.BillTable_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTable_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTable_Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTable_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTable_TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_transactionHistory = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_searchByCustomerName = new System.Windows.Forms.Button();
            this.cb_customerName = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_searchByDate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.TransactionHistoryDataView = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.Bill_ProductsDataView)).BeginInit();
            this.tab_transactionHistory.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionHistoryDataView)).BeginInit();
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
            this.transactionTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.transactionTabControl.Name = "transactionTabControl";
            this.transactionTabControl.Padding = new System.Drawing.Point(190, 3);
            this.transactionTabControl.SelectedIndex = 0;
            this.transactionTabControl.Size = new System.Drawing.Size(1737, 963);
            this.transactionTabControl.TabIndex = 0;
            // 
            // tab_newTransaction
            // 
            this.tab_newTransaction.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab_newTransaction.Controls.Add(this.btn_deleteBillRecord);
            this.tab_newTransaction.Controls.Add(this.gb_billDetails);
            this.tab_newTransaction.Controls.Add(this.gb_customerDeails);
            this.tab_newTransaction.Controls.Add(this.groupBox1);
            this.tab_newTransaction.Controls.Add(this.Bill_ProductsDataView);
            this.tab_newTransaction.Location = new System.Drawing.Point(4, 54);
            this.tab_newTransaction.Margin = new System.Windows.Forms.Padding(0);
            this.tab_newTransaction.Name = "tab_newTransaction";
            this.tab_newTransaction.Padding = new System.Windows.Forms.Padding(4);
            this.tab_newTransaction.Size = new System.Drawing.Size(1729, 905);
            this.tab_newTransaction.TabIndex = 0;
            this.tab_newTransaction.Text = "New Transaction";
            // 
            // btn_deleteBillRecord
            // 
            this.btn_deleteBillRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteBillRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteBillRecord.Location = new System.Drawing.Point(1578, 136);
            this.btn_deleteBillRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deleteBillRecord.Name = "btn_deleteBillRecord";
            this.btn_deleteBillRecord.Size = new System.Drawing.Size(103, 41);
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
            this.gb_billDetails.Controls.Add(this.btn_printBill);
            this.gb_billDetails.Controls.Add(this.label12);
            this.gb_billDetails.Controls.Add(this.label11);
            this.gb_billDetails.Controls.Add(this.label10);
            this.gb_billDetails.Controls.Add(this.label7);
            this.gb_billDetails.Controls.Add(this.tb_totalTax);
            this.gb_billDetails.Controls.Add(this.tb_totalDiscount);
            this.gb_billDetails.Location = new System.Drawing.Point(1044, 545);
            this.gb_billDetails.Name = "gb_billDetails";
            this.gb_billDetails.Size = new System.Drawing.Size(504, 336);
            this.gb_billDetails.TabIndex = 31;
            this.gb_billDetails.TabStop = false;
            this.gb_billDetails.Text = "Bill Details";
            // 
            // btn_saveTransaction
            // 
            this.btn_saveTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveTransaction.Location = new System.Drawing.Point(114, 281);
            this.btn_saveTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_saveTransaction.Name = "btn_saveTransaction";
            this.btn_saveTransaction.Size = new System.Drawing.Size(103, 41);
            this.btn_saveTransaction.TabIndex = 27;
            this.btn_saveTransaction.Text = "Save";
            this.btn_saveTransaction.UseVisualStyleBackColor = true;
            // 
            // tb_subtotal
            // 
            this.tb_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_subtotal.Location = new System.Drawing.Point(224, 46);
            this.tb_subtotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_subtotal.Name = "tb_subtotal";
            this.tb_subtotal.Size = new System.Drawing.Size(244, 24);
            this.tb_subtotal.TabIndex = 23;
            // 
            // tb_amountDue
            // 
            this.tb_amountDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_amountDue.Location = new System.Drawing.Point(224, 220);
            this.tb_amountDue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_amountDue.Name = "tb_amountDue";
            this.tb_amountDue.Size = new System.Drawing.Size(244, 24);
            this.tb_amountDue.TabIndex = 26;
            // 
            // btn_printBill
            // 
            this.btn_printBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_printBill.Location = new System.Drawing.Point(329, 281);
            this.btn_printBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_printBill.Name = "btn_printBill";
            this.btn_printBill.Size = new System.Drawing.Size(103, 41);
            this.btn_printBill.TabIndex = 28;
            this.btn_printBill.Text = "Print Bill";
            this.btn_printBill.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 24);
            this.label12.TabIndex = 26;
            this.label12.Text = "Amount Due";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(38, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 24);
            this.label11.TabIndex = 17;
            this.label11.Text = "Total Tax";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "Subtotal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total Discount";
            // 
            // tb_totalTax
            // 
            this.tb_totalTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_totalTax.Location = new System.Drawing.Point(224, 162);
            this.tb_totalTax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_totalTax.Name = "tb_totalTax";
            this.tb_totalTax.Size = new System.Drawing.Size(244, 24);
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
            this.tb_totalDiscount.Location = new System.Drawing.Point(224, 104);
            this.tb_totalDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_totalDiscount.Name = "tb_totalDiscount";
            this.tb_totalDiscount.Size = new System.Drawing.Size(244, 24);
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
            this.gb_customerDeails.Location = new System.Drawing.Point(60, 525);
            this.gb_customerDeails.Name = "gb_customerDeails";
            this.gb_customerDeails.Size = new System.Drawing.Size(604, 299);
            this.gb_customerDeails.TabIndex = 30;
            this.gb_customerDeails.TabStop = false;
            this.gb_customerDeails.Text = "Customer Details";
            // 
            // tb_mobileNumber
            // 
            this.tb_mobileNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mobileNumber.Location = new System.Drawing.Point(276, 55);
            this.tb_mobileNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_mobileNumber.Name = "tb_mobileNumber";
            this.tb_mobileNumber.Size = new System.Drawing.Size(244, 24);
            this.tb_mobileNumber.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(90, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Mobile No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Customer Name";
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCustomer.Location = new System.Drawing.Point(349, 244);
            this.btn_addCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(172, 41);
            this.btn_addCustomer.TabIndex = 26;
            this.btn_addCustomer.Text = "Add Customer";
            this.btn_addCustomer.UseVisualStyleBackColor = true;
            // 
            // tb_customerName
            // 
            this.tb_customerName.AutoCompleteCustomSource.AddRange(new string[] {
            "hh",
            "h"});
            this.tb_customerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_customerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customerName.Location = new System.Drawing.Point(276, 111);
            this.tb_customerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_customerName.Name = "tb_customerName";
            this.tb_customerName.Size = new System.Drawing.Size(244, 24);
            this.tb_customerName.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(90, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Pending Amount";
            // 
            // tb_pendingAmount
            // 
            this.tb_pendingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pendingAmount.Location = new System.Drawing.Point(276, 174);
            this.tb_pendingAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_pendingAmount.Name = "tb_pendingAmount";
            this.tb_pendingAmount.Size = new System.Drawing.Size(244, 24);
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
            this.groupBox1.Location = new System.Drawing.Point(60, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 435);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            // 
            // lbl_errorText
            // 
            this.lbl_errorText.AutoSize = true;
            this.lbl_errorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorText.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorText.Location = new System.Drawing.Point(194, 43);
            this.lbl_errorText.Name = "lbl_errorText";
            this.lbl_errorText.Size = new System.Drawing.Size(0, 20);
            this.lbl_errorText.TabIndex = 36;
            // 
            // tb_barCode
            // 
            this.tb_barCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_barCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_barCode.Location = new System.Drawing.Point(276, 82);
            this.tb_barCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_barCode.Name = "tb_barCode";
            this.tb_barCode.Size = new System.Drawing.Size(244, 24);
            this.tb_barCode.TabIndex = 1;
            this.tb_barCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_barCode_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(90, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 24);
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
            this.tb_productName.Location = new System.Drawing.Point(276, 138);
            this.tb_productName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.Size = new System.Drawing.Size(244, 24);
            this.tb_productName.TabIndex = 35;
            this.tb_productName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_productName_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(90, 193);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 24);
            this.label14.TabIndex = 25;
            this.label14.Text = "Price";
            // 
            // tb_quantity
            // 
            this.tb_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_quantity.Location = new System.Drawing.Point(276, 302);
            this.tb_quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(244, 24);
            this.tb_quantity.TabIndex = 2;
            this.tb_quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_quantity_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(90, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 24);
            this.label15.TabIndex = 33;
            this.label15.Text = "Bar Code";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(90, 302);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 24);
            this.label16.TabIndex = 28;
            this.label16.Text = "Quantity";
            // 
            // tb_discount
            // 
            this.tb_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_discount.Location = new System.Drawing.Point(276, 247);
            this.tb_discount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_discount.Name = "tb_discount";
            this.tb_discount.ReadOnly = true;
            this.tb_discount.Size = new System.Drawing.Size(244, 24);
            this.tb_discount.TabIndex = 32;
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(276, 193);
            this.tb_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_price.Name = "tb_price";
            this.tb_price.ReadOnly = true;
            this.tb_price.Size = new System.Drawing.Size(244, 24);
            this.tb_price.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(90, 247);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 24);
            this.label17.TabIndex = 31;
            this.label17.Text = "Discount";
            // 
            // btn_addProductToBill
            // 
            this.btn_addProductToBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addProductToBill.Location = new System.Drawing.Point(418, 354);
            this.btn_addProductToBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addProductToBill.Name = "btn_addProductToBill";
            this.btn_addProductToBill.Size = new System.Drawing.Size(103, 41);
            this.btn_addProductToBill.TabIndex = 3;
            this.btn_addProductToBill.Text = "Add";
            this.btn_addProductToBill.UseVisualStyleBackColor = true;
            this.btn_addProductToBill.Click += new System.EventHandler(this.btn_addProductToBill_Click);
            // 
            // Bill_ProductsDataView
            // 
            this.Bill_ProductsDataView.AllowUserToOrderColumns = true;
            this.Bill_ProductsDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Bill_ProductsDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Bill_ProductsDataView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Bill_ProductsDataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Bill_ProductsDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Bill_ProductsDataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Bill_ProductsDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Bill_ProductsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bill_ProductsDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillTable_Name,
            this.BillTable_Price,
            this.BillTable_Discount,
            this.BillTable_Quantity,
            this.BillTable_TotalPrice});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Bill_ProductsDataView.DefaultCellStyle = dataGridViewCellStyle8;
            this.Bill_ProductsDataView.GridColor = System.Drawing.Color.Black;
            this.Bill_ProductsDataView.Location = new System.Drawing.Point(697, 26);
            this.Bill_ProductsDataView.Margin = new System.Windows.Forms.Padding(4);
            this.Bill_ProductsDataView.MultiSelect = false;
            this.Bill_ProductsDataView.Name = "Bill_ProductsDataView";
            this.Bill_ProductsDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Bill_ProductsDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Bill_ProductsDataView.RowHeadersVisible = false;
            this.Bill_ProductsDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.Bill_ProductsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Bill_ProductsDataView.Size = new System.Drawing.Size(851, 493);
            this.Bill_ProductsDataView.TabIndex = 25;
            this.Bill_ProductsDataView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Bill_ProductsDataView_CellBeginEdit);
            this.Bill_ProductsDataView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Bill_ProductsDataView_CellEndEdit);
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
            this.tab_transactionHistory.Controls.Add(this.button1);
            this.tab_transactionHistory.Controls.Add(this.groupBox3);
            this.tab_transactionHistory.Controls.Add(this.groupBox2);
            this.tab_transactionHistory.Controls.Add(this.TransactionHistoryDataView);
            this.tab_transactionHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_transactionHistory.Location = new System.Drawing.Point(4, 54);
            this.tab_transactionHistory.Margin = new System.Windows.Forms.Padding(4);
            this.tab_transactionHistory.Name = "tab_transactionHistory";
            this.tab_transactionHistory.Padding = new System.Windows.Forms.Padding(4);
            this.tab_transactionHistory.Size = new System.Drawing.Size(1729, 905);
            this.tab_transactionHistory.TabIndex = 1;
            this.tab_transactionHistory.Text = "Transaction History";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1418, 481);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 41);
            this.button1.TabIndex = 29;
            this.button1.Text = "Export To Excel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_searchByCustomerName);
            this.groupBox3.Controls.Add(this.cb_customerName);
            this.groupBox3.Location = new System.Drawing.Point(370, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(937, 108);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Name";
            // 
            // btn_searchByCustomerName
            // 
            this.btn_searchByCustomerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchByCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchByCustomerName.Location = new System.Drawing.Point(625, 45);
            this.btn_searchByCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_searchByCustomerName.Name = "btn_searchByCustomerName";
            this.btn_searchByCustomerName.Size = new System.Drawing.Size(233, 41);
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
            this.cb_customerName.Location = new System.Drawing.Point(181, 45);
            this.cb_customerName.Name = "cb_customerName";
            this.cb_customerName.Size = new System.Drawing.Size(370, 28);
            this.cb_customerName.TabIndex = 0;
            this.cb_customerName.Text = "Select Customer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_searchByDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.toDate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.fromDate);
            this.groupBox2.Location = new System.Drawing.Point(102, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1407, 119);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Date";
            // 
            // btn_searchByDate
            // 
            this.btn_searchByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchByDate.Location = new System.Drawing.Point(1107, 45);
            this.btn_searchByDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_searchByDate.Name = "btn_searchByDate";
            this.btn_searchByDate.Size = new System.Drawing.Size(233, 41);
            this.btn_searchByDate.TabIndex = 30;
            this.btn_searchByDate.Text = "Search";
            this.btn_searchByDate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(650, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // toDate
            // 
            this.toDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDate.Location = new System.Drawing.Point(733, 53);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(309, 27);
            this.toDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // fromDate
            // 
            this.fromDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDate.Location = new System.Drawing.Point(172, 53);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(309, 27);
            this.fromDate.TabIndex = 0;
            // 
            // TransactionHistoryDataView
            // 
            this.TransactionHistoryDataView.AllowUserToOrderColumns = true;
            this.TransactionHistoryDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TransactionHistoryDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TransactionHistoryDataView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.TransactionHistoryDataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TransactionHistoryDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.TransactionHistoryDataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TransactionHistoryDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.TransactionHistoryDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionHistoryDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Transaction_Date,
            this.Transaction_ID,
            this.Transaction_CustomerName,
            this.Transaction_Quantity,
            this.Transaction_TotalPrice});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TransactionHistoryDataView.DefaultCellStyle = dataGridViewCellStyle11;
            this.TransactionHistoryDataView.GridColor = System.Drawing.Color.Black;
            this.TransactionHistoryDataView.Location = new System.Drawing.Point(175, 334);
            this.TransactionHistoryDataView.Margin = new System.Windows.Forms.Padding(4);
            this.TransactionHistoryDataView.MultiSelect = false;
            this.TransactionHistoryDataView.Name = "TransactionHistoryDataView";
            this.TransactionHistoryDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransactionHistoryDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.TransactionHistoryDataView.RowHeadersVisible = false;
            this.TransactionHistoryDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.TransactionHistoryDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TransactionHistoryDataView.Size = new System.Drawing.Size(1201, 533);
            this.TransactionHistoryDataView.TabIndex = 26;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.transactionTabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TransactionControl";
            this.Size = new System.Drawing.Size(1737, 963);
            this.Load += new System.EventHandler(this.TransactionControl_Load);
            this.transactionTabControl.ResumeLayout(false);
            this.tab_newTransaction.ResumeLayout(false);
            this.gb_billDetails.ResumeLayout(false);
            this.gb_billDetails.PerformLayout();
            this.gb_customerDeails.ResumeLayout(false);
            this.gb_customerDeails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bill_ProductsDataView)).EndInit();
            this.tab_transactionHistory.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionHistoryDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl transactionTabControl;
        private System.Windows.Forms.TabPage tab_newTransaction;
        private System.Windows.Forms.TabPage tab_transactionHistory;
        public System.Windows.Forms.DataGridView Bill_ProductsDataView;
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
        private System.Windows.Forms.Button btn_printBill;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTable_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTable_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTable_Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTable_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTable_TotalPrice;
        public System.Windows.Forms.DataGridView TransactionHistoryDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_TotalPrice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_customerName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_searchByCustomerName;
        private System.Windows.Forms.Button btn_searchByDate;
        private System.Windows.Forms.Button btn_deleteBillRecord;
        private System.Windows.Forms.Label lbl_errorText;
    }
}
