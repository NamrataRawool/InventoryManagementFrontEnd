namespace InventoryManagement.UI.Customer
{
    partial class Form_AddCustomer
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
            this.btn_saveCustomer = new System.Windows.Forms.Button();
            this.btn_ResetCustomer = new System.Windows.Forms.Button();
            this.tb_CustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_customerMobile = new System.Windows.Forms.TextBox();
            this.tb_customerEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_saveCustomer
            // 
            this.btn_saveCustomer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_saveCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_saveCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveCustomer.ForeColor = System.Drawing.Color.Black;
            this.btn_saveCustomer.Location = new System.Drawing.Point(283, 285);
            this.btn_saveCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_saveCustomer.Name = "btn_saveCustomer";
            this.btn_saveCustomer.Size = new System.Drawing.Size(88, 36);
            this.btn_saveCustomer.TabIndex = 37;
            this.btn_saveCustomer.Text = "Save";
            this.btn_saveCustomer.UseVisualStyleBackColor = false;
            this.btn_saveCustomer.Click += new System.EventHandler(this.btn_saveCustomer_Click);
            // 
            // btn_ResetCustomer
            // 
            this.btn_ResetCustomer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ResetCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetCustomer.ForeColor = System.Drawing.Color.Black;
            this.btn_ResetCustomer.Location = new System.Drawing.Point(157, 285);
            this.btn_ResetCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ResetCustomer.Name = "btn_ResetCustomer";
            this.btn_ResetCustomer.Size = new System.Drawing.Size(88, 36);
            this.btn_ResetCustomer.TabIndex = 38;
            this.btn_ResetCustomer.Text = "Reset";
            this.btn_ResetCustomer.UseVisualStyleBackColor = false;
            this.btn_ResetCustomer.Click += new System.EventHandler(this.btn_ResetCustomer_Click);
            // 
            // tb_CustomerName
            // 
            this.tb_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CustomerName.Location = new System.Drawing.Point(157, 54);
            this.tb_CustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_CustomerName.Name = "tb_CustomerName";
            this.tb_CustomerName.Size = new System.Drawing.Size(200, 22);
            this.tb_CustomerName.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Email ID :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mobile Number :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_customerMobile
            // 
            this.tb_customerMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customerMobile.Location = new System.Drawing.Point(157, 116);
            this.tb_customerMobile.Margin = new System.Windows.Forms.Padding(2);
            this.tb_customerMobile.Name = "tb_customerMobile";
            this.tb_customerMobile.Size = new System.Drawing.Size(200, 22);
            this.tb_customerMobile.TabIndex = 42;
            // 
            // tb_customerEmail
            // 
            this.tb_customerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customerEmail.Location = new System.Drawing.Point(157, 177);
            this.tb_customerEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tb_customerEmail.Name = "tb_customerEmail";
            this.tb_customerEmail.Size = new System.Drawing.Size(200, 22);
            this.tb_customerEmail.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_CustomerName);
            this.groupBox1.Controls.Add(this.tb_customerEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_customerMobile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 230);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // Form_AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(399, 347);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_saveCustomer);
            this.Controls.Add(this.btn_ResetCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Customer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_saveCustomer;
        private System.Windows.Forms.Button btn_ResetCustomer;
        public System.Windows.Forms.TextBox tb_CustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb_customerMobile;
        public System.Windows.Forms.TextBox tb_customerEmail;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}