namespace InventoryManagement.UI.Category
{
    partial class Form_EditCategory
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
            this.btn_UpdateCategory = new System.Windows.Forms.Button();
            this.tb_categoryDescription = new System.Windows.Forms.TextBox();
            this.tb_categoryName = new System.Windows.Forms.TextBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(129, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 23);
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
            this.btn_cancelCategory.Location = new System.Drawing.Point(116, 234);
            this.btn_cancelCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelCategory.Name = "btn_cancelCategory";
            this.btn_cancelCategory.Size = new System.Drawing.Size(88, 36);
            this.btn_cancelCategory.TabIndex = 48;
            this.btn_cancelCategory.Text = "Cancel";
            this.btn_cancelCategory.UseVisualStyleBackColor = false;
            this.btn_cancelCategory.Click += new System.EventHandler(this.btn_cancelCategory_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 43);
            this.panel1.TabIndex = 47;
            // 
            // btn_UpdateCategory
            // 
            this.btn_UpdateCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btn_UpdateCategory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_UpdateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateCategory.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateCategory.Location = new System.Drawing.Point(223, 234);
            this.btn_UpdateCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btn_UpdateCategory.Name = "btn_UpdateCategory";
            this.btn_UpdateCategory.Size = new System.Drawing.Size(88, 36);
            this.btn_UpdateCategory.TabIndex = 45;
            this.btn_UpdateCategory.Text = "Update";
            this.btn_UpdateCategory.UseVisualStyleBackColor = false;
            this.btn_UpdateCategory.Click += new System.EventHandler(this.btn_UpdateCategory_Click);
            // 
            // tb_categoryDescription
            // 
            this.tb_categoryDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_categoryDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_categoryDescription.Location = new System.Drawing.Point(181, 140);
            this.tb_categoryDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tb_categoryDescription.Multiline = true;
            this.tb_categoryDescription.Name = "tb_categoryDescription";
            this.tb_categoryDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_categoryDescription.Size = new System.Drawing.Size(218, 65);
            this.tb_categoryDescription.TabIndex = 44;
            // 
            // tb_categoryName
            // 
            this.tb_categoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_categoryName.Location = new System.Drawing.Point(181, 99);
            this.tb_categoryName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_categoryName.Multiline = true;
            this.tb_categoryName.Name = "tb_categoryName";
            this.tb_categoryName.Size = new System.Drawing.Size(200, 20);
            this.tb_categoryName.TabIndex = 43;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(56, 155);
            this.lbl_Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(95, 18);
            this.lbl_Description.TabIndex = 42;
            this.lbl_Description.Text = "Description : ";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(91, 101);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(60, 18);
            this.lbl_Name.TabIndex = 41;
            this.lbl_Name.Text = "Name : ";
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(181, 62);
            this.tb_ID.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ID.Multiline = true;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(200, 20);
            this.tb_ID.TabIndex = 50;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(113, 62);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(34, 18);
            this.lbl_ID.TabIndex = 49;
            this.lbl_ID.Text = "ID : ";
            // 
            // Form_EditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 297);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btn_cancelCategory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_UpdateCategory);
            this.Controls.Add(this.tb_categoryDescription);
            this.Controls.Add(this.tb_categoryName);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_Name);
            this.Name = "Form_EditCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_EditCategory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_cancelCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_UpdateCategory;
        public System.Windows.Forms.TextBox tb_categoryDescription;
        public System.Windows.Forms.TextBox tb_categoryName;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_Name;
        public System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_ID;
    }
}