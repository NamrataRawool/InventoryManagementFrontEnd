namespace InventoryManagement.UI.Category
{
    partial class Form_AddCategory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_saveCategory = new System.Windows.Forms.Button();
            this.btn_ResetCategory = new System.Windows.Forms.Button();
            this.tb_categoryDescription = new System.Windows.Forms.TextBox();
            this.tb_categoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(106, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Category Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 43);
            this.panel1.TabIndex = 39;
            // 
            // btn_saveCategory
            // 
            this.btn_saveCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_saveCategory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_saveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveCategory.ForeColor = System.Drawing.Color.Black;
            this.btn_saveCategory.Location = new System.Drawing.Point(262, 239);
            this.btn_saveCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btn_saveCategory.Name = "btn_saveCategory";
            this.btn_saveCategory.Size = new System.Drawing.Size(88, 36);
            this.btn_saveCategory.TabIndex = 37;
            this.btn_saveCategory.Text = "Save";
            this.btn_saveCategory.UseVisualStyleBackColor = false;
            this.btn_saveCategory.Click += new System.EventHandler(this.btn_saveCategory_Click);
            // 
            // btn_ResetCategory
            // 
            this.btn_ResetCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ResetCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetCategory.ForeColor = System.Drawing.Color.Black;
            this.btn_ResetCategory.Location = new System.Drawing.Point(150, 239);
            this.btn_ResetCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ResetCategory.Name = "btn_ResetCategory";
            this.btn_ResetCategory.Size = new System.Drawing.Size(88, 36);
            this.btn_ResetCategory.TabIndex = 38;
            this.btn_ResetCategory.Text = "Reset";
            this.btn_ResetCategory.UseVisualStyleBackColor = false;
            this.btn_ResetCategory.Click += new System.EventHandler(this.btn_ResetCategory_Click);
            // 
            // tb_categoryDescription
            // 
            this.tb_categoryDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_categoryDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_categoryDescription.Location = new System.Drawing.Point(134, 92);
            this.tb_categoryDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tb_categoryDescription.Multiline = true;
            this.tb_categoryDescription.Name = "tb_categoryDescription";
            this.tb_categoryDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_categoryDescription.Size = new System.Drawing.Size(218, 43);
            this.tb_categoryDescription.TabIndex = 32;
            // 
            // tb_categoryName
            // 
            this.tb_categoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_categoryName.Location = new System.Drawing.Point(134, 31);
            this.tb_categoryName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_categoryName.Name = "tb_categoryName";
            this.tb_categoryName.Size = new System.Drawing.Size(200, 22);
            this.tb_categoryName.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Description :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_categoryName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_categoryDescription);
            this.groupBox1.Location = new System.Drawing.Point(22, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 171);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // Form_AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 298);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_saveCategory);
            this.Controls.Add(this.btn_ResetCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Category";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_saveCategory;
        private System.Windows.Forms.Button btn_ResetCategory;
        public System.Windows.Forms.TextBox tb_categoryDescription;
        public System.Windows.Forms.TextBox tb_categoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}