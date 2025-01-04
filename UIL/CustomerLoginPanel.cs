using System;
using System.Windows.Forms;
using BLL.Models;

namespace YazLab1._3
{
    public partial class CustomerLoginPanel : Form
    {
        Customer selectedCustomer;
        OrderPanel orderPanel;

        public CustomerLoginPanel(Customer selectedCustomer)
        {
            InitializeComponent();
            this.selectedCustomer = selectedCustomer;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(CheckCustomerValidity())
            {
                orderPanel = new OrderPanel(selectedCustomer);
                orderPanel.ShowDialog();
                this.Close();
            }
            else
            {
                txtBxUserName.Text = string.Empty;
                txtBxPassword.Text = string.Empty;
            }
        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            if (txtBxPassword.PasswordChar == '*')
            {
                txtBxPassword.PasswordChar = '\0';
                btnViewPassword.Text = "O"; 
            }
            else
            {
                txtBxPassword.PasswordChar = '*';
                btnViewPassword.Text = "C"; 
            }
        }


        private bool CheckCustomerValidity()
        {
            if (txtBxUserName.Text == selectedCustomer.CustomerName
                && txtBxPassword.Text == selectedCustomer.CustomerID.ToString())
            {
                return true;
            }

            return false;
        }
    }
}
