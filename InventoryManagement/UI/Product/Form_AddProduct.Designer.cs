namespace InventoryManagement.UI.Product
{
    partial class Form_AddProduct
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
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_Description = new System.Windows.Forms.Label();
            this.Label_Category = new System.Windows.Forms.Label();
            this.Label_WholesalePrice = new System.Windows.Forms.Label();
            this.Label_RetailPrice = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.tb_RetailPrice = new System.Windows.Forms.TextBox();
            this.tb_WholeSalePrice = new System.Windows.Forms.TextBox();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.btn_saveProduct = new System.Windows.Forms.Button();
            this.btn_ResetProduct = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tb_Barcode = new System.Windows.Forms.TextBox();
            this.Label_Barcode = new System.Windows.Forms.Label();
            this.gb_Pricing = new System.Windows.Forms.GroupBox();
            this.gb_Tax = new System.Windows.Forms.GroupBox();
            this.tb_CGST = new System.Windows.Forms.TextBox();
            this.lbl_CGST = new System.Windows.Forms.Label();
            this.lbl_SGST = new System.Windows.Forms.Label();
            this.tb_SGST = new System.Windows.Forms.TextBox();
            this.tb_Discount = new System.Windows.Forms.TextBox();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.gb_Details = new System.Windows.Forms.GroupBox();
            this.btn_AddNewCategory = new System.Windows.Forms.Button();
            this.btn_ChangeProductImage = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.gb_Pricing.SuspendLayout();
            this.gb_Tax.SuspendLayout();
            this.gb_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Name
            // 
            this.Label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.Location = new System.Drawing.Point(24, 28);
            this.Label_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(116, 31);
            this.Label_Name.TabIndex = 0;
            this.Label_Name.Text = "Name :";
            this.Label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Description
            // 
            this.Label_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description.Location = new System.Drawing.Point(24, 144);
            this.Label_Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Description.Name = "Label_Description";
            this.Label_Description.Size = new System.Drawing.Size(116, 28);
            this.Label_Description.TabIndex = 1;
            this.Label_Description.Text = "Description :";
            this.Label_Description.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Category
            // 
            this.Label_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Category.Location = new System.Drawing.Point(24, 211);
            this.Label_Category.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Category.Name = "Label_Category";
            this.Label_Category.Size = new System.Drawing.Size(116, 24);
            this.Label_Category.TabIndex = 2;
            this.Label_Category.Text = "Category :";
            this.Label_Category.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_WholesalePrice
            // 
            this.Label_WholesalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_WholesalePrice.Location = new System.Drawing.Point(4, 77);
            this.Label_WholesalePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_WholesalePrice.Name = "Label_WholesalePrice";
            this.Label_WholesalePrice.Size = new System.Drawing.Size(128, 31);
            this.Label_WholesalePrice.TabIndex = 3;
            this.Label_WholesalePrice.Text = "Wholesale Price :";
            this.Label_WholesalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_RetailPrice
            // 
            this.Label_RetailPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RetailPrice.Location = new System.Drawing.Point(9, 24);
            this.Label_RetailPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_RetailPrice.Name = "Label_RetailPrice";
            this.Label_RetailPrice.Size = new System.Drawing.Size(123, 33);
            this.Label_RetailPrice.TabIndex = 4;
            this.Label_RetailPrice.Text = "Retail Price :";
            this.Label_RetailPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(166, 33);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(260, 22);
            this.tb_Name.TabIndex = 2;
            // 
            // tb_Description
            // 
            this.tb_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Description.Location = new System.Drawing.Point(166, 132);
            this.tb_Description.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Description.Size = new System.Drawing.Size(278, 50);
            this.tb_Description.TabIndex = 4;
            // 
            // tb_RetailPrice
            // 
            this.tb_RetailPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RetailPrice.Location = new System.Drawing.Point(151, 30);
            this.tb_RetailPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tb_RetailPrice.Name = "tb_RetailPrice";
            this.tb_RetailPrice.Size = new System.Drawing.Size(200, 22);
            this.tb_RetailPrice.TabIndex = 7;
            // 
            // tb_WholeSalePrice
            // 
            this.tb_WholeSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_WholeSalePrice.Location = new System.Drawing.Point(151, 81);
            this.tb_WholeSalePrice.Margin = new System.Windows.Forms.Padding(2);
            this.tb_WholeSalePrice.Name = "tb_WholeSalePrice";
            this.tb_WholeSalePrice.Size = new System.Drawing.Size(200, 22);
            this.tb_WholeSalePrice.TabIndex = 8;
            // 
            // cb_Category
            // 
            this.cb_Category.DropDownHeight = 80;
            this.cb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.IntegralHeight = false;
            this.cb_Category.Location = new System.Drawing.Point(166, 211);
            this.cb_Category.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(260, 24);
            this.cb_Category.TabIndex = 5;
            this.cb_Category.Text = "Select Category";
            // 
            // btn_saveProduct
            // 
            this.btn_saveProduct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_saveProduct.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_saveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveProduct.ForeColor = System.Drawing.Color.Black;
            this.btn_saveProduct.Location = new System.Drawing.Point(612, 545);
            this.btn_saveProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btn_saveProduct.Name = "btn_saveProduct";
            this.btn_saveProduct.Size = new System.Drawing.Size(88, 36);
            this.btn_saveProduct.TabIndex = 11;
            this.btn_saveProduct.Text = "Save";
            this.btn_saveProduct.UseVisualStyleBackColor = false;
            this.btn_saveProduct.Click += new System.EventHandler(this.btn_saveProduct_Click);
            // 
            // btn_ResetProduct
            // 
            this.btn_ResetProduct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ResetProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetProduct.ForeColor = System.Drawing.Color.Black;
            this.btn_ResetProduct.Location = new System.Drawing.Point(398, 545);
            this.btn_ResetProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ResetProduct.Name = "btn_ResetProduct";
            this.btn_ResetProduct.Size = new System.Drawing.Size(88, 36);
            this.btn_ResetProduct.TabIndex = 13;
            this.btn_ResetProduct.Text = "Reset";
            this.btn_ResetProduct.UseVisualStyleBackColor = false;
            this.btn_ResetProduct.Click += new System.EventHandler(this.btn_ResetProduct_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 43);
            this.panel1.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(421, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Add New Product";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Red;
            this.btn_cancel.Location = new System.Drawing.Point(505, 545);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(88, 36);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tb_Barcode
            // 
            this.tb_Barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Barcode.Location = new System.Drawing.Point(166, 88);
            this.tb_Barcode.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Barcode.Name = "tb_Barcode";
            this.tb_Barcode.Size = new System.Drawing.Size(260, 22);
            this.tb_Barcode.TabIndex = 3;
            // 
            // Label_Barcode
            // 
            this.Label_Barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Barcode.Location = new System.Drawing.Point(24, 83);
            this.Label_Barcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Barcode.Name = "Label_Barcode";
            this.Label_Barcode.Size = new System.Drawing.Size(116, 31);
            this.Label_Barcode.TabIndex = 25;
            this.Label_Barcode.Text = "Barcode :";
            this.Label_Barcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gb_Pricing
            // 
            this.gb_Pricing.Controls.Add(this.tb_RetailPrice);
            this.gb_Pricing.Controls.Add(this.Label_WholesalePrice);
            this.gb_Pricing.Controls.Add(this.Label_RetailPrice);
            this.gb_Pricing.Controls.Add(this.tb_WholeSalePrice);
            this.gb_Pricing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gb_Pricing.Location = new System.Drawing.Point(596, 188);
            this.gb_Pricing.Name = "gb_Pricing";
            this.gb_Pricing.Size = new System.Drawing.Size(374, 141);
            this.gb_Pricing.TabIndex = 2;
            this.gb_Pricing.TabStop = false;
            this.gb_Pricing.Text = "Pricing";
            // 
            // gb_Tax
            // 
            this.gb_Tax.Controls.Add(this.tb_CGST);
            this.gb_Tax.Controls.Add(this.lbl_CGST);
            this.gb_Tax.Controls.Add(this.lbl_SGST);
            this.gb_Tax.Controls.Add(this.tb_SGST);
            this.gb_Tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gb_Tax.Location = new System.Drawing.Point(596, 356);
            this.gb_Tax.Name = "gb_Tax";
            this.gb_Tax.Size = new System.Drawing.Size(374, 157);
            this.gb_Tax.TabIndex = 3;
            this.gb_Tax.TabStop = false;
            this.gb_Tax.Text = "Tax";
            // 
            // tb_CGST
            // 
            this.tb_CGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CGST.Location = new System.Drawing.Point(151, 51);
            this.tb_CGST.Margin = new System.Windows.Forms.Padding(2);
            this.tb_CGST.Name = "tb_CGST";
            this.tb_CGST.Size = new System.Drawing.Size(200, 22);
            this.tb_CGST.TabIndex = 9;
            // 
            // lbl_CGST
            // 
            this.lbl_CGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CGST.Location = new System.Drawing.Point(9, 45);
            this.lbl_CGST.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CGST.Name = "lbl_CGST";
            this.lbl_CGST.Size = new System.Drawing.Size(123, 33);
            this.lbl_CGST.TabIndex = 11;
            this.lbl_CGST.Text = "CGST :";
            this.lbl_CGST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_SGST
            // 
            this.lbl_SGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SGST.Location = new System.Drawing.Point(4, 104);
            this.lbl_SGST.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SGST.Name = "lbl_SGST";
            this.lbl_SGST.Size = new System.Drawing.Size(128, 31);
            this.lbl_SGST.TabIndex = 10;
            this.lbl_SGST.Text = "SGST :";
            this.lbl_SGST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_SGST
            // 
            this.tb_SGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SGST.Location = new System.Drawing.Point(151, 109);
            this.tb_SGST.Margin = new System.Windows.Forms.Padding(2);
            this.tb_SGST.Name = "tb_SGST";
            this.tb_SGST.Size = new System.Drawing.Size(200, 22);
            this.tb_SGST.TabIndex = 10;
            // 
            // tb_Discount
            // 
            this.tb_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Discount.Location = new System.Drawing.Point(166, 268);
            this.tb_Discount.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Discount.Name = "tb_Discount";
            this.tb_Discount.Size = new System.Drawing.Size(260, 22);
            this.tb_Discount.TabIndex = 6;
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.Location = new System.Drawing.Point(24, 263);
            this.lbl_Discount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(116, 31);
            this.lbl_Discount.TabIndex = 29;
            this.lbl_Discount.Text = "Discount :";
            this.lbl_Discount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gb_Details
            // 
            this.gb_Details.Controls.Add(this.btn_AddNewCategory);
            this.gb_Details.Controls.Add(this.tb_Description);
            this.gb_Details.Controls.Add(this.tb_Discount);
            this.gb_Details.Controls.Add(this.Label_Name);
            this.gb_Details.Controls.Add(this.lbl_Discount);
            this.gb_Details.Controls.Add(this.Label_Description);
            this.gb_Details.Controls.Add(this.Label_Category);
            this.gb_Details.Controls.Add(this.tb_Name);
            this.gb_Details.Controls.Add(this.tb_Barcode);
            this.gb_Details.Controls.Add(this.cb_Category);
            this.gb_Details.Controls.Add(this.Label_Barcode);
            this.gb_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gb_Details.Location = new System.Drawing.Point(41, 188);
            this.gb_Details.Name = "gb_Details";
            this.gb_Details.Size = new System.Drawing.Size(496, 325);
            this.gb_Details.TabIndex = 1;
            this.gb_Details.TabStop = false;
            this.gb_Details.Text = "Details";
            // 
            // btn_AddNewCategory
            // 
            this.btn_AddNewCategory.AutoSize = true;
            this.btn_AddNewCategory.Location = new System.Drawing.Point(432, 208);
            this.btn_AddNewCategory.Name = "btn_AddNewCategory";
            this.btn_AddNewCategory.Size = new System.Drawing.Size(28, 30);
            this.btn_AddNewCategory.TabIndex = 30;
            this.btn_AddNewCategory.Text = "+";
            this.btn_AddNewCategory.UseVisualStyleBackColor = true;
            this.btn_AddNewCategory.Click += new System.EventHandler(this.btn_AddNewCategory_Click);
            // 
            // btn_ChangeProductImage
            // 
            this.btn_ChangeProductImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangeProductImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangeProductImage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ChangeProductImage.Location = new System.Drawing.Point(230, 152);
            this.btn_ChangeProductImage.Name = "btn_ChangeProductImage";
            this.btn_ChangeProductImage.Size = new System.Drawing.Size(90, 30);
            this.btn_ChangeProductImage.TabIndex = 50;
            this.btn_ChangeProductImage.Text = "Change";
            this.btn_ChangeProductImage.UseVisualStyleBackColor = true;
            this.btn_ChangeProductImage.Click += new System.EventHandler(this.btn_ChangeProductImage_Click);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(422, 134);
            this.lbl_Error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 18);
            this.lbl_Error.TabIndex = 30;
            this.lbl_Error.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Image.ImageLocation = "Resources\\Images\\placeholder.jpg";
            this.pictureBox_Image.Location = new System.Drawing.Point(41, 48);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(183, 134);
            this.pictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Image.TabIndex = 33;
            this.pictureBox_Image.TabStop = false;
            // 
            // Form_AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1078, 599);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_ChangeProductImage);
            this.Controls.Add(this.pictureBox_Image);
            this.Controls.Add(this.gb_Details);
            this.Controls.Add(this.gb_Tax);
            this.Controls.Add(this.gb_Pricing);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_saveProduct);
            this.Controls.Add(this.btn_ResetProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Product";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_Pricing.ResumeLayout(false);
            this.gb_Pricing.PerformLayout();
            this.gb_Tax.ResumeLayout(false);
            this.gb_Tax.PerformLayout();
            this.gb_Details.ResumeLayout(false);
            this.gb_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_Description;
        private System.Windows.Forms.Label Label_Category;
        private System.Windows.Forms.Label Label_WholesalePrice;
        private System.Windows.Forms.Label Label_RetailPrice;
        public System.Windows.Forms.TextBox tb_Name;
        public System.Windows.Forms.TextBox tb_Description;
        public System.Windows.Forms.TextBox tb_RetailPrice;
        public System.Windows.Forms.TextBox tb_WholeSalePrice;
        public System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.Button btn_saveProduct;
        private System.Windows.Forms.Button btn_ResetProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.TextBox tb_Barcode;
        private System.Windows.Forms.Label Label_Barcode;
        private System.Windows.Forms.GroupBox gb_Pricing;
        private System.Windows.Forms.GroupBox gb_Tax;
        public System.Windows.Forms.TextBox tb_CGST;
        private System.Windows.Forms.Label lbl_CGST;
        private System.Windows.Forms.Label lbl_SGST;
        public System.Windows.Forms.TextBox tb_SGST;
        public System.Windows.Forms.TextBox tb_Discount;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.GroupBox gb_Details;
        public System.Windows.Forms.PictureBox pictureBox_Image;
        public System.Windows.Forms.Button btn_ChangeProductImage;
        public System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Button btn_AddNewCategory;
    }
}