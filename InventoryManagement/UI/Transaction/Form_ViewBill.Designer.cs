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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ViewBill_ProductsDataView = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_totalTax = new System.Windows.Forms.Label();
            this.lbl_TotalPrice = new System.Windows.Forms.Label();
            this.lbl_CustomerName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_printBill = new System.Windows.Forms.Button();
            this.ViewBillTable_ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewBillTable_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewBillTable_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewBillTable_TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBill_ProductsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.ViewBill_ProductsDataView);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_Date);
            this.groupBox1.Controls.Add(this.lbl_totalTax);
            this.groupBox1.Controls.Add(this.lbl_TotalPrice);
            this.groupBox1.Controls.Add(this.lbl_CustomerName);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_printBill);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(605, 681);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Details";
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ViewBill_ProductsDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ViewBill_ProductsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewBill_ProductsDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ViewBillTable_ProductId,
            this.ViewBillTable_ProductName,
            this.ViewBillTable_Quantity,
            this.ViewBillTable_TotalPrice});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ViewBill_ProductsDataView.DefaultCellStyle = dataGridViewCellStyle5;
            this.ViewBill_ProductsDataView.GridColor = System.Drawing.Color.Black;
            this.ViewBill_ProductsDataView.Location = new System.Drawing.Point(28, 261);
            this.ViewBill_ProductsDataView.MultiSelect = false;
            this.ViewBill_ProductsDataView.Name = "ViewBill_ProductsDataView";
            this.ViewBill_ProductsDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewBill_ProductsDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ViewBill_ProductsDataView.RowHeadersVisible = false;
            this.ViewBill_ProductsDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.ViewBill_ProductsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ViewBill_ProductsDataView.Size = new System.Drawing.Size(536, 306);
            this.ViewBill_ProductsDataView.TabIndex = 45;
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(367, 617);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(77, 33);
            this.btn_cancel.TabIndex = 44;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 43;
            this.label1.Text = "Product Details";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(188, 173);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(0, 18);
            this.lbl_Date.TabIndex = 42;
            // 
            // lbl_totalTax
            // 
            this.lbl_totalTax.AutoSize = true;
            this.lbl_totalTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalTax.Location = new System.Drawing.Point(188, 129);
            this.lbl_totalTax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_totalTax.Name = "lbl_totalTax";
            this.lbl_totalTax.Size = new System.Drawing.Size(0, 18);
            this.lbl_totalTax.TabIndex = 41;
            // 
            // lbl_TotalPrice
            // 
            this.lbl_TotalPrice.AutoSize = true;
            this.lbl_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalPrice.Location = new System.Drawing.Point(188, 85);
            this.lbl_TotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TotalPrice.Name = "lbl_TotalPrice";
            this.lbl_TotalPrice.Size = new System.Drawing.Size(0, 18);
            this.lbl_TotalPrice.TabIndex = 40;
            // 
            // lbl_CustomerName
            // 
            this.lbl_CustomerName.AutoSize = true;
            this.lbl_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerName.Location = new System.Drawing.Point(188, 40);
            this.lbl_CustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CustomerName.Name = "lbl_CustomerName";
            this.lbl_CustomerName.Size = new System.Drawing.Size(0, 18);
            this.lbl_CustomerName.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 40);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 18);
            this.label13.TabIndex = 26;
            this.label13.Text = "Customer Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 85);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 18);
            this.label14.TabIndex = 25;
            this.label14.Text = "Total Price";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(25, 173);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 18);
            this.label16.TabIndex = 28;
            this.label16.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Total Tax";
            // 
            // btn_printBill
            // 
            this.btn_printBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_printBill.Location = new System.Drawing.Point(478, 617);
            this.btn_printBill.Margin = new System.Windows.Forms.Padding(2);
            this.btn_printBill.Name = "btn_printBill";
            this.btn_printBill.Size = new System.Drawing.Size(86, 33);
            this.btn_printBill.TabIndex = 7;
            this.btn_printBill.Text = "Print Bill";
            this.btn_printBill.UseVisualStyleBackColor = true;
            // 
            // ViewBillTable_ProductId
            // 
            this.ViewBillTable_ProductId.HeaderText = "Product Id";
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
            // ViewBillTable_TotalPrice
            // 
            this.ViewBillTable_TotalPrice.HeaderText = "Total Price (in Rs)";
            this.ViewBillTable_TotalPrice.Name = "ViewBillTable_TotalPrice";
            this.ViewBillTable_TotalPrice.ReadOnly = true;
            // 
            // Form_ViewBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 732);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_ViewBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Form_ViewBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBill_ProductsDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btn_printBill;
        public System.Windows.Forms.Label lbl_CustomerName;
        public System.Windows.Forms.Label lbl_TotalPrice;
        public System.Windows.Forms.Label lbl_totalTax;
        public System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.DataGridView ViewBill_ProductsDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewBillTable_ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewBillTable_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewBillTable_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewBillTable_TotalPrice;
    }
}