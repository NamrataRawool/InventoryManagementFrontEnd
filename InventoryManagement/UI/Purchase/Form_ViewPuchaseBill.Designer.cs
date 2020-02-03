namespace InventoryManagement.UI.Purchase
{
    partial class Form_ViewPuchaseBill
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
            this.PurchaseBill_ProductsDataView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_PurchaseDate = new System.Windows.Forms.Label();
            this.lbl_TotalPrice = new System.Windows.Forms.Label();
            this.lbl_VendorName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.PurchaseTable_ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTable_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTable_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTable_ActualPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTable_DiscountedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_amountPaid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_TotalDiscount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseBill_ProductsDataView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.lbl_TotalDiscount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_amountPaid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PurchaseBill_ProductsDataView);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_PurchaseDate);
            this.groupBox1.Controls.Add(this.lbl_TotalPrice);
            this.groupBox1.Controls.Add(this.lbl_VendorName);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(664, 607);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // PurchaseBill_ProductsDataView
            // 
            this.PurchaseBill_ProductsDataView.AllowUserToAddRows = false;
            this.PurchaseBill_ProductsDataView.AllowUserToOrderColumns = true;
            this.PurchaseBill_ProductsDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PurchaseBill_ProductsDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PurchaseBill_ProductsDataView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.PurchaseBill_ProductsDataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PurchaseBill_ProductsDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.PurchaseBill_ProductsDataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PurchaseBill_ProductsDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PurchaseBill_ProductsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchaseBill_ProductsDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchaseTable_ProductId,
            this.PurchaseTable_ProductName,
            this.PurchaseTable_Quantity,
            this.PurchaseTable_ActualPrice,
            this.PurchaseTable_DiscountedPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PurchaseBill_ProductsDataView.DefaultCellStyle = dataGridViewCellStyle2;
            this.PurchaseBill_ProductsDataView.GridColor = System.Drawing.Color.Black;
            this.PurchaseBill_ProductsDataView.Location = new System.Drawing.Point(26, 273);
            this.PurchaseBill_ProductsDataView.MultiSelect = false;
            this.PurchaseBill_ProductsDataView.Name = "PurchaseBill_ProductsDataView";
            this.PurchaseBill_ProductsDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PurchaseBill_ProductsDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.PurchaseBill_ProductsDataView.RowHeadersVisible = false;
            this.PurchaseBill_ProductsDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.PurchaseBill_ProductsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PurchaseBill_ProductsDataView.Size = new System.Drawing.Size(608, 306);
            this.PurchaseBill_ProductsDataView.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 236);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 43;
            this.label1.Text = "Product Details :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_PurchaseDate
            // 
            this.lbl_PurchaseDate.AutoSize = true;
            this.lbl_PurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PurchaseDate.Location = new System.Drawing.Point(199, 66);
            this.lbl_PurchaseDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_PurchaseDate.Name = "lbl_PurchaseDate";
            this.lbl_PurchaseDate.Size = new System.Drawing.Size(0, 18);
            this.lbl_PurchaseDate.TabIndex = 42;
            // 
            // lbl_TotalPrice
            // 
            this.lbl_TotalPrice.AutoSize = true;
            this.lbl_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalPrice.Location = new System.Drawing.Point(199, 110);
            this.lbl_TotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TotalPrice.Name = "lbl_TotalPrice";
            this.lbl_TotalPrice.Size = new System.Drawing.Size(0, 18);
            this.lbl_TotalPrice.TabIndex = 40;
            // 
            // lbl_VendorName
            // 
            this.lbl_VendorName.AutoSize = true;
            this.lbl_VendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VendorName.Location = new System.Drawing.Point(199, 22);
            this.lbl_VendorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_VendorName.Name = "lbl_VendorName";
            this.lbl_VendorName.Size = new System.Drawing.Size(0, 18);
            this.lbl_VendorName.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 21);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 18);
            this.label13.TabIndex = 26;
            this.label13.Text = "Vendor Name :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 109);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 18);
            this.label14.TabIndex = 25;
            this.label14.Text = "Total Price :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 65);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 18);
            this.label16.TabIndex = 28;
            this.label16.Text = "Purchase Date :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 43);
            this.panel1.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(161, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Purchase Details";
            // 
            // PurchaseTable_ProductId
            // 
            this.PurchaseTable_ProductId.HeaderText = "ID";
            this.PurchaseTable_ProductId.Name = "PurchaseTable_ProductId";
            this.PurchaseTable_ProductId.ReadOnly = true;
            // 
            // PurchaseTable_ProductName
            // 
            this.PurchaseTable_ProductName.HeaderText = "Name";
            this.PurchaseTable_ProductName.Name = "PurchaseTable_ProductName";
            this.PurchaseTable_ProductName.ReadOnly = true;
            // 
            // PurchaseTable_Quantity
            // 
            this.PurchaseTable_Quantity.HeaderText = "Quantity";
            this.PurchaseTable_Quantity.Name = "PurchaseTable_Quantity";
            // 
            // PurchaseTable_ActualPrice
            // 
            this.PurchaseTable_ActualPrice.HeaderText = "Actual Price";
            this.PurchaseTable_ActualPrice.Name = "PurchaseTable_ActualPrice";
            this.PurchaseTable_ActualPrice.ReadOnly = true;
            // 
            // PurchaseTable_DiscountedPrice
            // 
            this.PurchaseTable_DiscountedPrice.HeaderText = "Discounted Price";
            this.PurchaseTable_DiscountedPrice.Name = "PurchaseTable_DiscountedPrice";
            this.PurchaseTable_DiscountedPrice.ReadOnly = true;
            // 
            // lbl_amountPaid
            // 
            this.lbl_amountPaid.AutoSize = true;
            this.lbl_amountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amountPaid.Location = new System.Drawing.Point(199, 154);
            this.lbl_amountPaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_amountPaid.Name = "lbl_amountPaid";
            this.lbl_amountPaid.Size = new System.Drawing.Size(0, 18);
            this.lbl_amountPaid.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 46;
            this.label3.Text = "Amount Paid :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_TotalDiscount
            // 
            this.lbl_TotalDiscount.AutoSize = true;
            this.lbl_TotalDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalDiscount.Location = new System.Drawing.Point(199, 198);
            this.lbl_TotalDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TotalDiscount.Name = "lbl_TotalDiscount";
            this.lbl_TotalDiscount.Size = new System.Drawing.Size(0, 18);
            this.lbl_TotalDiscount.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 18);
            this.label4.TabIndex = 48;
            this.label4.Text = " Total Discount :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form_ViewPuchaseBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_ViewPuchaseBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Bill";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseBill_ProductsDataView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView PurchaseBill_ProductsDataView;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_PurchaseDate;
        public System.Windows.Forms.Label lbl_TotalPrice;
        public System.Windows.Forms.Label lbl_VendorName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTable_ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTable_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTable_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTable_ActualPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTable_DiscountedPrice;
        public System.Windows.Forms.Label lbl_amountPaid;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbl_TotalDiscount;
        private System.Windows.Forms.Label label4;
    }
}