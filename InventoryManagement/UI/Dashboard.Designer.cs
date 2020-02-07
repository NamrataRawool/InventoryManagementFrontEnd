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
            this.btn_Vendors = new System.Windows.Forms.Button();
            this.btn_Purchase = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_Transaction = new System.Windows.Forms.Button();
            this.btn_Category = new System.Windows.Forms.Button();
            this.btn_Product = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vendorControl = new InventoryManagement.UI.UserControls.VendorControl();
            this.purchaseControl = new InventoryManagement.UI.UserControls.PurchaseControl();
            this.customerControl = new InventoryManagement.UI.UserControls.CustomerControl();
            this.transactionControl = new InventoryManagement.UI.UserControls.TransactionControl();
            this.categoryControl = new InventoryManagement.UI.UserControls.CategoryControl();
            this.productControl = new InventoryManagement.UI.UserControls.ProductControl();
            this.homeControl = new InventoryManagement.UI.UserControls.HomeControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btn_Vendors);
            this.panel1.Controls.Add(this.btn_Purchase);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_Customer);
            this.panel1.Controls.Add(this.btn_Transaction);
            this.panel1.Controls.Add(this.btn_Category);
            this.panel1.Controls.Add(this.btn_Product);
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 704);
            this.panel1.TabIndex = 2;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 80);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(13, 68);
            this.SidePanel.TabIndex = 4;
            // 
            // btn_Vendors
            // 
            this.btn_Vendors.FlatAppearance.BorderSize = 0;
            this.btn_Vendors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Vendors.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vendors.ForeColor = System.Drawing.Color.White;
            this.btn_Vendors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Vendors.Location = new System.Drawing.Point(1, 619);
            this.btn_Vendors.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Vendors.Name = "btn_Vendors";
            this.btn_Vendors.Size = new System.Drawing.Size(233, 66);
            this.btn_Vendors.TabIndex = 8;
            this.btn_Vendors.Text = "Vendors";
            this.btn_Vendors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Vendors.UseVisualStyleBackColor = true;
            this.btn_Vendors.Click += new System.EventHandler(this.btn_Vendors_Click);
            // 
            // btn_Purchase
            // 
            this.btn_Purchase.FlatAppearance.BorderSize = 0;
            this.btn_Purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Purchase.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Purchase.ForeColor = System.Drawing.Color.White;
            this.btn_Purchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Purchase.Location = new System.Drawing.Point(1, 522);
            this.btn_Purchase.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Purchase.Name = "btn_Purchase";
            this.btn_Purchase.Size = new System.Drawing.Size(233, 66);
            this.btn_Purchase.TabIndex = 8;
            this.btn_Purchase.Text = "Purchase";
            this.btn_Purchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Purchase.UseVisualStyleBackColor = true;
            this.btn_Purchase.Click += new System.EventHandler(this.btn_Purchase_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, -1);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 80);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
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
            this.btn_Customer.Location = new System.Drawing.Point(1, 433);
            this.btn_Customer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(233, 66);
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
            this.btn_Transaction.Location = new System.Drawing.Point(1, 345);
            this.btn_Transaction.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Transaction.Name = "btn_Transaction";
            this.btn_Transaction.Size = new System.Drawing.Size(233, 66);
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
            this.btn_Category.Location = new System.Drawing.Point(1, 256);
            this.btn_Category.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Category.Name = "btn_Category";
            this.btn_Category.Size = new System.Drawing.Size(233, 66);
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
            this.btn_Product.Location = new System.Drawing.Point(1, 167);
            this.btn_Product.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(233, 66);
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
            this.btn_Home.Location = new System.Drawing.Point(4, 82);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(233, 66);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 25);
            this.panel2.TabIndex = 3;
            // 
            // vendorControl
            // 
            this.vendorControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.vendorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vendorControl.Location = new System.Drawing.Point(236, 25);
            this.vendorControl.Name = "vendorControl";
            this.vendorControl.Size = new System.Drawing.Size(1114, 704);
            this.vendorControl.TabIndex = 4;
            // 
            // purchaseControl
            // 
            this.purchaseControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.purchaseControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseControl.Location = new System.Drawing.Point(236, 25);
            this.purchaseControl.Name = "purchaseControl";
            this.purchaseControl.Size = new System.Drawing.Size(1114, 704);
            this.purchaseControl.TabIndex = 5;
            // 
            // customerControl
            // 
            this.customerControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.customerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerControl.Location = new System.Drawing.Point(236, 25);
            this.customerControl.Name = "customerControl";
            this.customerControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customerControl.Size = new System.Drawing.Size(1114, 704);
            this.customerControl.TabIndex = 6;
            // 
            // transactionControl1
            // 
            this.transactionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.transactionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionControl.Location = new System.Drawing.Point(236, 25);
            this.transactionControl.Name = "transactionControl1";
            this.transactionControl.Size = new System.Drawing.Size(1114, 704);
            this.transactionControl.TabIndex = 7;
            // 
            // categoryControl
            // 
            this.categoryControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.categoryControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryControl.Location = new System.Drawing.Point(236, 25);
            this.categoryControl.Name = "categoryControl";
            this.categoryControl.Size = new System.Drawing.Size(1114, 704);
            this.categoryControl.TabIndex = 8;
            // 
            // productControl
            // 
            this.productControl.BackColor = System.Drawing.Color.Gainsboro;
            this.productControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productControl.Location = new System.Drawing.Point(236, 25);
            this.productControl.Margin = new System.Windows.Forms.Padding(2);
            this.productControl.Name = "productControl";
            this.productControl.Size = new System.Drawing.Size(1114, 704);
            this.productControl.TabIndex = 9;
            // 
            // homeControl
            // 
            this.homeControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.homeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeControl.Location = new System.Drawing.Point(236, 25);
            this.homeControl.Name = "homeControl";
            this.homeControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.homeControl.Size = new System.Drawing.Size(1114, 704);
            this.homeControl.TabIndex = 10;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.homeControl);
            this.Controls.Add(this.productControl);
            this.Controls.Add(this.categoryControl);
            this.Controls.Add(this.transactionControl);
            this.Controls.Add(this.customerControl);
            this.Controls.Add(this.purchaseControl);
            this.Controls.Add(this.vendorControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
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
        private System.Windows.Forms.Button btn_Vendors;
        private System.Windows.Forms.Button btn_Purchase;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_Transaction;
        private System.Windows.Forms.Button btn_Category;
        private System.Windows.Forms.Button btn_Product;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel panel2;
        private UserControls.VendorControl vendorControl;
        private UserControls.PurchaseControl purchaseControl;
        private UserControls.CustomerControl customerControl;
        private UserControls.TransactionControl transactionControl;
        private UserControls.CategoryControl categoryControl;
        private UserControls.ProductControl productControl;
        private UserControls.HomeControl homeControl;
    }
}