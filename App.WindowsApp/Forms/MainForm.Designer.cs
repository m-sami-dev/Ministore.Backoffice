namespace App.WindowsApp.Forms
{
    partial class MainForm
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
            panelHeader = new Panel();
            flpRight = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            labelAdmin = new Label();
            flpLeft = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            lblministore = new Label();
            panelnav = new Panel();
            flpnav = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnProducts = new Button();
            btnOrder = new Button();
            btnReports = new Button();
            btnSync = new Button();
            btnLogs = new Button();
            btnSettings = new Button();
            statusStrip1 = new StatusStrip();
            tsLabelStatus = new ToolStripStatusLabel();
            panelContent = new Panel();
            panelHeader.SuspendLayout();
            flpRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelnav.SuspendLayout();
            flpnav.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(flpRight);
            panelHeader.Controls.Add(flpLeft);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4, 3, 4, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1058, 72);
            panelHeader.TabIndex = 0;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // flpRight
            // 
            flpRight.Controls.Add(pictureBox2);
            flpRight.Controls.Add(labelAdmin);
            flpRight.Dock = DockStyle.Right;
            flpRight.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flpRight.Location = new Point(852, 0);
            flpRight.Margin = new Padding(4, 3, 4, 3);
            flpRight.Name = "flpRight";
            flpRight.Size = new Size(206, 72);
            flpRight.TabIndex = 1;
            flpRight.Paint += flpRight_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.employee_man_alt;
            pictureBox2.Location = new Point(46, 12);
            pictureBox2.Margin = new Padding(46, 12, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 31);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // labelAdmin
            // 
            labelAdmin.AutoSize = true;
            labelAdmin.Dock = DockStyle.Top;
            labelAdmin.Location = new Point(92, 18);
            labelAdmin.Margin = new Padding(4, 18, 4, 0);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.Size = new Size(49, 17);
            labelAdmin.TabIndex = 1;
            labelAdmin.Text = "Admin";
            labelAdmin.Click += labelAdmin_Click;
            // 
            // flpLeft
            // 
            flpLeft.Controls.Add(pictureBox1);
            flpLeft.Controls.Add(lblministore);
            flpLeft.Dock = DockStyle.Left;
            flpLeft.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flpLeft.Location = new Point(0, 0);
            flpLeft.Margin = new Padding(4, 3, 4, 3);
            flpLeft.Name = "flpLeft";
            flpLeft.Size = new Size(237, 72);
            flpLeft.TabIndex = 0;
            flpLeft.Paint += flpLeft_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.store_buyer__1_;
            pictureBox1.Location = new Point(35, 9);
            pictureBox1.Margin = new Padding(35, 9, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 34);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblministore
            // 
            lblministore.AutoSize = true;
            lblministore.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblministore.Location = new Point(77, 23);
            lblministore.Margin = new Padding(4, 23, 4, 0);
            lblministore.Name = "lblministore";
            lblministore.Size = new Size(118, 13);
            lblministore.TabIndex = 1;
            lblministore.Text = "MiniStore Back-Office";
            lblministore.Click += lblministore_Click;
            // 
            // panelnav
            // 
            panelnav.Controls.Add(flpnav);
            panelnav.Dock = DockStyle.Left;
            panelnav.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelnav.Location = new Point(0, 72);
            panelnav.Margin = new Padding(4, 3, 4, 3);
            panelnav.Name = "panelnav";
            panelnav.Size = new Size(257, 511);
            panelnav.TabIndex = 1;
            panelnav.Paint += panelnav_Paint;
            // 
            // flpnav
            // 
            flpnav.Controls.Add(btnDashboard);
            flpnav.Controls.Add(btnProducts);
            flpnav.Controls.Add(btnOrder);
            flpnav.Controls.Add(btnReports);
            flpnav.Controls.Add(btnSync);
            flpnav.Controls.Add(btnLogs);
            flpnav.Controls.Add(btnSettings);
            flpnav.Dock = DockStyle.Left;
            flpnav.FlowDirection = FlowDirection.TopDown;
            flpnav.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flpnav.Location = new Point(0, 0);
            flpnav.Margin = new Padding(4, 3, 4, 3);
            flpnav.Name = "flpnav";
            flpnav.Size = new Size(257, 511);
            flpnav.TabIndex = 1;
            flpnav.Paint += flpnav_Paint;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.Image = Properties.Resources.dashboard_monitor__1_;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(4, 3);
            btnDashboard.Margin = new Padding(4, 3, 4, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(12, 0, 0, 0);
            btnDashboard.Size = new Size(233, 46);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnProducts
            // 
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProducts.Image = Properties.Resources.box_open;
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(4, 55);
            btnProducts.Margin = new Padding(4, 3, 4, 3);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(12, 0, 0, 0);
            btnProducts.Size = new Size(233, 46);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnOrder
            // 
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrder.Image = Properties.Resources.order_history;
            btnOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrder.Location = new Point(4, 107);
            btnOrder.Margin = new Padding(4, 3, 4, 3);
            btnOrder.Name = "btnOrder";
            btnOrder.Padding = new Padding(12, 0, 0, 0);
            btnOrder.Size = new Size(233, 46);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReports.Image = Properties.Resources.Report;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(4, 159);
            btnReports.Margin = new Padding(4, 3, 4, 3);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(12, 0, 0, 0);
            btnReports.Size = new Size(233, 46);
            btnReports.TabIndex = 3;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnSync
            // 
            btnSync.FlatAppearance.BorderSize = 0;
            btnSync.FlatStyle = FlatStyle.Flat;
            btnSync.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSync.Image = Properties.Resources.auto_sync;
            btnSync.ImageAlign = ContentAlignment.MiddleLeft;
            btnSync.Location = new Point(4, 211);
            btnSync.Margin = new Padding(4, 3, 4, 3);
            btnSync.Name = "btnSync";
            btnSync.Padding = new Padding(12, 0, 0, 0);
            btnSync.Size = new Size(233, 46);
            btnSync.TabIndex = 4;
            btnSync.Text = "Sync";
            btnSync.UseVisualStyleBackColor = true;
            btnSync.Click += btnSync_Click;
            // 
            // btnLogs
            // 
            btnLogs.FlatAppearance.BorderSize = 0;
            btnLogs.FlatStyle = FlatStyle.Flat;
            btnLogs.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogs.Image = Properties.Resources.log_file;
            btnLogs.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogs.Location = new Point(4, 263);
            btnLogs.Margin = new Padding(4, 3, 4, 3);
            btnLogs.Name = "btnLogs";
            btnLogs.Padding = new Padding(12, 0, 0, 0);
            btnLogs.Size = new Size(233, 46);
            btnLogs.TabIndex = 5;
            btnLogs.Text = "Logs";
            btnLogs.UseVisualStyleBackColor = true;
            btnLogs.Click += btnLogs_Click;
            // 
            // btnSettings
            // 
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSettings.Image = Properties.Resources.settings;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(4, 315);
            btnSettings.Margin = new Padding(4, 3, 4, 3);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(12, 0, 0, 0);
            btnSettings.Size = new Size(233, 46);
            btnSettings.TabIndex = 6;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsLabelStatus });
            statusStrip1.Location = new Point(0, 583);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1058, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // tsLabelStatus
            // 
            tsLabelStatus.Name = "tsLabelStatus";
            tsLabelStatus.Size = new Size(39, 17);
            tsLabelStatus.Text = "Ready";
            tsLabelStatus.Click += tsLabelStatus_Click;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelContent.Location = new Point(257, 72);
            panelContent.Margin = new Padding(4, 3, 4, 3);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(801, 511);
            panelContent.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 605);
            Controls.Add(panelContent);
            Controls.Add(panelnav);
            Controls.Add(statusStrip1);
            Controls.Add(panelHeader);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            panelHeader.ResumeLayout(false);
            flpRight.ResumeLayout(false);
            flpRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flpLeft.ResumeLayout(false);
            flpLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelnav.ResumeLayout(false);
            flpnav.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelnav;
        private System.Windows.Forms.FlowLayoutPanel flpRight;
        private System.Windows.Forms.FlowLayoutPanel flpLeft;
        private System.Windows.Forms.FlowLayoutPanel flpnav;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsLabelStatus;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Label lblministore;
        private System.Windows.Forms.Panel panelContent;
    }
}