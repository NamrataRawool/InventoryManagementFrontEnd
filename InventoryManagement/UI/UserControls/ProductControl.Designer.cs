namespace InventoryManagement.UI.UserControls
{
    partial class ProductControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductControl));
            this.productDataView = new System.Windows.Forms.DataGridView();
            this.ProductTableColumn_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTableColumn_Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTableColumn_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTableColumn_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTableColumn_RetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTableColumn_WholesalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_searchProduct = new System.Windows.Forms.TextBox();
            this.btn_SearchProduct = new System.Windows.Forms.Button();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.btn_editProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productDataView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // productDataView
            // 
            this.productDataView.AllowUserToAddRows = false;
            this.productDataView.AllowUserToDeleteRows = false;
            this.productDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productDataView.BackgroundColor = System.Drawing.Color.White;
            this.productDataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.productDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductTableColumn_ID,
            this.ProductTableColumn_Barcode,
            this.ProductTableColumn_Name,
            this.ProductTableColumn_Category,
            this.ProductTableColumn_RetailPrice,
            this.ProductTableColumn_WholesalePrice});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(116)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(175)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productDataView.DefaultCellStyle = dataGridViewCellStyle5;
            this.productDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productDataView.GridColor = System.Drawing.Color.Black;
            this.productDataView.Location = new System.Drawing.Point(36, 108);
            this.productDataView.MultiSelect = false;
            this.productDataView.Name = "productDataView";
            this.productDataView.ReadOnly = true;
            this.productDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.productDataView.RowHeadersVisible = false;
            this.productDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.productDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataView.Size = new System.Drawing.Size(997, 486);
            this.productDataView.TabIndex = 2;
            // 
            // ProductTableColumn_ID
            // 
            this.ProductTableColumn_ID.HeaderText = "ID";
            this.ProductTableColumn_ID.Name = "ProductTableColumn_ID";
            this.ProductTableColumn_ID.ReadOnly = true;
            // 
            // ProductTableColumn_Barcode
            // 
            this.ProductTableColumn_Barcode.HeaderText = "Barcode";
            this.ProductTableColumn_Barcode.Name = "ProductTableColumn_Barcode";
            this.ProductTableColumn_Barcode.ReadOnly = true;
            // 
            // ProductTableColumn_Name
            // 
            this.ProductTableColumn_Name.HeaderText = "Name";
            this.ProductTableColumn_Name.Name = "ProductTableColumn_Name";
            this.ProductTableColumn_Name.ReadOnly = true;
            // 
            // ProductTableColumn_Category
            // 
            this.ProductTableColumn_Category.HeaderText = "Category";
            this.ProductTableColumn_Category.Name = "ProductTableColumn_Category";
            this.ProductTableColumn_Category.ReadOnly = true;
            // 
            // ProductTableColumn_RetailPrice
            // 
            this.ProductTableColumn_RetailPrice.HeaderText = "Retail Price";
            this.ProductTableColumn_RetailPrice.Name = "ProductTableColumn_RetailPrice";
            this.ProductTableColumn_RetailPrice.ReadOnly = true;
            // 
            // ProductTableColumn_WholesalePrice
            // 
            this.ProductTableColumn_WholesalePrice.HeaderText = "Wholesale price";
            this.ProductTableColumn_WholesalePrice.Name = "ProductTableColumn_WholesalePrice";
            this.ProductTableColumn_WholesalePrice.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.023758F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.9928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.909789F));
            this.tableLayoutPanel1.Controls.Add(this.productDataView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1114, 704);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.tableLayoutPanel2.Controls.Add(this.btn_addProduct, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_editProduct, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_searchProduct, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_SearchProduct, 4, 1);
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
            // tb_searchProduct
            // 
            this.tb_searchProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_searchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchProduct.Location = new System.Drawing.Point(397, 27);
            this.tb_searchProduct.Name = "tb_searchProduct";
            this.tb_searchProduct.Size = new System.Drawing.Size(290, 28);
            this.tb_searchProduct.TabIndex = 3;
            this.tb_searchProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_searchProduct_KeyDown);
            // 
            // btn_SearchProduct
            // 
            this.btn_SearchProduct.BackColor = System.Drawing.Color.White;
            this.btn_SearchProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SearchProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.btn_SearchProduct.FlatAppearance.BorderSize = 2;
            this.btn_SearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchProduct.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchProduct.Location = new System.Drawing.Point(693, 27);
            this.btn_SearchProduct.MaximumSize = new System.Drawing.Size(0, 28);
            this.btn_SearchProduct.MinimumSize = new System.Drawing.Size(0, 28);
            this.btn_SearchProduct.Name = "btn_SearchProduct";
            this.btn_SearchProduct.Size = new System.Drawing.Size(77, 28);
            this.btn_SearchProduct.TabIndex = 4;
            this.btn_SearchProduct.Text = "Search";
            this.btn_SearchProduct.UseVisualStyleBackColor = false;
            this.btn_SearchProduct.Click += new System.EventHandler(this.btn_SearchProduct_Click);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.BackColor = System.Drawing.Color.White;
            this.btn_addProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_addProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.btn_addProduct.FlatAppearance.BorderSize = 2;
            this.btn_addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addProduct.Image = ((System.Drawing.Image)(resources.GetObject("btn_addProduct.Image")));
            this.btn_addProduct.Location = new System.Drawing.Point(3, 27);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(82, 36);
            this.btn_addProduct.TabIndex = 1;
            this.btn_addProduct.UseVisualStyleBackColor = false;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // btn_editProduct
            // 
            this.btn_editProduct.BackColor = System.Drawing.Color.White;
            this.btn_editProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_editProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.btn_editProduct.FlatAppearance.BorderSize = 2;
            this.btn_editProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editProduct.Image = ((System.Drawing.Image)(resources.GetObject("btn_editProduct.Image")));
            this.btn_editProduct.Location = new System.Drawing.Point(91, 27);
            this.btn_editProduct.Name = "btn_editProduct";
            this.btn_editProduct.Size = new System.Drawing.Size(81, 36);
            this.btn_editProduct.TabIndex = 2;
            this.btn_editProduct.UseVisualStyleBackColor = false;
            this.btn_editProduct.Click += new System.EventHandler(this.btn_editProduct_Click);
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(1114, 704);
            this.Load += new System.EventHandler(this.ProductControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView productDataView;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Button btn_addProduct;
        public System.Windows.Forms.Button btn_editProduct;
        public System.Windows.Forms.TextBox tb_searchProduct;
        public System.Windows.Forms.Button btn_SearchProduct;
        public System.Windows.Forms.DataGridViewTextBoxColumn ProductTableColumn_ID;
        public System.Windows.Forms.DataGridViewTextBoxColumn ProductTableColumn_Barcode;
        public System.Windows.Forms.DataGridViewTextBoxColumn ProductTableColumn_Name;
        public System.Windows.Forms.DataGridViewTextBoxColumn ProductTableColumn_Category;
        public System.Windows.Forms.DataGridViewTextBoxColumn ProductTableColumn_RetailPrice;
        public System.Windows.Forms.DataGridViewTextBoxColumn ProductTableColumn_WholesalePrice;
    }
}
