namespace InventoryManagement.UI.Misc.InputBox
{
    partial class InputBox
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.tf_Input = new System.Windows.Forms.TextBox();
            this.Lbl_Hint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(269, 51);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // tf_Input
            // 
            this.tf_Input.Location = new System.Drawing.Point(48, 53);
            this.tf_Input.Name = "tf_Input";
            this.tf_Input.Size = new System.Drawing.Size(215, 20);
            this.tf_Input.TabIndex = 1;
            // 
            // Lbl_Hint
            // 
            this.Lbl_Hint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_Hint.Location = new System.Drawing.Point(44, 21);
            this.Lbl_Hint.Name = "Lbl_Hint";
            this.Lbl_Hint.Size = new System.Drawing.Size(100, 23);
            this.Lbl_Hint.TabIndex = 2;
            this.Lbl_Hint.Text = "Hint :";
            this.Lbl_Hint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 103);
            this.Controls.Add(this.Lbl_Hint);
            this.Controls.Add(this.tf_Input);
            this.Controls.Add(this.btn_OK);
            this.Name = "InputBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox tf_Input;
        private System.Windows.Forms.Label Lbl_Hint;
    }
}