namespace InventoryManagement.UI.UserControls
{
    partial class CustomerControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerControl));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customerDataView = new System.Windows.Forms.DataGridView();
            this.CustomerTable_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerTable_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerTable_EmailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerTable_MobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerTable_PendingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_addCustomer = new System.Windows.Forms.Button();
            this.btn_editCustomer = new System.Windows.Forms.Button();
            this.tb_searchCustomer = new System.Windows.Forms.TextBox();
            this.btn_searchCustomer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.023758F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.9928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.909789F));
            this.tableLayoutPanel1.Controls.Add(this.customerDataView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1114, 704);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // customerDataView
            // 
            this.customerDataView.AllowUserToAddRows = false;
            this.customerDataView.AllowUserToDeleteRows = false;
            this.customerDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.customerDataView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.customerDataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.customerDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerTable_ID,
            this.CustomerTable_Name,
            this.CustomerTable_EmailId,
            this.CustomerTable_MobileNumber,
            this.CustomerTable_PendingAmount});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerDataView.DefaultCellStyle = dataGridViewCellStyle11;
            this.customerDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerDataView.GridColor = System.Drawing.Color.Black;
            this.customerDataView.Location = new System.Drawing.Point(36, 108);
            this.customerDataView.MultiSelect = false;
            this.customerDataView.Name = "customerDataView";
            this.customerDataView.ReadOnly = true;
            this.customerDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.customerDataView.RowHeadersVisible = false;
            this.customerDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.customerDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataView.Size = new System.Drawing.Size(997, 486);
            this.customerDataView.TabIndex = 2;
            // 
            // CustomerTable_ID
            // 
            this.CustomerTable_ID.HeaderText = "Customer ID";
            this.CustomerTable_ID.Name = "CustomerTable_ID";
            this.CustomerTable_ID.ReadOnly = true;
            // 
            // CustomerTable_Name
            // 
            this.CustomerTable_Name.HeaderText = "Name";
            this.CustomerTable_Name.Name = "CustomerTable_Name";
            this.CustomerTable_Name.ReadOnly = true;
            // 
            // CustomerTable_EmailId
            // 
            this.CustomerTable_EmailId.HeaderText = "Email Address";
            this.CustomerTable_EmailId.Name = "CustomerTable_EmailId";
            this.CustomerTable_EmailId.ReadOnly = true;
            // 
            // CustomerTable_MobileNumber
            // 
            this.CustomerTable_MobileNumber.HeaderText = "Mobile Number";
            this.CustomerTable_MobileNumber.Name = "CustomerTable_MobileNumber";
            this.CustomerTable_MobileNumber.ReadOnly = true;
            // 
            // CustomerTable_PendingAmount
            // 
            this.CustomerTable_PendingAmount.HeaderText = "Pending Amount";
            this.CustomerTable_PendingAmount.Name = "CustomerTable_PendingAmount";
            this.CustomerTable_PendingAmount.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.90558F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.798284F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.2103F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.82648F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.7653F));
            this.tableLayoutPanel2.Controls.Add(this.btn_addCustomer, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_editCustomer, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_searchCustomer, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_searchCustomer, 4, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(36, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.41414F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.34343F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(997, 99);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_addCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_addCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_addCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btn_addCustomer.Image")));
            this.btn_addCustomer.Location = new System.Drawing.Point(3, 27);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(82, 34);
            this.btn_addCustomer.TabIndex = 1;
            this.btn_addCustomer.UseVisualStyleBackColor = false;
            this.btn_addCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // btn_editCustomer
            // 
            this.btn_editCustomer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_editCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_editCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_editCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btn_editCustomer.Image")));
            this.btn_editCustomer.Location = new System.Drawing.Point(91, 27);
            this.btn_editCustomer.Name = "btn_editCustomer";
            this.btn_editCustomer.Size = new System.Drawing.Size(81, 34);
            this.btn_editCustomer.TabIndex = 2;
            this.btn_editCustomer.UseVisualStyleBackColor = false;
            this.btn_editCustomer.Click += new System.EventHandler(this.btn_editCustomer_Click);
            // 
            // tb_searchCustomer
            // 
            this.tb_searchCustomer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_searchCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_searchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.tb_searchCustomer.Location = new System.Drawing.Point(398, 27);
            this.tb_searchCustomer.Name = "tb_searchCustomer";
            this.tb_searchCustomer.Size = new System.Drawing.Size(291, 28);
            this.tb_searchCustomer.TabIndex = 3;
            this.tb_searchCustomer.TextChanged += new System.EventHandler(this.tb_searchCustomer_TextChanged);
            this.tb_searchCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_searchCustomer_KeyDown);
            // 
            // btn_searchCustomer
            // 
            this.btn_searchCustomer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_searchCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_searchCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_searchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchCustomer.Location = new System.Drawing.Point(695, 27);
            this.btn_searchCustomer.MaximumSize = new System.Drawing.Size(0, 26);
            this.btn_searchCustomer.MinimumSize = new System.Drawing.Size(0, 26);
            this.btn_searchCustomer.Name = "btn_searchCustomer";
            this.btn_searchCustomer.Size = new System.Drawing.Size(81, 26);
            this.btn_searchCustomer.TabIndex = 4;
            this.btn_searchCustomer.Text = "Search";
            this.btn_searchCustomer.UseVisualStyleBackColor = false;
            this.btn_searchCustomer.Click += new System.EventHandler(this.btn_searchCustomer_Click);
            // 
            // CustomerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CustomerControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1114, 704);
            this.Load += new System.EventHandler(this.CustomerControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.DataGridView customerDataView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_addCustomer;
        private System.Windows.Forms.Button btn_editCustomer;
        private System.Windows.Forms.Button btn_searchCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerTable_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerTable_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerTable_EmailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerTable_MobileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerTable_PendingAmount;
        public System.Windows.Forms.TextBox tb_searchCustomer;
    }
}
