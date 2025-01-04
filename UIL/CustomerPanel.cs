using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Models;
using BLL.Services;

namespace YazLab1._3
{
    public partial class CustomerPanel : Form
    {
        int panelType;
        CustomerService customerService;
        Customer customerForEdit;

        public CustomerPanel(Customer _customerForEdit) // Edit Panel
        {
            InitializeComponent();
            
            panelType = 1;
            customerForEdit = _customerForEdit;
            SetPanelType(panelType);

            customerService = new CustomerService();
        }

        public CustomerPanel() // Add Panel
        {
            InitializeComponent();

            panelType = 0;
            SetPanelType(panelType);

            customerService = new CustomerService();
        }

        private void SetPanelType(int panelType)
        {
            cmbBxCustomerType.DataSource = Enum.GetValues(typeof(CustomerType));

            if (panelType == 0) // Add Customer
            {
                this.Text = $"Add Customer";
            }
            else if (panelType == 1) // Edit Customer
            {
                this.Text = $"Edit Customer";
                FillCustomerInfos();
            }
        }

        private void FillCustomerInfos()
        {
            txtBxCustomerName.Text = customerForEdit.CustomerName;
            txtBxCustomerBudget.Text = customerForEdit.Budget.ToString();
            cmbBxCustomerType.SelectedItem = customerForEdit.CustomerType;
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBxCustomerName.Text))
            {
                MessageBox.Show("Müşteri adı boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBxCustomerBudget.Text) || !decimal.TryParse(txtBxCustomerBudget.Text, out decimal budget))
            {
                MessageBox.Show("Geçerli bir bütçe girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbBxCustomerType.SelectedValue == null)
            {
                MessageBox.Show("Lütfen müşteri tipi seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool result = false;

            if (panelType == 0) // Add Customer
            {
                result = customerService.AddCustomer(
                    txtBxCustomerName.Text,
                    budget,
                    cmbBxCustomerType.SelectedValue.ToString());
            }
            else if (panelType == 1) // Edit Customer
            {
                if (customerForEdit == null)
                {
                    MessageBox.Show("Düzenlenecek müşteri seçilmedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                result = customerService.EditCustomer(
                    customerForEdit.CustomerID,
                    txtBxCustomerName.Text,
                    budget,
                    cmbBxCustomerType.SelectedValue.ToString(),
                    customerForEdit.TotalSpent);
            }

            if (result)
                this.Close();
            else
                MessageBox.Show("Müşteri düzenlenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
