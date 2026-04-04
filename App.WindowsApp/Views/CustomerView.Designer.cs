namespace App.WindowsApp.Views
{
    partial class CustomerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerView));
            tlpCustomerView = new TableLayoutPanel();
            tsCommands = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbView = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            tsSeparator = new ToolStripSeparator();
            tsbRefresh = new ToolStripButton();
            flpSearch = new FlowLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblCount = new Label();
            pnlCustomerData = new Panel();
            dgvCustomers = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colname = new DataGridViewTextBoxColumn();
            colphone = new DataGridViewTextBoxColumn();
            colemail = new DataGridViewTextBoxColumn();
            coladdress = new DataGridViewTextBoxColumn();
            tlpCustomerView.SuspendLayout();
            tsCommands.SuspendLayout();
            flpSearch.SuspendLayout();
            pnlCustomerData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // tlpCustomerView
            // 
            tlpCustomerView.ColumnCount = 1;
            tlpCustomerView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCustomerView.Controls.Add(tsCommands, 0, 0);
            tlpCustomerView.Controls.Add(flpSearch, 0, 1);
            tlpCustomerView.Controls.Add(pnlCustomerData, 0, 2);
            tlpCustomerView.Dock = DockStyle.Fill;
            tlpCustomerView.Font = new Font("Segoe UI", 9.75F);
            tlpCustomerView.Location = new Point(0, 0);
            tlpCustomerView.Name = "tlpCustomerView";
            tlpCustomerView.RowCount = 3;
            tlpCustomerView.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlpCustomerView.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tlpCustomerView.RowStyles.Add(new RowStyle(SizeType.Percent, 87F));
            tlpCustomerView.Size = new Size(850, 532);
            tlpCustomerView.TabIndex = 0;
            // 
            // tsCommands
            // 
            tsCommands.BackColor = Color.White;
            tsCommands.Dock = DockStyle.Fill;
            tsCommands.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbView, tsbDelete, tsSeparator, tsbRefresh });
            tsCommands.Location = new Point(0, 0);
            tsCommands.Name = "tsCommands";
            tsCommands.Size = new Size(850, 26);
            tsCommands.TabIndex = 0;
            tsCommands.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            tsbAdd.AutoSize = false;
            tsbAdd.Image = (Image)resources.GetObject("tsbAdd.Image");
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(47, 22);
            tsbAdd.Text = "Add";
            tsbAdd.Click += tsbAdd_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.Image = (Image)resources.GetObject("tsbEdit.Image");
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(47, 23);
            tsbEdit.Text = "Edit";
            tsbEdit.Click += tsbEdit_Click;
            // 
            // tsbView
            // 
            tsbView.Image = (Image)resources.GetObject("tsbView.Image");
            tsbView.ImageTransparentColor = Color.Magenta;
            tsbView.Name = "tsbView";
            tsbView.Size = new Size(52, 23);
            tsbView.Text = "View";
            tsbView.Click += tsbView_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.Image = (Image)resources.GetObject("tsbDelete.Image");
            tsbDelete.ImageTransparentColor = Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(60, 23);
            tsbDelete.Text = "Delete";
            tsbDelete.Click += tsbDelete_Click;
            // 
            // tsSeparator
            // 
            tsSeparator.Name = "tsSeparator";
            tsSeparator.Size = new Size(6, 26);
            // 
            // tsbRefresh
            // 
            tsbRefresh.Image = (Image)resources.GetObject("tsbRefresh.Image");
            tsbRefresh.ImageTransparentColor = Color.Magenta;
            tsbRefresh.Name = "tsbRefresh";
            tsbRefresh.Size = new Size(66, 23);
            tsbRefresh.Text = "Refresh";
            tsbRefresh.Click += tsbRefresh_Click;
            // 
            // flpSearch
            // 
            flpSearch.BackColor = Color.White;
            flpSearch.Controls.Add(lblSearch);
            flpSearch.Controls.Add(txtSearch);
            flpSearch.Controls.Add(lblCount);
            flpSearch.Dock = DockStyle.Fill;
            flpSearch.Location = new Point(3, 29);
            flpSearch.Name = "flpSearch";
            flpSearch.Size = new Size(844, 36);
            flpSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.75F);
            lblSearch.Location = new Point(3, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(47, 17);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(56, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(413, 25);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 9.75F);
            lblCount.Location = new Point(475, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(56, 17);
            lblCount.TabIndex = 5;
            lblCount.Text = "Count: 0";
            // 
            // pnlCustomerData
            // 
            pnlCustomerData.Controls.Add(dgvCustomers);
            pnlCustomerData.Dock = DockStyle.Fill;
            pnlCustomerData.Location = new Point(3, 71);
            pnlCustomerData.Name = "pnlCustomerData";
            pnlCustomerData.Size = new Size(844, 458);
            pnlCustomerData.TabIndex = 2;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { colId, colname, colphone, colemail, coladdress });
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.Location = new Point(0, 0);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(844, 458);
            dgvCustomers.TabIndex = 0;
            dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colname
            // 
            colname.DataPropertyName = "Name";
            colname.HeaderText = "Name";
            colname.Name = "colname";
            colname.ReadOnly = true;
            // 
            // colphone
            // 
            colphone.DataPropertyName = "Phone";
            colphone.HeaderText = "Phone";
            colphone.Name = "colphone";
            colphone.ReadOnly = true;
            // 
            // colemail
            // 
            colemail.DataPropertyName = "Email";
            colemail.HeaderText = "Email";
            colemail.Name = "colemail";
            colemail.ReadOnly = true;
            // 
            // coladdress
            // 
            coladdress.DataPropertyName = "Address";
            coladdress.HeaderText = "Address";
            coladdress.Name = "coladdress";
            coladdress.ReadOnly = true;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpCustomerView);
            Name = "CustomerView";
            Size = new Size(850, 532);
            tlpCustomerView.ResumeLayout(false);
            tlpCustomerView.PerformLayout();
            tsCommands.ResumeLayout(false);
            tsCommands.PerformLayout();
            flpSearch.ResumeLayout(false);
            flpSearch.PerformLayout();
            pnlCustomerData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCustomerView;
        private ToolStrip tsCommands;
        private ToolStripButton tsbAdd;
        private ToolStripButton tsbEdit;
        private ToolStripButton tsbView;
        private ToolStripButton tsbDelete;
        private ToolStripSeparator tsSeparator;
        private ToolStripButton tsbRefresh;
        private FlowLayoutPanel flpSearch;
        private Label lblCount;
        private TextBox txtSearch;
        private Label lblSearch;
        private Panel pnlCustomerData;
        private DataGridView dgvCustomers;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colname;
        private DataGridViewTextBoxColumn colphone;
        private DataGridViewTextBoxColumn colemail;
        private DataGridViewTextBoxColumn coladdress;
    }
}
