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
            this.GroupBox_ProductDetails = new System.Windows.Forms.GroupBox();
            this.Label_Discount = new System.Windows.Forms.Label();
            this.tf_ProductDetails_Discount = new System.Windows.Forms.TextBox();
            this.tf_ProductDetails_Description = new System.Windows.Forms.TextBox();
            this.tf_ProductDetails_ProductID = new System.Windows.Forms.TextBox();
            this.Label_Description = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tf_ProductDetails_Barcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tf_ProductDetails_ProductName = new System.Windows.Forms.TextBox();
            this.Label_Barcode = new System.Windows.Forms.Label();
            this.Label_ProductID = new System.Windows.Forms.Label();
            this.cb_ProductDetails_Category = new System.Windows.Forms.ComboBox();
            this.Label_SGST = new System.Windows.Forms.Label();
            this.tf_ProductDetails_SGST = new System.Windows.Forms.TextBox();
            this.Label_CGST = new System.Windows.Forms.Label();
            this.tf_ProductDetails_CGST = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tf_ProductDetails_RetailPrice = new System.Windows.Forms.TextBox();
            this.Button_UpdateProductDetails = new System.Windows.Forms.Button();
            this.tf_ProductDetails_WholesalePrice = new System.Windows.Forms.TextBox();
            this.lbl_ProductDetails_AvailableStock = new System.Windows.Forms.Label();
            this.pictureBox_ProductImage = new System.Windows.Forms.PictureBox();
            this.lbl_ProductDetails_AvailableStockValue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.GroupBox_ProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProductImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ChangeProductImage
            // 
            this.btn_ChangeProductImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangeProductImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangeProductImage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ChangeProductImage.Location = new System.Drawing.Point(278, 163);
            this.btn_ChangeProductImage.Name = "btn_ChangeProductImage";
            this.btn_ChangeProductImage.Size = new System.Drawing.Size(90, 30);
            this.btn_ChangeProductImage.TabIndex = 12;
            this.btn_ChangeProductImage.Text = "Change";
            this.btn_ChangeProductImage.UseVisualStyleBackColor = true;
            this.btn_ChangeProductImage.Click += new System.EventHandler(this.btn_ChangeProductImage_Click);
            // 
            // GroupBox_ProductDetails
            // 
            this.GroupBox_ProductDetails.Controls.Add(this.Label_Discount);
            this.GroupBox_ProductDetails.Controls.Add(this.tf_ProductDetails_Discount);
            this.GroupBox_ProductDetails.Controls.Add(this.tf_ProductDetails_Description);
            this.GroupBox_ProductDetails.Controls.Add(this.tf_ProductDetails_ProductID);
            this.GroupBox_ProductDetails.Controls.Add(this.Label_Description);
            this.GroupBox_ProductDetails.Controls.Add(this.label2);
            this.GroupBox_ProductDetails.Controls.Add(this.tf_ProductDetails_Barcode);
            this.GroupBox_ProductDetails.Controls.Add(this.label1);
            this.GroupBox_ProductDetails.Controls.Add(this.tf_ProductDetails_ProductName);
            this.GroupBox_ProductDetails.Controls.Add(this.Label_Barcode);
            this.GroupBox_ProductDetails.Controls.Add(this.Label_ProductID);
            this.GroupBox_ProductDetails.Controls.Add(this.cb_ProductDetails_Category);
            this.GroupBox_ProductDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_ProductDetails.Location = new System.Drawing.Point(37, 218);
            this.GroupBox_ProductDetails.Name = "GroupBox_ProductDetails";
            this.GroupBox_ProductDetails.Size = new System.Drawing.Size(362, 330);
            this.GroupBox_ProductDetails.TabIndex = 1;
            this.GroupBox_ProductDetails.TabStop = false;
            this.GroupBox_ProductDetails.Text = "Product Details";
            // 
            // Label_Discount
            // 
            this.Label_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Discount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Discount.Location = new System.Drawing.Point(16, 279);
            this.Label_Discount.Name = "Label_Discount";
            this.Label_Discount.Size = new System.Drawing.Size(123, 26);
            this.Label_Discount.TabIndex = 15;
            this.Label_Discount.Text = "Discount : ";
            this.Label_Discount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tf_ProductDetails_Discount
            // 
            this.tf_ProductDetails_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_ProductDetails_Discount.Location = new System.Drawing.Point(145, 280);
            this.tf_ProductDetails_Discount.Name = "tf_ProductDetails_Discount";
            this.tf_ProductDetails_Discount.Size = new System.Drawing.Size(186, 22);
            this.tf_ProductDetails_Discount.TabIndex = 6;
            // 
            // tf_ProductDetails_Description
            // 
            this.tf_ProductDetails_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_ProductDetails_Description.Location = new System.Drawing.Point(144, 180);
            this.tf_ProductDetails_Description.Name = "tf_ProductDetails_Description";
            this.tf_ProductDetails_Description.Size = new System.Drawing.Size(186, 22);
            this.tf_ProductDetails_Description.TabIndex = 4;
            // 
            // tf_ProductDetails_ProductID
            // 
            this.tf_ProductDetails_ProductID.Enabled = false;
            this.tf_ProductDetails_ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_ProductDetails_ProductID.Location = new System.Drawing.Point(144, 33);
            this.tf_ProductDetails_ProductID.Name = "tf_ProductDetails_ProductID";
            this.tf_ProductDetails_ProductID.ReadOnly = true;
            this.tf_ProductDetails_ProductID.Size = new System.Drawing.Size(186, 22);
            this.tf_ProductDetails_ProductID.TabIndex = 1;
            // 
            // Label_Description
            // 
            this.Label_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Description.Location = new System.Drawing.Point(15, 179);
            this.Label_Description.Name = "Label_Description";
            this.Label_Description.Size = new System.Drawing.Size(123, 26);
            this.Label_Description.TabIndex = 13;
            this.Label_Description.Text = "Description : ";
            this.Label_Description.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tf_ProductDetails_Barcode
            // 
            this.tf_ProductDetails_Barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_ProductDetails_Barcode.Location = new System.Drawing.Point(144, 82);
            this.tf_ProductDetails_Barcode.Name = "tf_ProductDetails_Barcode";
            this.tf_ProductDetails_Barcode.Size = new System.Drawing.Size(186, 22);
            this.tf_ProductDetails_Barcode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tf_ProductDetails_ProductName
            // 
            this.tf_ProductDetails_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_ProductDetails_ProductName.Location = new System.Drawing.Point(145, 131);
            this.tf_ProductDetails_ProductName.Name = "tf_ProductDetails_ProductName";
            this.tf_ProductDetails_ProductName.Size = new System.Drawing.Size(186, 22);
            this.tf_ProductDetails_ProductName.TabIndex = 3;
            // 
            // Label_Barcode
            // 
            this.Label_Barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Barcode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Barcode.Location = new System.Drawing.Point(15, 79);
            this.Label_Barcode.Name = "Label_Barcode";
            this.Label_Barcode.Size = new System.Drawing.Size(123, 26);
            this.Label_Barcode.TabIndex = 11;
            this.Label_Barcode.Text = "Barcode : ";
            this.Label_Barcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_ProductID
            // 
            this.Label_ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ProductID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_ProductID.Location = new System.Drawing.Point(17, 29);
            this.Label_ProductID.Name = "Label_ProductID";
            this.Label_ProductID.Size = new System.Drawing.Size(123, 26);
            this.Label_ProductID.TabIndex = 0;
            this.Label_ProductID.Text = "Product ID : ";
            this.Label_ProductID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_ProductDetails_Category
            // 
            this.cb_ProductDetails_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ProductDetails_Category.FormattingEnabled = true;
            this.cb_ProductDetails_Category.Location = new System.Drawing.Point(144, 229);
            this.cb_ProductDetails_Category.Name = "cb_ProductDetails_Category";
            this.cb_ProductDetails_Category.Size = new System.Drawing.Size(186, 24);
            this.cb_ProductDetails_Category.TabIndex = 5;
            // 
            // Label_SGST
            // 
            this.Label_SGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SGST.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_SGST.Location = new System.Drawing.Point(19, 79);
            this.Label_SGST.Name = "Label_SGST";
            this.Label_SGST.Size = new System.Drawing.Size(123, 26);
            this.Label_SGST.TabIndex = 19;
            this.Label_SGST.Text = "SGST : ";
            this.Label_SGST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tf_ProductDetails_SGST
            // 
            this.tf_ProductDetails_SGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_ProductDetails_SGST.Location = new System.Drawing.Point(148, 83);
            this.tf_ProductDetails_SGST.Name = "tf_ProductDetails_SGST";
            this.tf_ProductDetails_SGST.Size = new System.Drawing.Size(186, 22);
            this.tf_ProductDetails_SGST.TabIndex = 10;
            // 
            // Label_CGST
            // 
            this.Label_CGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CGST.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_CGST.Location = new System.Drawing.Point(18, 36);
            this.Label_CGST.Name = "Label_CGST";
            this.Label_CGST.Size = new System.Drawing.Size(123, 26);
            this.Label_CGST.TabIndex = 17;
            this.Label_CGST.Text = "CGST : ";
            this.Label_CGST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tf_ProductDetails_CGST
            // 
            this.tf_ProductDetails_CGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_ProductDetails_CGST.Location = new System.Drawing.Point(147, 38);
            this.tf_ProductDetails_CGST.Name = "tf_ProductDetails_CGST";
            this.tf_ProductDetails_CGST.Size = new System.Drawing.Size(186, 22);
            this.tf_ProductDetails_CGST.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(5, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Retail Price : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Wholesale Price : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tf_ProductDetails_RetailPrice
            // 
            this.tf_ProductDetails_RetailPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_ProductDetails_RetailPrice.Location = new System.Drawing.Point(147, 31);
            this.tf_ProductDetails_RetailPrice.Name = "tf_ProductDetails_RetailPrice";
            this.tf_ProductDetails_RetailPrice.Size = new System.Drawing.Size(186, 22);
            this.tf_ProductDetails_RetailPrice.TabIndex = 7;
            // 
            // Button_UpdateProductDetails
            // 
            this.Button_UpdateProductDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_UpdateProductDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_UpdateProductDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_UpdateProductDetails.Location = new System.Drawing.Point(384, 574);
            this.Button_UpdateProductDetails.Name = "Button_UpdateProductDetails";
            this.Button_UpdateProductDetails.Size = new System.Drawing.Size(97, 39);
            this.Button_UpdateProductDetails.TabIndex = 11;
            this.Button_UpdateProductDetails.Text = "Update";
            this.Button_UpdateProductDetails.UseVisualStyleBackColor = true;
            this.Button_UpdateProductDetails.Click += new System.EventHandler(this.Button_UpdateProductDetails_Click);
            // 
            // tf_ProductDetails_WholesalePrice
            // 
            this.tf_ProductDetails_WholesalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_ProductDetails_WholesalePrice.Location = new System.Drawing.Point(148, 74);
            this.tf_ProductDetails_WholesalePrice.Name = "tf_ProductDetails_WholesalePrice";
            this.tf_ProductDetails_WholesalePrice.Size = new System.Drawing.Size(186, 22);
            this.tf_ProductDetails_WholesalePrice.TabIndex = 8;
            // 
            // lbl_ProductDetails_AvailableStock
            // 
            this.lbl_ProductDetails_AvailableStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_ProductDetails_AvailableStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_ProductDetails_AvailableStock.Location = new System.Drawing.Point(486, 112);
            this.lbl_ProductDetails_AvailableStock.Name = "lbl_ProductDetails_AvailableStock";
            this.lbl_ProductDetails_AvailableStock.Size = new System.Drawing.Size(205, 55);
            this.lbl_ProductDetails_AvailableStock.TabIndex = 11;
            this.lbl_ProductDetails_AvailableStock.Text = "Available Stock : ";
            this.lbl_ProductDetails_AvailableStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox_ProductImage
            // 
            this.pictureBox_ProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_ProductImage.Image = global::InventoryManagement.Properties.Resources.placeholder;
            this.pictureBox_ProductImage.Location = new System.Drawing.Point(55, 58);
            this.pictureBox_ProductImage.Name = "pictureBox_ProductImage";
            this.pictureBox_ProductImage.Size = new System.Drawing.Size(200, 135);
            this.pictureBox_ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ProductImage.TabIndex = 0;
            this.pictureBox_ProductImage.TabStop = false;
            // 
            // lbl_ProductDetails_AvailableStockValue
            // 
            this.lbl_ProductDetails_AvailableStockValue.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lbl_ProductDetails_AvailableStockValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_ProductDetails_AvailableStockValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_ProductDetails_AvailableStockValue.Location = new System.Drawing.Point(706, 112);
            this.lbl_ProductDetails_AvailableStockValue.Name = "lbl_ProductDetails_AvailableStockValue";
            this.lbl_ProductDetails_AvailableStockValue.Size = new System.Drawing.Size(116, 55);
            this.lbl_ProductDetails_AvailableStockValue.TabIndex = 14;
            this.lbl_ProductDetails_AvailableStockValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 43);
            this.panel1.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(324, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Edit Product Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tf_ProductDetails_RetailPrice);
            this.groupBox1.Controls.Add(this.tf_ProductDetails_WholesalePrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(458, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 128);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pricing";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Label_SGST);
            this.groupBox2.Controls.Add(this.tf_ProductDetails_CGST);
            this.groupBox2.Controls.Add(this.tf_ProductDetails_SGST);
            this.groupBox2.Controls.Add(this.Label_CGST);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(458, 410);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 138);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tax Details";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(430, 175);
            this.lbl_Error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 18);
            this.lbl_Error.TabIndex = 31;
            this.lbl_Error.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form_ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(883, 625);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_ProductDetails_AvailableStockValue);
            this.Controls.Add(this.lbl_ProductDetails_AvailableStock);
            this.Controls.Add(this.GroupBox_ProductDetails);
            this.Controls.Add(this.btn_ChangeProductImage);
            this.Controls.Add(this.pictureBox_ProductImage);
            this.Controls.Add(this.Button_UpdateProductDetails);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_ProductDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product Details";
            this.GroupBox_ProductDetails.ResumeLayout(false);
            this.GroupBox_ProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProductImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox_ProductImage;
        public System.Windows.Forms.Button btn_ChangeProductImage;
        public System.Windows.Forms.GroupBox GroupBox_ProductDetails;
        public System.Windows.Forms.Label lbl_ProductDetails_AvailableStock;
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
        public System.Windows.Forms.Label Label_SGST;
        public System.Windows.Forms.TextBox tf_ProductDetails_SGST;
        public System.Windows.Forms.Label Label_CGST;
        public System.Windows.Forms.TextBox tf_ProductDetails_CGST;
        public System.Windows.Forms.Label Label_Discount;
        public System.Windows.Forms.TextBox tf_ProductDetails_Discount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lbl_Error;
    }
}