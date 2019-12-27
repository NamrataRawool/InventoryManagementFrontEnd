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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btn_AboutUs = new System.Windows.Forms.Button();
            this.btn_Stock = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_Transaction = new System.Windows.Forms.Button();
            this.btn_Category = new System.Windows.Forms.Button();
            this.btn_Product = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homeControl = new InventoryManagement.UI.UserControls.HomeControl();
            this.productControl = new InventoryManagement.UI.UserControls.ProductControl();
            this.stockControl = new InventoryManagement.UI.UserControls.StockControl();
            this.categoryControl = new InventoryManagement.UI.UserControls.CategoryControl();
            this.customerControl = new InventoryManagement.UI.UserControls.CustomerControl();
            this.transactionControl = new InventoryManagement.UI.UserControls.TransactionControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btn_AboutUs);
            this.panel1.Controls.Add(this.btn_Stock);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_Customer);
            this.panel1.Controls.Add(this.btn_Transaction);
            this.panel1.Controls.Add(this.btn_Category);
            this.panel1.Controls.Add(this.btn_Product);
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 866);
            this.panel1.TabIndex = 2;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 98);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(17, 84);
            this.SidePanel.TabIndex = 4;
            // 
            // btn_AboutUs
            // 
            this.btn_AboutUs.FlatAppearance.BorderSize = 0;
            this.btn_AboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AboutUs.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AboutUs.ForeColor = System.Drawing.Color.White;
            this.btn_AboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AboutUs.Location = new System.Drawing.Point(1, 762);
            this.btn_AboutUs.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_AboutUs.Name = "btn_AboutUs";
            this.btn_AboutUs.Size = new System.Drawing.Size(311, 81);
            this.btn_AboutUs.TabIndex = 8;
            this.btn_AboutUs.Text = "About Us";
            this.btn_AboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AboutUs.UseVisualStyleBackColor = true;
            this.btn_AboutUs.Click += new System.EventHandler(this.btn_AboutUs_Click);
            // 
            // btn_Stock
            // 
            this.btn_Stock.FlatAppearance.BorderSize = 0;
            this.btn_Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stock.ForeColor = System.Drawing.Color.White;
            this.btn_Stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Stock.Location = new System.Drawing.Point(1, 642);
            this.btn_Stock.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Stock.Name = "btn_Stock";
            this.btn_Stock.Size = new System.Drawing.Size(311, 81);
            this.btn_Stock.TabIndex = 8;
            this.btn_Stock.Text = "Stock";
            this.btn_Stock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Stock.UseVisualStyleBackColor = true;
            this.btn_Stock.Click += new System.EventHandler(this.btn_Stock_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, -1);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 98);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inventory";
            // 
            // btn_Customer
            // 
            this.btn_Customer.FlatAppearance.BorderSize = 0;
            this.btn_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Customer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.ForeColor = System.Drawing.Color.White;
            this.btn_Customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Customer.Location = new System.Drawing.Point(1, 533);
            this.btn_Customer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(311, 81);
            this.btn_Customer.TabIndex = 7;
            this.btn_Customer.Text = "Customer";
            this.btn_Customer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Customer.UseVisualStyleBackColor = true;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btn_Transaction
            // 
            this.btn_Transaction.FlatAppearance.BorderSize = 0;
            this.btn_Transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Transaction.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Transaction.ForeColor = System.Drawing.Color.White;
            this.btn_Transaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Transaction.Location = new System.Drawing.Point(1, 425);
            this.btn_Transaction.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Transaction.Name = "btn_Transaction";
            this.btn_Transaction.Size = new System.Drawing.Size(311, 81);
            this.btn_Transaction.TabIndex = 6;
            this.btn_Transaction.Text = "Transaction";
            this.btn_Transaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Transaction.UseVisualStyleBackColor = true;
            this.btn_Transaction.Click += new System.EventHandler(this.btn_Transaction_Click);
            // 
            // btn_Category
            // 
            this.btn_Category.FlatAppearance.BorderSize = 0;
            this.btn_Category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Category.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Category.ForeColor = System.Drawing.Color.White;
            this.btn_Category.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Category.Location = new System.Drawing.Point(1, 315);
            this.btn_Category.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Category.Name = "btn_Category";
            this.btn_Category.Size = new System.Drawing.Size(311, 81);
            this.btn_Category.TabIndex = 5;
            this.btn_Category.Text = "Category";
            this.btn_Category.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Category.UseVisualStyleBackColor = true;
            this.btn_Category.Click += new System.EventHandler(this.btn_Category_Click);
            // 
            // btn_Product
            // 
            this.btn_Product.FlatAppearance.BorderSize = 0;
            this.btn_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Product.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product.ForeColor = System.Drawing.Color.White;
            this.btn_Product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Product.Location = new System.Drawing.Point(1, 206);
            this.btn_Product.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(311, 81);
            this.btn_Product.TabIndex = 4;
            this.btn_Product.Text = "   Product";
            this.btn_Product.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Product.UseVisualStyleBackColor = true;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.White;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(5, 101);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(311, 81);
            this.btn_Home.TabIndex = 3;
            this.btn_Home.Text = "    Home";
            this.btn_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1800, 31);
            this.panel2.TabIndex = 3;
            // 
            // homeControl
            // 
            this.homeControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.homeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeControl.Location = new System.Drawing.Point(315, 31);
            this.homeControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.homeControl.Name = "homeControl";
            this.homeControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.homeControl.Size = new System.Drawing.Size(1485, 866);
            this.homeControl.TabIndex = 4;
            // 
            // productControl
            // 
            this.productControl.BackColor = System.Drawing.Color.Gainsboro;
            this.productControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productControl.Location = new System.Drawing.Point(315, 31);
            this.productControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productControl.Name = "productControl";
            this.productControl.Size = new System.Drawing.Size(1485, 866);
            this.productControl.TabIndex = 5;
            // 
            // stockControl
            // 
            this.stockControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.stockControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockControl.Location = new System.Drawing.Point(315, 31);
            this.stockControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.stockControl.Name = "stockControl";
            this.stockControl.Size = new System.Drawing.Size(1485, 866);
            this.stockControl.TabIndex = 6;
            // 
            // categoryControl
            // 
            this.categoryControl.BackColor = System.Drawing.Color.Gainsboro;
            this.categoryControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryControl.Location = new System.Drawing.Point(315, 31);
            this.categoryControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.categoryControl.Name = "categoryControl";
            this.categoryControl.Size = new System.Drawing.Size(1485, 866);
            this.categoryControl.TabIndex = 7;
            // 
            // customerControl
            // 
            this.customerControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.customerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerControl.Location = new System.Drawing.Point(315, 31);
            this.customerControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.customerControl.Name = "customerControl";
            this.customerControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customerControl.Size = new System.Drawing.Size(1485, 866);
            this.customerControl.TabIndex = 8;
            // 
            // transactionControl
            // 
            this.transactionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.transactionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionControl.Location = new System.Drawing.Point(315, 31);
            this.transactionControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.transactionControl.Name = "transactionControl";
            this.transactionControl.Size = new System.Drawing.Size(1485, 866);
            this.transactionControl.TabIndex = 9;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1800, 897);
            this.Controls.Add(this.transactionControl);
            this.Controls.Add(this.customerControl);
            this.Controls.Add(this.categoryControl);
            this.Controls.Add(this.stockControl);
            this.Controls.Add(this.productControl);
            this.Controls.Add(this.homeControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btn_AboutUs;
        private System.Windows.Forms.Button btn_Stock;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_Transaction;
        private System.Windows.Forms.Button btn_Category;
        private System.Windows.Forms.Button btn_Product;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel panel2;
        private UserControls.HomeControl homeControl;
        private UserControls.ProductControl productControl;
        private UserControls.StockControl stockControl;
        private UserControls.CategoryControl categoryControl;
        private UserControls.CustomerControl customerControl;
        private UserControls.TransactionControl transactionControl;
    }
}