namespace App.WindowsApp.Forms
{
    partial class CustomerForm
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
            tlpCustomerForm = new TableLayoutPanel();
            lblName = new Label();
            txtBName = new TextBox();
            txtBPhone = new TextBox();
            txtBEmail = new TextBox();
            txtBAddress = new TextBox();
            txtBid = new TextBox();
            lblPhone = new Label();
            lblEmail = new Label();
            lblAddress = new Label();
            lblid = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tlpCustomerForm.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCustomerForm
            // 
            tlpCustomerForm.ColumnCount = 2;
            tlpCustomerForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpCustomerForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tlpCustomerForm.Controls.Add(lblName, 0, 0);
            tlpCustomerForm.Controls.Add(txtBName, 1, 0);
            tlpCustomerForm.Controls.Add(txtBPhone, 1, 1);
            tlpCustomerForm.Controls.Add(txtBEmail, 1, 2);
            tlpCustomerForm.Controls.Add(txtBAddress, 1, 3);
            tlpCustomerForm.Controls.Add(txtBid, 1, 4);
            tlpCustomerForm.Controls.Add(lblPhone, 0, 1);
            tlpCustomerForm.Controls.Add(lblEmail, 0, 2);
            tlpCustomerForm.Controls.Add(lblAddress, 0, 3);
            tlpCustomerForm.Controls.Add(lblid, 0, 4);
            tlpCustomerForm.Dock = DockStyle.Top;
            tlpCustomerForm.Location = new Point(0, 0);
            tlpCustomerForm.Name = "tlpCustomerForm";
            tlpCustomerForm.RowCount = 5;
            tlpCustomerForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpCustomerForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpCustomerForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpCustomerForm.RowStyles.Add(new RowStyle());
            tlpCustomerForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpCustomerForm.Size = new Size(576, 182);
            tlpCustomerForm.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Segoe UI", 9.75F);
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(80, 30);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // txtBName
            // 
            txtBName.Dock = DockStyle.Fill;
            txtBName.Location = new Point(89, 3);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(484, 23);
            txtBName.TabIndex = 1;
            // 
            // txtBPhone
            // 
            txtBPhone.Dock = DockStyle.Fill;
            txtBPhone.Location = new Point(89, 33);
            txtBPhone.Name = "txtBPhone";
            txtBPhone.Size = new Size(484, 23);
            txtBPhone.TabIndex = 2;
            // 
            // txtBEmail
            // 
            txtBEmail.Dock = DockStyle.Fill;
            txtBEmail.Location = new Point(89, 63);
            txtBEmail.Name = "txtBEmail";
            txtBEmail.Size = new Size(484, 23);
            txtBEmail.TabIndex = 3;
            // 
            // txtBAddress
            // 
            txtBAddress.Dock = DockStyle.Fill;
            txtBAddress.Location = new Point(89, 93);
            txtBAddress.Multiline = true;
            txtBAddress.Name = "txtBAddress";
            txtBAddress.ScrollBars = ScrollBars.Vertical;
            txtBAddress.Size = new Size(484, 58);
            txtBAddress.TabIndex = 4;
            // 
            // txtBid
            // 
            txtBid.Dock = DockStyle.Fill;
            txtBid.Location = new Point(89, 157);
            txtBid.Name = "txtBid";
            txtBid.ReadOnly = true;
            txtBid.Size = new Size(484, 23);
            txtBid.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Dock = DockStyle.Fill;
            lblPhone.Font = new Font("Segoe UI", 9.75F);
            lblPhone.Location = new Point(3, 30);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(80, 30);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Segoe UI", 9.75F);
            lblEmail.Location = new Point(3, 60);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(80, 30);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Dock = DockStyle.Fill;
            lblAddress.Font = new Font("Segoe UI", 9.75F);
            lblAddress.Location = new Point(3, 90);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(80, 64);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "Address";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Dock = DockStyle.Fill;
            lblid.Font = new Font("Segoe UI", 9.75F);
            lblid.Location = new Point(3, 154);
            lblid.Name = "lblid";
            lblid.Size = new Size(80, 30);
            lblid.TabIndex = 9;
            lblid.Text = "Id";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 291);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(576, 52);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Image = Properties.Resources.diskette;
            btnSave.Location = new Point(481, 9);
            btnSave.Margin = new Padding(9);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(3);
            btnSave.Size = new Size(86, 37);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Image = Properties.Resources.cancel__1_;
            btnCancel.Location = new Point(377, 9);
            btnCancel.Margin = new Padding(9);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(3);
            btnCancel.Size = new Size(86, 37);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 343);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tlpCustomerForm);
            Name = "CustomerForm";
            Text = "CustomerForm";
            tlpCustomerForm.ResumeLayout(false);
            tlpCustomerForm.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCustomerForm;
        private Label lblName;
        private TextBox txtBName;
        private TextBox txtBPhone;
        private TextBox txtBEmail;
        private TextBox txtBAddress;
        private TextBox txtBid;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblAddress;
        private Label lblid;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSave;
        private Button btnCancel;
    }
}