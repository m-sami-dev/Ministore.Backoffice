namespace App.WindowsApp.Forms
{
    partial class CustomerPicker
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
            tlpCustomerPicker = new TableLayoutPanel();
            flpSearchBar = new FlowLayoutPanel();
            lblSearchtext = new Label();
            txtBSearch = new TextBox();
            flpButtons = new FlowLayoutPanel();
            btnSelect = new Button();
            btnCancel = new Button();
            lbCustomers = new ListBox();
            tlpCustomerPicker.SuspendLayout();
            flpSearchBar.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCustomerPicker
            // 
            tlpCustomerPicker.ColumnCount = 1;
            tlpCustomerPicker.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCustomerPicker.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpCustomerPicker.Controls.Add(flpSearchBar, 0, 0);
            tlpCustomerPicker.Controls.Add(flpButtons, 0, 2);
            tlpCustomerPicker.Controls.Add(lbCustomers, 0, 1);
            tlpCustomerPicker.Dock = DockStyle.Fill;
            tlpCustomerPicker.Location = new Point(0, 0);
            tlpCustomerPicker.Name = "tlpCustomerPicker";
            tlpCustomerPicker.RowCount = 3;
            tlpCustomerPicker.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpCustomerPicker.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tlpCustomerPicker.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpCustomerPicker.Size = new Size(800, 450);
            tlpCustomerPicker.TabIndex = 0;
            // 
            // flpSearchBar
            // 
            flpSearchBar.BackColor = Color.White;
            flpSearchBar.Controls.Add(lblSearchtext);
            flpSearchBar.Controls.Add(txtBSearch);
            flpSearchBar.Dock = DockStyle.Fill;
            flpSearchBar.Location = new Point(3, 3);
            flpSearchBar.Name = "flpSearchBar";
            flpSearchBar.Size = new Size(794, 39);
            flpSearchBar.TabIndex = 0;
            // 
            // lblSearchtext
            // 
            lblSearchtext.AutoSize = true;
            lblSearchtext.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchtext.Location = new Point(3, 0);
            lblSearchtext.Name = "lblSearchtext";
            lblSearchtext.Size = new Size(86, 17);
            lblSearchtext.TabIndex = 0;
            lblSearchtext.Text = "Search Query";
            // 
            // txtBSearch
            // 
            txtBSearch.Location = new Point(95, 3);
            txtBSearch.Name = "txtBSearch";
            txtBSearch.Size = new Size(418, 23);
            txtBSearch.TabIndex = 1;
            txtBSearch.TextChanged += txtBSearch_TextChanged;
            // 
            // flpButtons
            // 
            flpButtons.BackColor = Color.White;
            flpButtons.Controls.Add(btnSelect);
            flpButtons.Controls.Add(btnCancel);
            flpButtons.Dock = DockStyle.Fill;
            flpButtons.FlowDirection = FlowDirection.RightToLeft;
            flpButtons.Location = new Point(3, 408);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(794, 39);
            flpButtons.TabIndex = 1;
            // 
            // btnSelect
            // 
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelect.Image = Properties.Resources.touchscreen__2_;
            btnSelect.Location = new Point(716, 3);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 27);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Select";
            btnSelect.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Image = Properties.Resources.cancel__1_;
            btnCancel.Location = new Point(635, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 27);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbCustomers
            // 
            lbCustomers.Dock = DockStyle.Fill;
            lbCustomers.FormattingEnabled = true;
            lbCustomers.Location = new Point(3, 48);
            lbCustomers.Name = "lbCustomers";
            lbCustomers.Size = new Size(794, 354);
            lbCustomers.TabIndex = 2;
            lbCustomers.DoubleClick += lbCustomers_DoubleClick;
            // 
            // CustomerPicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpCustomerPicker);
            Name = "CustomerPicker";
            Text = "CustomerPicker";
            tlpCustomerPicker.ResumeLayout(false);
            flpSearchBar.ResumeLayout(false);
            flpSearchBar.PerformLayout();
            flpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCustomerPicker;
        private FlowLayoutPanel flpSearchBar;
        private FlowLayoutPanel flpButtons;
        private Label lblSearchtext;
        private TextBox txtBSearch;
        private Button btnSelect;
        private Button btnCancel;
        private ListBox lbCustomers;
    }
}