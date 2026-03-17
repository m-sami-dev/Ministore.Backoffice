namespace App.WindowsaApp.Views
{
    partial class Productsview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productsview));
            tblproducts = new TableLayoutPanel();
            pnlToolbar = new Panel();
            tsProducts = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbView = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbRefresh = new ToolStripButton();
            pnlFilters = new Panel();
            tblFilters = new TableLayoutPanel();
            lblSearch = new Label();
            lblCategory = new Label();
            lblStockStatus = new Label();
            txtSearch = new TextBox();
            cmbCategory = new ComboBox();
            cmbStockStatus = new ComboBox();
            pnlGrid = new Panel();
            dgvProducts = new DataGridView();
            Colid = new DataGridViewTextBoxColumn();
            Colname = new DataGridViewTextBoxColumn();
            ColCategory = new DataGridViewTextBoxColumn();
            ColPrice = new DataGridViewTextBoxColumn();
            ColStock = new DataGridViewTextBoxColumn();
            ColStatus = new DataGridViewTextBoxColumn();
            tblproducts.SuspendLayout();
            pnlToolbar.SuspendLayout();
            tsProducts.SuspendLayout();
            pnlFilters.SuspendLayout();
            tblFilters.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // tblproducts
            // 
            tblproducts.ColumnCount = 1;
            tblproducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblproducts.Controls.Add(pnlToolbar, 0, 0);
            tblproducts.Controls.Add(pnlFilters, 0, 1);
            tblproducts.Controls.Add(pnlGrid, 0, 2);
            tblproducts.Dock = DockStyle.Fill;
            tblproducts.Location = new Point(0, 0);
            tblproducts.Margin = new Padding(4, 3, 4, 3);
            tblproducts.Name = "tblproducts";
            tblproducts.RowCount = 3;
            tblproducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tblproducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            tblproducts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblproducts.Size = new Size(973, 632);
            tblproducts.TabIndex = 0;
            tblproducts.Paint += tblproducts_Paint;
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(tsProducts);
            pnlToolbar.Dock = DockStyle.Fill;
            pnlToolbar.Location = new Point(4, 3);
            pnlToolbar.Margin = new Padding(4, 3, 4, 3);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(965, 59);
            pnlToolbar.TabIndex = 0;
            // 
            // tsProducts
            // 
            tsProducts.Dock = DockStyle.Fill;
            tsProducts.GripStyle = ToolStripGripStyle.Hidden;
            tsProducts.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbView, tsbDelete, toolStripSeparator1, tsbRefresh });
            tsProducts.Location = new Point(0, 0);
            tsProducts.Name = "tsProducts";
            tsProducts.Size = new Size(965, 59);
            tsProducts.TabIndex = 0;
            tsProducts.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            tsbAdd.Image = (Image)resources.GetObject("tsbAdd.Image");
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(49, 56);
            tsbAdd.Text = "Add";
            tsbAdd.Click += tsbAdd_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.Image = (Image)resources.GetObject("tsbEdit.Image");
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(47, 56);
            tsbEdit.Text = "Edit";
            tsbEdit.Click += tsbEdit_Click;
            // 
            // tsbView
            // 
            tsbView.Image = (Image)resources.GetObject("tsbView.Image");
            tsbView.ImageTransparentColor = Color.Magenta;
            tsbView.Name = "tsbView";
            tsbView.Size = new Size(52, 56);
            tsbView.Text = "View";
            tsbView.Click += tsbView_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.Image = (Image)resources.GetObject("tsbDelete.Image");
            tsbDelete.ImageTransparentColor = Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(60, 56);
            tsbDelete.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 59);
            // 
            // tsbRefresh
            // 
            tsbRefresh.Image = (Image)resources.GetObject("tsbRefresh.Image");
            tsbRefresh.ImageTransparentColor = Color.Magenta;
            tsbRefresh.Name = "tsbRefresh";
            tsbRefresh.Size = new Size(66, 56);
            tsbRefresh.Text = "Refresh";
            // 
            // pnlFilters
            // 
            pnlFilters.BackColor = Color.White;
            pnlFilters.Controls.Add(tblFilters);
            pnlFilters.Dock = DockStyle.Fill;
            pnlFilters.Location = new Point(4, 68);
            pnlFilters.Margin = new Padding(4, 3, 4, 3);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Padding = new Padding(14, 12, 14, 12);
            pnlFilters.Size = new Size(965, 91);
            pnlFilters.TabIndex = 1;
            // 
            // tblFilters
            // 
            tblFilters.AutoSize = true;
            tblFilters.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblFilters.ColumnCount = 3;
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.36364F));
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.36364F));
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.27273F));
            tblFilters.Controls.Add(lblSearch, 0, 0);
            tblFilters.Controls.Add(lblCategory, 1, 0);
            tblFilters.Controls.Add(lblStockStatus, 2, 0);
            tblFilters.Controls.Add(txtSearch, 0, 1);
            tblFilters.Controls.Add(cmbCategory, 1, 1);
            tblFilters.Controls.Add(cmbStockStatus, 2, 1);
            tblFilters.Dock = DockStyle.Fill;
            tblFilters.Location = new Point(14, 12);
            tblFilters.Margin = new Padding(4, 3, 4, 3);
            tblFilters.Name = "tblFilters";
            tblFilters.RowCount = 2;
            tblFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFilters.Size = new Size(937, 67);
            tblFilters.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.Location = new Point(4, 0);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(332, 33);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Location = new Point(344, 0);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(332, 33);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category";
            // 
            // lblStockStatus
            // 
            lblStockStatus.AutoSize = true;
            lblStockStatus.Dock = DockStyle.Fill;
            lblStockStatus.Location = new Point(684, 0);
            lblStockStatus.Margin = new Padding(4, 0, 4, 0);
            lblStockStatus.Name = "lblStockStatus";
            lblStockStatus.Size = new Size(249, 33);
            lblStockStatus.TabIndex = 2;
            lblStockStatus.Text = "StockStatus";
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(4, 36);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(332, 23);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbCategory
            // 
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(344, 36);
            cmbCategory.Margin = new Padding(4, 3, 4, 3);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(332, 23);
            cmbCategory.TabIndex = 4;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // cmbStockStatus
            // 
            cmbStockStatus.Dock = DockStyle.Fill;
            cmbStockStatus.FormattingEnabled = true;
            cmbStockStatus.Location = new Point(684, 36);
            cmbStockStatus.Margin = new Padding(4, 3, 4, 3);
            cmbStockStatus.Name = "cmbStockStatus";
            cmbStockStatus.Size = new Size(249, 23);
            cmbStockStatus.TabIndex = 5;
            cmbStockStatus.SelectedIndexChanged += cmbStockStatus_SelectedIndexChanged;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.White;
            pnlGrid.Controls.Add(dgvProducts);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(4, 165);
            pnlGrid.Margin = new Padding(4, 3, 4, 3);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(14);
            pnlGrid.Size = new Size(965, 464);
            pnlGrid.TabIndex = 2;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { Colid, Colname, ColCategory, ColPrice, ColStock, ColStatus });
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.GridColor = Color.White;
            dgvProducts.Location = new Point(14, 14);
            dgvProducts.Margin = new Padding(4, 3, 4, 3);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(937, 436);
            dgvProducts.TabIndex = 0;
            // 
            // Colid
            // 
            Colid.DataPropertyName = "ID";
            Colid.HeaderText = "ID";
            Colid.Name = "Colid";
            Colid.ReadOnly = true;
            // 
            // Colname
            // 
            Colname.DataPropertyName = "Name";
            Colname.HeaderText = "Name";
            Colname.Name = "Colname";
            Colname.ReadOnly = true;
            // 
            // ColCategory
            // 
            ColCategory.DataPropertyName = "Category";
            ColCategory.HeaderText = "Category";
            ColCategory.Name = "ColCategory";
            ColCategory.ReadOnly = true;
            // 
            // ColPrice
            // 
            ColPrice.DataPropertyName = "Price";
            ColPrice.HeaderText = "Price";
            ColPrice.Name = "ColPrice";
            ColPrice.ReadOnly = true;
            // 
            // ColStock
            // 
            ColStock.DataPropertyName = "Stock";
            ColStock.HeaderText = "Stock";
            ColStock.Name = "ColStock";
            ColStock.ReadOnly = true;
            // 
            // ColStatus
            // 
            ColStatus.DataPropertyName = "Status";
            ColStatus.HeaderText = "Status";
            ColStatus.Name = "ColStatus";
            ColStatus.ReadOnly = true;
            // 
            // Productsview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblproducts);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Productsview";
            Size = new Size(973, 632);
            Load += Productsview_Load;
            tblproducts.ResumeLayout(false);
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            tsProducts.ResumeLayout(false);
            tsProducts.PerformLayout();
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            tblFilters.ResumeLayout(false);
            tblFilters.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblproducts;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.ToolStrip tsProducts;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbView;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.TableLayoutPanel tblFilters;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblStockStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbStockStatus;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvProducts;
        private DataGridViewTextBoxColumn Colid;
        private DataGridViewTextBoxColumn Colname;
        private DataGridViewTextBoxColumn ColCategory;
        private DataGridViewTextBoxColumn ColPrice;
        private DataGridViewTextBoxColumn ColStock;
        private DataGridViewTextBoxColumn ColStatus;
    }
}
