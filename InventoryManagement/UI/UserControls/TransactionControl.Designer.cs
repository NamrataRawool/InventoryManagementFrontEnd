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
            this.btn_resetTransaction = new System.Windows.Forms.Button();
            this.btn_deleteBillRecord = new System.Windows.Forms.Button();
            this.gb_billDetails = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_errorAmountPaid = new System.Windows.Forms.Label();
            this.btn_ViewBill = new System.Windows.Forms.Button();
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
            this.lbl_errorText = new System.Windows.Forms.Label();
            this.gb_customerDetails = new System.Windows.Forms.GroupBox();
            this.btn_AddNewCustomer = new System.Windows.Forms.Button();
            this.lbl_customerError = new System.Windows.Forms.Label();
            this.tb_mobileNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_customerName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_pendingAmount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tb_productName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_addProduct_ProductName = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_barCode = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_addProductToBill = new System.Windows.Forms.Button();
            this.Bill_ProductsDataView = new System.Windows.Forms.DataGridView();
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
            this.Transaction_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaction_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaction_CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaction_TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTable_ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTable_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTable_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTable_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTable_Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTable_Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTable_FinalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionTabControl.SuspendLayout();
            this.tab_newTransaction.SuspendLayout();
            this.gb_billDetails.SuspendLayout();
            this.gb_customerDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.transactionTabControl.Name = "transactionTabControl";
            this.transactionTabControl.Padding = new System.Drawing.Point(260, 3);
            this.transactionTabControl.SelectedIndex = 0;
            this.transactionTabControl.Size = new System.Drawing.Size(1303, 782);
            this.transactionTabControl.TabIndex = 0;
            // 
            // tab_newTransaction
            // 
            this.tab_newTransaction.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab_newTransaction.Controls.Add(this.btn_resetTransaction);
            this.tab_newTransaction.Controls.Add(this.btn_deleteBillRecord);
            this.tab_newTransaction.Controls.Add(this.gb_billDetails);
            this.tab_newTransaction.Controls.Add(this.lbl_errorText);
            this.tab_newTransaction.Controls.Add(this.gb_customerDetails);
            this.tab_newTransaction.Controls.Add(this.groupBox1);
            this.tab_newTransaction.Controls.Add(this.Bill_ProductsDataView);
            this.tab_newTransaction.Location = new System.Drawing.Point(4, 54);
            this.tab_newTransaction.Margin = new System.Windows.Forms.Padding(0);
            this.tab_newTransaction.Name = "tab_newTransaction";
            this.tab_newTransaction.Padding = new System.Windows.Forms.Padding(3);
            this.tab_newTransaction.Size = new System.Drawing.Size(1295, 724);
            this.tab_newTransaction.TabIndex = 0;
            this.tab_newTransaction.Text = "New Transaction";
            // 
            // btn_resetTransaction
            // 
            this.btn_resetTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_resetTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_resetTransaction.ForeColor = System.Drawing.Color.Red;
            this.btn_resetTransaction.Location = new System.Drawing.Point(1047, 15);
            this.btn_resetTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.btn_resetTransaction.Name = "btn_resetTransaction";
            this.btn_resetTransaction.Size = new System.Drawing.Size(191, 36);
            this.btn_resetTransaction.TabIndex = 37;
            this.btn_resetTransaction.Text = "Reset Transaction";
            this.btn_resetTransaction.UseVisualStyleBackColor = true;
            this.btn_resetTransaction.Click += new System.EventHandler(this.btn_resetTransaction_Click);
            // 
            // btn_deleteBillRecord
            // 
            this.btn_deleteBillRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteBillRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteBillRecord.Location = new System.Drawing.Point(25, 673);
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
            this.gb_billDetails.Controls.Add(this.label13);
            this.gb_billDetails.Controls.Add(this.lbl_errorAmountPaid);
            this.gb_billDetails.Controls.Add(this.btn_ViewBill);
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
            this.gb_billDetails.Location = new System.Drawing.Point(785, 335);
            this.gb_billDetails.Margin = new System.Windows.Forms.Padding(2);
            this.gb_billDetails.Name = "gb_billDetails";
            this.gb_billDetails.Padding = new System.Windows.Forms.Padding(2);
            this.gb_billDetails.Size = new System.Drawing.Size(453, 319);
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
            // btn_ViewBill
            // 
            this.btn_ViewBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewBill.Location = new System.Drawing.Point(311, 271);
            this.btn_ViewBill.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ViewBill.Name = "btn_ViewBill";
            this.btn_ViewBill.Size = new System.Drawing.Size(77, 33);
            this.btn_ViewBill.TabIndex = 28;
            this.btn_ViewBill.Text = "View Bill";
            this.btn_ViewBill.UseVisualStyleBackColor = true;
            this.btn_ViewBill.Click += new System.EventHandler(this.btn_ViewBill_Click);
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
            this.tb_AmountPaid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_AmountPaid_KeyDown);
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
            // lbl_errorText
            // 
            this.lbl_errorText.AutoSize = true;
            this.lbl_errorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorText.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorText.Location = new System.Drawing.Point(242, 183);
            this.lbl_errorText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_errorText.Name = "lbl_errorText";
            this.lbl_errorText.Size = new System.Drawing.Size(0, 17);
            this.lbl_errorText.TabIndex = 36;
            // 
            // gb_customerDetails
            // 
            this.gb_customerDetails.Controls.Add(this.btn_AddNewCustomer);
            this.gb_customerDetails.Controls.Add(this.lbl_customerError);
            this.gb_customerDetails.Controls.Add(this.tb_mobileNumber);
            this.gb_customerDetails.Controls.Add(this.label8);
            this.gb_customerDetails.Controls.Add(this.label6);
            this.gb_customerDetails.Controls.Add(this.tb_customerName);
            this.gb_customerDetails.Controls.Add(this.label9);
            this.gb_customerDetails.Controls.Add(this.tb_pendingAmount);
            this.gb_customerDetails.Location = new System.Drawing.Point(785, 65);
            this.gb_customerDetails.Margin = new System.Windows.Forms.Padding(2);
            this.gb_customerDetails.Name = "gb_customerDetails";
            this.gb_customerDetails.Padding = new System.Windows.Forms.Padding(2);
            this.gb_customerDetails.Size = new System.Drawing.Size(453, 213);
            this.gb_customerDetails.TabIndex = 30;
            this.gb_customerDetails.TabStop = false;
            this.gb_customerDetails.Text = "Customer Details";
            // 
            // btn_AddNewCustomer
            // 
            this.btn_AddNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_AddNewCustomer.Location = new System.Drawing.Point(249, 22);
            this.btn_AddNewCustomer.Name = "btn_AddNewCustomer";
            this.btn_AddNewCustomer.Size = new System.Drawing.Size(139, 29);
            this.btn_AddNewCustomer.TabIndex = 28;
            this.btn_AddNewCustomer.Text = "Add New Customer";
            this.btn_AddNewCustomer.UseVisualStyleBackColor = true;
            this.btn_AddNewCustomer.Click += new System.EventHandler(this.btn_AddNewCustomer_Click);
            // 
            // lbl_customerError
            // 
            this.lbl_customerError.AutoSize = true;
            this.lbl_customerError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerError.ForeColor = System.Drawing.Color.Red;
            this.lbl_customerError.Location = new System.Drawing.Point(65, 33);
            this.lbl_customerError.Name = "lbl_customerError";
            this.lbl_customerError.Size = new System.Drawing.Size(0, 18);
            this.lbl_customerError.TabIndex = 27;
            // 
            // tb_mobileNumber
            // 
            this.tb_mobileNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mobileNumber.Location = new System.Drawing.Point(204, 79);
            this.tb_mobileNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tb_mobileNumber.Name = "tb_mobileNumber";
            this.tb_mobileNumber.Size = new System.Drawing.Size(184, 21);
            this.tb_mobileNumber.TabIndex = 23;
            this.tb_mobileNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_mobileNumber_KeyDown);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Mobile No. :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Customer Name :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_customerName
            // 
            this.tb_customerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_customerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customerName.Location = new System.Drawing.Point(204, 124);
            this.tb_customerName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_customerName.Name = "tb_customerName";
            this.tb_customerName.Size = new System.Drawing.Size(184, 21);
            this.tb_customerName.TabIndex = 24;
            this.tb_customerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_customerName_KeyDown);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 166);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Pending Amount :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_pendingAmount
            // 
            this.tb_pendingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pendingAmount.Location = new System.Drawing.Point(204, 166);
            this.tb_pendingAmount.Margin = new System.Windows.Forms.Padding(2);
            this.tb_pendingAmount.Name = "tb_pendingAmount";
            this.tb_pendingAmount.ReadOnly = true;
            this.tb_pendingAmount.Size = new System.Drawing.Size(184, 21);
            this.tb_pendingAmount.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(25, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(697, 152);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Note: Use bar code or product name to add product to the bill";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tb_productName);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.btn_addProduct_ProductName);
            this.groupBox5.Location = new System.Drawing.Point(363, 33);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(314, 109);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            // 
            // tb_productName
            // 
            this.tb_productName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_productName.Location = new System.Drawing.Point(122, 33);
            this.tb_productName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.Size = new System.Drawing.Size(184, 21);
            this.tb_productName.TabIndex = 1;
            this.tb_productName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_productName_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Product Name :";
            // 
            // btn_addProduct_ProductName
            // 
            this.btn_addProduct_ProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addProduct_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_addProduct_ProductName.Location = new System.Drawing.Point(229, 75);
            this.btn_addProduct_ProductName.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addProduct_ProductName.Name = "btn_addProduct_ProductName";
            this.btn_addProduct_ProductName.Size = new System.Drawing.Size(77, 28);
            this.btn_addProduct_ProductName.TabIndex = 3;
            this.btn_addProduct_ProductName.Text = "Add";
            this.btn_addProduct_ProductName.UseVisualStyleBackColor = true;
            this.btn_addProduct_ProductName.Click += new System.EventHandler(this.btn_addProduct_ProductName_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_barCode);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.btn_addProductToBill);
            this.groupBox4.Location = new System.Drawing.Point(20, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(314, 112);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            // 
            // tb_barCode
            // 
            this.tb_barCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_barCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_barCode.Location = new System.Drawing.Point(93, 35);
            this.tb_barCode.Margin = new System.Windows.Forms.Padding(2);
            this.tb_barCode.Name = "tb_barCode";
            this.tb_barCode.Size = new System.Drawing.Size(184, 21);
            this.tb_barCode.TabIndex = 1;
            this.tb_barCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_barCode_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(5, 36);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 18);
            this.label15.TabIndex = 33;
            this.label15.Text = "Bar Code :";
            // 
            // btn_addProductToBill
            // 
            this.btn_addProductToBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addProductToBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_addProductToBill.Location = new System.Drawing.Point(200, 75);
            this.btn_addProductToBill.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addProductToBill.Name = "btn_addProductToBill";
            this.btn_addProductToBill.Size = new System.Drawing.Size(77, 28);
            this.btn_addProductToBill.TabIndex = 3;
            this.btn_addProductToBill.Text = "Add";
            this.btn_addProductToBill.UseVisualStyleBackColor = true;
            this.btn_addProductToBill.Click += new System.EventHandler(this.btn_addProductToBill_Click);
            // 
            // Bill_ProductsDataView
            // 
            this.Bill_ProductsDataView.AllowUserToAddRows = false;
            this.Bill_ProductsDataView.AllowUserToDeleteRows = false;
            this.Bill_ProductsDataView.AllowUserToOrderColumns = true;
            this.Bill_ProductsDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Bill_ProductsDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Bill_ProductsDataView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Bill_ProductsDataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Bill_ProductsDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Bill_ProductsDataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Bill_ProductsDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Bill_ProductsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bill_ProductsDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillTable_ProductId,
            this.BillTable_Name,
            this.BillTable_Price,
            this.BillTable_Quantity,
            this.BillTable_Discount,
            this.BillTable_Tax,
            this.BillTable_FinalPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Bill_ProductsDataView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Bill_ProductsDataView.GridColor = System.Drawing.Color.Black;
            this.Bill_ProductsDataView.Location = new System.Drawing.Point(25, 213);
            this.Bill_ProductsDataView.MultiSelect = false;
            this.Bill_ProductsDataView.Name = "Bill_ProductsDataView";
            this.Bill_ProductsDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Bill_ProductsDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Bill_ProductsDataView.RowHeadersVisible = false;
            this.Bill_ProductsDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.Bill_ProductsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Bill_ProductsDataView.Size = new System.Drawing.Size(711, 441);
            this.Bill_ProductsDataView.TabIndex = 25;
            this.Bill_ProductsDataView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Bill_ProductsDataView_CellEndEdit);
            this.Bill_ProductsDataView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bill_ProductsDataView_KeyDown);
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
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TransactionHistoryDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TransactionHistoryDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionHistoryDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Transaction_Date,
            this.Transaction_ID,
            this.Transaction_CustomerName,
            this.Transaction_TotalPrice});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TransactionHistoryDataView.DefaultCellStyle = dataGridViewCellStyle5;
            this.TransactionHistoryDataView.GridColor = System.Drawing.Color.Black;
            this.TransactionHistoryDataView.Location = new System.Drawing.Point(129, 297);
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
            this.TransactionHistoryDataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransactionHistoryDataView_CellDoubleClick);
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
            // Transaction_TotalPrice
            // 
            this.Transaction_TotalPrice.HeaderText = "Total Price (in Rs)";
            this.Transaction_TotalPrice.Name = "Transaction_TotalPrice";
            this.Transaction_TotalPrice.ReadOnly = true;
            // 
            // BillTable_ProductId
            // 
            this.BillTable_ProductId.HeaderText = "ID";
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
            this.BillTable_Price.HeaderText = "Price";
            this.BillTable_Price.Name = "BillTable_Price";
            this.BillTable_Price.ReadOnly = true;
            // 
            // BillTable_Quantity
            // 
            this.BillTable_Quantity.HeaderText = "Quantity";
            this.BillTable_Quantity.Name = "BillTable_Quantity";
            // 
            // BillTable_Discount
            // 
            this.BillTable_Discount.HeaderText = "Discount(Rs.)";
            this.BillTable_Discount.Name = "BillTable_Discount";
            this.BillTable_Discount.ReadOnly = true;
            // 
            // BillTable_Tax
            // 
            this.BillTable_Tax.HeaderText = "Tax";
            this.BillTable_Tax.Name = "BillTable_Tax";
            // 
            // BillTable_FinalPrice
            // 
            this.BillTable_FinalPrice.HeaderText = "Final Price";
            this.BillTable_FinalPrice.Name = "BillTable_FinalPrice";
            this.BillTable_FinalPrice.ReadOnly = true;
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
            this.tab_newTransaction.PerformLayout();
            this.gb_billDetails.ResumeLayout(false);
            this.gb_billDetails.PerformLayout();
            this.gb_customerDetails.ResumeLayout(false);
            this.gb_customerDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bill_ProductsDataView)).EndInit();
            this.tab_transactionHistory.ResumeLayout(false);
            this.tab_transactionHistory.PerformLayout();
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
        public System.Windows.Forms.TextBox tb_mobileNumber;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tb_customerName;
        public System.Windows.Forms.TextBox tb_pendingAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btn_ViewBill;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox tb_subtotal;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tb_totalDiscount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_addProductToBill;
        private System.Windows.Forms.GroupBox gb_billDetails;
        private System.Windows.Forms.GroupBox gb_customerDetails;
        public System.Windows.Forms.DataGridView TransactionHistoryDataView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker DateTime_fromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateTime_toDate;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cb_customerName;
        private System.Windows.Forms.Button btn_exportToExcel;
        private System.Windows.Forms.Button btn_searchByCustomerName;
        private System.Windows.Forms.Button btn_searchByDate;
        private System.Windows.Forms.Button btn_deleteBillRecord;
        public System.Windows.Forms.Label lbl_errorText;
        public System.Windows.Forms.Label lbl_transactionError;
        public System.Windows.Forms.Label lbl_customerError;
        public System.Windows.Forms.TextBox tb_totalTax;
        public System.Windows.Forms.TextBox tb_amountDue;
        private System.Windows.Forms.Button btn_resetTransaction;
        public System.Windows.Forms.TextBox tb_barCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_TotalPrice;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.TextBox tb_productName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_addProduct_ProductName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_AmountPaid;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lbl_errorAmountPaid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_AddNewCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTable_ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTable_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTable_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTable_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTable_Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTable_Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTable_FinalPrice;
    }
}
