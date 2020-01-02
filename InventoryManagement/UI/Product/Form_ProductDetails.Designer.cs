namespace InventoryManagement.UI.Product
{
    partial class Form_ProductDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_ChangeProductImage = new System.Windows.Forms.Button();
            this.GroupBox_ProductDetails = new System.Windows.Forms.GroupBox();
            this.tf_ProductDetails_Description = new System.Windows.Forms.TextBox();
            this.Label_Description = new System.Windows.Forms.Label();
            this.tf_ProductDetails_Barcode = new System.Windows.Forms.TextBox();
            this.Label_Barcode = new System.Windows.Forms.Label();
            this.Button_UpdateProductDetails = new System.Windows.Forms.Button();
            this.cb_ProductDetails_Category = new System.Windows.Forms.ComboBox();
            this.tf_ProductDetails_WholesalePrice = new System.Windows.Forms.TextBox();
            this.tf_ProductDetails_RetailPrice = new System.Windows.Forms.TextBox();
            this.tf_ProductDetails_ProductName = new System.Windows.Forms.TextBox();
            this.tf_ProductDetails_ProductID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_ProductID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_AddStock_Vendor = new System.Windows.Forms.ComboBox();
            this.btn_AddStockAddStock = new System.Windows.Forms.Button();
            this.tf_AddStock_BuyingPrice = new System.Windows.Forms.TextBox();
            this.tf_AddStock_Quantity = new System.Windows.Forms.TextBox();
            this.datePicker_AddStock_Date = new System.Windows.Forms.DateTimePicker();
            this.Label_AddStockBuyingPrice = new System.Windows.Forms.Label();
            this.Label_AddStockQuantity = new System.Windows.Forms.Label();
            this.Label_AddStockDate = new System.Windows.Forms.Label();
            this.Label_AddStockVendor = new System.Windows.Forms.Label();
            this.lbl_ProductDetails_AvailableStock = new System.Windows.Forms.Label();
            this.pictureBox_ProductImage = new System.Windows.Forms.PictureBox();
            this.lbl_ProductDetails_AvailableStockValue = new System.Windows.Forms.Label();
            this.table_StockHistory = new System.Windows.Forms.DataGridView();
            this.StockHistoryColumn_TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockHistoryColumn_BuyingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockHistoryColumn_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockHistoryColumn_Vendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockHIstoryTable_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox_ProductDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_StockHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ChangeProductImage
            // 
            this.btn_ChangeProductImage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ChangeProductImage.Location = new System.Drawing.Point(194, 120);
            this.btn_ChangeProductImage.Name = "btn_ChangeProductImage";
            this.btn_ChangeProductImage.Size = new System.Drawing.Size(75, 23);
            this.btn_ChangeProductImage.TabIndex = 1;
            this.btn_ChangeProductImage.Text = "Change";
            this.btn_ChangeProductImage.UseVisualStyleBackColor = true;
            this.btn_ChangeProductImage.Click += new System.EventHandler(this.btn_ChangeProductImage_Click);
            // 
            // GroupBox_ProductDetails
            // 
            this.GroupBox_ProductDetails.Controls.Add(this.tf_ProductDetails_Description);
            this.GroupBox_ProductDetails.Controls.Add(this.tf_ProductDetails_ProductID);
            this.GroupBox_ProductDetails.Controls.Add(this.label3);
            this.GroupBox_ProductDetails.Controls.Add(this.Label_Description);
            this.GroupBox_ProductDetails.Controls.Add(this.label4);
            this.GroupBox_ProductDetails.Controls.Add(this.label2);
            this.GroupBox_ProductDetails.Controls.Add(this.tf_ProductDetails_Barcode);
            this.GroupBox_ProductDetails.Controls.Add(this.label1);
            this.GroupBox_ProductDetails.Controls.Add(this.tf_ProductDetails_ProductName);
            this.GroupBox_ProductDetails.Controls.Add(this.Label_Barcode);
            this.GroupBox_ProductDetails.Controls.Add(this.Label_ProductID);
            this.GroupBox_ProductDetails.Controls.Add(this.tf_ProductDetails_RetailPrice);
            this.GroupBox_ProductDetails.Controls.Add(this.Button_UpdateProductDetails);
            this.GroupBox_ProductDetails.Controls.Add(this.tf_ProductDetails_WholesalePrice);
            this.GroupBox_ProductDetails.Controls.Add(this.cb_ProductDetails_Category);
            this.GroupBox_ProductDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_ProductDetails.Location = new System.Drawing.Point(12, 162);
            this.GroupBox_ProductDetails.Name = "GroupBox_ProductDetails";
            this.GroupBox_ProductDetails.Size = new System.Drawing.Size(362, 324);
            this.GroupBox_ProductDetails.TabIndex = 4;
            this.GroupBox_ProductDetails.TabStop = false;
            this.GroupBox_ProductDetails.Text = "Product Details";
            // 
            // tf_ProductDetails_Description
            // 
            this.tf_ProductDetails_Description.Location = new System.Drawing.Point(144, 131);
            this.tf_ProductDetails_Description.Name = "tf_ProductDetails_Description";
            this.tf_ProductDetails_Description.Size = new System.Drawing.Size(186, 22);
            this.tf_ProductDetails_Description.TabIndex = 14;
            // 
            // Label_Description
            // 
            this.Label_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_Description.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Description.Location = new System.Drawing.Point(15, 127);
            this.Label_Description.Name = "Label_Description";
            this.Label_Description.Size = new System.Drawing.Size(123, 26);
            this.Label_Description.TabIndex = 13;
            this.Label_Description.Text = "Description : ";
            this.Label_Description.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tf_ProductDetails_Barcode
            // 
            this.tf_ProductDetails_Barcode.Location = new System.Drawing.Point(144, 64);
            this.tf_ProductDetails_Barcode.Name = "tf_ProductDetails_Barcode";
            this.tf_ProductDetails_Barcode.Size = new System.Drawing.Size(186, 22);
            this.tf_ProductDetails_Barcode.TabIndex = 12;
            // 
            // Label_Barcode
            // 
            this.Label_Barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_Barcode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Barcode.Location = new System.Drawing.Point(15, 60);
            this.Label_Barcode.Name = "Label_Barcode";
            this.Label_Barcode.Size = new System.Drawing.Size(123, 26);
            this.Label_Barcode.TabIndex = 11;
            this.Label_Barcode.Text = "Barcode : ";
            this.Label_Barcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Button_UpdateProductDetails
            // 
            this.Button_UpdateProductDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_UpdateProductDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_UpdateProductDetails.Location = new System.Drawing.Point(246, 272);
            this.Button_UpdateProductDetails.Name = "Button_UpdateProductDetails";
            this.Button_UpdateProductDetails.Size = new System.Drawing.Size(90, 30);
            this.Button_UpdateProductDetails.TabIndex = 10;
            this.Button_UpdateProductDetails.Text = "Update";
            this.Button_UpdateProductDetails.UseVisualStyleBackColor = true;
            this.Button_UpdateProductDetails.Click += new System.EventHandler(this.Button_UpdateProductDetails_Click);
            // 
            // cb_ProductDetails_Category
            // 
            this.cb_ProductDetails_Category.FormattingEnabled = true;
            this.cb_ProductDetails_Category.Location = new System.Drawing.Point(144, 166);
            this.cb_ProductDetails_Category.Name = "cb_ProductDetails_Category";
            this.cb_ProductDetails_Category.Size = new System.Drawing.Size(186, 24);
            this.cb_ProductDetails_Category.TabIndex = 9;
            // 
            // tf_ProductDetails_WholesalePrice
            // 
            this.tf_ProductDetails_WholesalePrice.Location = new System.Drawing.Point(144, 235);
            this.tf_ProductDetails_WholesalePrice.Name = "tf_ProductDetails_WholesalePrice";
            this.tf_ProductDetails_WholesalePrice.Size = new System.Drawing.Size(186, 22);
            this.tf_ProductDetails_WholesalePrice.TabIndex = 8;
            // 
            // tf_ProductDetails_RetailPrice
            // 
            this.tf_ProductDetails_RetailPrice.Location = new System.Drawing.Point(144, 203);
            this.tf_ProductDetails_RetailPrice.Name = "tf_ProductDetails_RetailPrice";
            this.tf_ProductDetails_RetailPrice.Size = new System.Drawing.Size(186, 22);
            this.tf_ProductDetails_RetailPrice.TabIndex = 7;
            // 
            // tf_ProductDetails_ProductName
            // 
            this.tf_ProductDetails_ProductName.Location = new System.Drawing.Point(144, 97);
            this.tf_ProductDetails_ProductName.Name = "tf_ProductDetails_ProductName";
            this.tf_ProductDetails_ProductName.Size = new System.Drawing.Size(186, 22);
            this.tf_ProductDetails_ProductName.TabIndex = 6;
            // 
            // tf_ProductDetails_ProductID
            // 
            this.tf_ProductDetails_ProductID.Enabled = false;
            this.tf_ProductDetails_ProductID.Location = new System.Drawing.Point(144, 33);
            this.tf_ProductDetails_ProductID.Name = "tf_ProductDetails_ProductID";
            this.tf_ProductDetails_ProductID.Size = new System.Drawing.Size(186, 22);
            this.tf_ProductDetails_ProductID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(15, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Wholesale Price : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(15, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Retail Price : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_ProductID
            // 
            this.Label_ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_ProductID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_ProductID.Location = new System.Drawing.Point(17, 29);
            this.Label_ProductID.Name = "Label_ProductID";
            this.Label_ProductID.Size = new System.Drawing.Size(123, 26);
            this.Label_ProductID.TabIndex = 0;
            this.Label_ProductID.Text = "Product ID : ";
            this.Label_ProductID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.cb_AddStock_Vendor);
            this.groupBox1.Controls.Add(this.btn_AddStockAddStock);
            this.groupBox1.Controls.Add(this.Label_AddStockVendor);
            this.groupBox1.Controls.Add(this.tf_AddStock_BuyingPrice);
            this.groupBox1.Controls.Add(this.Label_AddStockDate);
            this.groupBox1.Controls.Add(this.tf_AddStock_Quantity);
            this.groupBox1.Controls.Add(this.Label_AddStockQuantity);
            this.groupBox1.Controls.Add(this.datePicker_AddStock_Date);
            this.groupBox1.Controls.Add(this.Label_AddStockBuyingPrice);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 492);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 201);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Stock";
            // 
            // cb_AddStock_Vendor
            // 
            this.cb_AddStock_Vendor.FormattingEnabled = true;
            this.cb_AddStock_Vendor.Location = new System.Drawing.Point(145, 36);
            this.cb_AddStock_Vendor.Name = "cb_AddStock_Vendor";
            this.cb_AddStock_Vendor.Size = new System.Drawing.Size(185, 24);
            this.cb_AddStock_Vendor.TabIndex = 20;
            // 
            // btn_AddStockAddStock
            // 
            this.btn_AddStockAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddStockAddStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AddStockAddStock.Location = new System.Drawing.Point(240, 152);
            this.btn_AddStockAddStock.Name = "btn_AddStockAddStock";
            this.btn_AddStockAddStock.Size = new System.Drawing.Size(90, 30);
            this.btn_AddStockAddStock.TabIndex = 19;
            this.btn_AddStockAddStock.Text = "Add Stock";
            this.btn_AddStockAddStock.UseVisualStyleBackColor = true;
            this.btn_AddStockAddStock.Click += new System.EventHandler(this.btn_AddStockAddStock_Click);
            // 
            // tf_AddStock_BuyingPrice
            // 
            this.tf_AddStock_BuyingPrice.Location = new System.Drawing.Point(145, 120);
            this.tf_AddStock_BuyingPrice.Name = "tf_AddStock_BuyingPrice";
            this.tf_AddStock_BuyingPrice.Size = new System.Drawing.Size(185, 22);
            this.tf_AddStock_BuyingPrice.TabIndex = 18;
            // 
            // tf_AddStock_Quantity
            // 
            this.tf_AddStock_Quantity.Location = new System.Drawing.Point(145, 92);
            this.tf_AddStock_Quantity.Name = "tf_AddStock_Quantity";
            this.tf_AddStock_Quantity.Size = new System.Drawing.Size(185, 22);
            this.tf_AddStock_Quantity.TabIndex = 17;
            // 
            // datePicker_AddStock_Date
            // 
            this.datePicker_AddStock_Date.Location = new System.Drawing.Point(145, 66);
            this.datePicker_AddStock_Date.Name = "datePicker_AddStock_Date";
            this.datePicker_AddStock_Date.Size = new System.Drawing.Size(185, 22);
            this.datePicker_AddStock_Date.TabIndex = 16;
            // 
            // Label_AddStockBuyingPrice
            // 
            this.Label_AddStockBuyingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_AddStockBuyingPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_AddStockBuyingPrice.Location = new System.Drawing.Point(18, 114);
            this.Label_AddStockBuyingPrice.Name = "Label_AddStockBuyingPrice";
            this.Label_AddStockBuyingPrice.Size = new System.Drawing.Size(123, 26);
            this.Label_AddStockBuyingPrice.TabIndex = 14;
            this.Label_AddStockBuyingPrice.Text = "Buying Price : ";
            this.Label_AddStockBuyingPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_AddStockQuantity
            // 
            this.Label_AddStockQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_AddStockQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_AddStockQuantity.Location = new System.Drawing.Point(18, 88);
            this.Label_AddStockQuantity.Name = "Label_AddStockQuantity";
            this.Label_AddStockQuantity.Size = new System.Drawing.Size(123, 26);
            this.Label_AddStockQuantity.TabIndex = 13;
            this.Label_AddStockQuantity.Text = "Quantity : ";
            this.Label_AddStockQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_AddStockDate
            // 
            this.Label_AddStockDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_AddStockDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_AddStockDate.Location = new System.Drawing.Point(18, 62);
            this.Label_AddStockDate.Name = "Label_AddStockDate";
            this.Label_AddStockDate.Size = new System.Drawing.Size(123, 26);
            this.Label_AddStockDate.TabIndex = 12;
            this.Label_AddStockDate.Text = "Date : ";
            this.Label_AddStockDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_AddStockVendor
            // 
            this.Label_AddStockVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_AddStockVendor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_AddStockVendor.Location = new System.Drawing.Point(18, 36);
            this.Label_AddStockVendor.Name = "Label_AddStockVendor";
            this.Label_AddStockVendor.Size = new System.Drawing.Size(123, 26);
            this.Label_AddStockVendor.TabIndex = 11;
            this.Label_AddStockVendor.Text = "Vendor : ";
            this.Label_AddStockVendor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ProductDetails_AvailableStock
            // 
            this.lbl_ProductDetails_AvailableStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_ProductDetails_AvailableStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_ProductDetails_AvailableStock.Location = new System.Drawing.Point(729, 76);
            this.lbl_ProductDetails_AvailableStock.Name = "lbl_ProductDetails_AvailableStock";
            this.lbl_ProductDetails_AvailableStock.Size = new System.Drawing.Size(192, 67);
            this.lbl_ProductDetails_AvailableStock.TabIndex = 11;
            this.lbl_ProductDetails_AvailableStock.Text = "Available Stock : ";
            this.lbl_ProductDetails_AvailableStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_ProductImage
            // 
            this.pictureBox_ProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_ProductImage.Image = global::InventoryManagement.Properties.Resources.placeholder;
            this.pictureBox_ProductImage.Location = new System.Drawing.Point(18, 25);
            this.pictureBox_ProductImage.Name = "pictureBox_ProductImage";
            this.pictureBox_ProductImage.Size = new System.Drawing.Size(170, 118);
            this.pictureBox_ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ProductImage.TabIndex = 0;
            this.pictureBox_ProductImage.TabStop = false;
            // 
            // lbl_ProductDetails_AvailableStockValue
            // 
            this.lbl_ProductDetails_AvailableStockValue.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lbl_ProductDetails_AvailableStockValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_ProductDetails_AvailableStockValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_ProductDetails_AvailableStockValue.Location = new System.Drawing.Point(927, 76);
            this.lbl_ProductDetails_AvailableStockValue.Name = "lbl_ProductDetails_AvailableStockValue";
            this.lbl_ProductDetails_AvailableStockValue.Size = new System.Drawing.Size(122, 67);
            this.lbl_ProductDetails_AvailableStockValue.TabIndex = 14;
            this.lbl_ProductDetails_AvailableStockValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // table_StockHistory
            // 
            this.table_StockHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_StockHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.table_StockHistory.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_StockHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.table_StockHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_StockHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockHIstoryTable_Date,
            this.StockHistoryColumn_Vendor,
            this.StockHistoryColumn_Quantity,
            this.StockHistoryColumn_BuyingPrice,
            this.StockHistoryColumn_TotalPrice});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table_StockHistory.DefaultCellStyle = dataGridViewCellStyle12;
            this.table_StockHistory.Location = new System.Drawing.Point(484, 172);
            this.table_StockHistory.Name = "table_StockHistory";
            this.table_StockHistory.Size = new System.Drawing.Size(710, 449);
            this.table_StockHistory.TabIndex = 12;
            // 
            // StockHistoryColumn_TotalPrice
            // 
            this.StockHistoryColumn_TotalPrice.HeaderText = "Total Price";
            this.StockHistoryColumn_TotalPrice.Name = "StockHistoryColumn_TotalPrice";
            // 
            // StockHistoryColumn_BuyingPrice
            // 
            this.StockHistoryColumn_BuyingPrice.HeaderText = "Buying Price";
            this.StockHistoryColumn_BuyingPrice.Name = "StockHistoryColumn_BuyingPrice";
            // 
            // StockHistoryColumn_Quantity
            // 
            this.StockHistoryColumn_Quantity.HeaderText = "Quantity";
            this.StockHistoryColumn_Quantity.Name = "StockHistoryColumn_Quantity";
            // 
            // StockHistoryColumn_Vendor
            // 
            this.StockHistoryColumn_Vendor.HeaderText = "Vendor";
            this.StockHistoryColumn_Vendor.Name = "StockHistoryColumn_Vendor";
            // 
            // StockHIstoryTable_Date
            // 
            this.StockHIstoryTable_Date.HeaderText = "Date";
            this.StockHIstoryTable_Date.Name = "StockHIstoryTable_Date";
            // 
            // Form_ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1301, 705);
            this.Controls.Add(this.table_StockHistory);
            this.Controls.Add(this.lbl_ProductDetails_AvailableStockValue);
            this.Controls.Add(this.lbl_ProductDetails_AvailableStock);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBox_ProductDetails);
            this.Controls.Add(this.btn_ChangeProductImage);
            this.Controls.Add(this.pictureBox_ProductImage);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_ProductDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product Details";
            this.GroupBox_ProductDetails.ResumeLayout(false);
            this.GroupBox_ProductDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_StockHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox_ProductImage;
        public System.Windows.Forms.Button btn_ChangeProductImage;
        public System.Windows.Forms.GroupBox GroupBox_ProductDetails;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label Label_AddStockBuyingPrice;
        public System.Windows.Forms.Label Label_AddStockQuantity;
        public System.Windows.Forms.Label Label_AddStockDate;
        public System.Windows.Forms.Label Label_AddStockVendor;
        public System.Windows.Forms.Button btn_AddStockAddStock;
        public System.Windows.Forms.TextBox tf_AddStock_BuyingPrice;
        public System.Windows.Forms.TextBox tf_AddStock_Quantity;
        public System.Windows.Forms.DateTimePicker datePicker_AddStock_Date;
        public System.Windows.Forms.Label lbl_ProductDetails_AvailableStock;
        public System.Windows.Forms.ComboBox cb_AddStock_Vendor;
        public System.Windows.Forms.Label lbl_ProductDetails_AvailableStockValue;
        public System.Windows.Forms.Button Button_UpdateProductDetails;
        public System.Windows.Forms.ComboBox cb_ProductDetails_Category;
        public System.Windows.Forms.TextBox tf_ProductDetails_WholesalePrice;
        public System.Windows.Forms.TextBox tf_ProductDetails_RetailPrice;
        public System.Windows.Forms.TextBox tf_ProductDetails_ProductName;
        public System.Windows.Forms.TextBox tf_ProductDetails_ProductID;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label Label_ProductID;
        public System.Windows.Forms.TextBox tf_ProductDetails_Barcode;
        public System.Windows.Forms.Label Label_Barcode;
        public System.Windows.Forms.Label Label_Description;
        public System.Windows.Forms.TextBox tf_ProductDetails_Description;
        public System.Windows.Forms.DataGridView table_StockHistory;
        public System.Windows.Forms.DataGridViewTextBoxColumn StockHIstoryTable_Date;
        public System.Windows.Forms.DataGridViewTextBoxColumn StockHistoryColumn_Vendor;
        public System.Windows.Forms.DataGridViewTextBoxColumn StockHistoryColumn_Quantity;
        public System.Windows.Forms.DataGridViewTextBoxColumn StockHistoryColumn_BuyingPrice;
        public System.Windows.Forms.DataGridViewTextBoxColumn StockHistoryColumn_TotalPrice;
    }
}