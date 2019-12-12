namespace InventoryManagement.UI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_Product = new System.Windows.Forms.Button();
            this.btn_Category = new System.Windows.Forms.Button();
            this.btn_Transaction = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_Stock = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.homeControl = new InventoryManagement.UserControls.HomeControl();
            this.productControl = new InventoryManagement.UserControls.ProductControl();
            this.categoryControl = new InventoryManagement.UserControls.CategoryControl();
            this.transactionControl = new InventoryManagement.UserControls.TransactionControl();
            this.customerControl = new InventoryManagement.UserControls.CustomerControl();
            this.stockControl = new InventoryManagement.UserControls.StockControl();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.77524F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.22475F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(347, 763);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btn_Home, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Product, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.btn_Category, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.btn_Transaction, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.btn_Customer, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.btn_Stock, 0, 10);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 127);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 12;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.21739F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.21739F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.21739F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.21739F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.21739F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.21739F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(347, 636);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btn_Home
            // 
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.White;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(4, 4);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(339, 73);
            this.btn_Home.TabIndex = 4;
            this.btn_Home.Text = "    Home";
            this.btn_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_Product
            // 
            this.btn_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Product.FlatAppearance.BorderSize = 0;
            this.btn_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Product.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product.ForeColor = System.Drawing.Color.White;
            this.btn_Product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Product.Location = new System.Drawing.Point(4, 108);
            this.btn_Product.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(339, 73);
            this.btn_Product.TabIndex = 5;
            this.btn_Product.Text = "   Product";
            this.btn_Product.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Product.UseVisualStyleBackColor = true;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // btn_Category
            // 
            this.btn_Category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Category.FlatAppearance.BorderSize = 0;
            this.btn_Category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Category.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Category.ForeColor = System.Drawing.Color.White;
            this.btn_Category.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Category.Location = new System.Drawing.Point(4, 212);
            this.btn_Category.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Category.Name = "btn_Category";
            this.btn_Category.Size = new System.Drawing.Size(339, 73);
            this.btn_Category.TabIndex = 6;
            this.btn_Category.Text = "Category";
            this.btn_Category.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Category.UseVisualStyleBackColor = true;
            this.btn_Category.Click += new System.EventHandler(this.btn_Category_Click);
            // 
            // btn_Transaction
            // 
            this.btn_Transaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Transaction.FlatAppearance.BorderSize = 0;
            this.btn_Transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Transaction.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Transaction.ForeColor = System.Drawing.Color.White;
            this.btn_Transaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Transaction.Location = new System.Drawing.Point(4, 318);
            this.btn_Transaction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Transaction.Name = "btn_Transaction";
            this.btn_Transaction.Size = new System.Drawing.Size(339, 73);
            this.btn_Transaction.TabIndex = 7;
            this.btn_Transaction.Text = "Transaction";
            this.btn_Transaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Transaction.UseVisualStyleBackColor = true;
            this.btn_Transaction.Click += new System.EventHandler(this.btn_Transaction_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Customer.FlatAppearance.BorderSize = 0;
            this.btn_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Customer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.ForeColor = System.Drawing.Color.White;
            this.btn_Customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Customer.Location = new System.Drawing.Point(4, 424);
            this.btn_Customer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(339, 73);
            this.btn_Customer.TabIndex = 8;
            this.btn_Customer.Text = "Customer";
            this.btn_Customer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Customer.UseVisualStyleBackColor = true;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btn_Stock
            // 
            this.btn_Stock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Stock.FlatAppearance.BorderSize = 0;
            this.btn_Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stock.ForeColor = System.Drawing.Color.White;
            this.btn_Stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Stock.Location = new System.Drawing.Point(4, 530);
            this.btn_Stock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Stock.Name = "btn_Stock";
            this.btn_Stock.Size = new System.Drawing.Size(339, 73);
            this.btn_Stock.TabIndex = 9;
            this.btn_Stock.Text = "Stock";
            this.btn_Stock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Stock.UseVisualStyleBackColor = true;
            this.btn_Stock.Click += new System.EventHandler(this.btn_Stock_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(347, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1389, 70);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management";
            // 
            // homeControl
            // 
            this.homeControl.BackColor = System.Drawing.Color.Gainsboro;
            this.homeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeControl.Location = new System.Drawing.Point(347, 70);
            this.homeControl.Margin = new System.Windows.Forms.Padding(5);
            this.homeControl.Name = "homeControl";
            this.homeControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.homeControl.Size = new System.Drawing.Size(1389, 693);
            this.homeControl.TabIndex = 11;
            // 
            // productControl
            // 
            this.productControl.BackColor = System.Drawing.Color.Gainsboro;
            this.productControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productControl.Location = new System.Drawing.Point(347, 70);
            this.productControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productControl.Name = "productControl";
            this.productControl.Size = new System.Drawing.Size(1389, 693);
            this.productControl.TabIndex = 10;
            // 
            // categoryControl
            // 
            this.categoryControl.BackColor = System.Drawing.Color.Gainsboro;
            this.categoryControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryControl.Location = new System.Drawing.Point(347, 70);
            this.categoryControl.Margin = new System.Windows.Forms.Padding(5);
            this.categoryControl.Name = "categoryControl";
            this.categoryControl.Size = new System.Drawing.Size(1389, 693);
            this.categoryControl.TabIndex = 9;
            // 
            // transactionControl
            // 
            this.transactionControl.BackColor = System.Drawing.Color.Gainsboro;
            this.transactionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionControl.Location = new System.Drawing.Point(347, 70);
            this.transactionControl.Margin = new System.Windows.Forms.Padding(5);
            this.transactionControl.Name = "transactionControl";
            this.transactionControl.Size = new System.Drawing.Size(1389, 693);
            this.transactionControl.TabIndex = 8;
            // 
            // customerControl
            // 
            this.customerControl.BackColor = System.Drawing.Color.Gainsboro;
            this.customerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerControl.Location = new System.Drawing.Point(347, 70);
            this.customerControl.Margin = new System.Windows.Forms.Padding(5);
            this.customerControl.Name = "customerControl";
            this.customerControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customerControl.Size = new System.Drawing.Size(1389, 693);
            this.customerControl.TabIndex = 7;
            // 
            // stockControl
            // 
            this.stockControl.BackColor = System.Drawing.Color.Gainsboro;
            this.stockControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockControl.Location = new System.Drawing.Point(347, 70);
            this.stockControl.Margin = new System.Windows.Forms.Padding(5);
            this.stockControl.Name = "stockControl";
            this.stockControl.Size = new System.Drawing.Size(1389, 693);
            this.stockControl.TabIndex = 6;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1736, 763);
            this.Controls.Add(this.homeControl);
            this.Controls.Add(this.productControl);
            this.Controls.Add(this.categoryControl);
            this.Controls.Add(this.transactionControl);
            this.Controls.Add(this.customerControl);
            this.Controls.Add(this.stockControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Product;
        private System.Windows.Forms.Button btn_Category;
        private System.Windows.Forms.Button btn_Transaction;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_Stock;
        private System.Windows.Forms.Panel panel1;
        private UserControls.StockControl stockControl;
        private UserControls.CustomerControl customerControl;
        private UserControls.TransactionControl transactionControl;
        private UserControls.CategoryControl categoryControl;
        private UserControls.ProductControl productControl;
        private UserControls.HomeControl homeControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}