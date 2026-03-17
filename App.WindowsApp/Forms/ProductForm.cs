using App.Core.Contracts;
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

        ProductFormModeEnum _mode;
        Product _product;
        IProductService _service;

        public ProductForm(ProductFormModeEnum mode, Product? P, IProductService service)
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


            _mode = mode;
            _product = P;
            _service = service;

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
            this.Close();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void numPrice_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            if (_mode == ProductFormModeEnum.Add)
            {
                Product newProduct = new Product();
                newProduct.Name = txtName.Text;
                newProduct.Category = (ProductCategoryEnum)cmbCategory.SelectedItem;
                newProduct.Status = (ProductStatusEnum)cmbStatus.SelectedItem;
                newProduct.Price = numPrice.Value;
                newProduct.Stock = (int)numStock.Value;

                //_product = _service.Add(newProduct);
                //txtID.Text = _product.Id;


                Product temp = _service.Add(newProduct);
                txtID.Text = temp?.Id ?? "";
            }
            else if (_mode == ProductFormModeEnum.Edit)
            {
                _product.Name = txtName.Text;
                _product.Category = (ProductCategoryEnum)cmbCategory.SelectedItem;
                _product.Status = (ProductStatusEnum)cmbStatus.SelectedItem;
                _product.Price = numPrice.Value;
                _product.Stock = (int)numStock.Value;

                bool isUpdated = _service.Update(_product);


            }
            this.Close();   

        }
    }
}
