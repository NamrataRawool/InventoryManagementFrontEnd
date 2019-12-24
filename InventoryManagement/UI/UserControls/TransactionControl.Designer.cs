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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Bill_ProductsDataView = new System.Windows.Forms.DataGridView();
            this.billControl1 = new InventoryManagement.UI.UserControls.BillControl();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_subTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_discountedPrice = new System.Windows.Forms.Label();
            this.BillTable_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTable_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTable_Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTable_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTable_TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bill_ProductsDataView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.00036F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.8049F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.1879F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.00036F));
            this.tableLayoutPanel1.Controls.Add(this.Bill_ProductsDataView, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.billControl1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.48897F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.59596F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.98413F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1389, 693);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Bill_ProductsDataView
            // 
            this.Bill_ProductsDataView.AllowUserToOrderColumns = true;
            this.Bill_ProductsDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Bill_ProductsDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Bill_ProductsDataView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.Bill_ProductsDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Bill_ProductsDataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Bill_ProductsDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Bill_ProductsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bill_ProductsDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillTable_Name,
            this.BillTable_Price,
            this.BillTable_Discount,
            this.BillTable_Quantity,
            this.BillTable_TotalPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(175)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Bill_ProductsDataView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Bill_ProductsDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bill_ProductsDataView.GridColor = System.Drawing.Color.Black;
            this.Bill_ProductsDataView.Location = new System.Drawing.Point(612, 97);
            this.Bill_ProductsDataView.Margin = new System.Windows.Forms.Padding(4);
            this.Bill_ProductsDataView.MultiSelect = false;
            this.Bill_ProductsDataView.Name = "Bill_ProductsDataView";
            this.Bill_ProductsDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Bill_ProductsDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Bill_ProductsDataView.RowHeadersVisible = false;
            this.Bill_ProductsDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.Bill_ProductsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Bill_ProductsDataView.Size = new System.Drawing.Size(703, 404);
            this.Bill_ProductsDataView.TabIndex = 3;
            this.Bill_ProductsDataView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Bill_ProductsDataView_CellBeginEdit);
            this.Bill_ProductsDataView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Bill_ProductsDataView_CellEndEdit);
            // 
            // billControl1
            // 
            this.billControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billControl1.Location = new System.Drawing.Point(72, 96);
            this.billControl1.Name = "billControl1";
            this.billControl1.Size = new System.Drawing.Size(533, 406);
            this.billControl1.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.98478F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.01522F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_subTotal, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_discountedPrice, 3, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(611, 508);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.59406F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.58416F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(705, 182);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "Subtotal";
            // 
            // lbl_subTotal
            // 
            this.lbl_subTotal.AutoSize = true;
            this.lbl_subTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_subTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subTotal.Location = new System.Drawing.Point(557, 20);
            this.lbl_subTotal.Name = "lbl_subTotal";
            this.lbl_subTotal.Size = new System.Drawing.Size(145, 44);
            this.lbl_subTotal.TabIndex = 1;
            this.lbl_subTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Discount";
            // 
            // lbl_discountedPrice
            // 
            this.lbl_discountedPrice.AutoSize = true;
            this.lbl_discountedPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discountedPrice.Location = new System.Drawing.Point(557, 64);
            this.lbl_discountedPrice.Name = "lbl_discountedPrice";
            this.lbl_discountedPrice.Size = new System.Drawing.Size(23, 25);
            this.lbl_discountedPrice.TabIndex = 3;
            this.lbl_discountedPrice.Text = "0";
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
            // BillTable_Discount
            // 
            this.BillTable_Discount.HeaderText = "Discount";
            this.BillTable_Discount.Name = "BillTable_Discount";
            // 
            // BillTable_Quantity
            // 
            this.BillTable_Quantity.HeaderText = "Quantity";
            this.BillTable_Quantity.Name = "BillTable_Quantity";
            // 
            // BillTable_TotalPrice
            // 
            this.BillTable_TotalPrice.HeaderText = "Total Price";
            this.BillTable_TotalPrice.Name = "BillTable_TotalPrice";
            this.BillTable_TotalPrice.ReadOnly = true;
            // 
            // TransactionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TransactionControl";
            this.Size = new System.Drawing.Size(1389, 693);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Bill_ProductsDataView)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.DataGridView Bill_ProductsDataView;
        private BillControl billControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_subTotal;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_discountedPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTable_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTable_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTable_Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTable_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTable_TotalPrice;
    }
}
