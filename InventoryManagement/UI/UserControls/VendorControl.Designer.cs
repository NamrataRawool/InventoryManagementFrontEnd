namespace InventoryManagement.UI.UserControls
{
    partial class VendorControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_addVendor = new System.Windows.Forms.Button();
            this.btn_editVendor = new System.Windows.Forms.Button();
            this.tb_searchVendors = new System.Windows.Forms.TextBox();
            this.btn_searchVendor = new System.Windows.Forms.Button();
            this.VendorsDataView = new System.Windows.Forms.DataGridView();
            this.VendorTable_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendorTable_CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendorTable_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendorTable_MobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendorTable_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VendorsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.023758F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.9928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.909789F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.VendorsDataView, 1, 1);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.90558F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.798284F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.2103F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.476395F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.3176F));
            this.tableLayoutPanel2.Controls.Add(this.btn_addVendor, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_editVendor, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_searchVendors, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_searchVendor, 4, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(36, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.31313F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(997, 99);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btn_addVendor
            // 
            this.btn_addVendor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_addVendor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_addVendor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_addVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addVendor.Image = ((System.Drawing.Image)(resources.GetObject("btn_addVendor.Image")));
            this.btn_addVendor.Location = new System.Drawing.Point(3, 27);
            this.btn_addVendor.Name = "btn_addVendor";
            this.btn_addVendor.Size = new System.Drawing.Size(82, 37);
            this.btn_addVendor.TabIndex = 1;
            this.btn_addVendor.UseVisualStyleBackColor = false;
            this.btn_addVendor.Click += new System.EventHandler(this.btn_addVendor_Click);
            // 
            // btn_editVendor
            // 
            this.btn_editVendor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_editVendor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_editVendor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_editVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editVendor.Image = ((System.Drawing.Image)(resources.GetObject("btn_editVendor.Image")));
            this.btn_editVendor.Location = new System.Drawing.Point(91, 27);
            this.btn_editVendor.Name = "btn_editVendor";
            this.btn_editVendor.Size = new System.Drawing.Size(81, 37);
            this.btn_editVendor.TabIndex = 2;
            this.btn_editVendor.UseVisualStyleBackColor = false;
            this.btn_editVendor.Click += new System.EventHandler(this.btn_editVendor_Click);
            // 
            // tb_searchVendors
            // 
            this.tb_searchVendors.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_searchVendors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_searchVendors.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.tb_searchVendors.Location = new System.Drawing.Point(397, 27);
            this.tb_searchVendors.Name = "tb_searchVendors";
            this.tb_searchVendors.Size = new System.Drawing.Size(290, 28);
            this.tb_searchVendors.TabIndex = 3;
            this.tb_searchVendors.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_searchVendors_KeyDown);
            // 
            // btn_searchVendor
            // 
            this.btn_searchVendor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_searchVendor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_searchVendor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_searchVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchVendor.Location = new System.Drawing.Point(693, 27);
            this.btn_searchVendor.MaximumSize = new System.Drawing.Size(0, 28);
            this.btn_searchVendor.MinimumSize = new System.Drawing.Size(0, 28);
            this.btn_searchVendor.Name = "btn_searchVendor";
            this.btn_searchVendor.Size = new System.Drawing.Size(77, 28);
            this.btn_searchVendor.TabIndex = 4;
            this.btn_searchVendor.Text = "Search";
            this.btn_searchVendor.UseVisualStyleBackColor = false;
            this.btn_searchVendor.Click += new System.EventHandler(this.btn_searchVendor_Click);
            // 
            // VendorsDataView
            // 
            this.VendorsDataView.AllowUserToAddRows = false;
            this.VendorsDataView.AllowUserToOrderColumns = true;
            this.VendorsDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VendorsDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.VendorsDataView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.VendorsDataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VendorsDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.VendorsDataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VendorsDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.VendorsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VendorsDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VendorTable_Id,
            this.VendorTable_CompanyName,
            this.VendorTable_Email,
            this.VendorTable_MobileNumber,
            this.VendorTable_Address});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VendorsDataView.DefaultCellStyle = dataGridViewCellStyle2;
            this.VendorsDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VendorsDataView.GridColor = System.Drawing.Color.Black;
            this.VendorsDataView.Location = new System.Drawing.Point(36, 108);
            this.VendorsDataView.MultiSelect = false;
            this.VendorsDataView.Name = "VendorsDataView";
            this.VendorsDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VendorsDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.VendorsDataView.RowHeadersVisible = false;
            this.VendorsDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.VendorsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VendorsDataView.Size = new System.Drawing.Size(997, 486);
            this.VendorsDataView.TabIndex = 26;
            // 
            // VendorTable_Id
            // 
            this.VendorTable_Id.HeaderText = "Vendor Id";
            this.VendorTable_Id.Name = "VendorTable_Id";
            this.VendorTable_Id.ReadOnly = true;
            // 
            // VendorTable_CompanyName
            // 
            this.VendorTable_CompanyName.HeaderText = "Company Name";
            this.VendorTable_CompanyName.Name = "VendorTable_CompanyName";
            this.VendorTable_CompanyName.ReadOnly = true;
            // 
            // VendorTable_Email
            // 
            this.VendorTable_Email.HeaderText = "Email";
            this.VendorTable_Email.Name = "VendorTable_Email";
            this.VendorTable_Email.ReadOnly = true;
            // 
            // VendorTable_MobileNumber
            // 
            this.VendorTable_MobileNumber.HeaderText = "Mobile Number";
            this.VendorTable_MobileNumber.Name = "VendorTable_MobileNumber";
            this.VendorTable_MobileNumber.ReadOnly = true;
            // 
            // VendorTable_Address
            // 
            this.VendorTable_Address.HeaderText = "Address";
            this.VendorTable_Address.Name = "VendorTable_Address";
            // 
            // VendorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VendorControl";
            this.Size = new System.Drawing.Size(1114, 704);
            this.Load += new System.EventHandler(this.VendorControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VendorsDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_addVendor;
        private System.Windows.Forms.Button btn_editVendor;
        public System.Windows.Forms.TextBox tb_searchVendors;
        private System.Windows.Forms.Button btn_searchVendor;
        public System.Windows.Forms.DataGridView VendorsDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendorTable_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendorTable_CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendorTable_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendorTable_MobileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendorTable_Address;
    }
}
