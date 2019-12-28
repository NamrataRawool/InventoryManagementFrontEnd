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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_ChangeImage = new System.Windows.Forms.Button();
            this.Panel_ProductDetails = new System.Windows.Forms.Panel();
            this.Button_UpdateProductDetails = new System.Windows.Forms.Button();
            this.ComboBox_ProductDetails_Category = new System.Windows.Forms.ComboBox();
            this.TextBox_ProductDetails_WholesalePrice = new System.Windows.Forms.TextBox();
            this.TextBox_ProductDetails_RetailPrice = new System.Windows.Forms.TextBox();
            this.TextBox_ProductDetails_ProductName = new System.Windows.Forms.TextBox();
            this.TextBox_ProductDetails_ProductID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_ProductID = new System.Windows.Forms.Label();
            this.GroupBox_ProductDetails = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Panel_AddStock = new System.Windows.Forms.Panel();
            this.Button_AddStockAddStock = new System.Windows.Forms.Button();
            this.TextBox_AddStock_BuyingPrice = new System.Windows.Forms.TextBox();
            this.TextBox_AddStock_Quantity = new System.Windows.Forms.TextBox();
            this.DateTimePicker_AddStock_Date = new System.Windows.Forms.DateTimePicker();
            this.Label_AddStockBuyingPrice = new System.Windows.Forms.Label();
            this.Label_AddStockQuantity = new System.Windows.Forms.Label();
            this.Label_AddStockDate = new System.Windows.Forms.Label();
            this.Label_AddStockVendor = new System.Windows.Forms.Label();
            this.Label_ProductDetails_AvailableStock = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.StockHIstoryTable_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockHistoryColumn_Vendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockHistoryColumn_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockHistoryColumn_BuyingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockHistoryColumn_TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboBox_AddStock_Vendor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_ProductDetails.SuspendLayout();
            this.GroupBox_ProductDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Panel_AddStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 118);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Button_ChangeImage
            // 
            this.Button_ChangeImage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_ChangeImage.Location = new System.Drawing.Point(194, 120);
            this.Button_ChangeImage.Name = "Button_ChangeImage";
            this.Button_ChangeImage.Size = new System.Drawing.Size(75, 23);
            this.Button_ChangeImage.TabIndex = 1;
            this.Button_ChangeImage.Text = "Change";
            this.Button_ChangeImage.UseVisualStyleBackColor = true;
            this.Button_ChangeImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // Panel_ProductDetails
            // 
            this.Panel_ProductDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel_ProductDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_ProductDetails.Controls.Add(this.Button_UpdateProductDetails);
            this.Panel_ProductDetails.Controls.Add(this.ComboBox_ProductDetails_Category);
            this.Panel_ProductDetails.Controls.Add(this.TextBox_ProductDetails_WholesalePrice);
            this.Panel_ProductDetails.Controls.Add(this.TextBox_ProductDetails_RetailPrice);
            this.Panel_ProductDetails.Controls.Add(this.TextBox_ProductDetails_ProductName);
            this.Panel_ProductDetails.Controls.Add(this.TextBox_ProductDetails_ProductID);
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
            // ComboBox_ProductDetails_Category
            // 
            this.ComboBox_ProductDetails_Category.FormattingEnabled = true;
            this.ComboBox_ProductDetails_Category.Location = new System.Drawing.Point(132, 88);
            this.ComboBox_ProductDetails_Category.Name = "ComboBox_ProductDetails_Category";
            this.ComboBox_ProductDetails_Category.Size = new System.Drawing.Size(186, 21);
            this.ComboBox_ProductDetails_Category.TabIndex = 9;
            // 
            // TextBox_ProductDetails_WholesalePrice
            // 
            this.TextBox_ProductDetails_WholesalePrice.Location = new System.Drawing.Point(132, 161);
            this.TextBox_ProductDetails_WholesalePrice.Name = "TextBox_ProductDetails_WholesalePrice";
            this.TextBox_ProductDetails_WholesalePrice.Size = new System.Drawing.Size(186, 20);
            this.TextBox_ProductDetails_WholesalePrice.TabIndex = 8;
            // 
            // TextBox_ProductDetails_RetailPrice
            // 
            this.TextBox_ProductDetails_RetailPrice.Location = new System.Drawing.Point(132, 125);
            this.TextBox_ProductDetails_RetailPrice.Name = "TextBox_ProductDetails_RetailPrice";
            this.TextBox_ProductDetails_RetailPrice.Size = new System.Drawing.Size(186, 20);
            this.TextBox_ProductDetails_RetailPrice.TabIndex = 7;
            // 
            // TextBox_ProductDetails_ProductName
            // 
            this.TextBox_ProductDetails_ProductName.Location = new System.Drawing.Point(132, 50);
            this.TextBox_ProductDetails_ProductName.Name = "TextBox_ProductDetails_ProductName";
            this.TextBox_ProductDetails_ProductName.Size = new System.Drawing.Size(186, 20);
            this.TextBox_ProductDetails_ProductName.TabIndex = 6;
            // 
            // TextBox_ProductDetails_ProductID
            // 
            this.TextBox_ProductDetails_ProductID.Location = new System.Drawing.Point(132, 17);
            this.TextBox_ProductDetails_ProductID.Name = "TextBox_ProductDetails_ProductID";
            this.TextBox_ProductDetails_ProductID.Size = new System.Drawing.Size(186, 20);
            this.TextBox_ProductDetails_ProductID.TabIndex = 5;
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
            this.Panel_AddStock.Controls.Add(this.ComboBox_AddStock_Vendor);
            this.Panel_AddStock.Controls.Add(this.Button_AddStockAddStock);
            this.Panel_AddStock.Controls.Add(this.TextBox_AddStock_BuyingPrice);
            this.Panel_AddStock.Controls.Add(this.TextBox_AddStock_Quantity);
            this.Panel_AddStock.Controls.Add(this.DateTimePicker_AddStock_Date);
            this.Panel_AddStock.Controls.Add(this.Label_AddStockBuyingPrice);
            this.Panel_AddStock.Controls.Add(this.Label_AddStockQuantity);
            this.Panel_AddStock.Controls.Add(this.Label_AddStockDate);
            this.Panel_AddStock.Controls.Add(this.Label_AddStockVendor);
            this.Panel_AddStock.Location = new System.Drawing.Point(3, 16);
            this.Panel_AddStock.Name = "Panel_AddStock";
            this.Panel_AddStock.Size = new System.Drawing.Size(321, 169);
            this.Panel_AddStock.TabIndex = 0;
            // 
            // Button_AddStockAddStock
            // 
            this.Button_AddStockAddStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_AddStockAddStock.Location = new System.Drawing.Point(130, 134);
            this.Button_AddStockAddStock.Name = "Button_AddStockAddStock";
            this.Button_AddStockAddStock.Size = new System.Drawing.Size(75, 23);
            this.Button_AddStockAddStock.TabIndex = 19;
            this.Button_AddStockAddStock.Text = "Add Stock";
            this.Button_AddStockAddStock.UseVisualStyleBackColor = true;
            // 
            // TextBox_AddStock_BuyingPrice
            // 
            this.TextBox_AddStock_BuyingPrice.Location = new System.Drawing.Point(130, 94);
            this.TextBox_AddStock_BuyingPrice.Name = "TextBox_AddStock_BuyingPrice";
            this.TextBox_AddStock_BuyingPrice.Size = new System.Drawing.Size(185, 20);
            this.TextBox_AddStock_BuyingPrice.TabIndex = 18;
            // 
            // TextBox_AddStock_Quantity
            // 
            this.TextBox_AddStock_Quantity.Location = new System.Drawing.Point(130, 66);
            this.TextBox_AddStock_Quantity.Name = "TextBox_AddStock_Quantity";
            this.TextBox_AddStock_Quantity.Size = new System.Drawing.Size(185, 20);
            this.TextBox_AddStock_Quantity.TabIndex = 17;
            // 
            // DateTimePicker_AddStock_Date
            // 
            this.DateTimePicker_AddStock_Date.Location = new System.Drawing.Point(130, 40);
            this.DateTimePicker_AddStock_Date.Name = "DateTimePicker_AddStock_Date";
            this.DateTimePicker_AddStock_Date.Size = new System.Drawing.Size(185, 20);
            this.DateTimePicker_AddStock_Date.TabIndex = 16;
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
            // Label_ProductDetails_AvailableStock
            // 
            this.Label_ProductDetails_AvailableStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Label_ProductDetails_AvailableStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_ProductDetails_AvailableStock.Location = new System.Drawing.Point(654, 76);
            this.Label_ProductDetails_AvailableStock.Name = "Label_ProductDetails_AvailableStock";
            this.Label_ProductDetails_AvailableStock.Size = new System.Drawing.Size(339, 67);
            this.Label_ProductDetails_AvailableStock.TabIndex = 11;
            this.Label_ProductDetails_AvailableStock.Text = "Available Stock : ";
            this.Label_ProductDetails_AvailableStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataGridView
            // 
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockHIstoryTable_Date,
            this.StockHistoryColumn_Vendor,
            this.StockHistoryColumn_Quantity,
            this.StockHistoryColumn_BuyingPrice,
            this.StockHistoryColumn_TotalPrice});
            this.DataGridView.Location = new System.Drawing.Point(376, 175);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(676, 411);
            this.DataGridView.TabIndex = 12;
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
            // ComboBox_AddStock_Vendor
            // 
            this.ComboBox_AddStock_Vendor.FormattingEnabled = true;
            this.ComboBox_AddStock_Vendor.Location = new System.Drawing.Point(130, 10);
            this.ComboBox_AddStock_Vendor.Name = "ComboBox_AddStock_Vendor";
            this.ComboBox_AddStock_Vendor.Size = new System.Drawing.Size(185, 21);
            this.ComboBox_AddStock_Vendor.TabIndex = 20;
            // 
            // GroupBox_AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1064, 601);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.Label_ProductDetails_AvailableStock);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBox_ProductDetails);
            this.Controls.Add(this.Button_ChangeImage);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GroupBox_AddStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product Details";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_ProductDetails.ResumeLayout(false);
            this.Panel_ProductDetails.PerformLayout();
            this.GroupBox_ProductDetails.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.Panel_AddStock.ResumeLayout(false);
            this.Panel_AddStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Button_ChangeImage;
        private System.Windows.Forms.Panel Panel_ProductDetails;
        private System.Windows.Forms.Label Label_ProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_ProductDetails_WholesalePrice;
        private System.Windows.Forms.TextBox TextBox_ProductDetails_RetailPrice;
        private System.Windows.Forms.TextBox TextBox_ProductDetails_ProductName;
        private System.Windows.Forms.TextBox TextBox_ProductDetails_ProductID;
        private System.Windows.Forms.ComboBox ComboBox_ProductDetails_Category;
        private System.Windows.Forms.Button Button_UpdateProductDetails;
        private System.Windows.Forms.GroupBox GroupBox_ProductDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel Panel_AddStock;
        private System.Windows.Forms.Label Label_AddStockBuyingPrice;
        private System.Windows.Forms.Label Label_AddStockQuantity;
        private System.Windows.Forms.Label Label_AddStockDate;
        private System.Windows.Forms.Label Label_AddStockVendor;
        private System.Windows.Forms.Button Button_AddStockAddStock;
        private System.Windows.Forms.TextBox TextBox_AddStock_BuyingPrice;
        private System.Windows.Forms.TextBox TextBox_AddStock_Quantity;
        private System.Windows.Forms.DateTimePicker DateTimePicker_AddStock_Date;
        private System.Windows.Forms.Label Label_ProductDetails_AvailableStock;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockHIstoryTable_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockHistoryColumn_Vendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockHistoryColumn_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockHistoryColumn_BuyingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockHistoryColumn_TotalPrice;
        private System.Windows.Forms.ComboBox ComboBox_AddStock_Vendor;
    }
}