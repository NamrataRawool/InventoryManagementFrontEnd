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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.ViewBill_ProductsDataView = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_TotalPrice = new System.Windows.Forms.Label();
            this.lbl_CustomerName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_amountPaid = new System.Windows.Forms.Label();
            this.ViewBillTable_ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewBillTable_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewBillTable_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewBillTable_FinalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBill_ProductsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.lbl_amountPaid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_back);
            this.groupBox1.Controls.Add(this.ViewBill_ProductsDataView);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_Date);
            this.groupBox1.Controls.Add(this.lbl_TotalPrice);
            this.groupBox1.Controls.Add(this.lbl_CustomerName);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(509, 681);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Details";
            // 
            // btn_back
            // 
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(298, 630);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(77, 33);
            this.btn_back.TabIndex = 48;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ViewBill_ProductsDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.ViewBill_ProductsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewBill_ProductsDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ViewBillTable_ProductId,
            this.ViewBillTable_ProductName,
            this.ViewBillTable_Quantity,
            this.ViewBillTable_FinalPrice});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ViewBill_ProductsDataView.DefaultCellStyle = dataGridViewCellStyle11;
            this.ViewBill_ProductsDataView.GridColor = System.Drawing.Color.Black;
            this.ViewBill_ProductsDataView.Location = new System.Drawing.Point(26, 287);
            this.ViewBill_ProductsDataView.MultiSelect = false;
            this.ViewBill_ProductsDataView.Name = "ViewBill_ProductsDataView";
            this.ViewBill_ProductsDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewBill_ProductsDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.ViewBill_ProductsDataView.RowHeadersVisible = false;
            this.ViewBill_ProductsDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.ViewBill_ProductsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ViewBill_ProductsDataView.Size = new System.Drawing.Size(452, 306);
            this.ViewBill_ProductsDataView.TabIndex = 45;
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(401, 630);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(77, 33);
            this.btn_save.TabIndex = 44;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 253);
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
            this.lbl_Date.Location = new System.Drawing.Point(199, 103);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(0, 18);
            this.lbl_Date.TabIndex = 42;
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
            // lbl_CustomerName
            // 
            this.lbl_CustomerName.AutoSize = true;
            this.lbl_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerName.Location = new System.Drawing.Point(199, 53);
            this.lbl_CustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CustomerName.Name = "lbl_CustomerName";
            this.lbl_CustomerName.Size = new System.Drawing.Size(0, 18);
            this.lbl_CustomerName.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 52);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 18);
            this.label13.TabIndex = 26;
            this.label13.Text = "Customer Name :";
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
            this.label16.Text = "Transaction Date :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 49;
            this.label2.Text = "Amount Paid :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_amountPaid
            // 
            this.lbl_amountPaid.AutoSize = true;
            this.lbl_amountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amountPaid.Location = new System.Drawing.Point(199, 203);
            this.lbl_amountPaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_amountPaid.Name = "lbl_amountPaid";
            this.lbl_amountPaid.Size = new System.Drawing.Size(0, 18);
            this.lbl_amountPaid.TabIndex = 50;
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
            // Form_ViewBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 732);
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
        public System.Windows.Forms.Label lbl_CustomerName;
        public System.Windows.Forms.Label lbl_TotalPrice;
        public System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.DataGridView ViewBill_ProductsDataView;
        public System.Windows.Forms.Button btn_back;
        public System.Windows.Forms.Label lbl_amountPaid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewBillTable_ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewBillTable_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewBillTable_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewBillTable_FinalPrice;
    }
}