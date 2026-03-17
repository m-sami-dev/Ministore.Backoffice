namespace App.WinForms.Views
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
            this.tblDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.tblKpi = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRevenue = new System.Windows.Forms.Panel();
            this.lblRevenueV = new System.Windows.Forms.Label();
            this.lblRevenueT = new System.Windows.Forms.Label();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.lblOrderV = new System.Windows.Forms.Label();
            this.lblOrderT = new System.Windows.Forms.Label();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.lblSalesV = new System.Windows.Forms.Label();
            this.lblSalesT = new System.Windows.Forms.Label();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.lvLowStock = new System.Windows.Forms.ListView();
            this.clmProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLowStock = new System.Windows.Forms.Label();
            this.pnlRecentOrders = new System.Windows.Forms.Panel();
            this.lvRecentOrders = new System.Windows.Forms.ListView();
            this.clmOrder_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblRecentOrders = new System.Windows.Forms.Label();
            this.tblDashboard.SuspendLayout();
            this.tblKpi.SuspendLayout();
            this.pnlRevenue.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.pnlLowStock.SuspendLayout();
            this.pnlRecentOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblDashboard
            // 
            this.tblDashboard.ColumnCount = 1;
            this.tblDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDashboard.Controls.Add(this.tblKpi, 0, 0);
            this.tblDashboard.Controls.Add(this.pnlLowStock, 0, 1);
            this.tblDashboard.Controls.Add(this.pnlRecentOrders, 0, 2);
            this.tblDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDashboard.Location = new System.Drawing.Point(0, 0);
            this.tblDashboard.Name = "tblDashboard";
            this.tblDashboard.Padding = new System.Windows.Forms.Padding(16);
            this.tblDashboard.RowCount = 3;
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.Size = new System.Drawing.Size(874, 542);
            this.tblDashboard.TabIndex = 0;
            // 
            // tblKpi
            // 
            this.tblKpi.ColumnCount = 3;
            this.tblKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tblKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tblKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tblKpi.Controls.Add(this.pnlRevenue, 2, 0);
            this.tblKpi.Controls.Add(this.pnlOrders, 1, 0);
            this.tblKpi.Controls.Add(this.pnlSales, 0, 0);
            this.tblKpi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblKpi.Location = new System.Drawing.Point(19, 19);
            this.tblKpi.Name = "tblKpi";
            this.tblKpi.RowCount = 1;
            this.tblKpi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblKpi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tblKpi.Size = new System.Drawing.Size(836, 114);
            this.tblKpi.TabIndex = 0;
            // 
            // pnlRevenue
            // 
            this.pnlRevenue.BackColor = System.Drawing.Color.White;
            this.pnlRevenue.Controls.Add(this.lblRevenueV);
            this.pnlRevenue.Controls.Add(this.lblRevenueT);
            this.pnlRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRevenue.Location = new System.Drawing.Point(553, 3);
            this.pnlRevenue.Name = "pnlRevenue";
            this.pnlRevenue.Size = new System.Drawing.Size(280, 108);
            this.pnlRevenue.TabIndex = 2;
            // 
            // lblRevenueV
            // 
            this.lblRevenueV.AutoSize = true;
            this.lblRevenueV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueV.Location = new System.Drawing.Point(135, 48);
            this.lblRevenueV.Margin = new System.Windows.Forms.Padding(9, 0, 3, 0);
            this.lblRevenueV.Name = "lblRevenueV";
            this.lblRevenueV.Size = new System.Drawing.Size(91, 20);
            this.lblRevenueV.TabIndex = 5;
            this.lblRevenueV.Text = "37,765 PKR";
            // 
            // lblRevenueT
            // 
            this.lblRevenueT.AutoSize = true;
            this.lblRevenueT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueT.Location = new System.Drawing.Point(42, 48);
            this.lblRevenueT.Margin = new System.Windows.Forms.Padding(9, 0, 3, 0);
            this.lblRevenueT.Name = "lblRevenueT";
            this.lblRevenueT.Size = new System.Drawing.Size(69, 20);
            this.lblRevenueT.TabIndex = 4;
            this.lblRevenueT.Text = "Revenue";
            // 
            // pnlOrders
            // 
            this.pnlOrders.BackColor = System.Drawing.Color.White;
            this.pnlOrders.Controls.Add(this.lblOrderV);
            this.pnlOrders.Controls.Add(this.lblOrderT);
            this.pnlOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrders.Location = new System.Drawing.Point(278, 3);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(269, 108);
            this.pnlOrders.TabIndex = 1;
            // 
            // lblOrderV
            // 
            this.lblOrderV.AutoSize = true;
            this.lblOrderV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderV.Location = new System.Drawing.Point(148, 48);
            this.lblOrderV.Margin = new System.Windows.Forms.Padding(9, 0, 3, 0);
            this.lblOrderV.Name = "lblOrderV";
            this.lblOrderV.Size = new System.Drawing.Size(27, 20);
            this.lblOrderV.TabIndex = 3;
            this.lblOrderV.Text = "32";
            this.lblOrderV.Click += new System.EventHandler(this.lblOrderV_Click);
            // 
            // lblOrderT
            // 
            this.lblOrderT.AutoSize = true;
            this.lblOrderT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderT.Location = new System.Drawing.Point(45, 48);
            this.lblOrderT.Margin = new System.Windows.Forms.Padding(9, 0, 3, 0);
            this.lblOrderT.Name = "lblOrderT";
            this.lblOrderT.Size = new System.Drawing.Size(56, 20);
            this.lblOrderT.TabIndex = 2;
            this.lblOrderT.Text = "Orders";
            // 
            // pnlSales
            // 
            this.pnlSales.BackColor = System.Drawing.Color.White;
            this.pnlSales.Controls.Add(this.lblSalesV);
            this.pnlSales.Controls.Add(this.lblSalesT);
            this.pnlSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSales.Location = new System.Drawing.Point(3, 3);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(269, 108);
            this.pnlSales.TabIndex = 0;
            // 
            // lblSalesV
            // 
            this.lblSalesV.AutoSize = true;
            this.lblSalesV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesV.Location = new System.Drawing.Point(135, 48);
            this.lblSalesV.Margin = new System.Windows.Forms.Padding(9, 0, 3, 0);
            this.lblSalesV.Name = "lblSalesV";
            this.lblSalesV.Size = new System.Drawing.Size(36, 20);
            this.lblSalesV.TabIndex = 1;
            this.lblSalesV.Text = "168";
            // 
            // lblSalesT
            // 
            this.lblSalesT.AutoSize = true;
            this.lblSalesT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesT.Location = new System.Drawing.Point(37, 48);
            this.lblSalesT.Margin = new System.Windows.Forms.Padding(9, 0, 3, 0);
            this.lblSalesT.Name = "lblSalesT";
            this.lblSalesT.Size = new System.Drawing.Size(44, 20);
            this.lblSalesT.TabIndex = 0;
            this.lblSalesT.Text = "Sales";
            // 
            // pnlLowStock
            // 
            this.pnlLowStock.Controls.Add(this.lvLowStock);
            this.pnlLowStock.Controls.Add(this.lblLowStock);
            this.pnlLowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLowStock.Location = new System.Drawing.Point(19, 139);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Size = new System.Drawing.Size(836, 189);
            this.pnlLowStock.TabIndex = 1;
            // 
            // lvLowStock
            // 
            this.lvLowStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmProductName,
            this.clmStock});
            this.lvLowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLowStock.FullRowSelect = true;
            this.lvLowStock.GridLines = true;
            this.lvLowStock.HideSelection = false;
            this.lvLowStock.Location = new System.Drawing.Point(0, 17);
            this.lvLowStock.Name = "lvLowStock";
            this.lvLowStock.Size = new System.Drawing.Size(836, 172);
            this.lvLowStock.TabIndex = 1;
            this.lvLowStock.UseCompatibleStateImageBehavior = false;
            this.lvLowStock.View = System.Windows.Forms.View.Details;
            // 
            // clmProductName
            // 
            this.clmProductName.Text = "Product Name";
            this.clmProductName.Width = 93;
            // 
            // clmStock
            // 
            this.clmStock.Text = "Stock";
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLowStock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStock.Location = new System.Drawing.Point(0, 0);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(70, 17);
            this.lblLowStock.TabIndex = 0;
            this.lblLowStock.Text = "Low Stock";
            // 
            // pnlRecentOrders
            // 
            this.pnlRecentOrders.Controls.Add(this.lvRecentOrders);
            this.pnlRecentOrders.Controls.Add(this.lblRecentOrders);
            this.pnlRecentOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecentOrders.Location = new System.Drawing.Point(19, 334);
            this.pnlRecentOrders.Name = "pnlRecentOrders";
            this.pnlRecentOrders.Size = new System.Drawing.Size(836, 189);
            this.pnlRecentOrders.TabIndex = 2;
            // 
            // lvRecentOrders
            // 
            this.lvRecentOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmOrder_ID,
            this.clmCustomer,
            this.clmTotal,
            this.clmStatus});
            this.lvRecentOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRecentOrders.FullRowSelect = true;
            this.lvRecentOrders.GridLines = true;
            this.lvRecentOrders.HideSelection = false;
            this.lvRecentOrders.Location = new System.Drawing.Point(0, 17);
            this.lvRecentOrders.Name = "lvRecentOrders";
            this.lvRecentOrders.Size = new System.Drawing.Size(836, 172);
            this.lvRecentOrders.TabIndex = 1;
            this.lvRecentOrders.UseCompatibleStateImageBehavior = false;
            this.lvRecentOrders.View = System.Windows.Forms.View.Details;
            // 
            // clmOrder_ID
            // 
            this.clmOrder_ID.Text = "Order_ID";
            // 
            // clmCustomer
            // 
            this.clmCustomer.Text = "Customer";
            // 
            // clmTotal
            // 
            this.clmTotal.Text = "Total";
            // 
            // clmStatus
            // 
            this.clmStatus.Text = "Status";
            // 
            // lblRecentOrders
            // 
            this.lblRecentOrders.AutoSize = true;
            this.lblRecentOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecentOrders.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentOrders.Location = new System.Drawing.Point(0, 0);
            this.lblRecentOrders.Name = "lblRecentOrders";
            this.lblRecentOrders.Size = new System.Drawing.Size(94, 17);
            this.lblRecentOrders.TabIndex = 0;
            this.lblRecentOrders.Text = "Recent Orders";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblDashboard);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(874, 542);
            this.tblDashboard.ResumeLayout(false);
            this.tblKpi.ResumeLayout(false);
            this.pnlRevenue.ResumeLayout(false);
            this.pnlRevenue.PerformLayout();
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrders.PerformLayout();
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.pnlLowStock.ResumeLayout(false);
            this.pnlLowStock.PerformLayout();
            this.pnlRecentOrders.ResumeLayout(false);
            this.pnlRecentOrders.PerformLayout();
            this.ResumeLayout(false);

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
