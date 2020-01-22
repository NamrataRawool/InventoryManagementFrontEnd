namespace InventoryManagement.UI.UserControls
{
    partial class CategoryControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryControl));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.categoryDataView = new System.Windows.Forms.DataGridView();
            this.TableColumn_Category_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableColumn_Category_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableColumn_Category_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_addCategory = new System.Windows.Forms.Button();
            this.btn_editCategory = new System.Windows.Forms.Button();
            this.tb_searchCategory = new System.Windows.Forms.TextBox();
            this.btn_searchCategory = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataView)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.categoryDataView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1114, 704);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // categoryDataView
            // 
            this.categoryDataView.AllowUserToAddRows = false;
            this.categoryDataView.AllowUserToDeleteRows = false;
            this.categoryDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.categoryDataView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.categoryDataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoryDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.categoryDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableColumn_Category_ID,
            this.TableColumn_Category_Name,
            this.TableColumn_Category_Description});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoryDataView.DefaultCellStyle = dataGridViewCellStyle5;
            this.categoryDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryDataView.GridColor = System.Drawing.Color.Black;
            this.categoryDataView.Location = new System.Drawing.Point(36, 108);
            this.categoryDataView.MultiSelect = false;
            this.categoryDataView.Name = "categoryDataView";
            this.categoryDataView.ReadOnly = true;
            this.categoryDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.categoryDataView.RowHeadersVisible = false;
            this.categoryDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.categoryDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryDataView.Size = new System.Drawing.Size(997, 486);
            this.categoryDataView.TabIndex = 2;
            this.categoryDataView.DoubleClick += new System.EventHandler(this.categoryDataView_DoubleClick);
            // 
            // TableColumn_Category_ID
            // 
            this.TableColumn_Category_ID.HeaderText = "ID";
            this.TableColumn_Category_ID.Name = "TableColumn_Category_ID";
            this.TableColumn_Category_ID.ReadOnly = true;
            // 
            // TableColumn_Category_Name
            // 
            this.TableColumn_Category_Name.HeaderText = "Name";
            this.TableColumn_Category_Name.Name = "TableColumn_Category_Name";
            this.TableColumn_Category_Name.ReadOnly = true;
            // 
            // TableColumn_Category_Description
            // 
            this.TableColumn_Category_Description.HeaderText = "Description";
            this.TableColumn_Category_Description.Name = "TableColumn_Category_Description";
            this.TableColumn_Category_Description.ReadOnly = true;
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
            this.tableLayoutPanel2.Controls.Add(this.btn_addCategory, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_editCategory, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_searchCategory, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_searchCategory, 4, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(36, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.58974F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.05128F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(997, 99);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_addCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_addCategory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_addCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCategory.Image = ((System.Drawing.Image)(resources.GetObject("btn_addCategory.Image")));
            this.btn_addCategory.Location = new System.Drawing.Point(3, 27);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(82, 36);
            this.btn_addCategory.TabIndex = 1;
            this.btn_addCategory.UseVisualStyleBackColor = false;
            this.btn_addCategory.Click += new System.EventHandler(this.btn_addCategory_Click);
            // 
            // btn_editCategory
            // 
            this.btn_editCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_editCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_editCategory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_editCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editCategory.Image = ((System.Drawing.Image)(resources.GetObject("btn_editCategory.Image")));
            this.btn_editCategory.Location = new System.Drawing.Point(91, 27);
            this.btn_editCategory.Name = "btn_editCategory";
            this.btn_editCategory.Size = new System.Drawing.Size(81, 36);
            this.btn_editCategory.TabIndex = 2;
            this.btn_editCategory.UseVisualStyleBackColor = false;
            this.btn_editCategory.Click += new System.EventHandler(this.btn_editCategory_Click);
            // 
            // tb_searchCategory
            // 
            this.tb_searchCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_searchCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_searchCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchCategory.Location = new System.Drawing.Point(397, 27);
            this.tb_searchCategory.Name = "tb_searchCategory";
            this.tb_searchCategory.Size = new System.Drawing.Size(290, 28);
            this.tb_searchCategory.TabIndex = 3;
            // 
            // btn_searchCategory
            // 
            this.btn_searchCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_searchCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_searchCategory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_searchCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchCategory.Location = new System.Drawing.Point(693, 27);
            this.btn_searchCategory.MaximumSize = new System.Drawing.Size(0, 28);
            this.btn_searchCategory.MinimumSize = new System.Drawing.Size(0, 28);
            this.btn_searchCategory.Name = "btn_searchCategory";
            this.btn_searchCategory.Size = new System.Drawing.Size(77, 28);
            this.btn_searchCategory.TabIndex = 4;
            this.btn_searchCategory.Text = "Search";
            this.btn_searchCategory.UseVisualStyleBackColor = false;
            // 
            // CategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CategoryControl";
            this.Size = new System.Drawing.Size(1114, 704);
            this.Load += new System.EventHandler(this.CategoryControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.DataGridView categoryDataView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_addCategory;
        private System.Windows.Forms.Button btn_editCategory;
        public System.Windows.Forms.TextBox tb_searchCategory;
        private System.Windows.Forms.Button btn_searchCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableColumn_Category_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableColumn_Category_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableColumn_Category_Description;
    }
}
