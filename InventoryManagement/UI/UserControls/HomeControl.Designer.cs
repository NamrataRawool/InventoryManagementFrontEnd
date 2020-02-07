namespace InventoryManagement.UI.UserControls
{
    partial class HomeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_transactions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cb_period = new System.Windows.Forms.ComboBox();
            this.lbl_purchase = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_customers = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_pendingAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_lowStockItems = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_dateTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_MoreInfo_Transactions = new System.Windows.Forms.Button();
            this.btn_MoreInfo_Purchases = new System.Windows.Forms.Button();
            this.btn_MoreInfo_Customers = new System.Windows.Forms.Button();
            this.btn_MoreInfo_LowStock = new System.Windows.Forms.Button();
            this.btn_MoreInfo_PendingAmount = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_MoreInfo_Transactions);
            this.panel1.Controls.Add(this.lbl_transactions);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(65, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 173);
            this.panel1.TabIndex = 0;
            // 
            // lbl_transactions
            // 
            this.lbl_transactions.AutoSize = true;
            this.lbl_transactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transactions.Location = new System.Drawing.Point(108, 62);
            this.lbl_transactions.Name = "lbl_transactions";
            this.lbl_transactions.Size = new System.Drawing.Size(0, 20);
            this.lbl_transactions.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transactions";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_MoreInfo_LowStock);
            this.panel2.Controls.Add(this.lbl_lowStockItems);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(290, 515);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 173);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_MoreInfo_Purchases);
            this.panel3.Controls.Add(this.lbl_purchase);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(425, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 173);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btn_MoreInfo_PendingAmount);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.lbl_pendingAmount);
            this.panel4.Location = new System.Drawing.Point(670, 515);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 173);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btn_MoreInfo_Customers);
            this.panel5.Controls.Add(this.lbl_customers);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(785, 136);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(267, 173);
            this.panel5.TabIndex = 0;
            // 
            // cb_period
            // 
            this.cb_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_period.FormattingEnabled = true;
            this.cb_period.Location = new System.Drawing.Point(65, 50);
            this.cb_period.Name = "cb_period";
            this.cb_period.Size = new System.Drawing.Size(226, 26);
            this.cb_period.TabIndex = 2;
            // 
            // lbl_purchase
            // 
            this.lbl_purchase.AutoSize = true;
            this.lbl_purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purchase.Location = new System.Drawing.Point(120, 63);
            this.lbl_purchase.Name = "lbl_purchase";
            this.lbl_purchase.Size = new System.Drawing.Size(0, 20);
            this.lbl_purchase.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Purchases";
            // 
            // lbl_customers
            // 
            this.lbl_customers.AutoSize = true;
            this.lbl_customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customers.Location = new System.Drawing.Point(125, 62);
            this.lbl_customers.Name = "lbl_customers";
            this.lbl_customers.Size = new System.Drawing.Size(0, 20);
            this.lbl_customers.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Customers";
            // 
            // lbl_pendingAmount
            // 
            this.lbl_pendingAmount.AutoSize = true;
            this.lbl_pendingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pendingAmount.Location = new System.Drawing.Point(112, 69);
            this.lbl_pendingAmount.Name = "lbl_pendingAmount";
            this.lbl_pendingAmount.Size = new System.Drawing.Size(0, 20);
            this.lbl_pendingAmount.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pending Amount";
            // 
            // lbl_lowStockItems
            // 
            this.lbl_lowStockItems.AutoSize = true;
            this.lbl_lowStockItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lowStockItems.Location = new System.Drawing.Point(109, 69);
            this.lbl_lowStockItems.Name = "lbl_lowStockItems";
            this.lbl_lowStockItems.Size = new System.Drawing.Size(0, 20);
            this.lbl_lowStockItems.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Low Stock Items";
            // 
            // lbl_dateTime
            // 
            this.lbl_dateTime.AutoSize = true;
            this.lbl_dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateTime.Location = new System.Drawing.Point(953, 27);
            this.lbl_dateTime.Name = "lbl_dateTime";
            this.lbl_dateTime.Size = new System.Drawing.Size(0, 25);
            this.lbl_dateTime.TabIndex = 3;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_period);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1118, 353);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overview";
            // 
            // btn_MoreInfo_Transactions
            // 
            this.btn_MoreInfo_Transactions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_MoreInfo_Transactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MoreInfo_Transactions.Image = ((System.Drawing.Image)(resources.GetObject("btn_MoreInfo_Transactions.Image")));
            this.btn_MoreInfo_Transactions.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_MoreInfo_Transactions.Location = new System.Drawing.Point(0, 118);
            this.btn_MoreInfo_Transactions.Name = "btn_MoreInfo_Transactions";
            this.btn_MoreInfo_Transactions.Size = new System.Drawing.Size(265, 53);
            this.btn_MoreInfo_Transactions.TabIndex = 2;
            this.btn_MoreInfo_Transactions.Text = "More Info";
            this.btn_MoreInfo_Transactions.UseVisualStyleBackColor = true;
            this.btn_MoreInfo_Transactions.Click += new System.EventHandler(this.btn_MoreInfo_Transactions_Click);
            // 
            // btn_MoreInfo_Purchases
            // 
            this.btn_MoreInfo_Purchases.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_MoreInfo_Purchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MoreInfo_Purchases.Image = ((System.Drawing.Image)(resources.GetObject("btn_MoreInfo_Purchases.Image")));
            this.btn_MoreInfo_Purchases.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_MoreInfo_Purchases.Location = new System.Drawing.Point(0, 120);
            this.btn_MoreInfo_Purchases.Name = "btn_MoreInfo_Purchases";
            this.btn_MoreInfo_Purchases.Size = new System.Drawing.Size(265, 51);
            this.btn_MoreInfo_Purchases.TabIndex = 4;
            this.btn_MoreInfo_Purchases.Text = "More Info";
            this.btn_MoreInfo_Purchases.UseVisualStyleBackColor = true;
            this.btn_MoreInfo_Purchases.Click += new System.EventHandler(this.btn_MoreInfo_Purchases_Click);
            // 
            // btn_MoreInfo_Customers
            // 
            this.btn_MoreInfo_Customers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_MoreInfo_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MoreInfo_Customers.Image = ((System.Drawing.Image)(resources.GetObject("btn_MoreInfo_Customers.Image")));
            this.btn_MoreInfo_Customers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_MoreInfo_Customers.Location = new System.Drawing.Point(0, 120);
            this.btn_MoreInfo_Customers.Name = "btn_MoreInfo_Customers";
            this.btn_MoreInfo_Customers.Size = new System.Drawing.Size(265, 51);
            this.btn_MoreInfo_Customers.TabIndex = 4;
            this.btn_MoreInfo_Customers.Text = "More Info";
            this.btn_MoreInfo_Customers.UseVisualStyleBackColor = true;
            this.btn_MoreInfo_Customers.Click += new System.EventHandler(this.btn_MoreInfo_Customers_Click);
            // 
            // btn_MoreInfo_LowStock
            // 
            this.btn_MoreInfo_LowStock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_MoreInfo_LowStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MoreInfo_LowStock.Image = ((System.Drawing.Image)(resources.GetObject("btn_MoreInfo_LowStock.Image")));
            this.btn_MoreInfo_LowStock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_MoreInfo_LowStock.Location = new System.Drawing.Point(0, 120);
            this.btn_MoreInfo_LowStock.Name = "btn_MoreInfo_LowStock";
            this.btn_MoreInfo_LowStock.Size = new System.Drawing.Size(265, 51);
            this.btn_MoreInfo_LowStock.TabIndex = 6;
            this.btn_MoreInfo_LowStock.Text = "More Info";
            this.btn_MoreInfo_LowStock.UseVisualStyleBackColor = true;
            this.btn_MoreInfo_LowStock.Click += new System.EventHandler(this.btn_MoreInfo_LowStock_Click);
            // 
            // btn_MoreInfo_PendingAmount
            // 
            this.btn_MoreInfo_PendingAmount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_MoreInfo_PendingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MoreInfo_PendingAmount.Image = ((System.Drawing.Image)(resources.GetObject("btn_MoreInfo_PendingAmount.Image")));
            this.btn_MoreInfo_PendingAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_MoreInfo_PendingAmount.Location = new System.Drawing.Point(0, 120);
            this.btn_MoreInfo_PendingAmount.Name = "btn_MoreInfo_PendingAmount";
            this.btn_MoreInfo_PendingAmount.Size = new System.Drawing.Size(265, 51);
            this.btn_MoreInfo_PendingAmount.TabIndex = 6;
            this.btn_MoreInfo_PendingAmount.Text = "More Info";
            this.btn_MoreInfo_PendingAmount.UseVisualStyleBackColor = true;
            this.btn_MoreInfo_PendingAmount.Click += new System.EventHandler(this.btn_MoreInfo_PendingAmount_Click);
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_dateTime);
            this.Name = "HomeControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1303, 782);
            this.Load += new System.EventHandler(this.HomeControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_transactions;
        private System.Windows.Forms.Label lbl_pendingAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_purchase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_lowStockItems;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_customers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_dateTime;
        public System.Windows.Forms.ComboBox cb_period;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_MoreInfo_Transactions;
        private System.Windows.Forms.Button btn_MoreInfo_LowStock;
        private System.Windows.Forms.Button btn_MoreInfo_Purchases;
        private System.Windows.Forms.Button btn_MoreInfo_PendingAmount;
        private System.Windows.Forms.Button btn_MoreInfo_Customers;
    }
}
