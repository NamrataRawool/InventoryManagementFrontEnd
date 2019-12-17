namespace InventoryManagement.UI.Category
{
    partial class form_categoryDetails
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
            this.label7 = new System.Windows.Forms.Label();
            this.btn_cancelCategory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_saveCategory = new System.Windows.Forms.Button();
            this.btn_ResetCategory = new System.Windows.Forms.Button();
            this.tb_categorySgst = new System.Windows.Forms.TextBox();
            this.tb_categoryDiscount = new System.Windows.Forms.TextBox();
            this.tb_categoryDescription = new System.Windows.Forms.TextBox();
            this.tb_categoryName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_categoryCgst = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(172, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Category Details";
            // 
            // btn_cancelCategory
            // 
            this.btn_cancelCategory.BackColor = System.Drawing.Color.White;
            this.btn_cancelCategory.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_cancelCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelCategory.ForeColor = System.Drawing.Color.Red;
            this.btn_cancelCategory.Location = new System.Drawing.Point(215, 593);
            this.btn_cancelCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelCategory.Name = "btn_cancelCategory";
            this.btn_cancelCategory.Size = new System.Drawing.Size(117, 44);
            this.btn_cancelCategory.TabIndex = 40;
            this.btn_cancelCategory.Text = "Cancel";
            this.btn_cancelCategory.UseVisualStyleBackColor = false;
            this.btn_cancelCategory.Click += new System.EventHandler(this.btn_cancelCategory_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 53);
            this.panel1.TabIndex = 39;
            // 
            // btn_saveCategory
            // 
            this.btn_saveCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.btn_saveCategory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_saveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveCategory.ForeColor = System.Drawing.Color.White;
            this.btn_saveCategory.Location = new System.Drawing.Point(357, 593);
            this.btn_saveCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_saveCategory.Name = "btn_saveCategory";
            this.btn_saveCategory.Size = new System.Drawing.Size(117, 44);
            this.btn_saveCategory.TabIndex = 37;
            this.btn_saveCategory.Text = "Save";
            this.btn_saveCategory.UseVisualStyleBackColor = false;
            this.btn_saveCategory.Click += new System.EventHandler(this.btn_saveCategory_Click);
            // 
            // btn_ResetCategory
            // 
            this.btn_ResetCategory.BackColor = System.Drawing.Color.LightGray;
            this.btn_ResetCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetCategory.ForeColor = System.Drawing.Color.Black;
            this.btn_ResetCategory.Location = new System.Drawing.Point(72, 593);
            this.btn_ResetCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ResetCategory.Name = "btn_ResetCategory";
            this.btn_ResetCategory.Size = new System.Drawing.Size(117, 44);
            this.btn_ResetCategory.TabIndex = 38;
            this.btn_ResetCategory.Text = "Reset";
            this.btn_ResetCategory.UseVisualStyleBackColor = false;
            this.btn_ResetCategory.Click += new System.EventHandler(this.btn_ResetCategory_Click);
            // 
            // tb_categorySgst
            // 
            this.tb_categorySgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_categorySgst.Location = new System.Drawing.Point(232, 386);
            this.tb_categorySgst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_categorySgst.Multiline = true;
            this.tb_categorySgst.Name = "tb_categorySgst";
            this.tb_categorySgst.Size = new System.Drawing.Size(265, 40);
            this.tb_categorySgst.TabIndex = 34;
            // 
            // tb_categoryDiscount
            // 
            this.tb_categoryDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_categoryDiscount.Location = new System.Drawing.Point(232, 301);
            this.tb_categoryDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_categoryDiscount.Multiline = true;
            this.tb_categoryDiscount.Name = "tb_categoryDiscount";
            this.tb_categoryDiscount.Size = new System.Drawing.Size(265, 40);
            this.tb_categoryDiscount.TabIndex = 33;
            // 
            // tb_categoryDescription
            // 
            this.tb_categoryDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_categoryDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_categoryDescription.Location = new System.Drawing.Point(232, 195);
            this.tb_categoryDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_categoryDescription.Multiline = true;
            this.tb_categoryDescription.Name = "tb_categoryDescription";
            this.tb_categoryDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_categoryDescription.Size = new System.Drawing.Size(290, 61);
            this.tb_categoryDescription.TabIndex = 32;
            // 
            // tb_categoryName
            // 
            this.tb_categoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_categoryName.Location = new System.Drawing.Point(232, 110);
            this.tb_categoryName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_categoryName.Multiline = true;
            this.tb_categoryName.Name = "tb_categoryName";
            this.tb_categoryName.Size = new System.Drawing.Size(265, 40);
            this.tb_categoryName.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Discount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "SGST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "CGST";
            // 
            // tb_categoryCgst
            // 
            this.tb_categoryCgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_categoryCgst.Location = new System.Drawing.Point(232, 471);
            this.tb_categoryCgst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_categoryCgst.Multiline = true;
            this.tb_categoryCgst.Name = "tb_categoryCgst";
            this.tb_categoryCgst.Size = new System.Drawing.Size(265, 40);
            this.tb_categoryCgst.TabIndex = 34;
            // 
            // form_categoryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 692);
            this.Controls.Add(this.btn_cancelCategory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_saveCategory);
            this.Controls.Add(this.btn_ResetCategory);
            this.Controls.Add(this.tb_categoryCgst);
            this.Controls.Add(this.tb_categorySgst);
            this.Controls.Add(this.tb_categoryDiscount);
            this.Controls.Add(this.tb_categoryDescription);
            this.Controls.Add(this.tb_categoryName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "form_categoryDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Category";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_cancelCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_saveCategory;
        private System.Windows.Forms.Button btn_ResetCategory;
        public System.Windows.Forms.TextBox tb_categorySgst;
        public System.Windows.Forms.TextBox tb_categoryDiscount;
        public System.Windows.Forms.TextBox tb_categoryDescription;
        public System.Windows.Forms.TextBox tb_categoryName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tb_categoryCgst;
    }
}