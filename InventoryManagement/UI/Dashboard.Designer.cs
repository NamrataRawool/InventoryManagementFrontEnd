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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_Product = new System.Windows.Forms.Button();
            this.btn_Category = new System.Windows.Forms.Button();
            this.btn_Transaction = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_Stock = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addProductControl1 = new InventoryManagement.UserControls.ProductControl();
            this.homeControl1 = new InventoryManagement.UserControls.HomeControl();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.77524F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.22475F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(260, 620);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btn_Home, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Product, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.btn_Category, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.btn_Transaction, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.btn_Customer, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.btn_Stock, 0, 10);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 104);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 12;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.21739F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.21739F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.21739F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.21739F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.21739F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.21739F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(260, 516);
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
            this.btn_Home.Location = new System.Drawing.Point(3, 3);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(254, 60);
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
            this.btn_Product.Location = new System.Drawing.Point(3, 87);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(254, 60);
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
            this.btn_Category.Location = new System.Drawing.Point(3, 171);
            this.btn_Category.Name = "btn_Category";
            this.btn_Category.Size = new System.Drawing.Size(254, 60);
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
            this.btn_Transaction.Location = new System.Drawing.Point(3, 257);
            this.btn_Transaction.Name = "btn_Transaction";
            this.btn_Transaction.Size = new System.Drawing.Size(254, 60);
            this.btn_Transaction.TabIndex = 7;
            this.btn_Transaction.Text = "Transaction";
            this.btn_Transaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Transaction.UseVisualStyleBackColor = true;
            // 
            // btn_Customer
            // 
            this.btn_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Customer.FlatAppearance.BorderSize = 0;
            this.btn_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Customer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.ForeColor = System.Drawing.Color.White;
            this.btn_Customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Customer.Location = new System.Drawing.Point(3, 343);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(254, 60);
            this.btn_Customer.TabIndex = 8;
            this.btn_Customer.Text = "Customer";
            this.btn_Customer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Customer.UseVisualStyleBackColor = true;
            // 
            // btn_Stock
            // 
            this.btn_Stock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Stock.FlatAppearance.BorderSize = 0;
            this.btn_Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stock.ForeColor = System.Drawing.Color.White;
            this.btn_Stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Stock.Location = new System.Drawing.Point(3, 429);
            this.btn_Stock.Name = "btn_Stock";
            this.btn_Stock.Size = new System.Drawing.Size(254, 60);
            this.btn_Stock.TabIndex = 9;
            this.btn_Stock.Text = "Stock";
            this.btn_Stock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Stock.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(260, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 57);
            this.panel1.TabIndex = 5;
            // 
            // addProductControl1
            // 
            this.addProductControl1.BackColor = System.Drawing.Color.Gainsboro;
            this.addProductControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addProductControl1.Location = new System.Drawing.Point(260, 57);
            this.addProductControl1.Margin = new System.Windows.Forms.Padding(2);
            this.addProductControl1.Name = "addProductControl1";
            this.addProductControl1.Size = new System.Drawing.Size(1042, 563);
            this.addProductControl1.TabIndex = 6;
            // 
            // homeControl1
            // 
            this.homeControl1.BackColor = System.Drawing.Color.Gainsboro;
            this.homeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeControl1.Location = new System.Drawing.Point(260, 57);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.homeControl1.Size = new System.Drawing.Size(1042, 563);
            this.homeControl1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1302, 620);
            this.Controls.Add(this.homeControl1);
            this.Controls.Add(this.addProductControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
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
        private UserControls.ProductControl addProductControl1;
        private UserControls.HomeControl homeControl1;
    }
}