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
            this.Label_Image = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.tb_RetailPrice = new System.Windows.Forms.TextBox();
            this.tb_WholeSalePrice = new System.Windows.Forms.TextBox();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.btn_browseImage = new System.Windows.Forms.Button();
            this.btn_saveProduct = new System.Windows.Forms.Button();
            this.btn_ResetProduct = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tb_imageName = new System.Windows.Forms.TextBox();
            this.tb_Barcode = new System.Windows.Forms.TextBox();
            this.Label_Barcode = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Name
            // 
            this.Label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.Location = new System.Drawing.Point(32, 86);
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
            this.Label_Description.Location = new System.Drawing.Point(32, 202);
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
            this.Label_Category.Location = new System.Drawing.Point(32, 269);
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
            this.Label_WholesalePrice.Location = new System.Drawing.Point(27, 390);
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
            this.Label_RetailPrice.Location = new System.Drawing.Point(32, 326);
            this.Label_RetailPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_RetailPrice.Name = "Label_RetailPrice";
            this.Label_RetailPrice.Size = new System.Drawing.Size(116, 33);
            this.Label_RetailPrice.TabIndex = 4;
            this.Label_RetailPrice.Text = "Retail Price :";
            this.Label_RetailPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Image
            // 
            this.Label_Image.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Image.Location = new System.Drawing.Point(32, 450);
            this.Label_Image.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Image.Name = "Label_Image";
            this.Label_Image.Size = new System.Drawing.Size(116, 33);
            this.Label_Image.TabIndex = 5;
            this.Label_Image.Text = "Image :";
            this.Label_Image.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(174, 84);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(200, 33);
            this.tb_Name.TabIndex = 8;
            // 
            // tb_Description
            // 
            this.tb_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Description.Location = new System.Drawing.Point(174, 190);
            this.tb_Description.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Description.Size = new System.Drawing.Size(218, 50);
            this.tb_Description.TabIndex = 9;
            // 
            // tb_RetailPrice
            // 
            this.tb_RetailPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RetailPrice.Location = new System.Drawing.Point(174, 326);
            this.tb_RetailPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tb_RetailPrice.Multiline = true;
            this.tb_RetailPrice.Name = "tb_RetailPrice";
            this.tb_RetailPrice.Size = new System.Drawing.Size(200, 33);
            this.tb_RetailPrice.TabIndex = 9;
            // 
            // tb_WholeSalePrice
            // 
            this.tb_WholeSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_WholeSalePrice.Location = new System.Drawing.Point(174, 388);
            this.tb_WholeSalePrice.Margin = new System.Windows.Forms.Padding(2);
            this.tb_WholeSalePrice.Multiline = true;
            this.tb_WholeSalePrice.Name = "tb_WholeSalePrice";
            this.tb_WholeSalePrice.Size = new System.Drawing.Size(200, 33);
            this.tb_WholeSalePrice.TabIndex = 9;
            // 
            // cb_Category
            // 
            this.cb_Category.DropDownHeight = 80;
            this.cb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.IntegralHeight = false;
            this.cb_Category.Location = new System.Drawing.Point(174, 269);
            this.cb_Category.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(200, 24);
            this.cb_Category.TabIndex = 10;
            // 
            // btn_browseImage
            // 
            this.btn_browseImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(124)))));
            this.btn_browseImage.FlatAppearance.BorderSize = 2;
            this.btn_browseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browseImage.ForeColor = System.Drawing.Color.White;
            this.btn_browseImage.Location = new System.Drawing.Point(330, 448);
            this.btn_browseImage.Margin = new System.Windows.Forms.Padding(0);
            this.btn_browseImage.Name = "btn_browseImage";
            this.btn_browseImage.Size = new System.Drawing.Size(65, 37);
            this.btn_browseImage.TabIndex = 11;
            this.btn_browseImage.Text = "Upload";
            this.btn_browseImage.UseVisualStyleBackColor = false;
            this.btn_browseImage.Click += new System.EventHandler(this.btn_browseImage_Click);
            // 
            // btn_saveProduct
            // 
            this.btn_saveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.btn_saveProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_saveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveProduct.ForeColor = System.Drawing.Color.White;
            this.btn_saveProduct.Location = new System.Drawing.Point(281, 520);
            this.btn_saveProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btn_saveProduct.Name = "btn_saveProduct";
            this.btn_saveProduct.Size = new System.Drawing.Size(88, 36);
            this.btn_saveProduct.TabIndex = 20;
            this.btn_saveProduct.Text = "Save";
            this.btn_saveProduct.UseVisualStyleBackColor = false;
            this.btn_saveProduct.Click += new System.EventHandler(this.btn_saveProduct_Click);
            // 
            // btn_ResetProduct
            // 
            this.btn_ResetProduct.BackColor = System.Drawing.Color.LightGray;
            this.btn_ResetProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetProduct.ForeColor = System.Drawing.Color.Black;
            this.btn_ResetProduct.Location = new System.Drawing.Point(67, 520);
            this.btn_ResetProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ResetProduct.Name = "btn_ResetProduct";
            this.btn_ResetProduct.Size = new System.Drawing.Size(88, 36);
            this.btn_ResetProduct.TabIndex = 21;
            this.btn_ResetProduct.Text = "Reset";
            this.btn_ResetProduct.UseVisualStyleBackColor = false;
            this.btn_ResetProduct.Click += new System.EventHandler(this.btn_ResetProduct_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 43);
            this.panel1.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(129, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Product Details";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Red;
            this.btn_cancel.Location = new System.Drawing.Point(174, 520);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(88, 36);
            this.btn_cancel.TabIndex = 23;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tb_imageName
            // 
            this.tb_imageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_imageName.Location = new System.Drawing.Point(174, 450);
            this.tb_imageName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_imageName.Multiline = true;
            this.tb_imageName.Name = "tb_imageName";
            this.tb_imageName.Size = new System.Drawing.Size(159, 33);
            this.tb_imageName.TabIndex = 24;
            // 
            // tb_Barcode
            // 
            this.tb_Barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Barcode.Location = new System.Drawing.Point(174, 139);
            this.tb_Barcode.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Barcode.Multiline = true;
            this.tb_Barcode.Name = "tb_Barcode";
            this.tb_Barcode.Size = new System.Drawing.Size(200, 33);
            this.tb_Barcode.TabIndex = 26;
            // 
            // Label_Barcode
            // 
            this.Label_Barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Barcode.Location = new System.Drawing.Point(32, 141);
            this.Label_Barcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Barcode.Name = "Label_Barcode";
            this.Label_Barcode.Size = new System.Drawing.Size(116, 31);
            this.Label_Barcode.TabIndex = 25;
            this.Label_Barcode.Text = "Barcode :";
            this.Label_Barcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form_AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(426, 593);
            this.Controls.Add(this.tb_Barcode);
            this.Controls.Add(this.Label_Barcode);
            this.Controls.Add(this.tb_imageName);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_saveProduct);
            this.Controls.Add(this.btn_ResetProduct);
            this.Controls.Add(this.btn_browseImage);
            this.Controls.Add(this.cb_Category);
            this.Controls.Add(this.tb_WholeSalePrice);
            this.Controls.Add(this.tb_RetailPrice);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.Label_Image);
            this.Controls.Add(this.Label_RetailPrice);
            this.Controls.Add(this.Label_WholesalePrice);
            this.Controls.Add(this.Label_Category);
            this.Controls.Add(this.Label_Description);
            this.Controls.Add(this.Label_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Product";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_Description;
        private System.Windows.Forms.Label Label_Category;
        private System.Windows.Forms.Label Label_WholesalePrice;
        private System.Windows.Forms.Label Label_RetailPrice;
        private System.Windows.Forms.Label Label_Image;
        public System.Windows.Forms.TextBox tb_Name;
        public System.Windows.Forms.TextBox tb_Description;
        public System.Windows.Forms.TextBox tb_RetailPrice;
        public System.Windows.Forms.TextBox tb_WholeSalePrice;
        public System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.Button btn_browseImage;
        private System.Windows.Forms.Button btn_saveProduct;
        private System.Windows.Forms.Button btn_ResetProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.TextBox tb_imageName;
        public System.Windows.Forms.TextBox tb_Barcode;
        private System.Windows.Forms.Label Label_Barcode;
    }
}