namespace App.WindowsaApp.Views
{
    partial class DashboardView
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
            tblDashboard = new TableLayoutPanel();
            tblKpi = new TableLayoutPanel();
            pnlRevenue = new Panel();
            lblRevenueV = new Label();
            lblRevenueT = new Label();
            pnlOrders = new Panel();
            lblOrderV = new Label();
            lblOrderT = new Label();
            pnlSales = new Panel();
            lblSalesV = new Label();
            lblSalesT = new Label();
            pnlLowStock = new Panel();
            lvLowStock = new ListView();
            clmProductName = new ColumnHeader();
            clmStock = new ColumnHeader();
            lblLowStock = new Label();
            pnlRecentOrders = new Panel();
            lvRecentOrders = new ListView();
            clmOrder_ID = new ColumnHeader();
            clmCustomer = new ColumnHeader();
            clmTotal = new ColumnHeader();
            clmStatus = new ColumnHeader();
            lblRecentOrders = new Label();
            tblDashboard.SuspendLayout();
            tblKpi.SuspendLayout();
            pnlRevenue.SuspendLayout();
            pnlOrders.SuspendLayout();
            pnlSales.SuspendLayout();
            pnlLowStock.SuspendLayout();
            pnlRecentOrders.SuspendLayout();
            SuspendLayout();
            // 
            // tblDashboard
            // 
            tblDashboard.ColumnCount = 1;
            tblDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblDashboard.Controls.Add(tblKpi, 0, 0);
            tblDashboard.Controls.Add(pnlLowStock, 0, 1);
            tblDashboard.Controls.Add(pnlRecentOrders, 0, 2);
            tblDashboard.Dock = DockStyle.Fill;
            tblDashboard.Location = new Point(0, 0);
            tblDashboard.Margin = new Padding(4, 3, 4, 3);
            tblDashboard.Name = "tblDashboard";
            tblDashboard.Padding = new Padding(19, 18, 19, 18);
            tblDashboard.RowCount = 3;
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 138F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.Size = new Size(1020, 625);
            tblDashboard.TabIndex = 0;
            // 
            // tblKpi
            // 
            tblKpi.ColumnCount = 3;
            tblKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tblKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tblKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tblKpi.Controls.Add(pnlRevenue, 2, 0);
            tblKpi.Controls.Add(pnlOrders, 1, 0);
            tblKpi.Controls.Add(pnlSales, 0, 0);
            tblKpi.Dock = DockStyle.Fill;
            tblKpi.Location = new Point(23, 21);
            tblKpi.Margin = new Padding(4, 3, 4, 3);
            tblKpi.Name = "tblKpi";
            tblKpi.RowCount = 1;
            tblKpi.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblKpi.RowStyles.Add(new RowStyle(SizeType.Absolute, 132F));
            tblKpi.Size = new Size(974, 132);
            tblKpi.TabIndex = 0;
            // 
            // pnlRevenue
            // 
            pnlRevenue.BackColor = Color.White;
            pnlRevenue.Controls.Add(lblRevenueV);
            pnlRevenue.Controls.Add(lblRevenueT);
            pnlRevenue.Dock = DockStyle.Fill;
            pnlRevenue.Location = new Point(646, 3);
            pnlRevenue.Margin = new Padding(4, 3, 4, 3);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new Size(324, 126);
            pnlRevenue.TabIndex = 2;
            // 
            // lblRevenueV
            // 
            lblRevenueV.AutoSize = true;
            lblRevenueV.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRevenueV.Location = new Point(158, 55);
            lblRevenueV.Margin = new Padding(10, 0, 4, 0);
            lblRevenueV.Name = "lblRevenueV";
            lblRevenueV.Size = new Size(91, 20);
            lblRevenueV.TabIndex = 5;
            lblRevenueV.Text = "37,765 PKR";
            // 
            // lblRevenueT
            // 
            lblRevenueT.AutoSize = true;
            lblRevenueT.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRevenueT.Location = new Point(49, 55);
            lblRevenueT.Margin = new Padding(10, 0, 4, 0);
            lblRevenueT.Name = "lblRevenueT";
            lblRevenueT.Size = new Size(69, 20);
            lblRevenueT.TabIndex = 4;
            lblRevenueT.Text = "Revenue";
            // 
            // pnlOrders
            // 
            pnlOrders.BackColor = Color.White;
            pnlOrders.Controls.Add(lblOrderV);
            pnlOrders.Controls.Add(lblOrderT);
            pnlOrders.Dock = DockStyle.Fill;
            pnlOrders.Location = new Point(325, 3);
            pnlOrders.Margin = new Padding(4, 3, 4, 3);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new Size(313, 126);
            pnlOrders.TabIndex = 1;
            // 
            // lblOrderV
            // 
            lblOrderV.AutoSize = true;
            lblOrderV.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderV.Location = new Point(173, 55);
            lblOrderV.Margin = new Padding(10, 0, 4, 0);
            lblOrderV.Name = "lblOrderV";
            lblOrderV.Size = new Size(27, 20);
            lblOrderV.TabIndex = 3;
            lblOrderV.Text = "32";
            lblOrderV.Click += lblOrderV_Click;
            // 
            // lblOrderT
            // 
            lblOrderT.AutoSize = true;
            lblOrderT.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderT.Location = new Point(52, 55);
            lblOrderT.Margin = new Padding(10, 0, 4, 0);
            lblOrderT.Name = "lblOrderT";
            lblOrderT.Size = new Size(56, 20);
            lblOrderT.TabIndex = 2;
            lblOrderT.Text = "Orders";
            // 
            // pnlSales
            // 
            pnlSales.BackColor = Color.White;
            pnlSales.Controls.Add(lblSalesV);
            pnlSales.Controls.Add(lblSalesT);
            pnlSales.Dock = DockStyle.Fill;
            pnlSales.Location = new Point(4, 3);
            pnlSales.Margin = new Padding(4, 3, 4, 3);
            pnlSales.Name = "pnlSales";
            pnlSales.Size = new Size(313, 126);
            pnlSales.TabIndex = 0;
            // 
            // lblSalesV
            // 
            lblSalesV.AutoSize = true;
            lblSalesV.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesV.Location = new Point(158, 55);
            lblSalesV.Margin = new Padding(10, 0, 4, 0);
            lblSalesV.Name = "lblSalesV";
            lblSalesV.Size = new Size(36, 20);
            lblSalesV.TabIndex = 1;
            lblSalesV.Text = "168";
            // 
            // lblSalesT
            // 
            lblSalesT.AutoSize = true;
            lblSalesT.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesT.Location = new Point(43, 55);
            lblSalesT.Margin = new Padding(10, 0, 4, 0);
            lblSalesT.Name = "lblSalesT";
            lblSalesT.Size = new Size(44, 20);
            lblSalesT.TabIndex = 0;
            lblSalesT.Text = "Sales";
            // 
            // pnlLowStock
            // 
            pnlLowStock.Controls.Add(lvLowStock);
            pnlLowStock.Controls.Add(lblLowStock);
            pnlLowStock.Dock = DockStyle.Fill;
            pnlLowStock.Location = new Point(23, 159);
            pnlLowStock.Margin = new Padding(4, 3, 4, 3);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Size = new Size(974, 219);
            pnlLowStock.TabIndex = 1;
            // 
            // lvLowStock
            // 
            lvLowStock.Columns.AddRange(new ColumnHeader[] { clmProductName, clmStock });
            lvLowStock.Dock = DockStyle.Fill;
            lvLowStock.FullRowSelect = true;
            lvLowStock.GridLines = true;
            lvLowStock.Location = new Point(0, 17);
            lvLowStock.Margin = new Padding(4, 3, 4, 3);
            lvLowStock.Name = "lvLowStock";
            lvLowStock.Size = new Size(974, 202);
            lvLowStock.TabIndex = 1;
            lvLowStock.UseCompatibleStateImageBehavior = false;
            lvLowStock.View = View.Details;
            // 
            // clmProductName
            // 
            clmProductName.Text = "Product Name";
            clmProductName.Width = 93;
            // 
            // clmStock
            // 
            clmStock.Text = "Stock";
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Dock = DockStyle.Top;
            lblLowStock.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStock.Location = new Point(0, 0);
            lblLowStock.Margin = new Padding(4, 0, 4, 0);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(70, 17);
            lblLowStock.TabIndex = 0;
            lblLowStock.Text = "Low Stock";
            // 
            // pnlRecentOrders
            // 
            pnlRecentOrders.Controls.Add(lvRecentOrders);
            pnlRecentOrders.Controls.Add(lblRecentOrders);
            pnlRecentOrders.Dock = DockStyle.Fill;
            pnlRecentOrders.Location = new Point(23, 384);
            pnlRecentOrders.Margin = new Padding(4, 3, 4, 3);
            pnlRecentOrders.Name = "pnlRecentOrders";
            pnlRecentOrders.Size = new Size(974, 220);
            pnlRecentOrders.TabIndex = 2;
            // 
            // lvRecentOrders
            // 
            lvRecentOrders.Columns.AddRange(new ColumnHeader[] { clmOrder_ID, clmCustomer, clmTotal, clmStatus });
            lvRecentOrders.Dock = DockStyle.Fill;
            lvRecentOrders.FullRowSelect = true;
            lvRecentOrders.GridLines = true;
            lvRecentOrders.Location = new Point(0, 17);
            lvRecentOrders.Margin = new Padding(4, 3, 4, 3);
            lvRecentOrders.Name = "lvRecentOrders";
            lvRecentOrders.Size = new Size(974, 203);
            lvRecentOrders.TabIndex = 1;
            lvRecentOrders.UseCompatibleStateImageBehavior = false;
            lvRecentOrders.View = View.Details;
            // 
            // clmOrder_ID
            // 
            clmOrder_ID.Text = "Order_ID";
            // 
            // clmCustomer
            // 
            clmCustomer.Text = "Customer";
            // 
            // clmTotal
            // 
            clmTotal.Text = "Total";
            // 
            // clmStatus
            // 
            clmStatus.Text = "Status";
            // 
            // lblRecentOrders
            // 
            lblRecentOrders.AutoSize = true;
            lblRecentOrders.Dock = DockStyle.Top;
            lblRecentOrders.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentOrders.Location = new Point(0, 0);
            lblRecentOrders.Margin = new Padding(4, 0, 4, 0);
            lblRecentOrders.Name = "lblRecentOrders";
            lblRecentOrders.Size = new Size(94, 17);
            lblRecentOrders.TabIndex = 0;
            lblRecentOrders.Text = "Recent Orders";
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblDashboard);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DashboardView";
            Size = new Size(1020, 625);
            tblDashboard.ResumeLayout(false);
            tblKpi.ResumeLayout(false);
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
            pnlOrders.ResumeLayout(false);
            pnlOrders.PerformLayout();
            pnlSales.ResumeLayout(false);
            pnlSales.PerformLayout();
            pnlLowStock.ResumeLayout(false);
            pnlLowStock.PerformLayout();
            pnlRecentOrders.ResumeLayout(false);
            pnlRecentOrders.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDashboard;
        private System.Windows.Forms.TableLayoutPanel tblKpi;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Label lblRevenueV;
        private System.Windows.Forms.Label lblRevenueT;
        private System.Windows.Forms.Label lblOrderV;
        private System.Windows.Forms.Label lblOrderT;
        private System.Windows.Forms.Label lblSalesV;
        private System.Windows.Forms.Label lblSalesT;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.ListView lvLowStock;
        private System.Windows.Forms.ColumnHeader clmProductName;
        private System.Windows.Forms.ColumnHeader clmStock;
        private System.Windows.Forms.Panel pnlRecentOrders;
        private System.Windows.Forms.Label lblRecentOrders;
        private System.Windows.Forms.ListView lvRecentOrders;
        private System.Windows.Forms.ColumnHeader clmOrder_ID;
        private System.Windows.Forms.ColumnHeader clmCustomer;
        private System.Windows.Forms.ColumnHeader clmTotal;
        private System.Windows.Forms.ColumnHeader clmStatus;
    }
}
