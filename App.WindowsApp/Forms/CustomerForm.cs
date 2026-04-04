using App.Core.Contracts;
using App.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace App.WindowsApp.Forms
{
    public partial class CustomerForm : Form
    {
        private ICustomerService _customerService;
        private CustomerFormModeEnum _mode;
        private Customer _customer;
        public CustomerForm(ICustomerService service, CustomerFormModeEnum mode, Customer customer = null)
        {
            InitializeComponent();
            _customerService = service;
            _mode = mode;
            _customer = customer ?? new Customer();
            PopulateFields();
            SetupMode();


        }
        private void PopulateFields()
        {
            txtBName.Text = _customer.Name;
            txtBPhone.Text = _customer.Phone;
            txtBEmail.Text = _customer.Email;
            txtBAddress.Text = _customer.Address;
            txtBid.Text = _customer.Id;

        }

        private void SetupMode()
        {
            switch (_mode)
            {
                case CustomerFormModeEnum.Add:
                    this.Text = "Add Customer";
                    lblid.Visible = false;
                    txtBid.Visible = false;

                    break;

                case CustomerFormModeEnum.Edit:
                    this.Text = "Edit Customer";
                    break;

                case CustomerFormModeEnum.View:
                    this.Text = "View Customer";
                    txtBid.ReadOnly = true;
                    txtBName.ReadOnly = true;
                    txtBPhone.ReadOnly = true;
                    txtBEmail.ReadOnly = true;
                    txtBAddress.ReadOnly = true;
                    btnSave.Visible = false;
                    break;
            }
        }
        private bool validateData()
        {
            if (string.IsNullOrWhiteSpace(txtBName.Text))
            {
                MessageBox.Show("Name cannot be empty", "Validating data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBPhone.Text))
            {
                MessageBox.Show("Phone cannot be empty", "Validating data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateData())
                {
                    _customer.Name = txtBName.Text;
                    _customer.Phone = txtBPhone.Text;
                    _customer.Email = txtBEmail.Text;
                    _customer.Address = txtBAddress.Text;

                    if (_mode == CustomerFormModeEnum.Add)
                    {
                        _customerService.Add(_customer);
                    }
                    else
                    {
                        _customerService.Update(_customer);
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();


        }
    }
}
