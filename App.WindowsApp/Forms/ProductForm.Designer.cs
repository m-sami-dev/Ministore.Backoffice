
using App.Core.Models;
using App.Core.Utilities;

namespace App.WindowsApp.Forms
{
    partial class ProductForm
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
            pnltop = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCancel = new Button();
            btnSave = new Button();
            tblProductForm = new TableLayoutPanel();
            pnlStock = new Panel();
            lblStock = new Label();
            pnlName = new Panel();
            lblName = new Label();
            pnlCategory = new Panel();
            lblCategory = new Label();
            pnlPrice = new Panel();
            lblPrice = new Label();
            pnlStatus = new Panel();
            lblStatus = new Label();
            pnlid = new Panel();
            lblID = new Label();
            txtName = new TextBox();
            cmbCategory = new ComboBox();
            numPrice = new NumericUpDown();
            numStock = new NumericUpDown();
            cmbStatus = new ComboBox();
            txtID = new TextBox();
            pnltop.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tblProductForm.SuspendLayout();
            pnlStock.SuspendLayout();
            pnlName.SuspendLayout();
            pnlCategory.SuspendLayout();
            pnlPrice.SuspendLayout();
            pnlStatus.SuspendLayout();
            pnlid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();
            // 
            // pnltop
            // 
            pnltop.Controls.Add(flowLayoutPanel1);
            pnltop.Dock = DockStyle.Bottom;
            pnltop.Location = new Point(0, 350);
            pnltop.Name = "pnltop";
            pnltop.Size = new Size(800, 100);
            pnltop.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 100);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Image = Properties.Resources.cancel__1_;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(631, 40);
            btnCancel.Margin = new Padding(3, 40, 80, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(89, 32);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.diskette;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(460, 40);
            btnSave.Margin = new Padding(3, 40, 80, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 32);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tblProductForm
            // 
            tblProductForm.AutoSize = true;
            tblProductForm.ColumnCount = 2;
            tblProductForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblProductForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tblProductForm.Controls.Add(pnlStock, 0, 3);
            tblProductForm.Controls.Add(pnlName, 0, 0);
            tblProductForm.Controls.Add(pnlCategory, 0, 1);
            tblProductForm.Controls.Add(pnlPrice, 0, 2);
            tblProductForm.Controls.Add(pnlStatus, 0, 4);
            tblProductForm.Controls.Add(pnlid, 0, 5);
            tblProductForm.Controls.Add(txtName, 1, 0);
            tblProductForm.Controls.Add(cmbCategory, 1, 1);
            tblProductForm.Controls.Add(numPrice, 1, 2);
            tblProductForm.Controls.Add(numStock, 1, 3);
            tblProductForm.Controls.Add(cmbStatus, 1, 4);
            tblProductForm.Controls.Add(txtID, 1, 5);
            tblProductForm.Dock = DockStyle.Fill;
            tblProductForm.Location = new Point(0, 0);
            tblProductForm.Name = "tblProductForm";
            tblProductForm.RowCount = 7;
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Percent, 46F));
            tblProductForm.Size = new Size(800, 350);
            tblProductForm.TabIndex = 1;
            // 
            // pnlStock
            // 
            pnlStock.Controls.Add(lblStock);
            pnlStock.Dock = DockStyle.Fill;
            pnlStock.Location = new Point(3, 96);
            pnlStock.Name = "pnlStock";
            pnlStock.Size = new Size(154, 25);
            pnlStock.TabIndex = 10;
            // 
            // lblStock
            // 
            lblStock.Anchor = AnchorStyles.Left;
            lblStock.AutoSize = true;
            lblStock.Location = new Point(50, 3);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 0;
            lblStock.Text = "Stock";
            // 
            // pnlName
            // 
            pnlName.Controls.Add(lblName);
            pnlName.Dock = DockStyle.Fill;
            pnlName.Location = new Point(3, 3);
            pnlName.Name = "pnlName";
            pnlName.Size = new Size(154, 25);
            pnlName.TabIndex = 6;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Left;
            lblName.Location = new Point(47, 1);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 19);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            lblName.Click += lblName_Click;
            // 
            // pnlCategory
            // 
            pnlCategory.Controls.Add(lblCategory);
            pnlCategory.Dock = DockStyle.Fill;
            pnlCategory.Location = new Point(3, 34);
            pnlCategory.Name = "pnlCategory";
            pnlCategory.Size = new Size(154, 25);
            pnlCategory.TabIndex = 7;
            // 
            // lblCategory
            // 
            lblCategory.Anchor = AnchorStyles.Left;
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(47, 4);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category";
            // 
            // pnlPrice
            // 
            pnlPrice.Controls.Add(lblPrice);
            pnlPrice.Dock = DockStyle.Fill;
            pnlPrice.Location = new Point(3, 65);
            pnlPrice.Name = "pnlPrice";
            pnlPrice.Size = new Size(154, 25);
            pnlPrice.TabIndex = 9;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Left;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(53, 3);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 0;
            lblPrice.Text = "Price";
            // 
            // pnlStatus
            // 
            pnlStatus.Controls.Add(lblStatus);
            pnlStatus.Dock = DockStyle.Fill;
            pnlStatus.Location = new Point(3, 127);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(154, 25);
            pnlStatus.TabIndex = 11;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(50, 4);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status";
            // 
            // pnlid
            // 
            pnlid.Controls.Add(lblID);
            pnlid.Dock = DockStyle.Fill;
            pnlid.Location = new Point(3, 158);
            pnlid.Name = "pnlid";
            pnlid.Size = new Size(154, 25);
            pnlid.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.Anchor = AnchorStyles.Left;
            lblID.AutoSize = true;
            lblID.Location = new Point(53, 4);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(163, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(634, 23);
            txtName.TabIndex = 0;
            // 
            // cmbCategory
            // 
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(163, 34);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(634, 23);
            cmbCategory.TabIndex = 1;
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Dock = DockStyle.Fill;
            numPrice.Location = new Point(163, 65);
            numPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(634, 23);
            numPrice.TabIndex = 2;
            numPrice.ValueChanged += numPrice_ValueChanged;
            // 
            // numStock
            // 
            numStock.Dock = DockStyle.Fill;
            numStock.Location = new Point(163, 96);
            numStock.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(634, 23);
            numStock.TabIndex = 3;
            // 
            // cmbStatus
            // 
            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(163, 127);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(634, 23);
            cmbStatus.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.BackColor = Color.White;
            txtID.Dock = DockStyle.Fill;
            txtID.Location = new Point(163, 158);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(634, 23);
            txtID.TabIndex = 5;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblProductForm);
            Controls.Add(pnltop);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductForm";
            pnltop.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            tblProductForm.ResumeLayout(false);
            tblProductForm.PerformLayout();
            pnlStock.ResumeLayout(false);
            pnlStock.PerformLayout();
            pnlName.ResumeLayout(false);
            pnlCategory.ResumeLayout(false);
            pnlCategory.PerformLayout();
            pnlPrice.ResumeLayout(false);
            pnlPrice.PerformLayout();
            pnlStatus.ResumeLayout(false);
            pnlStatus.PerformLayout();
            pnlid.ResumeLayout(false);
            pnlid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    //throw new NotImplementedException();

        //    if (_mode == ProductFormModeEnum.Add)
        //    {
        //        Product newProduct = new Product();
        //        newProduct.Name = txtName.Text;
        //        newProduct.Category = (ProductCategoryEnum)cmbCategory.SelectedItem;
        //        newProduct.Status = (ProductStatusEnum)cmbStatus.SelectedItem;
        //        newProduct.Price = numPrice.Value;
        //        newProduct.Stock = (int)numStock.Value;

        //        //_product = _service.Add(newProduct);
        //        //txtID.Text = _product.Id;


        //        Product temp = _service.Add(newProduct);
        //        txtID.Text = temp?.Id ?? "";
        //    }
        //    else if (_mode == ProductFormModeEnum.Edit)
        //    {
        //        _product.Name = txtName.Text;
        //        _product.Category = (ProductCategoryEnum)cmbCategory.SelectedItem;
        //        _product.Status = (ProductStatusEnum)cmbStatus.SelectedItem;
        //        _product.Price = numPrice.Value;
        //        _product.Stock = (int)numStock.Value;

        //        bool isUpdated = _service.Update(_product);

        //    }

        //}

        #endregion

        private Panel pnltop;
        private TableLayoutPanel tblProductForm;
        private Panel pnlStock;
        private Label lblStock;
        private Panel pnlName;
        private Label lblName;
        private Panel pnlCategory;
        private Label lblCategory;
        private Panel pnlPrice;
        private Label lblPrice;
        private Panel pnlStatus;
        private Label lblStatus;
        private Panel pnlid;
        private Label lblID;
        private TextBox txtName;
        private ComboBox cmbCategory;
        private NumericUpDown numPrice;
        private FlowLayoutPanel flowLayoutPanel1;
        private NumericUpDown numStock;
        private ComboBox cmbStatus;
        private TextBox txtID;
        private Button btnCancel;
        private Button btnSave;
    }
}