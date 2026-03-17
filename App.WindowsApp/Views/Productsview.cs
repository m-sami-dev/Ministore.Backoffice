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
            cmbCategory.Items.Add("--ALL--");
            cmbCategory.Items.AddRange(Enum.GetNames(typeof(ProductCategoryEnum)));
            cmbCategory.SelectedIndex = 0;

            cmbStockStatus.Items.Clear();
            cmbStockStatus.Items.Add("--ALL--");
            cmbStockStatus.Items.AddRange(Enum.GetNames(typeof(ProductStatusEnum)));
            cmbStockStatus.SelectedIndex = 0;

            if (_service == null)

                return;
            _service.GetAll();
            _dgvBindingSource.DataSource = _service.GetAll();


        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            ProductForm prodForm = new ProductForm(ProductFormModeEnum.Add, null);
            prodForm.ShowDialog();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            Product? SelectedProduct = _dgvBindingSource.Current as Product;
            if (SelectedProduct != null) {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.Edit, SelectedProduct);
                prodForm.ShowDialog();
            }
            

        }

        private void tsbView_Click(object sender, EventArgs e)
        {
            Product? SelectedProduct = _dgvBindingSource.Current as Product;
            if (SelectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.View, SelectedProduct);
                prodForm.ShowDialog();
            }

        }
    }
}
