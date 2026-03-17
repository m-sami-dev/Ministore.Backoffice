using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App.WindowsApp.Forms
{
    public partial class ProductForm : Form
    {
        public ProductForm(ProductFormModeEnum mode, Product? P)
        {
            




            InitializeComponent();

            numPrice.Maximum = Decimal.MaxValue;
            numStock.Maximum = int.MaxValue;

            cmbCategory.Items.Clear();
            cmbCategory.DataSource = (Enum.GetValues(typeof(ProductCategoryEnum)));
            cmbCategory.SelectedIndex = 0;

            cmbStatus.Items.Clear();
            cmbStatus.DataSource = (Enum.GetValues(typeof(ProductStatusEnum)));
            cmbStatus.SelectedIndex = 0;

            if (mode == ProductFormModeEnum.Edit)
            {
                btnSave.Text = "Update";
            }

            else if (mode == ProductFormModeEnum.View)
            {
                btnSave.Visible = false;
            }
            if (mode == ProductFormModeEnum.Edit || mode== ProductFormModeEnum.View)
            {
                
                txtID.Text = P.Id;
                txtName.Text = P.Name;
                cmbCategory.SelectedItem = P.Category;
                cmbStatus.SelectedItem = P.Status;
                numPrice.Value = P.Price;
                numStock.Value = P.Stock;


            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void numPrice_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
