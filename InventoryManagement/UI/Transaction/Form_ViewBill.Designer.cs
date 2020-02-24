namespace InventoryManagement.UI.Transaction
{
    partial class Form_ViewBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_pendingAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_amountPaid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewBill_ProductsDataView = new System.Windows.Forms.DataGridView();
            this.ViewBillTable_ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewBillTable_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewBillTable_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewBillTable_FinalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_amountDue = new System.Windows.Forms.Label();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.lbl_CustomerName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBill_ProductsDataView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.lbl_pendingAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_amountPaid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ViewBill_ProductsDataView);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_Date);
            this.groupBox1.Controls.Add(this.lbl_amountDue);
            this.groupBox1.Controls.Add(this.lbl_subtotal);
            this.groupBox1.Controls.Add(this.lbl_CustomerName);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(509, 620);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // lbl_pendingAmount
            // 
            this.lbl_pendingAmount.AutoSize = true;
            this.lbl_pendingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pendingAmount.Location = new System.Drawing.Point(200, 192);
            this.lbl_pendingAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pendingAmount.Name = "lbl_pendingAmount";
            this.lbl_pendingAmount.Size = new System.Drawing.Size(0, 18);
            this.lbl_pendingAmount.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "Pending Amount :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_amountPaid
            // 
            this.lbl_amountPaid.AutoSize = true;
            this.lbl_amountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amountPaid.Location = new System.Drawing.Point(200, 158);
            this.lbl_amountPaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_amountPaid.Name = "lbl_amountPaid";
            this.lbl_amountPaid.Size = new System.Drawing.Size(0, 18);
            this.lbl_amountPaid.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 49;
            this.label2.Text = "Paid Amount :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ViewBill_ProductsDataView
            // 
            this.ViewBill_ProductsDataView.AllowUserToAddRows = false;
            this.ViewBill_ProductsDataView.AllowUserToOrderColumns = true;
            this.ViewBill_ProductsDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewBill_ProductsDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ViewBill_ProductsDataView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ViewBill_ProductsDataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ViewBill_ProductsDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ViewBill_ProductsDataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ViewBill_ProductsDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ViewBill_ProductsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewBill_ProductsDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ViewBillTable_ProductId,
            this.ViewBillTable_ProductName,
            this.ViewBillTable_Quantity,
            this.ViewBillTable_FinalPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ViewBill_ProductsDataView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ViewBill_ProductsDataView.GridColor = System.Drawing.Color.Black;
            this.ViewBill_ProductsDataView.Location = new System.Drawing.Point(26, 275);
            this.ViewBill_ProductsDataView.MultiSelect = false;
            this.ViewBill_ProductsDataView.Name = "ViewBill_ProductsDataView";
            this.ViewBill_ProductsDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewBill_ProductsDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ViewBill_ProductsDataView.RowHeadersVisible = false;
            this.ViewBill_ProductsDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.ViewBill_ProductsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ViewBill_ProductsDataView.Size = new System.Drawing.Size(452, 306);
            this.ViewBill_ProductsDataView.TabIndex = 45;
            // 
            // ViewBillTable_ProductId
            // 
            this.ViewBillTable_ProductId.HeaderText = "ID";
            this.ViewBillTable_ProductId.Name = "ViewBillTable_ProductId";
            this.ViewBillTable_ProductId.ReadOnly = true;
            // 
            // ViewBillTable_ProductName
            // 
            this.ViewBillTable_ProductName.HeaderText = "Name";
            this.ViewBillTable_ProductName.Name = "ViewBillTable_ProductName";
            this.ViewBillTable_ProductName.ReadOnly = true;
            // 
            // ViewBillTable_Quantity
            // 
            this.ViewBillTable_Quantity.HeaderText = "Quantity";
            this.ViewBillTable_Quantity.Name = "ViewBillTable_Quantity";
            // 
            // ViewBillTable_FinalPrice
            // 
            this.ViewBillTable_FinalPrice.HeaderText = "Final Price";
            this.ViewBillTable_FinalPrice.Name = "ViewBillTable_FinalPrice";
            this.ViewBillTable_FinalPrice.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 43;
            this.label1.Text = "Product Details :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(200, 56);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(0, 18);
            this.lbl_Date.TabIndex = 42;
            // 
            // lbl_amountDue
            // 
            this.lbl_amountDue.AutoSize = true;
            this.lbl_amountDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amountDue.Location = new System.Drawing.Point(200, 124);
            this.lbl_amountDue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_amountDue.Name = "lbl_amountDue";
            this.lbl_amountDue.Size = new System.Drawing.Size(0, 18);
            this.lbl_amountDue.TabIndex = 40;
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtotal.Location = new System.Drawing.Point(200, 90);
            this.lbl_subtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(0, 18);
            this.lbl_subtotal.TabIndex = 40;
            // 
            // lbl_CustomerName
            // 
            this.lbl_CustomerName.AutoSize = true;
            this.lbl_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerName.Location = new System.Drawing.Point(200, 22);
            this.lbl_CustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CustomerName.Name = "lbl_CustomerName";
            this.lbl_CustomerName.Size = new System.Drawing.Size(0, 18);
            this.lbl_CustomerName.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 21);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 18);
            this.label13.TabIndex = 26;
            this.label13.Text = "Customer Name :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Amount Due :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 89);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 18);
            this.label14.TabIndex = 25;
            this.label14.Text = "Subtotal :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 55);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 18);
            this.label16.TabIndex = 28;
            this.label16.Text = "Transaction Date :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_back
            // 
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(294, 687);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(77, 33);
            this.btn_back.TabIndex = 48;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_print
            // 
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(412, 687);
            this.btn_print.Margin = new System.Windows.Forms.Padding(2);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(77, 33);
            this.btn_print.TabIndex = 44;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 43);
            this.panel1.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(161, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Transaction Details";
            // 
            // Form_ViewBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 747);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_print);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_ViewBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Form_ViewBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBill_ProductsDataView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label lbl_CustomerName;
        public System.Windows.Forms.Label lbl_subtotal;
        public System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_print;
        public System.Windows.Forms.DataGridView ViewBill_ProductsDataView;
        public System.Windows.Forms.Button btn_back;
        public System.Windows.Forms.Label lbl_amountPaid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewBillTable_ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewBillTable_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewBillTable_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewBillTable_FinalPrice;
        public System.Windows.Forms.Label lbl_pendingAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lbl_amountDue;
        private System.Windows.Forms.Label label3;
    }
}