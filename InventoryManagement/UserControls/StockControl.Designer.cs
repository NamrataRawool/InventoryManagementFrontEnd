namespace InventoryManagement.UserControls
{
    partial class StockControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockControl));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.stockDataView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_addStock = new System.Windows.Forms.Button();
            this.btn_editStock = new System.Windows.Forms.Button();
            this.tb_searchCategory = new System.Windows.Forms.TextBox();
            this.btn_searchStock = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.023758F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.9928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.909789F));
            this.tableLayoutPanel1.Controls.Add(this.stockDataView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1042, 563);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // stockDataView
            // 
            this.stockDataView.AllowUserToAddRows = false;
            this.stockDataView.AllowUserToDeleteRows = false;
            this.stockDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.stockDataView.BackgroundColor = System.Drawing.Color.White;
            this.stockDataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stockDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.stockDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(116)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(175)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stockDataView.DefaultCellStyle = dataGridViewCellStyle2;
            this.stockDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockDataView.GridColor = System.Drawing.Color.Black;
            this.stockDataView.Location = new System.Drawing.Point(34, 87);
            this.stockDataView.MultiSelect = false;
            this.stockDataView.Name = "stockDataView";
            this.stockDataView.ReadOnly = true;
            this.stockDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.stockDataView.RowHeadersVisible = false;
            this.stockDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.stockDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockDataView.Size = new System.Drawing.Size(932, 388);
            this.stockDataView.TabIndex = 2;
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
            this.tableLayoutPanel2.Controls.Add(this.btn_addStock, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_editStock, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_searchCategory, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_searchStock, 4, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(34, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.58974F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.05128F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(932, 78);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btn_addStock
            // 
            this.btn_addStock.BackColor = System.Drawing.Color.White;
            this.btn_addStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_addStock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.btn_addStock.FlatAppearance.BorderSize = 2;
            this.btn_addStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addStock.Image = ((System.Drawing.Image)(resources.GetObject("btn_addStock.Image")));
            this.btn_addStock.Location = new System.Drawing.Point(3, 22);
            this.btn_addStock.Name = "btn_addStock";
            this.btn_addStock.Size = new System.Drawing.Size(76, 27);
            this.btn_addStock.TabIndex = 1;
            this.btn_addStock.UseVisualStyleBackColor = false;
            // 
            // btn_editStock
            // 
            this.btn_editStock.BackColor = System.Drawing.Color.White;
            this.btn_editStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_editStock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.btn_editStock.FlatAppearance.BorderSize = 2;
            this.btn_editStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editStock.Image = ((System.Drawing.Image)(resources.GetObject("btn_editStock.Image")));
            this.btn_editStock.Location = new System.Drawing.Point(85, 22);
            this.btn_editStock.Name = "btn_editStock";
            this.btn_editStock.Size = new System.Drawing.Size(75, 27);
            this.btn_editStock.TabIndex = 2;
            this.btn_editStock.UseVisualStyleBackColor = false;
            // 
            // tb_searchCategory
            // 
            this.tb_searchCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_searchCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchCategory.Location = new System.Drawing.Point(371, 22);
            this.tb_searchCategory.Name = "tb_searchCategory";
            this.tb_searchCategory.Size = new System.Drawing.Size(271, 28);
            this.tb_searchCategory.TabIndex = 3;
            // 
            // btn_searchStock
            // 
            this.btn_searchStock.BackColor = System.Drawing.Color.White;
            this.btn_searchStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_searchStock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.btn_searchStock.FlatAppearance.BorderSize = 2;
            this.btn_searchStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchStock.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchStock.Location = new System.Drawing.Point(648, 22);
            this.btn_searchStock.MaximumSize = new System.Drawing.Size(0, 28);
            this.btn_searchStock.MinimumSize = new System.Drawing.Size(0, 28);
            this.btn_searchStock.Name = "btn_searchStock";
            this.btn_searchStock.Size = new System.Drawing.Size(72, 28);
            this.btn_searchStock.TabIndex = 4;
            this.btn_searchStock.Text = "Search";
            this.btn_searchStock.UseVisualStyleBackColor = false;
            // 
            // StockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StockControl";
            this.Size = new System.Drawing.Size(1042, 563);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stockDataView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView stockDataView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_addStock;
        private System.Windows.Forms.Button btn_editStock;
        private System.Windows.Forms.TextBox tb_searchCategory;
        private System.Windows.Forms.Button btn_searchStock;
    }
}
