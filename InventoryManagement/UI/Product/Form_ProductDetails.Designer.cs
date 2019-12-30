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
            this.btn_ChangeProductImage = new System.Windows.Forms.Button();
            this.Panel_ProductDetails = new System.Windows.Forms.Panel();
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
            this.GroupBox_ProductDetails = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Panel_AddStock = new System.Windows.Forms.Panel();
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
            this.table_StockHistory = new System.Windows.Forms.DataGridView();
            this.StockHIstoryTable_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockHistoryColumn_Vendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockHistoryColumn_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockHistoryColumn_BuyingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockHistoryColumn_TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox_ProductImage = new System.Windows.Forms.PictureBox();
            this.Panel_ProductDetails.SuspendLayout();
            this.GroupBox_ProductDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Panel_AddStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_StockHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProductImage)).BeginInit();
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
            // 
            // Panel_ProductDetails
            // 
            this.Panel_ProductDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel_ProductDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_ProductDetails.Controls.Add(this.Button_UpdateProductDetails);
            this.Panel_ProductDetails.Controls.Add(this.cb_ProductDetails_Category);
            this.Panel_ProductDetails.Controls.Add(this.tf_ProductDetails_WholesalePrice);
            this.Panel_ProductDetails.Controls.Add(this.tf_ProductDetails_RetailPrice);
            this.Panel_ProductDetails.Controls.Add(this.tf_ProductDetails_ProductName);
            this.Panel_ProductDetails.Controls.Add(this.tf_ProductDetails_ProductID);
            this.Panel_ProductDetails.Controls.Add(this.label4);
            this.Panel_ProductDetails.Controls.Add(this.label3);
            this.Panel_ProductDetails.Controls.Add(this.label2);
            this.Panel_ProductDetails.Controls.Add(this.label1);
            this.Panel_ProductDetails.Controls.Add(this.Label_ProductID);
            this.Panel_ProductDetails.Location = new System.Drawing.Point(6, 13);
            this.Panel_ProductDetails.Name = "Panel_ProductDetails";
            this.Panel_ProductDetails.Size = new System.Drawing.Size(324, 214);
            this.Panel_ProductDetails.TabIndex = 2;
            // 
            // Button_UpdateProductDetails
            // 
            this.Button_UpdateProductDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_UpdateProductDetails.Location = new System.Drawing.Point(132, 187);
            this.Button_UpdateProductDetails.Name = "Button_UpdateProductDetails";
            this.Button_UpdateProductDetails.Size = new System.Drawing.Size(75, 23);
            this.Button_UpdateProductDetails.TabIndex = 10;
            this.Button_UpdateProductDetails.Text = "Update";
            this.Button_UpdateProductDetails.UseVisualStyleBackColor = true;
            // 
            // cb_ProductDetails_Category
            // 
            this.cb_ProductDetails_Category.FormattingEnabled = true;
            this.cb_ProductDetails_Category.Location = new System.Drawing.Point(132, 88);
            this.cb_ProductDetails_Category.Name = "cb_ProductDetails_Category";
            this.cb_ProductDetails_Category.Size = new System.Drawing.Size(186, 21);
            this.cb_ProductDetails_Category.TabIndex = 9;
            // 
            // tf_ProductDetails_WholesalePrice
            // 
            this.tf_ProductDetails_WholesalePrice.Location = new System.Drawing.Point(132, 161);
            this.tf_ProductDetails_WholesalePrice.Name = "tf_ProductDetails_WholesalePrice";
            this.tf_ProductDetails_WholesalePrice.Size = new System.Drawing.Size(186, 20);
            this.tf_ProductDetails_WholesalePrice.TabIndex = 8;
            // 
            // tf_ProductDetails_RetailPrice
            // 
            this.tf_ProductDetails_RetailPrice.Location = new System.Drawing.Point(132, 125);
            this.tf_ProductDetails_RetailPrice.Name = "tf_ProductDetails_RetailPrice";
            this.tf_ProductDetails_RetailPrice.Size = new System.Drawing.Size(186, 20);
            this.tf_ProductDetails_RetailPrice.TabIndex = 7;
            // 
            // tf_ProductDetails_ProductName
            // 
            this.tf_ProductDetails_ProductName.Location = new System.Drawing.Point(132, 50);
            this.tf_ProductDetails_ProductName.Name = "tf_ProductDetails_ProductName";
            this.tf_ProductDetails_ProductName.Size = new System.Drawing.Size(186, 20);
            this.tf_ProductDetails_ProductName.TabIndex = 6;
            // 
            // tf_ProductDetails_ProductID
            // 
            this.tf_ProductDetails_ProductID.Location = new System.Drawing.Point(132, 17);
            this.tf_ProductDetails_ProductID.Name = "tf_ProductDetails_ProductID";
            this.tf_ProductDetails_ProductID.Size = new System.Drawing.Size(186, 20);
            this.tf_ProductDetails_ProductID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(3, 157);
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
            this.label3.Location = new System.Drawing.Point(3, 121);
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
            this.label2.Location = new System.Drawing.Point(3, 84);
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
            this.label1.Location = new System.Drawing.Point(3, 46);
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
            this.Label_ProductID.Location = new System.Drawing.Point(3, 11);
            this.Label_ProductID.Name = "Label_ProductID";
            this.Label_ProductID.Size = new System.Drawing.Size(123, 26);
            this.Label_ProductID.TabIndex = 0;
            this.Label_ProductID.Text = "Product ID : ";
            this.Label_ProductID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GroupBox_ProductDetails
            // 
            this.GroupBox_ProductDetails.Controls.Add(this.Panel_ProductDetails);
            this.GroupBox_ProductDetails.Location = new System.Drawing.Point(12, 162);
            this.GroupBox_ProductDetails.Name = "GroupBox_ProductDetails";
            this.GroupBox_ProductDetails.Size = new System.Drawing.Size(330, 233);
            this.GroupBox_ProductDetails.TabIndex = 4;
            this.GroupBox_ProductDetails.TabStop = false;
            this.GroupBox_ProductDetails.Text = "Product Details";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.Panel_AddStock);
            this.groupBox1.Location = new System.Drawing.Point(18, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 188);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Stock";
            // 
            // Panel_AddStock
            // 
            this.Panel_AddStock.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel_AddStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_AddStock.Controls.Add(this.cb_AddStock_Vendor);
            this.Panel_AddStock.Controls.Add(this.btn_AddStockAddStock);
            this.Panel_AddStock.Controls.Add(this.tf_AddStock_BuyingPrice);
            this.Panel_AddStock.Controls.Add(this.tf_AddStock_Quantity);
            this.Panel_AddStock.Controls.Add(this.datePicker_AddStock_Date);
            this.Panel_AddStock.Controls.Add(this.Label_AddStockBuyingPrice);
            this.Panel_AddStock.Controls.Add(this.Label_AddStockQuantity);
            this.Panel_AddStock.Controls.Add(this.Label_AddStockDate);
            this.Panel_AddStock.Controls.Add(this.Label_AddStockVendor);
            this.Panel_AddStock.Location = new System.Drawing.Point(3, 16);
            this.Panel_AddStock.Name = "Panel_AddStock";
            this.Panel_AddStock.Size = new System.Drawing.Size(321, 169);
            this.Panel_AddStock.TabIndex = 0;
            // 
            // cb_AddStock_Vendor
            // 
            this.cb_AddStock_Vendor.FormattingEnabled = true;
            this.cb_AddStock_Vendor.Location = new System.Drawing.Point(130, 10);
            this.cb_AddStock_Vendor.Name = "cb_AddStock_Vendor";
            this.cb_AddStock_Vendor.Size = new System.Drawing.Size(185, 21);
            this.cb_AddStock_Vendor.TabIndex = 20;
            // 
            // btn_AddStockAddStock
            // 
            this.btn_AddStockAddStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AddStockAddStock.Location = new System.Drawing.Point(130, 134);
            this.btn_AddStockAddStock.Name = "btn_AddStockAddStock";
            this.btn_AddStockAddStock.Size = new System.Drawing.Size(75, 23);
            this.btn_AddStockAddStock.TabIndex = 19;
            this.btn_AddStockAddStock.Text = "Add Stock";
            this.btn_AddStockAddStock.UseVisualStyleBackColor = true;
            // 
            // tf_AddStock_BuyingPrice
            // 
            this.tf_AddStock_BuyingPrice.Location = new System.Drawing.Point(130, 94);
            this.tf_AddStock_BuyingPrice.Name = "tf_AddStock_BuyingPrice";
            this.tf_AddStock_BuyingPrice.Size = new System.Drawing.Size(185, 20);
            this.tf_AddStock_BuyingPrice.TabIndex = 18;
            // 
            // tf_AddStock_Quantity
            // 
            this.tf_AddStock_Quantity.Location = new System.Drawing.Point(130, 66);
            this.tf_AddStock_Quantity.Name = "tf_AddStock_Quantity";
            this.tf_AddStock_Quantity.Size = new System.Drawing.Size(185, 20);
            this.tf_AddStock_Quantity.TabIndex = 17;
            // 
            // datePicker_AddStock_Date
            // 
            this.datePicker_AddStock_Date.Location = new System.Drawing.Point(130, 40);
            this.datePicker_AddStock_Date.Name = "datePicker_AddStock_Date";
            this.datePicker_AddStock_Date.Size = new System.Drawing.Size(185, 20);
            this.datePicker_AddStock_Date.TabIndex = 16;
            // 
            // Label_AddStockBuyingPrice
            // 
            this.Label_AddStockBuyingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_AddStockBuyingPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_AddStockBuyingPrice.Location = new System.Drawing.Point(3, 88);
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
            this.Label_AddStockQuantity.Location = new System.Drawing.Point(3, 62);
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
            this.Label_AddStockDate.Location = new System.Drawing.Point(3, 36);
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
            this.Label_AddStockVendor.Location = new System.Drawing.Point(3, 10);
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
            this.lbl_ProductDetails_AvailableStock.Location = new System.Drawing.Point(654, 76);
            this.lbl_ProductDetails_AvailableStock.Name = "lbl_ProductDetails_AvailableStock";
            this.lbl_ProductDetails_AvailableStock.Size = new System.Drawing.Size(339, 67);
            this.lbl_ProductDetails_AvailableStock.TabIndex = 11;
            this.lbl_ProductDetails_AvailableStock.Text = "Available Stock : ";
            this.lbl_ProductDetails_AvailableStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // table_StockHistory
            // 
            this.table_StockHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_StockHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.table_StockHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_StockHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockHIstoryTable_Date,
            this.StockHistoryColumn_Vendor,
            this.StockHistoryColumn_Quantity,
            this.StockHistoryColumn_BuyingPrice,
            this.StockHistoryColumn_TotalPrice});
            this.table_StockHistory.Location = new System.Drawing.Point(376, 175);
            this.table_StockHistory.Name = "table_StockHistory";
            this.table_StockHistory.Size = new System.Drawing.Size(676, 411);
            this.table_StockHistory.TabIndex = 12;
            // 
            // StockHIstoryTable_Date
            // 
            this.StockHIstoryTable_Date.HeaderText = "Date";
            this.StockHIstoryTable_Date.Name = "StockHIstoryTable_Date";
            // 
            // StockHistoryColumn_Vendor
            // 
            this.StockHistoryColumn_Vendor.HeaderText = "Vendor";
            this.StockHistoryColumn_Vendor.Name = "StockHistoryColumn_Vendor";
            // 
            // StockHistoryColumn_Quantity
            // 
            this.StockHistoryColumn_Quantity.HeaderText = "Quantity";
            this.StockHistoryColumn_Quantity.Name = "StockHistoryColumn_Quantity";
            // 
            // StockHistoryColumn_BuyingPrice
            // 
            this.StockHistoryColumn_BuyingPrice.HeaderText = "Buying Price";
            this.StockHistoryColumn_BuyingPrice.Name = "StockHistoryColumn_BuyingPrice";
            // 
            // StockHistoryColumn_TotalPrice
            // 
            this.StockHistoryColumn_TotalPrice.HeaderText = "Total Price";
            this.StockHistoryColumn_TotalPrice.Name = "StockHistoryColumn_TotalPrice";
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
            // Form_ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1064, 601);
            this.Controls.Add(this.table_StockHistory);
            this.Controls.Add(this.lbl_ProductDetails_AvailableStock);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBox_ProductDetails);
            this.Controls.Add(this.btn_ChangeProductImage);
            this.Controls.Add(this.pictureBox_ProductImage);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_ProductDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product Details";
            this.Panel_ProductDetails.ResumeLayout(false);
            this.Panel_ProductDetails.PerformLayout();
            this.GroupBox_ProductDetails.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.Panel_AddStock.ResumeLayout(false);
            this.Panel_AddStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_StockHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox_ProductImage;
        public System.Windows.Forms.Button btn_ChangeProductImage;
        public System.Windows.Forms.Panel Panel_ProductDetails;
        public System.Windows.Forms.Label Label_ProductID;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tf_ProductDetails_WholesalePrice;
        public System.Windows.Forms.TextBox tf_ProductDetails_RetailPrice;
        public System.Windows.Forms.TextBox tf_ProductDetails_ProductName;
        public System.Windows.Forms.TextBox tf_ProductDetails_ProductID;
        public System.Windows.Forms.ComboBox cb_ProductDetails_Category;
        public System.Windows.Forms.Button Button_UpdateProductDetails;
        public System.Windows.Forms.GroupBox GroupBox_ProductDetails;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Panel Panel_AddStock;
        public System.Windows.Forms.Label Label_AddStockBuyingPrice;
        public System.Windows.Forms.Label Label_AddStockQuantity;
        public System.Windows.Forms.Label Label_AddStockDate;
        public System.Windows.Forms.Label Label_AddStockVendor;
        public System.Windows.Forms.Button btn_AddStockAddStock;
        public System.Windows.Forms.TextBox tf_AddStock_BuyingPrice;
        public System.Windows.Forms.TextBox tf_AddStock_Quantity;
        public System.Windows.Forms.DateTimePicker datePicker_AddStock_Date;
        public System.Windows.Forms.Label lbl_ProductDetails_AvailableStock;
        public System.Windows.Forms.DataGridView table_StockHistory;
        public System.Windows.Forms.DataGridViewTextBoxColumn StockHIstoryTable_Date;
        public System.Windows.Forms.DataGridViewTextBoxColumn StockHistoryColumn_Vendor;
        public System.Windows.Forms.DataGridViewTextBoxColumn StockHistoryColumn_Quantity;
        public System.Windows.Forms.DataGridViewTextBoxColumn StockHistoryColumn_BuyingPrice;
        public System.Windows.Forms.DataGridViewTextBoxColumn StockHistoryColumn_TotalPrice;
        public System.Windows.Forms.ComboBox cb_AddStock_Vendor;
    }
}