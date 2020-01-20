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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PurchaseBill_ProductsDataView = new System.Windows.Forms.DataGridView();
            this.PurchaseTable_ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTable_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTable_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTable_PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_PurchaseDate = new System.Windows.Forms.Label();
            this.lbl_TotalPrice = new System.Windows.Forms.Label();
            this.lbl_VendorName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseBill_ProductsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.PurchaseBill_ProductsDataView);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_PurchaseDate);
            this.groupBox1.Controls.Add(this.lbl_TotalPrice);
            this.groupBox1.Controls.Add(this.lbl_VendorName);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(509, 599);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Details";
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PurchaseBill_ProductsDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PurchaseBill_ProductsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchaseBill_ProductsDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchaseTable_ProductId,
            this.PurchaseTable_ProductName,
            this.PurchaseTable_Quantity,
            this.PurchaseTable_PurchasePrice});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PurchaseBill_ProductsDataView.DefaultCellStyle = dataGridViewCellStyle5;
            this.PurchaseBill_ProductsDataView.GridColor = System.Drawing.Color.Black;
            this.PurchaseBill_ProductsDataView.Location = new System.Drawing.Point(26, 244);
            this.PurchaseBill_ProductsDataView.MultiSelect = false;
            this.PurchaseBill_ProductsDataView.Name = "PurchaseBill_ProductsDataView";
            this.PurchaseBill_ProductsDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PurchaseBill_ProductsDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.PurchaseBill_ProductsDataView.RowHeadersVisible = false;
            this.PurchaseBill_ProductsDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.PurchaseBill_ProductsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PurchaseBill_ProductsDataView.Size = new System.Drawing.Size(452, 306);
            this.PurchaseBill_ProductsDataView.TabIndex = 45;
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
            // PurchaseTable_PurchasePrice
            // 
            this.PurchaseTable_PurchasePrice.HeaderText = "Purchase Price";
            this.PurchaseTable_PurchasePrice.Name = "PurchaseTable_PurchasePrice";
            this.PurchaseTable_PurchasePrice.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 198);
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
            this.lbl_PurchaseDate.Location = new System.Drawing.Point(199, 103);
            this.lbl_PurchaseDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_PurchaseDate.Name = "lbl_PurchaseDate";
            this.lbl_PurchaseDate.Size = new System.Drawing.Size(0, 18);
            this.lbl_PurchaseDate.TabIndex = 42;
            // 
            // lbl_TotalPrice
            // 
            this.lbl_TotalPrice.AutoSize = true;
            this.lbl_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalPrice.Location = new System.Drawing.Point(199, 153);
            this.lbl_TotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TotalPrice.Name = "lbl_TotalPrice";
            this.lbl_TotalPrice.Size = new System.Drawing.Size(0, 18);
            this.lbl_TotalPrice.TabIndex = 40;
            // 
            // lbl_VendorName
            // 
            this.lbl_VendorName.AutoSize = true;
            this.lbl_VendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VendorName.Location = new System.Drawing.Point(199, 53);
            this.lbl_VendorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_VendorName.Name = "lbl_VendorName";
            this.lbl_VendorName.Size = new System.Drawing.Size(0, 18);
            this.lbl_VendorName.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 52);
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
            this.label14.Location = new System.Drawing.Point(23, 152);
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
            this.label16.Location = new System.Drawing.Point(23, 102);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 18);
            this.label16.TabIndex = 28;
            this.label16.Text = "Purchase Date :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form_ViewPuchaseBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 653);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_ViewPuchaseBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Bill";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseBill_ProductsDataView)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTable_ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTable_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTable_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTable_PurchasePrice;
    }
}