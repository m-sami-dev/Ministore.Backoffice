using App.Core.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core.Utilities;
using App.WindowsApp.Forms;
using App.Core.Models;


namespace App.WindowsaApp.Views
{
    public partial class Productsview : UserControl
    {
        IProductService _service;
        BindingSource _dgvBindingSource = new BindingSource();

        public Productsview(IProductService _ser)
        {
            _service = _ser; //data binding google it
            InitializeComponent();
            dgvProducts.DataSource = _dgvBindingSource;
        }

        private void tblproducts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Productsview_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Clear();
            var categories = new List<object> { "--ALL--" };
            categories.AddRange(Enum.GetValues(typeof(ProductCategoryEnum)).Cast<object>());
            cmbCategory.DataSource = categories;
            cmbCategory.SelectedIndex = 0;

            cmbStockStatus.Items.Clear();
            var stockStaus = new List<object> { "--ALL--" };
            stockStaus.AddRange(Enum.GetValues(typeof(ProductStatusEnum)).Cast<object>());
            cmbStockStatus.DataSource = stockStaus;
            cmbStockStatus.SelectedIndex = 0;

            if (_service == null)

                return;
            //_service.GetAll();
            _dgvBindingSource.DataSource = _service.GetAll();


        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            ProductForm prodForm = new ProductForm(ProductFormModeEnum.Add, null, _service);
            prodForm.ShowDialog();
            RefreshGrid();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            Product? SelectedProduct = _dgvBindingSource.Current as Product;
            if (SelectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.Edit, SelectedProduct, _service);
                prodForm.ShowDialog();

                RefreshGrid();
            }


        }

        private void tsbView_Click(object sender, EventArgs e)
        {
            Product? SelectedProduct = _dgvBindingSource.Current as Product;
            if (SelectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.View, SelectedProduct, _service);
                prodForm.ShowDialog();
            }


        }

        private void RefreshGrid()
        {

            //_dgvBindingSource.DataSource = _service.GetAll();
            string searchText = txtSearch.Text;
            //ProductCategoryEnum? category = cmbCategory.SelectedItem != null ? (ProductCategoryEnum)cmbCategory.SelectedItem : null;
            //ProductStatusEnum? status = cmbStockStatus.SelectedItem != null ? (ProductStatusEnum)cmbStockStatus.SelectedItem : null;

            ProductCategoryEnum? selectedCategory = null;
            if (cmbCategory.SelectedItem != null)
            {
                if (cmbCategory.SelectedItem.ToString().Equals("--ALL--"))
                {
                    selectedCategory = null;
                }
                else
                {
                    selectedCategory = (ProductCategoryEnum)cmbCategory.SelectedItem;
                }
            }

            ProductStatusEnum? selectedStatus = null;
            if (cmbStockStatus.SelectedItem != null)
            {
                if (cmbStockStatus.SelectedItem.ToString().Equals("--ALL--"))
                {
                    selectedStatus = null;
                }
                else
                {
                    selectedStatus = (ProductStatusEnum)cmbStockStatus.SelectedItem;
                }
            }


            _dgvBindingSource.DataSource = _service.Search(searchText, selectedCategory, selectedStatus);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            RefreshGrid();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmbStockStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
